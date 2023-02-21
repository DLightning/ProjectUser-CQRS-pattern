using MediatR;
using Projeto.Domain.Application.Commands.Requests;
using Projeto.Domain.Application.Commands.Responses;
using Projeto.Domain.Entities;
using Projeto.Domain.Interfaces.Repositories;

namespace Projeto.Domain.Application.Handlers
{
    public class CreateUserHandler : IRequestHandler<CreateUserRequest, CreateUserResponse>
    {

        private readonly IUserRepository _userRepository;

        public CreateUserHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public Task<CreateUserResponse> Handle(CreateUserRequest request, CancellationToken cancellationToken)
        {
            UserEntity user = new UserEntity
            {
                Email = request.Email,
                Name = request.Name,
                BirthDate = request.BirthDate,
                Cpf = request.Cpf,
                MotherName = request.MotherName,
                Password = request.Password,
                PhoneNumber = request.PhoneNumber,
                UserName = request.UserName,
            };

            var newUser = _userRepository.AddUser(user);
            var result = new CreateUserResponse
            {
                Id = newUser.Id,
                Email = newUser.Email,
                Name = newUser.Name,
                BirthDate = newUser.BirthDate,
                Cpf = newUser.Cpf,
                MotherName = newUser.MotherName,
                Password = newUser.Password,
                PhoneNumber = newUser.PhoneNumber,
                UserName = newUser.UserName,
            };

            return Task.FromResult(result);
        }

    }
}
