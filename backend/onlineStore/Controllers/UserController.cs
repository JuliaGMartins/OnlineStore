using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineStore.Domain.Users.Entities;
using OnlineStore.Domain.Users.Interfaces.Services;

namespace OnlineStore.API.Controllers
{
    [Route("api/[controller]")]
    public class UserController : Controller
    {
        public readonly IUserService userService;
        private readonly IMapper mapper;

        public UserController(IUserService userService, IMapper mapper)
        {
            this.userService = userService;
            this.mapper = mapper;
        }

        [HttpGet("{userName}")]
        // GET api/<ProductController>/5
        public ActionResult<User> Get(String userName)
        {
            var user = userService.GetByUserName(userName);
            return Ok(user);
        }

        [HttpPost]
        [Route("CreateUser")]
        public void Create([FromBody] User user)
        {
            userService.Create(user);
        }

        [HttpPut]
        [Route("Update")]
        public void Update(User user)
        {
            try
            {
                userService.Update(user);
            } catch (System.Web.Http.HttpResponseException ex)
            {
                throw ex;
            }
            
        }

    }
}
