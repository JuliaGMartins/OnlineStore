using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineStore.Domain.Carts.Entities;
using OnlineStore.Domain.Carts.Interfaces.Services;

namespace OnlineStore.API.Controllers
{
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
        [Route("Find")]
        //Procura o Cart, se já não existir algum para o usuário, cria
        public ActionResult<Cart> Create([FromBody] Cart cart)
        {
            return cartService.FindCart(cart);
        }
    }
}
