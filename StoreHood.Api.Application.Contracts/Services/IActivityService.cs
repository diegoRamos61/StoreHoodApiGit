using StoreHood.Api.Business.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StoreHood.Api.Application.Contracts
{
    public interface IActivityService
    {
        Task<Activity> GetActivityId(int id);
        Task<Activity> AddActivity(Activity activity);
        Task<Activity> UpdateActivity(Activity activity);
        Task<bool> Delete(int id);
        Task<IEnumerable<Activity>> GetAll();
        Task<int> CountAll();
    }
}
