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
    
    public class ProfessionalController : Controller
    {
        private readonly IProfessionalService _professionalService;
        //Podemos inyectar los servicios que queramos por controlador.
        
        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="professionalService"></param>
        public ProfessionalController(IProfessionalService professionalService)
        {
            _professionalService = professionalService;
        }
    
        /// <summary>
        /// Add new Professional
        /// </summary>
        /// <param name="professional"></param>
        /// <returns>Professional</returns>
        [ProducesResponseType(200)]
        [ProducesResponseType(500)]
        [ProducesResponseType(401)]
        [Produces("application/json",Type= typeof(ProfessionalModel))]
        [HttpPost]
        public async Task<IActionResult> AddProfessional([FromBody]ProfessionalModel professional)
        {
            //Para invocar a los metodos de negocio se tiene que transformar a DTO.
            var ProfessionalAddDto = await _professionalService.AddProfessional(ProfessionalMapper.Map(professional));
            //Pero la salida devolvemos el modelo.            
            return Ok(ProfessionalMapper.Map(ProfessionalAddDto));
        }

        /// <summary>
        /// Delete Professional
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProfessional(int id)
        {
            var isDeleted = await _professionalService.Delete(id);

            return Ok(isDeleted);            
        }

        /// <summary>
        /// Update Professional
        /// </summary>
        /// <param name="Professional"></param>
        /// <returns></returns>
        [HttpPut]
        [Produces("application/json", Type = typeof(ProfessionalModel))]
        public async Task<IActionResult> UpdateProfessional([FromBody]ProfessionalModel Professional)
        {
            var ProfessionalUpdDto = await _professionalService.UpdateProfessional(ProfessionalMapper.Map(Professional));

            return Ok(ProfessionalMapper.Map(ProfessionalUpdDto));

        }

        /// <summary>
        /// Get All Professionals
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Produces("application/json", Type = typeof(List<ProfessionalModel>))]
        public async Task<IActionResult> GetProfessionalAll()
        {
            var Professionals = await _professionalService.GetAll();
            
            return Ok(Professionals.Select(ProfessionalMapper.Map));
        }

        /// <summary>
        /// Get Professional by ID.
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Professional</returns>
        [HttpGet("{id}")]
        [Produces("application/json", Type = typeof(ProfessionalModel))]
        public async Task<IActionResult> GetProfessional(int id)
        {
            var Professional = await _professionalService.GetProfessionalId(id);
            
            return Ok(ProfessionalMapper.Map(Professional));
        }

    }
}