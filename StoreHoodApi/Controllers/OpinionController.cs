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
    
    public class OpinionController : Controller
    {
        private readonly IOpinionService _opinionService;
        //Podemos inyectar los servicios que queramos por controlador.
        
        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="opinionService"></param>
        public OpinionController(IOpinionService opinionService)
        {
            _opinionService = opinionService;
        }
    
        /// <summary>
        /// Add new Opinion
        /// </summary>
        /// <param name="opinion"></param>
        /// <returns>Opinion</returns>
        [ProducesResponseType(200)]
        [ProducesResponseType(500)]
        [ProducesResponseType(401)]
        [Produces("application/json",Type= typeof(OpinionModel))]
        [HttpPost]
        public async Task<IActionResult> AddOpinion([FromBody]OpinionModel opinion)
        {
            //Para invocar a los metodos de negocio se tiene que transformar a DTO.
            var OpinionAddDto = await _opinionService.AddOpinion(OpinionMapper.Map(opinion));
            //Pero la salida devolvemos el modelo.            
            return Ok(OpinionMapper.Map(OpinionAddDto));
        }

        /// <summary>
        /// Delete Opinion
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOpinion(int id)
        {
            var isDeleted = await _opinionService.Delete(id);

            return Ok(isDeleted);            
        }

        /// <summary>
        /// Update Opinion
        /// </summary>
        /// <param name="Opinion"></param>
        /// <returns></returns>
        [HttpPut]
        [Produces("application/json", Type = typeof(OpinionModel))]
        public async Task<IActionResult> UpdateOpinion([FromBody]OpinionModel Opinion)
        {
            var OpinionUpdDto = await _opinionService.UpdateOpinion(OpinionMapper.Map(Opinion));

            return Ok(OpinionMapper.Map(OpinionUpdDto));

        }

        /// <summary>
        /// Get All Opinions
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Produces("application/json", Type = typeof(List<OpinionModel>))]
        public async Task<IActionResult> GetOpinionAll()
        {
            var Opinions = await _opinionService.GetAll();
            
            return Ok(Opinions.Select(OpinionMapper.Map));
        }

        /// <summary>
        /// Get Opinion by ID.
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Opinion</returns>
        [HttpGet("{id}")]
        [Produces("application/json", Type = typeof(OpinionModel))]
        public async Task<IActionResult> GetOpinion(int id)
        {
            var Opinion = await _opinionService.GetOpinionId(id);
            
            return Ok(OpinionMapper.Map(Opinion));
        }

    }
}