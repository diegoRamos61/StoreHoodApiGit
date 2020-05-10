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
    public class DealerService : IDealerService
    {
        //Así accederíamos a métodos de otro servicio.
        private readonly IDealerRepository _dealerRepository;

        public DealerService(IDealerRepository dealerRepository)
        {
            _dealerRepository = dealerRepository;
        }

        public async Task<Dealer> GetDealerId(int id)
        {
            var entidad = DealerMapper.Map(await _dealerRepository.GetById(id));

            return entidad;
        }

        public async Task<Dealer> AddDealer(Dealer dealer)
        {
            var addedEntity = await _dealerRepository.Add(DealerMapper.Map(dealer));

            return DealerMapper.Map(addedEntity);
        }

        public async Task<Dealer> UpdateDealer(Dealer dealer)
        {
            //Convertimos el DTO a Entidad para que pueda ser actualizado.
            var updatedEntity = await _dealerRepository.Update(DealerMapper.Map(dealer));
            //Mapeamos la entity devuelta del repository a DTO que será los objetos devueltos de negocio.
            return DealerMapper.Map(updatedEntity);
        }

        public async Task<bool> Delete(int id)
        {
            var deleted = await _dealerRepository.DeleteAsync(id);

            return deleted;
        }

        public async Task<IEnumerable<Dealer>> GetAll()
        {
            var allDealers = await _dealerRepository.GetAll();
            //Por cada item que contiene el listado lo mapea.
            return allDealers.Select(DealerMapper.Map);
        }

        public async Task<int> CountAll()
        {
            var countAll = await _dealerRepository.CountAll();
            return countAll;
        }

    }
}
