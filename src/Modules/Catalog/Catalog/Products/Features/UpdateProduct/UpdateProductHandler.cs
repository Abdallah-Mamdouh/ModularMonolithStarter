namespace Catalog.Products.Features.UpdateProduct
{
    public record UpdateProductCommand(ProductDto Product) : ICommand<UpdateProductResult>;

    public record UpdateProductResult(bool IsSuccess);

    public class UpdateProductCommandValidator : AbstractValidator<UpdateProductCommand>
    {
        public UpdateProductCommandValidator()
        {
            RuleFor(x => x.Product.Id).NotEmpty().WithMessage("Id is required");
            RuleFor(x => x.Product.Name).NotEmpty().WithMessage("Name is required");
            RuleFor(x => x.Product.Price).GreaterThan(0).WithMessage("Price must be greater than 0");
        }
    }

    internal class UpdateProductHandler(CatalogDbContext catalogDbContext) : ICommandHandler<UpdateProductCommand, UpdateProductResult>
    {
        public async Task<UpdateProductResult> Handle(UpdateProductCommand command, CancellationToken cancellationToken)
        {
            // update product entity from command
            // save product to database
            // return result with new product id

            var product = await catalogDbContext.Products
                .FindAsync([command.Product.Id], cancellationToken);

            if (product is null)
            {
                throw new Exception($"Product not found :{command.Product.Id}");
            }

            UpdateProductWithNewValue(product, command.Product);

            catalogDbContext.Products.Update(product);
            await catalogDbContext.SaveChangesAsync();

            return new UpdateProductResult(true);
        }

        private void UpdateProductWithNewValue(Product product, ProductDto productDto)
        {
            product.Update(
                    productDto.Id,
                    productDto.Name,
                    productDto.Categories,
                    productDto.Description,
                    productDto.ImageFile,
                    productDto.Price);
        }
    }
}
