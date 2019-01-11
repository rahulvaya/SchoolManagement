using System;
using System.Collections.Generic;
using System.Text;
using SMT.DTO.DTOBase;

namespace SMT.DTO
{
    public class EmployeeDTO : AuditableDTOBase<int>
    {
        public string Name { get; set; }
    }
}
