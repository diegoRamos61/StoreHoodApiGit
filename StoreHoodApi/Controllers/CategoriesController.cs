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
    
    public class CategoriesController : Controller
    {
        private readonly ICategoriesService _categoriesService;
        //Podemos inyectar los servicios que queramos por controlador.
        
        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="categoriesService"></param>
        public CategoriesController(ICategoriesService categoriesService)
        {
            _categoriesService = categoriesService;
        }
    
        /// <summary>
        /// Add new Categories
        /// </summary>
        /// <param name="categories"></param>
        /// <returns>Categories</returns>
        [ProducesResponseType(200)]
        [ProducesResponseType(500)]
        [ProducesResponseType(401)]
        [Produces("application/json",Type= typeof(CategoriesModel))]
        [HttpPost]
        public async Task<IActionResult> AddCategories([FromBody]CategoriesModel categories)
        {
            //Para invocar a los metodos de negocio se tiene que transformar a DTO.
            var CategoriesAddDto = await _categoriesService.AddCategories(CategoriesMapper.Map(categories));
            //Pero la salida devolvemos el modelo.            
            return Ok(CategoriesMapper.Map(CategoriesAddDto));
        }

        /// <summary>
        /// Delete Categories
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCategories(int id)
        {
            var isDeleted = await _categoriesService.Delete(id);

            return Ok(isDeleted);            
        }

        /// <summary>
        /// Update Categories
        /// </summary>
        /// <param name="Categories"></param>
        /// <returns></returns>
        [HttpPut]
        [Produces("application/json", Type = typeof(CategoriesModel))]
        public async Task<IActionResult> UpdateCategories([FromBody]CategoriesModel Categories)
        {
            var CategoriesUpdDto = await _categoriesService.UpdateCategories(CategoriesMapper.Map(Categories));

            return Ok(CategoriesMapper.Map(CategoriesUpdDto));

        }

        /// <summary>
        /// Get All Categoriess
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Produces("application/json", Type = typeof(List<CategoriesModel>))]
        public async Task<IActionResult> GetCategoriesAll()
        {
            var Categoriess = await _categoriesService.GetAll();
            
            return Ok(Categoriess.Select(CategoriesMapper.Map));
        }

        /// <summary>
        /// Get USER by ID.
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Categories</returns>
        [HttpGet("{id}")]
        [Produces("application/json", Type = typeof(CategoriesModel))]
        public async Task<IActionResult> GetCategories(int id)
        {
            var Categories = await _categoriesService.GetCategoriesId(id);
            
            return Ok(CategoriesMapper.Map(Categories));
        }

    }
}