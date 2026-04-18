using CatalogContracts.Products.Features.GetProductById;

namespace Catalog.Products.Features.GetProductById
{

    internal class GetProductByIdHandler(CatalogDbContext catalogDbContext) : IQueryHandler<GetProductByIdQuery, GetProductByIdResult>
    {
        public async Task<GetProductByIdResult> Handle(GetProductByIdQuery query, CancellationToken cancellationToken)
        {
            // get product from database
            // return them as a result

            var product = await catalogDbContext.Products
                .AsNoTracking()
                .SingleOrDefaultAsync(p => p.Id == query.ProductId, cancellationToken);

            if (product is null)
            {
                throw new ProductNotFoundExcption(query.ProductId);
            }

            var productDto = product.Adapt<ProductDto>();

            return new GetProductByIdResult(productDto);
        }
    }
}
