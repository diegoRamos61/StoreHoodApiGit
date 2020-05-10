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
    
    public class ActivityController : Controller
    {
        private readonly IActivityService _activityService;
        //Podemos inyectar los servicios que queramos por controlador.
        
        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="activityService"></param>
        public ActivityController(IActivityService activityService)
        {
            _activityService = activityService;
        }
    
        /// <summary>
        /// Add new Activity
        /// </summary>
        /// <param name="activity"></param>
        /// <returns>Activity</returns>
        [ProducesResponseType(200)]
        [ProducesResponseType(500)]
        [ProducesResponseType(401)]
        [Produces("application/json",Type= typeof(ActivityModel))]
        [HttpPost]
        public async Task<IActionResult> AddActivity([FromBody]ActivityModel activity)
        {
            //Para invocar a los metodos de negocio se tiene que transformar a DTO.
            var ActivityAddDto = await _activityService.AddActivity(ActivityMapper.Map(activity));
            //Pero la salida devolvemos el modelo.            
            return Ok(ActivityMapper.Map(ActivityAddDto));
        }

        /// <summary>
        /// Delete Activity
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteActivity(int id)
        {
            var isDeleted = await _activityService.Delete(id);

            return Ok(isDeleted);            
        }

        /// <summary>
        /// Update Activity
        /// </summary>
        /// <param name="Activity"></param>
        /// <returns></returns>
        [HttpPut]
        [Produces("application/json", Type = typeof(ActivityModel))]
        public async Task<IActionResult> UpdateActivity([FromBody]ActivityModel Activity)
        {
            var ActivityUpdDto = await _activityService.UpdateActivity(ActivityMapper.Map(Activity));

            return Ok(ActivityMapper.Map(ActivityUpdDto));

        }

        /// <summary>
        /// Get All Activitys
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Produces("application/json", Type = typeof(List<ActivityModel>))]
        public async Task<IActionResult> GetActivityAll()
        {
            var Activitys = await _activityService.GetAll();
            
            return Ok(Activitys.Select(ActivityMapper.Map));
        }

        /// <summary>
        /// Get USER by ID.
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Activity</returns>
        [HttpGet("{id}")]
        [Produces("application/json", Type = typeof(ActivityModel))]
        public async Task<IActionResult> GetActivity(int id)
        {
            var Activity = await _activityService.GetActivityId(id);
            
            return Ok(ActivityMapper.Map(Activity));
        }

    }
}