using StoreHood.Api.Application.Contracts;
using StoreHood.Api.Business.Models;
using StoreHood.Api.DataAccess.Contracts.Repositories;
using StoreHood.Api.DataAccess.Mappers;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreHood.Api.Application.Professionals
{
    public class ProfessionalService : IProfessionalService
    {
        private readonly IProfessionalRepository _professionalRepository;

        public ProfessionalService(IProfessionalRepository professionalRepository)
        {
            _professionalRepository = professionalRepository;
        }

        public async Task<Professional> GetProfessionalId(int id)
        {
            var entidad = ProfessionalMapper.Map(await _professionalRepository.GetById(id));

            return entidad;
        }

        public async Task<Professional> AddProfessional(Professional professional)
        {
            var addedEntity = await _professionalRepository.Add(ProfessionalMapper.Map(professional));

            return ProfessionalMapper.Map(addedEntity);
        }

        public async Task<Professional> UpdateProfessional(Professional professional)
        {
            //Convertimos el DTO a Entidad para que pueda ser actualizado.
            var updatedEntity = await _professionalRepository.Update(ProfessionalMapper.Map(professional));
            //Mapeamos la entity devuelta del repository a DTO que será los objetos devueltos de negocio.
            return ProfessionalMapper.Map(updatedEntity);
        }

        public async Task<bool> Delete(int id)
        {
            var deleted = await _professionalRepository.DeleteAsync(id);

            return deleted;
        }

        public async Task<IEnumerable<Professional>> GetAll()
        {
            var allProfessionals = await _professionalRepository.GetAll();
            //Por cada item que contiene el listado lo mapea.
            return allProfessionals.Select(ProfessionalMapper.Map);
        }

        public async Task<int> CountAll()
        {
            var countAll = await _professionalRepository.CountAll();
            return countAll;
        }
    }
}
