using CqrsUsingMediatRApi.Data;
using CqrsUsingMediatRApi.Data.Entity;
using MediatR;

namespace CqrsUsingMediatRApi.Operations.Products.Handlers.Create
{
    public class CreateProductCommendHandler(ShopDbContext context) : IRequestHandler<CreateProductCommendRequest, Guid>
    {
        public async Task<Guid> Handle(CreateProductCommendRequest request, CancellationToken cancellationToken)
        {
            var data = new Product()
            {
                Id = Guid.NewGuid(),
                Name = request.Name,
                Description = request.Description,
                Price = request.Price
            };
            context.Products.Add(data);
            context.SaveChanges();
            return data.Id;
        }
    }
}
