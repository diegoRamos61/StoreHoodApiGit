using StoreHood.Api.Application.Contracts;
using StoreHood.Api.Business.Models;
using StoreHood.Api.DataAccess.Contracts.Repositories;
using StoreHood.Api.DataAccess.Mappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreHood.Api.Application.Services
{
    public class OpinionService : IOpinionService
    {
        //Así accederíamos a métodos de otro servicio.
        private readonly IOpinionRepository _opinionRepository;

        public OpinionService(IOpinionRepository opinionRepository)
        {
            _opinionRepository = opinionRepository;
        }
        public async Task<Opinion> GetOpinionId(int id)
        {
            var entidad = OpinionMapper.Map(await _opinionRepository.GetById(id));

            return entidad;
        }

        public async Task<Opinion> AddOpinion(Opinion opinion)
        {
            var addedEntity = await _opinionRepository.Add(OpinionMapper.Map(opinion));

            return OpinionMapper.Map(addedEntity);
        }

        public async Task<Opinion> UpdateOpinion(Opinion opinion)
        {
            //Convertimos el DTO a Entidad para que pueda ser actualizado.
            var updatedEntity = await _opinionRepository.Update(OpinionMapper.Map(opinion));
            //Mapeamos la entity devuelta del repository a DTO que será los objetos devueltos de negocio.
            return OpinionMapper.Map(updatedEntity);
        }

        public async Task<bool> Delete(int id)
        {
            var deleted = await _opinionRepository.DeleteAsync(id);

            return deleted;
        }

        public async Task<IEnumerable<Opinion>> GetAll()
        {
            var allOpinions = await _opinionRepository.GetAll();
            //Por cada item que contiene el listado lo mapea.
            return allOpinions.Select(OpinionMapper.Map);
        }

        public async Task<int> CountAll()
        {
            var countAll = await _opinionRepository.CountAll();
            return countAll;
        }

    }
}
