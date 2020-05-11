using System;
using System.Collections.Generic;
using System.Text;

namespace StoreHood.Api.DataAccess.Contracts.Entities
{
    public class CategoriesEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        // Un producto puede tener varias categorias, y alguna de ellas no activa por tanto no se mostraría. 
        // Por si fuera necesario actualizar la categoría un producto y no se desease actualizar sino darla de baja y sustituirla por otra.
        public bool Active { get; set; }

    }
}
