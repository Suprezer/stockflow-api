using stockflow.domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace stockflow.domain.Repositories
{
    public interface IStorageLocation
    {
        Task<StorageLocation?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default);
        Task<IEnumerable<StorageLocation>> GetAllAsync(CancellationToken cancellationToken = default);
        Task AddAsync(StorageLocation location, CancellationToken cancellationToken = default);
        Task UpdateAsync(StorageLocation location, CancellationToken cancellationToken = default);
        Task DeleteAsync(Guid id, CancellationToken cancellationToken = default);
        Task<bool> ExistsAsync(Guid id, CancellationToken cancellationToken = default);
    }
}
