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
    public class ServiceService : IServiceService
    {
        private readonly IServiceRepository _serviceRepository;

        public ServiceService(IServiceRepository serviceRepository)
        {
            _serviceRepository = serviceRepository;
        }

        public async Task<Service> GetServiceId(int id)
        {
            var entidad = ServiceMapper.Map(await _serviceRepository.GetById(id));

            return entidad;
        }

        public async Task<Service> AddService(Service service)
        {
            var addedEntity = await _serviceRepository.Add(ServiceMapper.Map(service));

            return ServiceMapper.Map(addedEntity);
        }

        public async Task<Service> UpdateService(Service service)
        {
            //Convertimos el DTO a Entidad para que pueda ser actualizado.
            var updatedEntity = await _serviceRepository.Update(ServiceMapper.Map(service));
            //Mapeamos la entity devuelta del repository a DTO que será los objetos devueltos de negocio.
            return ServiceMapper.Map(updatedEntity);
        }

        public async Task<bool> Delete(int id)
        {
            var deleted = await _serviceRepository.DeleteAsync(id);

            return deleted;
        }

        public async Task<IEnumerable<Service>> GetAll()
        {
            var allServices = await _serviceRepository.GetAll();
            //Por cada item que contiene el listado lo mapea.
            return allServices.Select(ServiceMapper.Map);
        }

        public async Task<int> CountAll()
        {
            var countAll = await _serviceRepository.CountAll();
            return countAll;
        }
    }
}
