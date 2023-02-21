using Microsoft.AspNetCore.Mvc;
using Projeto.Domain.Application.Handlers;
using Projeto.Domain.Entities;
using Projeto.Domain.Repositories;

namespace Projeto.Domain.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {

        private readonly UserHandler _userHandler;

        public UserController(UserHandler userHandler)
        {
            _userHandler = userHandler;
        }

        [HttpGet]
        public IEnumerable<UserEntity> Index()
        {
            var result = _userHandler.Handler();

            return result;
        }
    }
}
