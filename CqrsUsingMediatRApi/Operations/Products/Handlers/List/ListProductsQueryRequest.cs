using CqrsUsingMediatRApi.Data.Entity;
using CqrsUsingMediatRApi.Operations.Products.Models;
using MediatR;

namespace CqrsUsingMediatRApi.Operations.Products.Handlers.List
{
    public class ListProductsQueryRequest : IRequest<IList<ProductModel>>
    {
    }
}
