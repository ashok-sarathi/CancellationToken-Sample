using MediatR;

namespace CqrsUsingMediatRApi.Operations.Products.Handlers.Create
{
    public class DeleteProductCommendRequest : IRequest
    {
        public Guid Id { get; set; }
    }
}
