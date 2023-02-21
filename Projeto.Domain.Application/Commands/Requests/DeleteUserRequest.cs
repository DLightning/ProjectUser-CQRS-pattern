using MediatR;
using Projeto.Domain.Application.Commands.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Domain.Application.Commands.Requests
{
    public class DeleteUserRequest : IRequest<DeleteUserResponse>
    {
        public Guid Id { get; set; }
    }
}
