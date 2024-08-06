using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Volxyseat.Domain.Models;
using Volxyseat.Domain.Repositories;
using Volxyseat.Infrastructure.Data;

namespace Volxyseat.Infrastructure.Repositories
{
    public class VolxyseatRepository : BaseRepository<Subscription, Guid>, IVolxyseatRepository
    {
        public VolxyseatRepository(DataContext context) : base(context) { }

        public async Task<Subscription> GetByIdAsync(Guid id)
        {
            return await _entities.FindAsync(id);
        }

        public List<Subscription> GetAll()
        {
            return _entities.ToList();
        }
    }
}