using MediatR;
using Projeto.Domain.Application.Queries.Requests;
using Projeto.Domain.Application.Queries.Responses;
using Projeto.Domain.Interfaces.Repositories;

namespace Projeto.Domain.Application.Handlers
{
    public class GetUsersHandler : IRequestHandler<GetUsersRequest, IEnumerable<GetUsersResponse>>
    {

        private readonly IUserRepository _userRepository;

        public GetUsersHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }



        public Task<IEnumerable<GetUsersResponse>> Handle(GetUsersRequest request, CancellationToken cancellationToken)
        {
            var result = _userRepository.GetAll().ToList();
            var response = new List<GetUsersResponse>();
            foreach (var user in result)
            {
                response.Add(new GetUsersResponse
                {
                    UserName = user.UserName,
                    Name = user.Name,
                    Id = user.Id,
                    AlterationDate = user.AlterationDate,
                    MotherName = user.MotherName,
                    BirthDate = user.BirthDate,
                    PhoneNumber = user.PhoneNumber,
                    Cpf = user.Cpf,
                    Email = user.Email,
                    Password = user.Password,
                    InclusionDate = user.InclusionDate,
                    status = user.Status,

                });
            }

            return Task.FromResult(response.AsEnumerable());

        }
    }
}
