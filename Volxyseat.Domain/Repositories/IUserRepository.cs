using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volxyseat.Domain.Models;

namespace Volxyseat.Domain.Repositories
{
    public interface IUserRepository : IRepository<User, Guid>
    {
        IEnumerable<User> GetAll();
        Task<User> GetByIdAsync(Guid id);
    }
}