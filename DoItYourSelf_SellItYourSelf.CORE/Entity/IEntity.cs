using System;
using System.Collections.Generic;
using System.Text;

namespace DoItYourSelf_SellItYourSelf.CORE.Entity
{
    public class IEntity<T>
    {
        T ID { get; set; }
    }
}
