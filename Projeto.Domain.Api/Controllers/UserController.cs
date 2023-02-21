using Azure.Core;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Projeto.Domain.Application.Commands.Requests;
using Projeto.Domain.Application.Handlers;
using Projeto.Domain.Application.Queries.Requests;

namespace Projeto.Domain.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly CreateUserHandler _createUserHandler;

        public UserController(CreateUserHandler createUserHandler, IMediator mediator)
        {
            _createUserHandler = createUserHandler;
            _mediator = mediator;
        }

        [HttpPost]
        public IActionResult CreateUser(CreateUserRequest createUserRequest)
        {
            return Ok(_mediator.Send(createUserRequest));

        }

        [HttpGet]
        public IActionResult GetUsers()
        {
            var request = new GetUsersRequest();

            return Ok(_mediator.Send(request));

        }

        [HttpGet("{id:Guid}")]
        public IActionResult GetUser(Guid id)
        {
            var request = new GetUserRequest();
            request.Id = id;
            return Ok(_mediator.Send(request));

        }

        [HttpPut("{id:Guid}")]
        public IActionResult UpdateUser(Guid id, UpdateUserRequest updateUserRequest)
        {
            updateUserRequest.Id = id;
            return Ok(_mediator.Send(updateUserRequest));
        }

        [HttpDelete("{id:Guid}")]
        public IActionResult DeleteUser(Guid id)
        {
            var request = new DeleteUserRequest();
            request.Id = id;
            return Ok(_mediator.Send(request));

        }
    }
}
