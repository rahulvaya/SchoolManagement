using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace SMT.DTO.DTOBase
{
    [Serializable]
    [DataContract]
    public abstract class AuditableDTOBase<T> : DTOBase<T>, IAuditable
    {
        [DataMember]
        public int CreatedBy { get; set; }

        [DataMember]
        public DateTime CreatedDate { get; set; }

        [DataMember]
        public int ModifiedBy { get; set; }

        [DataMember]
        public DateTime ModifiedDate { get; set; }
    }
}
