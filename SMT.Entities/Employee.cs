using System;
using System.Collections.Generic;
using System.Text;

namespace SMT.Entities
{
    public class Employee : EntityBase.AuditableBase<int>
    {
        public string Name { get; set; }
    }
}
