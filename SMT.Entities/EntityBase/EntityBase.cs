using SMT.Shared1.Infrastructure.Common.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SMT.Entities.EntityBase
{
    public class EntityBase<T> : IEntityBase
    {
        public virtual T Id { get; set; }

        public bool IsDeleted { get; set; }

        [NotMapped]
        public ObjectState State { get; set; }
    }
}
