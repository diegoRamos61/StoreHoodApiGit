using Microsoft.EntityFrameworkCore;
using StoreHood.Api.DataAccess.Contracts;
using System;


namespace StoreHood.Api.DataAccess
{
    public class StoreHoodDBContext: DbContext, IStoreHoodDBContext
    {
        public StoreHoodDBContext()
        {
                
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
        }

    }
}
