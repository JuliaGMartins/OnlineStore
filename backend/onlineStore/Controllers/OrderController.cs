using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineStore.Domain.Orders.Entities;
using OnlineStore.Domain.Orders.Interfaces.Services;

namespace OnlineStore.API.Controllers
{
    [Route("api/[controller]")]
    [Authorize]
    [ApiController]
    public class OrderController : Controller
    {

        public readonly IOrderService orderService;
        private readonly IMapper mapper;

        public OrderController(IOrderService productService, IMapper mapper)
        {
            this.orderService = productService;
            this.mapper = mapper;
        }

        // GET: api/<ProductController>
        [HttpGet("{id}")]
        public ActionResult<Order> Get(Guid id)
        {
            return orderService.FindOrder(id);
        }

        [HttpPost]
        [Route("CancelOrder")]
        // GET api/<ProductController>/5
        public ActionResult CancelOrder(Guid id)
        {
            orderService.CancelOrder(id);
            return Ok();
        }

        [HttpPost]
        [Route("Create")]
        // GET api/<ProductController>/5
        public ActionResult CreateOrder(Order order)
        {
            orderService.CreateOrder(order);
            return Ok();
        }

        [HttpPost]
        [Route("UpdateOrderCancelPending")]
        // GET api/<ProductController>/5
        public ActionResult UpdateOrderCancelPending(Guid id)
        {
            orderService.UpdateOrderStatusCancelPending(id);
            return Ok();
        }

        [HttpPost]
        [Route("UpdateOrderFinished")]
        // GET api/<ProductController>/5
        public ActionResult UpdateOrderFinished(Guid id)
        {
            orderService.UpdateOrderStatusFinished(id);
            return Ok();
        }

    }
}
