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
    
    public class ShopController : Controller
    {
        private readonly IShopService _shopService;
        //Podemos inyectar los servicios que queramos por controlador.
        
        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="ShopService"></param>
        public ShopController(IShopService shopService)
        {
            _shopService = shopService;
        }
    
        /// <summary>
        /// Add new Shop
        /// </summary>
        /// <param name="shop"></param>
        /// <returns>Shop</returns>
        [ProducesResponseType(200)]
        [ProducesResponseType(500)]
        [ProducesResponseType(401)]
        [Produces("application/json",Type= typeof(ShopModel))]
        [HttpPost]
        public async Task<IActionResult> AddShop([FromBody]ShopModel shop)
        {
            //Para invocar a los metodos de negocio se tiene que transformar a DTO.
            var ShopAddDto = await _shopService.AddShop(ShopMapper.Map(shop));
            //Pero la salida devolvemos el modelo.            
            return Ok(ShopMapper.Map(ShopAddDto));
        }

        /// <summary>
        /// Delete Shop
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteShop(int id)
        {
            var isDeleted = await _shopService.Delete(id);

            return Ok(isDeleted);            
        }

        /// <summary>
        /// Update Shop
        /// </summary>
        /// <param name="Shop"></param>
        /// <returns></returns>
        [HttpPut]
        [Produces("application/json", Type = typeof(ShopModel))]
        public async Task<IActionResult> UpdateShop([FromBody]ShopModel Shop)
        {
            var ShopUpdDto = await _shopService.UpdateShop(ShopMapper.Map(Shop));

            return Ok(ShopMapper.Map(ShopUpdDto));

        }

        /// <summary>
        /// Get All Shops
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Produces("application/json", Type = typeof(List<ShopModel>))]
        public async Task<IActionResult> GetShopAll()
        {
            var Shops = await _shopService.GetAll();
            
            return Ok(Shops.Select(ShopMapper.Map));
        }

        /// <summary>
        /// Get Shop by ID.
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Shop</returns>
        [HttpGet("{id}")]
        [Produces("application/json", Type = typeof(ShopModel))]
        public async Task<IActionResult> GetShop(int id)
        {
            var Shop = await _shopService.GetShopId(id);
            
            return Ok(ShopMapper.Map(Shop));
        }

    }
}