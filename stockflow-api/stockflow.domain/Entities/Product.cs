namespace stockflow.domain.Entities
{
    public class Product
    {
        public Guid Id { get; private set; }
        public string Name { get; private set; }
        public string Description { get; private set; }
        public decimal Price { get; private set; }
        public int Quantity { get; private set; }

        public DateTime CreatedAt { get; private set; }
        public DateTime UpdatedAt { get; private set; }

        private Product() { }

        public Product(string name, string description)
        {
            Id = Guid.NewGuid();
            Name = name.Trim();
            Description = description.Trim();
        }

        public void Rename(string newName)
        {
            Name = newName.Trim();
            UpdatedAt = DateTime.UtcNow;
        }

        public void UpdateDescription(string newDescription)
        {
            Description = newDescription.Trim();
            UpdatedAt = DateTime.UtcNow;
        }

        public void UpdatePrice(decimal newPrice)
        {
            Price = newPrice;
            UpdatedAt = DateTime.UtcNow;
        }
    }
}
