namespace Catalog.Data.Seed
{
    public static class InitialData
    {
        public static IEnumerable<Product> Products => new List<Product>
        {
            Product.Create(Guid.NewGuid(), "iphone 16 pro", ["cat1"], "desc", "image", 20),
            Product.Create(Guid.NewGuid(), "iphone 15 pro", ["cat1"], "desc", "image", 10),
            Product.Create(Guid.NewGuid(), "iphone 14 pro", ["cat1"], "desc", "image", 9),
        };
    }
}
