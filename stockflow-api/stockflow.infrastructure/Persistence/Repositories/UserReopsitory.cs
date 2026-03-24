using stockflow.domain.Repositories;
using StockFlow.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace stockflow.infrastructure.Persistence.Repositories
{
    public class UserReopsitory : IUserRepository
    {
        public Task AddAsync(User user, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Guid id, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<User>> GetAllAsync(CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<User?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(User user, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
    }
}
