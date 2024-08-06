using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volxyseat.Domain.Models;

namespace Volxyseat.Domain.Repositories
{
    public interface IVolxyseatRepository : IRepository<Subscription, Guid>
    {
        List<Subscription> GetAll();
        Task<Subscription> GetByIdAsync(Guid id);
    }
}
