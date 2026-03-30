using Shared.DDD;

namespace Catalog.Products.Models
{
    public class Product : Entity<Guid>
    {
        public string Name { get; set; } = default!;
        public List<string> Categories { get; set; } = new();
        public string Description { get; set; } = default!;
        public string ImageFile { get; set; } = default!;
        public decimal Price { get; set; }

        public static Product Create(Guid id ,string name,  List<string> categories, string description, string imageFile, decimal price)
        {
            ArgumentException.ThrowIfNullOrEmpty(name);
            ArgumentOutOfRangeException.ThrowIfNegativeOrZero(price);

            Product product = new Product
            {
                Id = id,
                Name = name,
                Categories = categories,
                Description = description,
                ImageFile = imageFile,
                Price = price
            };
        }
    }
}
