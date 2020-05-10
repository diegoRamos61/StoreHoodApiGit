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
    public class ProductService : IProductService
    {
        //Así accederíamos a métodos de otro servicio.
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<Product> GetProductId(int id)
        {
            var entidad = ProductMapper.Map(await _productRepository.GetById(id));

            return entidad;
        }

        public async Task<Product> AddProduct(Product product)
        {
            var addedEntity = await _productRepository.Add(ProductMapper.Map(product));

            return ProductMapper.Map(addedEntity);
        }

        public async Task<Product> UpdateProduct(Product product)
        {
            //Convertimos el DTO a Entidad para que pueda ser actualizado.
            var updatedEntity = await _productRepository.Update(ProductMapper.Map(product));
            //Mapeamos la entity devuelta del repository a DTO que será los objetos devueltos de negocio.
            return ProductMapper.Map(updatedEntity);
        }

        public async Task<bool> Delete(int id)
        {
            var deleted = await _productRepository.DeleteAsync(id);

            return deleted;
        }

        public async Task<IEnumerable<Product>> GetAll()
        {
            var allProducts = await _productRepository.GetAll();
            //Por cada item que contiene el listado lo mapea.
            return allProducts.Select(ProductMapper.Map);
        }

        public async Task<int> CountAll()
        {
            var countAll = await _productRepository.CountAll();
            return countAll;
        }

    }
}
