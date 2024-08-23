using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Volxyseat.Domain.Models;
using Volxyseat.Domain.Repositories;
using Volxyseat.Infrastructure.Data;

namespace Volxyseat.Infrastructure.Repositories
{
    public class SubscriptionRepository : BaseRepository<Subscription, Guid>, ISubscriptionRepository
    {
        public SubscriptionRepository(DataContext context) : base(context) { }

        public async Task<Subscription> GetByIdAsync(Guid id)
        {
            return await _entities.FindAsync(id);
        }

        public IEnumerable<Subscription> GetAll()
        {
            return _entities.ToList();
        }
    }
}