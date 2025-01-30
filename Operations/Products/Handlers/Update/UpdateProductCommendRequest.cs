using MediatR;

namespace CqrsUsingMediatRApi.Operations.Products.Handlers.Create
{
    public class UpdateProductCommendRequest : IRequest
    {
        public Guid Id { get; set; }
        public required string Name { get; set; }
        public required string Description { get; set; }
        public decimal Price { get; set; }
    }
}
