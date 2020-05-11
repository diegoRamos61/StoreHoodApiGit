using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StoreHood.Api.Application.Contracts;
using StoreHood.Api.Business.Models;
using StoreHood.Api.Mappers;
using StoreHood.Api.ViewModels;

namespace StoreHood.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    
    public class ServiceController : Controller
    {
        private readonly IServiceService _serviceService;
        //Podemos inyectar los servicios que queramos por controlador.
        
        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="ServiceService"></param>
        public ServiceController(IServiceService serviceService)
        {
            _serviceService = serviceService;
        }
    
        /// <summary>
        /// Add new Service
        /// </summary>
        /// <param name="shop"></param>
        /// <returns>Service</returns>
        [ProducesResponseType(200)]
        [ProducesResponseType(500)]
        [ProducesResponseType(401)]
        [Produces("application/json",Type= typeof(ServiceModel))]
        [HttpPost]
        public async Task<IActionResult> AddService([FromBody]ServiceModel shop)
        {
            //Para invocar a los metodos de negocio se tiene que transformar a DTO.
            var ServiceAddDto = await _serviceService.AddService(ServiceMapper.Map(shop));
            //Pero la salida devolvemos el modelo.            
            return Ok(ServiceMapper.Map(ServiceAddDto));
        }

        /// <summary>
        /// Delete Service
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteService(int id)
        {
            var isDeleted = await _serviceService.Delete(id);

            return Ok(isDeleted);            
        }

        /// <summary>
        /// Update Service
        /// </summary>
        /// <param name="Service"></param>
        /// <returns></returns>
        [HttpPut]
        [Produces("application/json", Type = typeof(ServiceModel))]
        public async Task<IActionResult> UpdateService([FromBody]ServiceModel Service)
        {
            var ServiceUpdDto = await _serviceService.UpdateService(ServiceMapper.Map(Service));

            return Ok(ServiceMapper.Map(ServiceUpdDto));

        }

        /// <summary>
        /// Get All Services
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Produces("application/json", Type = typeof(List<ServiceModel>))]
        public async Task<IActionResult> GetServiceAll()
        {
            var Services = await _serviceService.GetAll();
            
            return Ok(Services.Select(ServiceMapper.Map));
        }

        /// <summary>
        /// Get Service by ID.
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Service</returns>
        [HttpGet("{id}")]
        [Produces("application/json", Type = typeof(ServiceModel))]
        public async Task<IActionResult> GetService(int id)
        {
            var Service = await _serviceService.GetServiceId(id);
            
            return Ok(ServiceMapper.Map(Service));
        }

    }
}