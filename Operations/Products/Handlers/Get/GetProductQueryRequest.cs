using CqrsUsingMediatRApi.Operations.Products.Models;
using MediatR;

namespace CqrsUsingMediatRApi.Operations.Products.Handlers.Get
{
    public class GetProductQueryRequest : IRequest<ProductModel>
    {
        public Guid Id { get; set; }
    }
}
