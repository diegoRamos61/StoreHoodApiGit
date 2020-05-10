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
    
    public class CalendaryController : Controller
    {
        private readonly ICalendaryService _calendaryService;
        //Podemos inyectar los servicios que queramos por controlador.
        
        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="calendaryService"></param>
        public CalendaryController(ICalendaryService calendaryService)
        {
            _calendaryService = calendaryService;
        }
    
        /// <summary>
        /// Add new Calendary
        /// </summary>
        /// <param name="calendary"></param>
        /// <returns>Calendary</returns>
        [ProducesResponseType(200)]
        [ProducesResponseType(500)]
        [ProducesResponseType(401)]
        [Produces("application/json",Type= typeof(CalendaryModel))]
        [HttpPost]
        public async Task<IActionResult> AddCalendary([FromBody]CalendaryModel calendary)
        {
            //Para invocar a los metodos de negocio se tiene que transformar a DTO.
            var CalendaryAddDto = await _calendaryService.AddCalendary(CalendaryMapper.Map(calendary));
            //Pero la salida devolvemos el modelo.            
            return Ok(CalendaryMapper.Map(CalendaryAddDto));
        }

        /// <summary>
        /// Delete Calendary
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCalendary(int id)
        {
            var isDeleted = await _calendaryService.Delete(id);

            return Ok(isDeleted);            
        }

        /// <summary>
        /// Update Calendary
        /// </summary>
        /// <param name="Calendary"></param>
        /// <returns></returns>
        [HttpPut]
        [Produces("application/json", Type = typeof(CalendaryModel))]
        public async Task<IActionResult> UpdateCalendary([FromBody]CalendaryModel Calendary)
        {
            var CalendaryUpdDto = await _calendaryService.UpdateCalendary(CalendaryMapper.Map(Calendary));

            return Ok(CalendaryMapper.Map(CalendaryUpdDto));

        }

        /// <summary>
        /// Get All Calendarys
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Produces("application/json", Type = typeof(List<CalendaryModel>))]
        public async Task<IActionResult> GetCalendaryAll()
        {
            var Calendarys = await _calendaryService.GetAll();
            
            return Ok(Calendarys.Select(CalendaryMapper.Map));
        }

        /// <summary>
        /// Get USER by ID.
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Calendary</returns>
        [HttpGet("{id}")]
        [Produces("application/json", Type = typeof(CalendaryModel))]
        public async Task<IActionResult> GetCalendary(int id)
        {
            var Calendary = await _calendaryService.GetCalendaryId(id);
            
            return Ok(CalendaryMapper.Map(Calendary));
        }

    }
}