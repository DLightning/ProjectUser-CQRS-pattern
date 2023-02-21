using MediatR;
using Projeto.Domain.Application.Commands.Responses;

namespace Projeto.Domain.Application.Commands.Requests
{
    public class UpdateUserRequest : IRequest<UpdateUserResponse>
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string UserName { get; set; }
        public string Cpf { get; set; }
        public string MotherName { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime BirthDate { get; set; }
    }
}
