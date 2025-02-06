using CqrsUsingMediatRApi.Data;
using CqrsUsingMediatRApi.Data.Entity;
using MediatR;

namespace CqrsUsingMediatRApi.Operations.Products.Handlers.Create
{
    public class UpdateProductCommendHandler(ShopDbContext context) : IRequestHandler<UpdateProductCommendRequest>
    {
        public async Task Handle(UpdateProductCommendRequest request, CancellationToken cancellationToken)
        {
            var data = new Product()
            {
                Id = request.Id,
                Name = request.Name,
                Description = request.Description,
                Price = request.Price
            };
            context.Products.Update(data);
            context.SaveChanges();
        }
    }
}
