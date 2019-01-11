using SMT.DTO.DTOBase;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SMT.BusinessContracts.BaseContract
{
    public interface IManagerBase<TEntityDTO> where TEntityDTO : IDTOBase
    {
        Task<IEnumerable<TEntityDTO>> GetAllAsync();

        Task<TEntityDTO> GetEntityByIdAsync(object id);

        Task<TEntityDTO> GetDetailedEntityByIdAsync(object id);

        Task<TEntityDTO> InsertEntityAsync(TEntityDTO entityDTO);

        Task<TEntityDTO> UpdateEntityAsync(TEntityDTO entityDTO);

        Task DeleteEntityAsync(TEntityDTO entityDTO);

        Task DeleteEntityAsync(object id);
    }
}
