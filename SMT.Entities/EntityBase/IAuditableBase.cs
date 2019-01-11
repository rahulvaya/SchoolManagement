using System;
using System.Collections.Generic;
using System.Text;

namespace SMT.Entities.EntityBase
{
    public interface IAuditableBase
    {
        int CreatedBy { get; set; }

        DateTime CreatedDate { get; set; }

        int ModifiedBy { get; set; }

        DateTime ModifiedDate { get; set; }
    }
}
