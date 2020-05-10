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
    
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        //Podemos inyectar los servicios que queramos por controlador.
        
        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="productService"></param>
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
    
        /// <summary>
        /// Add new Product
        /// </summary>
        /// <param name="product"></param>
        /// <returns>Product</returns>
        [ProducesResponseType(200)]
        [ProducesResponseType(500)]
        [ProducesResponseType(401)]
        [Produces("application/json",Type= typeof(ProductModel))]
        [HttpPost]
        public async Task<IActionResult> AddProduct([FromBody]ProductModel product)
        {
            //Para invocar a los metodos de negocio se tiene que transformar a DTO.
            var ProductAddDto = await _productService.AddProduct(ProductMapper.Map(product));
            //Pero la salida devolvemos el modelo.            
            return Ok(ProductMapper.Map(ProductAddDto));
        }

        /// <summary>
        /// Delete Product
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            var isDeleted = await _productService.Delete(id);

            return Ok(isDeleted);            
        }

        /// <summary>
        /// Update Product
        /// </summary>
        /// <param name="Product"></param>
        /// <returns></returns>
        [HttpPut]
        [Produces("application/json", Type = typeof(ProductModel))]
        public async Task<IActionResult> UpdateProduct([FromBody]ProductModel Product)
        {
            var ProductUpdDto = await _productService.UpdateProduct(ProductMapper.Map(Product));

            return Ok(ProductMapper.Map(ProductUpdDto));

        }

        /// <summary>
        /// Get All Products
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Produces("application/json", Type = typeof(List<ProductModel>))]
        public async Task<IActionResult> GetProductAll()
        {
            var Products = await _productService.GetAll();
            
            return Ok(Products.Select(ProductMapper.Map));
        }

        /// <summary>
        /// Get USER by ID.
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Product</returns>
        [HttpGet("{id}")]
        [Produces("application/json", Type = typeof(ProductModel))]
        public async Task<IActionResult> GetProduct(int id)
        {
            var Product = await _productService.GetProductId(id);
            
            return Ok(ProductMapper.Map(Product));
        }

    }
}