namespace Catalog.Products.Features.GetProducts
{
    public record GetProductsQuery : IQuery<GetProductsResult>;

    public record GetProductsResult(IEnumerable<ProductDto> Products);

    internal class GetProductsHandler(CatalogDbContext catalogDbContext) : IQueryHandler<GetProductsQuery, GetProductsResult>
    {
        public async Task<GetProductsResult> Handle(GetProductsQuery query, CancellationToken cancellationToken)
        {
            // get products from database
            // return them as a result

            var products = await catalogDbContext.Products
                .AsNoTracking()
                .OrderBy(p => p.Name)
                .ToListAsync(cancellationToken);

            var productDtos = products.Adapt<List<ProductDto>>();

            return new GetProductsResult(productDtos);
        }
    }
}
