using DoItYourSelf_SellItYourSelf.CORE.Entity;
using DoItYourSelf_SellItYourSelf.CORE.Entity.Enums;
using DoItYourSelf_SellItYourSelf.CORE.Service;
using DoItYourSelf_SellItYourSelf.MODEL.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Transactions;

namespace DoItYourSelf_SellItYourSelf.SERVİCE.Base
{ 
    class BaseService<T> : ICoreService<T> where T : CoreEntity
    {
        //instance constructor, It is a method of a class that executes when the class's objects are created
        private readonly DIYSIYContext context;
       
        public BaseService(DIYSIYContext _context)
        {
            this.context = _context;
        }

        //This method sets the "T" type table element to active status
        public bool Activate(Guid id)
        {    
            T activated = GetByID(id);
            activated.Status = Status.Active;
            return Update(activated);
        }

        //This method adds the "T" type element to own table. If any unexpected situation occurs, program will go to "catch" blog and throw error 
        public bool Add(T item)
        { 

            try
            {
                context.Set<T>().Add(item);
                return Save() > 0;
            }
            catch (Exception)
            {
                return false;
            }
            
        }

        //This method adds the "T" type List to own table. If any unexpected situation occurs, program will go to "catch" blog and throw error 
        public bool Add(List<T> item)
        {
            try
            {
                //TransactionScope is used to all transaction roll back when data adds fail, thus it prevented the loss of data
                using (TransactionScope ts = new TransactionScope())
                {
                    context.Set<T>().AddRange(item);
                    ts.Complete();
                    return Save() > 0;    
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        //Note:exp variables should be lambda expressions (x => x.status == Status.Active)
        //Returns true if at least one of the request matches with database info.
        public bool Any(Expression<Func<T, bool>> exp) => context.Set<T>().Any(exp);

        //All active columns is listed.
        public List<T> GetActive() => context.Set<T>().Where(x => x.Status != Status.Deleted).ToList();

        //All columns is listed.
        public List<T> GetAll() => context.Set<T>().ToList();

        //Queries within the "exp" statement are sent to the server and the first or default element is returned
        public T GetByDefault(Expression<Func<T, bool>> exp) => context.Set<T>().FirstOrDefault(exp);

        //this query gets "T" element by using the unique key
        public T GetByID(Guid id)
        {
            return context.Set<T>().Find(id);
        }

        //Queries within the "exp" statement are sent to the server and listed data is returned.
        public List<T> GetDefault(Expression<Func<T, bool>> exp) => context.Set<T>().Where(exp).ToList();

        //"T" element is not actually deleted from the database, but its status is set deleted.
        public bool Remove(T item)
        {
            item.Status = Status.Deleted;
            return Update(item);
        }

        //Is finded "T" element by using the unique key and set status to "deleted". Because of used more than one linq it is invoked "TransactionScope"
        public bool Remove(Guid id)
        {
            try
            {
                using (TransactionScope ts = new TransactionScope())
                {
                    T item = GetByID(id);
                    item.Status = Status.Deleted;
                    ts.Complete();
                    return Update(item);

                }
            }
            catch (Exception)
            {
                return false;
            }
           
        }

        //Queries within the "exp" statement are sent to the server and listed data is returned. All elements status in to the list are set as "deleted"
        public bool RemoveAll(Expression<Func<T, bool>> exp)
        {
            try
            {
                using (TransactionScope ts = new TransactionScope())
                {
                    var collection = GetDefault(exp);
                    int count = 0;

                    foreach (var item in collection)
                    {
                        item.Status = Status.Deleted;
                        bool opResult = Update(item);

                        if (opResult) count++;

                    }
                    if (collection.Count == count) ts.Complete();
                    else return false;
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        //All database changes are saved
        public int Save()
        {
            return context.SaveChanges();
        }

        //This method updates the "T" type element to own table.
        public bool Update(T item)
        {
            try
            {
                context.Set<T>().Update(item);
                return Save() > 0;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
