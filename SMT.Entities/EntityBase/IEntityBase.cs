using System;
using System.Collections.Generic;
using System.Text;

namespace SMT.Entities.EntityBase
{
    public interface IEntityBase
    {
        bool IsDeleted { get; set; }
    }
}
