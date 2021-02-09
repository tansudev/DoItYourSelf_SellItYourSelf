﻿using DoItYourSelf_SellItYourSelf.CORE.Entity.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace DoItYourSelf_SellItYourSelf.CORE.Entity
{
    public class CoreEntity:IEntity<Guid>
    {
        public CoreEntity()
        {

        }

        public Guid ID { get; set; }
        public Status Status { get; set; }

        public  DateTime? CreatedDate { get; set; }
        public string CreatedComputerName { get; set; }
        public string CreatedIP { get; set; }

        public DateTime? UpdatedDate { get; set; }
        public string UpdatedComputerName { get; set; }
        public string UpdatedIP { get; set; }
    }
}
