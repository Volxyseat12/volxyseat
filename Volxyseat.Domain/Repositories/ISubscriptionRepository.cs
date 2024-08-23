using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volxyseat.Domain.Models;

namespace Volxyseat.Domain.Repositories
{
    public interface ISubscriptionRepository : IRepository<Subscription, Guid>
    {
        IEnumerable<Subscription> GetAll();
        Task<Subscription> GetByIdAsync(Guid id);
    }
}