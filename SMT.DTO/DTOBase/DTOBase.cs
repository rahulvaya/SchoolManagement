

using System.Runtime.Serialization;

namespace SMT.DTO.DTOBase
{
    using SMT.Shared1.Infrastructure.Common.Enums;
    using System;
    using System.Collections.Generic;
    using System.Text;

    [Serializable]
    [DataContract]
    public abstract class DTOBase<T> : IDTOBase
    {
        [DataMember]
        public T Id { get; set; }

        [DataMember]
        public ObjectState state { get; set; }

        [DataMember]
        public bool IsDeleted { get; set; }
    }
}
