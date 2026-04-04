
using Catalog.Data;

namespace Catalog.Products.Features.GetProductByCategory
{
    public record GetProductByCategoryQuery(string Category) : IQuery<GetProductByCategoryResult>;

    public record GetProductByCategoryResult(IEnumerable<ProductDto> Products);

    internal class GetProductByCategoryHandler(CatalogDbContext catalogDbContext) : IQueryHandler<GetProductByCategoryQuery, GetProductByCategoryResult>
    {
        public async Task<GetProductByCategoryResult> Handle(GetProductByCategoryQuery query, CancellationToken cancellationToken)
        {
            // get products from database
            // return them as a result

            var products = await catalogDbContext.Products
                .AsNoTracking()
                .Where(p => p.Categories.Contains(query.Category))
                .OrderBy(p => p.Name)
                .ToListAsync(cancellationToken);

            var productDtos = products.Adapt<List<ProductDto>>();

            return new GetProductByCategoryResult(productDtos);
        }
    }
}
