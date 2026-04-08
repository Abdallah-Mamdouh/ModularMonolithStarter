
using Catalog.Products.Features.UpdateProduct;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Catalog.Products.Features.DeleteProduct
{
    public record DeleteProductCommand(Guid ProductId) : ICommand<DeleteProductResult>;

    public record DeleteProductResult(bool IsSuccess);

    public class DeleteProductCommandValidator : AbstractValidator<DeleteProductCommand>
    {
        public DeleteProductCommandValidator()
        {
            RuleFor(x => x.ProductId).NotEmpty().WithMessage("Product Id is required");
        }
    }

    internal class DeleteProductHandler(CatalogDbContext catalogDbContext) : ICommandHandler<DeleteProductCommand, DeleteProductResult>
    {
        public async Task<DeleteProductResult> Handle(DeleteProductCommand command, CancellationToken cancellationToken)
        {
            // delete product entity from command
            // save product to database
            // return result with new product id

            var product = await catalogDbContext.Products
                .FindAsync([command.ProductId], cancellationToken);

            if (product is null)
            {
                throw new Exception($"Product not found :{command.ProductId}");
            }

            catalogDbContext.Remove(product);
            await catalogDbContext.SaveChangesAsync(cancellationToken);

            return new DeleteProductResult(true);
        }
    }
}
