namespace stockflow.domain.Entities
{
    public class Product
    {
        public Guid Id { get; private set; }
        public string Name { get; private set; }
        public string Description { get; private set; }

        private Product() { }

        public Product(string name, string description)
        {
            Id = Guid.NewGuid();
            Name = name.Trim();
            Description = description.Trim();
        }
    }
}
