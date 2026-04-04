namespace Catalog.Products.Features.CreateProduct
{
    public record CreateProductCommand(ProductDto Product)
        : ICommand<CreateProductResult>;
    public record CreateProductResult(Guid Id);

    internal class CreateProductHandler(CatalogDbContext catalogDbContext) : ICommandHandler<CreateProductCommand, CreateProductResult>
    {
        public async Task<CreateProductResult> Handle(CreateProductCommand command, CancellationToken cancellationToken)
        {
            // create product entity from command
            // save product to database
            // return result with new product id

            var product = CreateNewProduct(command.Product);

            catalogDbContext.Products.Add(product);
            await catalogDbContext.SaveChangesAsync(cancellationToken);

            return new CreateProductResult(product.Id);
        }

        private Product CreateNewProduct(ProductDto productDto)
        {
            var product = Product.Create(
                Guid.NewGuid(),
                productDto.name,
                productDto.categories,
                productDto.description,
                productDto.imageFile,
                productDto.price
            );

            return product;
        }
    }
}
