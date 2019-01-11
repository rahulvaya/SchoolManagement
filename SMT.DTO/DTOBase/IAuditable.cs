

namespace SMT.DTO.DTOBase
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public interface IAuditable : IDTOBase
    {
        int CreatedBy { get; set; }

        DateTime CreatedDate { get; set; }

        int ModifiedBy { get; set; }

        DateTime ModifiedDate { get; set; }
    }
}
