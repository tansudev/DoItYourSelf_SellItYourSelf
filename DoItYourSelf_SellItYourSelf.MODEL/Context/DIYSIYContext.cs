using DoItYourSelf_SellItYourSelf.CORE.Entity;
using DoItYourSelf_SellItYourSelf.MODEL.Entities;
using DoItYourSelf_SellItYourSelf.MODEL.Maps;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DoItYourSelf_SellItYourSelf.MODEL.Context
{
    public class DIYSIYContext:DbContext
    {
        public DIYSIYContext()
        {}

        public DIYSIYContext(DbContextOptions<DIYSIYContext> options):base(options)
        {}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AddressMap());
            modelBuilder.ApplyConfiguration(new CategoryMap());
            modelBuilder.ApplyConfiguration(new CommentMap());
            modelBuilder.ApplyConfiguration(new ImageMap());
            modelBuilder.ApplyConfiguration(new OrderMap());
            modelBuilder.ApplyConfiguration(new PaymentMap());
            modelBuilder.ApplyConfiguration(new PostMap());
            modelBuilder.ApplyConfiguration(new ProductMap());
            modelBuilder.ApplyConfiguration(new ShipperMap());
            modelBuilder.ApplyConfiguration(new TagMap());
            modelBuilder.ApplyConfiguration(new UserMap());


            //A many-to-many relationship is defined in codes
            //PostTag class
            modelBuilder.Entity<PostTag>().HasKey(op => new { op.PostID, op.TagID });
            modelBuilder.Entity<PostTag>().HasOne(op => op.Post).WithMany(o => o.PostTags).HasForeignKey(op => op.PostID);
            modelBuilder.Entity<PostTag>().HasOne(op => op.Tag).WithMany(o => o.PostTags).HasForeignKey(op => op.TagID);

            base.OnModelCreating(modelBuilder);
        }

        //ConnectionString is writing in OnConfiguring Method for SqlServer
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=.; database=DIYSIYProject; uid=sa; pwd=123;");
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<Address> Addresses { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<PostTag> PostTags { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Shipper> Shippers { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<User> Users { get; set; }

        public override int SaveChanges()
        {
            //Have changes or added entities are catched with ChangceTracker and assing to modifiedEntities variable
            var modifiedEntities = ChangeTracker.Entries().Where(x => x.State == EntityState.Modified || x.State == EntityState.Added).ToList();
            string computerName = Environment.MachineName;
            string ipAddress = "127.0.0.1";
            DateTime date = DateTime.Now;

            foreach (var item in modifiedEntities)
            {
                CoreEntity entity = item.Entity as CoreEntity;

                if (item!=null)
                {
                    if (item.State == EntityState.Modified)
                    {
                        entity.UpdatedComputerName = computerName;
                        entity.UpdatedIP = ipAddress;
                        entity.CreatedDate = date;
                    }
                    else if (item.State == EntityState.Added)
                    {
                        entity.UpdatedComputerName = computerName;
                        entity.UpdatedIP = ipAddress;
                        entity.CreatedDate = date;
                    }

                }
            }
            
            return base.SaveChanges();
        }
    }
}
