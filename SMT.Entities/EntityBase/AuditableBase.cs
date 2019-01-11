using System;
using System.Collections.Generic;
using System.Text;

namespace SMT.Entities.EntityBase
{
    public class AuditableBase<T> : EntityBase<T>, IAuditableBase
    {
        public int CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public int ModifiedBy { get; set; }

        public DateTime ModifiedDate { get; set; }
    }
}
