using MediatR;

namespace CqrsUsingMediatRApi.Operations.Products.Handlers.Create
{
    public class CreateProductCommendRequest : IRequest<Guid>
    {
        public required string Name { get; set; }
        public required string Description { get; set; }
        public decimal Price { get; set; }
    }
}
