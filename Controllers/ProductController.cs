using CqrsUsingMediatRApi.Operations.Products.Handlers.Create;
using CqrsUsingMediatRApi.Operations.Products.Handlers.Get;
using CqrsUsingMediatRApi.Operations.Products.Handlers.List;
using CqrsUsingMediatRApi.Operations.Products.Models;
using MediatR;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CqrsUsingMediatRApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController(ISender sender) : ControllerBase
    {
        // GET: api/<ProductController>
        [HttpGet]
        public async Task<IEnumerable<ProductModel>> Get()
        {
            return await sender.Send(new ListProductsQueryRequest());
        }

        // GET api/<ProductController>/5
        [HttpGet("{id}")]
        public async Task<ProductModel> Get(Guid id)
        {
            return await sender.Send(new GetProductQueryRequest() { Id = id });
        }

        // POST api/<ProductController>
        [HttpPost]
        public async Task<Guid> Post([FromBody] ProductModel model)
        {
            return await sender.Send(new CreateProductCommendRequest() { Name = model.Name, Description = model.Description, Price = model.Price });
        }

        // PUT api/<ProductController>/5
        [HttpPut]
        public async Task Put([FromBody] ProductModel model)
        {
            await sender.Send(new UpdateProductCommendRequest() { Id = model.Id, Name = model.Name, Description = model.Description, Price = model.Price });
        }

        // DELETE api/<ProductController>/5
        [HttpDelete("{id}")]
        public async Task Delete(Guid id)
        {
            await sender.Send(new DeleteProductCommendRequest() { Id = id });
        }
    }
}
