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
    public class ShopService : IShopService
    {
        //Así accederíamos a métodos de otro servicio.
        private readonly IShopRepository _shopRepository;

        public ShopService(IShopRepository shopRepository)
        {
            _shopRepository = shopRepository;
        }

       
        public async Task<Shop> GetShopId(int id)
        {
            var entidad = ShopMapper.Map(await _shopRepository.GetById(id));

            return entidad;
        }

        public async Task<Shop> AddShop(Shop user)
        {
            var addedEntity = await _shopRepository.Add(ShopMapper.Map(user));

            return ShopMapper.Map(addedEntity);
        }

        public async Task<Shop> UpdateShop(Shop user)
        {
            //Convertimos el DTO a Entidad para que pueda ser actualizado.
            var updatedEntity = await _shopRepository.Update(ShopMapper.Map(user));
            //Mapeamos la entity devuelta del repository a DTO que será los objetos devueltos de negocio.
            return ShopMapper.Map(updatedEntity);
        }

        public async Task<bool> Delete(int id)
        {
            var deleted = await _shopRepository.DeleteAsync(id);

            return deleted;
        }

        public async Task<IEnumerable<Shop>> GetAll()
        {
            var allShops = await _shopRepository.GetAll();
            //Por cada item que contiene el listado lo mapea.
            return allShops.Select(ShopMapper.Map);
        }

        public async Task<int> CountAll()
        {
            var countAll = await _shopRepository.CountAll();
            return countAll;
        }

    }
}
