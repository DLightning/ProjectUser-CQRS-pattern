using MediatR;
using Projeto.Domain.Application.Commands.Requests;
using Projeto.Domain.Application.Commands.Responses;
using Projeto.Domain.Application.Queries.Requests;
using Projeto.Domain.Application.Queries.Responses;
using Projeto.Domain.Infra.Contexts;
using Projeto.Domain.Interfaces.Repositories;

namespace Projeto.Domain.Application.Handlers
{
    public class DeleteUserHandler : IRequestHandler<DeleteUserRequest, DeleteUserResponse>
    {
        private readonly IUserRepository _userRepository;
        private readonly MyContext _myContext;

        public DeleteUserHandler(IUserRepository userRepository, MyContext myContext)
        {
            _userRepository = userRepository;
            _myContext = myContext;
        }

        public Task<DeleteUserResponse> Handle(DeleteUserRequest request, CancellationToken cancellationToken)
        {
            var user = _userRepository.GetUser(request.Id);
            
            if (user != null)
            {
                _userRepository.DeleteUser(user);

            }


            return Task.FromResult(new DeleteUserResponse());

        }
    }
}
