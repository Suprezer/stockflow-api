using System;
using System.Collections.Generic;
using System.Text;

namespace stockflow.domain.Entities
{
    public class StorageLocation
    {
        public Guid Id { get; private set; }

        public string Name { get; private set; }
        public string Address { get; private set; }

        public DateTime CreatedAt { get; private set; }
        public DateTime UpdatedAt { get; private set; }

        // EF Core
        private StorageLocation() { }

        public StorageLocation(string name, string address)
        {
            Id = Guid.NewGuid();
            Name = name.Trim();
            Address = address.Trim();
            CreatedAt = DateTime.UtcNow;
            UpdatedAt = DateTime.UtcNow;
        }

        public void Rename(string newName)
        {
            Name = newName.Trim();
            UpdatedAt = DateTime.UtcNow;
        }
    }
}
