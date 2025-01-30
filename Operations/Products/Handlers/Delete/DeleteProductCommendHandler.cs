using CqrsUsingMediatRApi.Data;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace CqrsUsingMediatRApi.Operations.Products.Handlers.Create
{
    public class DeleteProductCommendHandler(ShopDbContext context) : IRequestHandler<DeleteProductCommendRequest>
    {
        public async Task Handle(DeleteProductCommendRequest request, CancellationToken cancellationToken)
        {
            var data = context.Products.Find(request.Id);
            if (data != null)
            {
                context.Products.Remove(data);
                context.SaveChanges();
            }
        }
    }
}
