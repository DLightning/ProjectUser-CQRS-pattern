using MediatR;
using Projeto.Domain.Application.Commands.Responses;
using Projeto.Domain.Application.Queries.Requests;
using Projeto.Domain.Application.Queries.Responses;
using Projeto.Domain.Interfaces.Repositories;

namespace Projeto.Domain.Application.Handlers
{
    public class GetUserHandler : IRequestHandler<GetUserRequest, GetUserResponse>
    {

        private readonly IUserRepository _userRepository;

        public GetUserHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public Task<GetUserResponse> Handle(GetUserRequest request, CancellationToken cancellationToken)
        {
            var user = _userRepository.GetUser(request.Id);
            var result = new GetUserResponse();
            if (user != null) { 
                result = new GetUserResponse
                {
                    Id = user.Id,
                    Email = user.Email,
                    Name = user.Name,
                    BirthDate = user.BirthDate,
                    Cpf = user.Cpf,
                    MotherName = user.MotherName,
                    Password = user.Password,
                    PhoneNumber = user.PhoneNumber,
                    UserName = user.UserName,
                    status = user.Status,
                    AlterationDate = user.AlterationDate,
                    InclusionDate = user.InclusionDate,
                };
            }
            return Task.FromResult(result);

        }
    }
}
