using CqrsUsingMediatRApi.Data;
using CqrsUsingMediatRApi.Operations.Products.Models;
using MediatR;

namespace CqrsUsingMediatRApi.Operations.Products.Handlers.List
{
    public class ListProductsQueryHandler(ShopDbContext context) : IRequestHandler<ListProductsQueryRequest, IList<ProductModel>>
    {
        public async Task<IList<ProductModel>> Handle(ListProductsQueryRequest request, CancellationToken cancellationToken)
        {
            return context.Products.Select(p => new ProductModel()
            {
                Id = p.Id,
                Name = p.Name,
                Description = p.Description,
                Price = p.Price
            }).ToList();
        }
    }
}
