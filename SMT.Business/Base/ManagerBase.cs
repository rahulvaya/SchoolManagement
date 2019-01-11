using SMT.Business.AutoMapper;
using SMT.BusinessContracts.BaseContract;
using SMT.DTO.DTOBase;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SMT.Business.Base
{
    public class ManagerBase<TEntity, TEntityDTO, TId> : IManagerBase<TEntityDTO>
        where TEntity : Entities.EntityBase.EntityBase<TId>
        where TEntityDTO : IDTOBase
    {
        
        public ManagerBase()
        {
            GenericAutoMapperConfiguration.Instance.Initialize();
        }

        public Task DeleteEntityAsync(TEntityDTO entityDTO)
        {
            throw new NotImplementedException();
        }

        public Task DeleteEntityAsync(object id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TEntityDTO>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<TEntityDTO> GetDetailedEntityByIdAsync(object id)
        {
            throw new NotImplementedException();
        }

        public Task<TEntityDTO> GetEntityByIdAsync(object id)
        {
            throw new NotImplementedException();
        }

        public Task<TEntityDTO> InsertEntityAsync(TEntityDTO entityDTO)
        {
            throw new NotImplementedException();
        }

        public Task<TEntityDTO> UpdateEntityAsync(TEntityDTO entityDTO)
        {
            throw new NotImplementedException();
        }
    }
}
