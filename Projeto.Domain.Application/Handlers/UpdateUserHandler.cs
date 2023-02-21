using MediatR;
using Projeto.Domain.Application.Commands.Requests;
using Projeto.Domain.Application.Commands.Responses;
using Projeto.Domain.Application.Queries.Requests;
using Projeto.Domain.Infra.Contexts;
using Projeto.Domain.Interfaces.Repositories;

namespace Projeto.Domain.Application.Handlers
{
    public class UpdateUserHandler : IRequestHandler<UpdateUserRequest, UpdateUserResponse>
    {

        private readonly IUserRepository _userRepository;
   

        public UpdateUserHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
            
        }

        public Task<UpdateUserResponse> Handle(UpdateUserRequest request, CancellationToken cancellationToken)
        {

            var user = _userRepository.GetUser(request.Id);
            if(user != null)
            {
                user.PhoneNumber = request.PhoneNumber;
                user.UserName = request.UserName;
                user.Email = request.Email;
                user.Password = request.Password;
                user.Cpf = request.Cpf;
                user.BirthDate = request.BirthDate;
                user.MotherName = request.MotherName;
                user.Name = request.Name;
                
            }
            var result = _userRepository.UpdateUser(user);

            return Task.FromResult(new UpdateUserResponse());

        }
    }
}
