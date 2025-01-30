using CqrsUsingMediatRApi.Data;
using CqrsUsingMediatRApi.Operations.Products.Models;
using MediatR;

namespace CqrsUsingMediatRApi.Operations.Products.Handlers.Get
{
    public class GetProductQueryHandler(ShopDbContext context) : IRequestHandler<GetProductQueryRequest, ProductModel>
    {
        public async Task<ProductModel> Handle(GetProductQueryRequest request, CancellationToken cancellationToken)
        {
            var data = context.Products.Find(request.Id);
            return data != null ? new ProductModel()
            {
                Id = data.Id,
                Name = data.Name,
                Description = data.Description,
                Price = data.Price
            } : new();
        }
    }
}
