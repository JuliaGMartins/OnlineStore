using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineStore.Domain.Carts.Entities;
using OnlineStore.Domain.Carts.Interfaces.Services;
using OnlineStore.Domain.Products.Entities;

namespace OnlineStore.API.Controllers
{
    [Route("api/[controller]")]
    public class CartController : Controller
    {
        public readonly ICartService cartService;
        private readonly IMapper mapper;

        public CartController(ICartService cartService, IMapper mapper)
        {
            this.cartService = cartService;
            this.mapper = mapper;
        }

        [HttpPost]
        [Route("CreateCart")]
        //Procura o Cart, se já não existir algum para o usuário, cria
        public ActionResult<Cart> Create([FromBody] Cart cart)
        {
            return cartService.Create(cart);
        }

        [HttpGet]
        [Route("GetByUsername")]
        public ActionResult<Cart> Get(String username)
        {
            return cartService.GetCartByUser(username);
        }

        [HttpPost]
        [Route("AddCartItem")]
        public ActionResult AddCartItem(Guid productId, string userId)
        {
            cartService.AddCartItem(productId, userId);
            return Ok();
        }

        [HttpPost]
        [Route("RemoveCartItem")]
        public ActionResult RemoveCartItem(Guid productId, string userId)
        {
            cartService.DeleteCartItem(productId, userId);
            return Ok();
        }

    }
}
