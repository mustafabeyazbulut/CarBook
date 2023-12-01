using Carbook.Application.Features.Mediator.Results.ServiceResults;
using MediatR;

namespace Carbook.Application.Features.Mediator.Queries.ServiceQueries
{
    public class GetServiceQuery:IRequest<List<GetServiceQueryResult>>
    {
    }
}
