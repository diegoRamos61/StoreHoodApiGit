using StoreHood.Api.Business.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StoreHood.Api.Application.Contracts
{
    public interface ICalendaryService
    {
        Task<Calendary> GetCalendaryId(int id);
        Task<Calendary> AddCalendary(Calendary calendary);
        Task<Calendary> UpdateCalendary(Calendary calendary);
        Task<bool> Delete(int id);
        Task<IEnumerable<Calendary>> GetAll();
        Task<int> CountAll();
    }
}
