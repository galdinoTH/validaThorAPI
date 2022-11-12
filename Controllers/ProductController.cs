using validaThorAPI.Models;
using validaThorAPI.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace validaThorAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : Controller
    {
        private readonly ProductService _productsService;

        public ProductController(ProductService productsService)
        {
            _productsService = productsService;
        }

        [HttpGet]
        public ActionResult<List<Product>> Get() => _productsService.Get();

        [HttpGet("{id:length(24)}", Name = "GetProduct")]
        public ActionResult<Product> Get(string id)
        {
            var product = _productsService.Get(id);

            if (product == null)
                return NotFound();

            return product;
        }

        [HttpPost]
        public ActionResult<Product> Create(Product product)
        {
            _productsService.Create(product);

            return CreatedAtRoute("GetProduct", new { id = product.Id.ToString() }, product);
        }

        [HttpPut("{id:length(24)}")]
        public IActionResult Update(string id, Product productIn)
        {
            var product = _productsService.Get(id);

            if (product == null)
                return NotFound();

            _productsService.Update(id, productIn);

            return NoContent();
        }

        [HttpDelete("{id:length(24)}")]
        public IActionResult Delete(string id)
        {
            var product = _productsService.Get(id);

            if (product == null)
                return NotFound();

            _productsService.Remove(product.Id);

            return NoContent();
        }
    }
}