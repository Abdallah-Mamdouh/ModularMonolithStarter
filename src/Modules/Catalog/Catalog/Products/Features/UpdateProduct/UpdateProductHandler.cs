
namespace Catalog.Products.Features.UpdateProduct
{
    public record UpdateProductCommand(ProductDto Product) : ICommand<UpdateProductResult>;

    public record UpdateProductResult(bool IsSuccess);

    internal class UpdateProductHandler(CatalogDbContext catalogDbContext) : ICommandHandler<UpdateProductCommand, UpdateProductResult>
    {
        public Task<UpdateProductResult> Handle(UpdateProductCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
