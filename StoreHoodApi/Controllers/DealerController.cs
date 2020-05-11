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
    
    public class DealerController : Controller
    {
        private readonly IDealerService _dealerService;
        //Podemos inyectar los servicios que queramos por controlador.
        
        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="dealerService"></param>
        public DealerController(IDealerService dealerService)
        {
            _dealerService = dealerService;
        }
    
        /// <summary>
        /// Add new Dealer
        /// </summary>
        /// <param name="dealer"></param>
        /// <returns>Dealer</returns>
        [ProducesResponseType(200)]
        [ProducesResponseType(500)]
        [ProducesResponseType(401)]
        [Produces("application/json",Type= typeof(DealerModel))]
        [HttpPost]
        public async Task<IActionResult> AddDealer([FromBody]DealerModel dealer)
        {
            //Para invocar a los metodos de negocio se tiene que transformar a DTO.
            var DealerAddDto = await _dealerService.AddDealer(DealerMapper.Map(dealer));
            //Pero la salida devolvemos el modelo.            
            return Ok(DealerMapper.Map(DealerAddDto));
        }

        /// <summary>
        /// Delete Dealer
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDealer(int id)
        {
            var isDeleted = await _dealerService.Delete(id);

            return Ok(isDeleted);            
        }

        /// <summary>
        /// Update Dealer
        /// </summary>
        /// <param name="Dealer"></param>
        /// <returns></returns>
        [HttpPut]
        [Produces("application/json", Type = typeof(DealerModel))]
        public async Task<IActionResult> UpdateDealer([FromBody]DealerModel Dealer)
        {
            var DealerUpdDto = await _dealerService.UpdateDealer(DealerMapper.Map(Dealer));

            return Ok(DealerMapper.Map(DealerUpdDto));

        }

        /// <summary>
        /// Get All Dealers
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Produces("application/json", Type = typeof(List<DealerModel>))]
        public async Task<IActionResult> GetDealerAll()
        {
            var Dealers = await _dealerService.GetAll();
            
            return Ok(Dealers.Select(DealerMapper.Map));
        }

        /// <summary>
        /// Get Dealer by ID.
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Dealer</returns>
        [HttpGet("{id}")]
        [Produces("application/json", Type = typeof(DealerModel))]
        public async Task<IActionResult> GetDealer(int id)
        {
            var Dealer = await _dealerService.GetDealerId(id);
            
            return Ok(DealerMapper.Map(Dealer));
        }

    }
}