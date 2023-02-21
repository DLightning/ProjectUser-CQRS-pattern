using MediatR;
using Projeto.Domain.Application.Queries.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Domain.Application.Queries.Requests
{
    public class GetUserRequest : IRequest<GetUserResponse>
    {
        public Guid Id { get; set;}
    }
}
