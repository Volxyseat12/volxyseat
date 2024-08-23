﻿using Volxyseat.Domain.Core;
using Volxyseat.Domain.Models;
using Volxyseat.Domain.Repositories;
using Volxyseat.Infrastructure.Data;

namespace Volxyseat.Infrastructure.Repositories
{
    public class UserRepository : BaseRepository<User, Guid>, IUserRepository
    {
        private readonly DataContext _context;

        public UserRepository(DataContext context) : base(context)
        {
            _context = context;
        }

        public IUnitOfWork UnitOfWork => _context;

        public async Task AddAsync(User obj)
        {
            await _entities.AddAsync(obj);
        }

        public IEnumerable<User> GetAll()
        {
            return _entities.ToList();
        }

        public async Task<User> GetByIdAsync(Guid id)
        {
            return await _entities.FindAsync(id);
        }

        public void Update(User obj)
        {
            _entities.Update(obj);
        }
    }
}