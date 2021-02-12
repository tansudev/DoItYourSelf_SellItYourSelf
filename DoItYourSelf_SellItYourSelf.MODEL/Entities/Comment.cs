using DoItYourSelf_SellItYourSelf.CORE.Entity;
using DoItYourSelf_SellItYourSelf.CORE.Entity.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DoItYourSelf_SellItYourSelf.MODEL.Entities
{
    public class Comment:CoreEntity
    {
        public string CommentTitle { get; set; }
        public string CommentText { get; set; }
        public Score Score { get; set; }

        public Guid UserID { get; set; }
        public virtual User User { get; set; }
        public Guid PostID { get; set; }
        public virtual Post Post { get; set; }
    }
}
