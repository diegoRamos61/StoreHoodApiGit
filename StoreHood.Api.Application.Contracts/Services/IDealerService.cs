using StoreHood.Api.Business.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StoreHood.Api.Application.Contracts
{
    public interface IDealerService
    {
        Task<Dealer> GetDealerId(int id);
        Task<Dealer> AddDealer(Dealer dealer);
        Task<Dealer> UpdateDealer(Dealer dealer);
        Task<bool> Delete(int id);
        Task<IEnumerable<Dealer>> GetAll();
        Task<int> CountAll();
    }
}
