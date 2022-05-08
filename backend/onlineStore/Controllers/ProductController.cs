using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OnlineStore.API.Models;
using OnlineStore.Domain.Products.Entities;
using OnlineStore.Domain.Products.Interfaces.Services;
using OnlineStore.Domain.Products.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace OnlineStore.API.Controllers
{
    [Route("api/[controller]")]
    [Authorize]
    [ApiController]
    public class ProductController : ControllerBase
    {
        public readonly IProductService productService;
        private readonly IMapper mapper;

        public ProductController(IProductService productService, IMapper mapper)
        {
            this.productService = productService;
            this.mapper = mapper;
        }
        // GET: api/<ProductController>
        [HttpGet]
        [Route("GetAllProducts")]
        public IEnumerable<Product> Get()
        {
            return productService.GetProducts();
        }
        [HttpGet("{productName}")]
        // GET api/<ProductController>/5
        public ActionResult<ICollection<ProductViewModel>> Get(String productName)
        {
            var products = productService.GetByName(productName);
            var productsViewModel = products.Select(product => mapper.Map<ProductViewModel>(product));
            return Ok(productsViewModel);
        }

        [HttpGet]
        [Route("Category")]
        // GET api/<ProductController>/5
        public ActionResult<ICollection<ProductViewModel>> GetbyCategory(int cat)
        {
            var products = productService.GetByCategory(cat);
            var productsViewModel = products.Select(product => mapper.Map<ProductViewModel>(product));
            return Ok(productsViewModel);
        }

        [HttpGet]
        [Route("Color")]
        // GET api/<ProductController>/5
        public ActionResult<ICollection<ProductViewModel>> GetbyColor(int color)
        {
            var products = productService.GetByColor(color);
            var productsViewModel = products.Select(product => mapper.Map<ProductViewModel>(product));
            return Ok(productsViewModel);
        }

        // POST api/<ProductController>
        [HttpPost]
        [Route("Create")]
        public ActionResult<String> Create([FromBody] Product product)
        {
            var productView = productService.Create(product);
            var productViewModel = mapper.Map<ProductViewModel>(productView);
            return Ok(productViewModel);
        }

        // PUT api/<ProductController>/5
        [HttpPut]
        [Route("Update")]
        public void Put(Product product)
        {
            productService.Update(product);
        }

        // DELETE api/<ProductController>/5
        [HttpDelete]
        [Route("Delete")]
        public void Delete(Guid productId)
        {
            productService.Delete(productId);
        }
    }
}
