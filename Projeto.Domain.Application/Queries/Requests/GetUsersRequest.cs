using MediatR;
using Projeto.Domain.Application.Queries.Responses;

namespace Projeto.Domain.Application.Queries.Requests
{
    public class GetUsersRequest : IRequest<IEnumerable<GetUsersResponse>>
    {

    }
}
