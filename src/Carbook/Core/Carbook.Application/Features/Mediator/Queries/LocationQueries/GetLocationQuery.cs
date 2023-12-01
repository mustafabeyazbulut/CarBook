using Carbook.Application.Features.Mediator.Results.LocationResults;
using MediatR;

namespace Carbook.Application.Features.Mediator.Queries.LocationQueries
{
    public class GetLocationQuery:IRequest<List<GetLocationQueryResult>>
    {
    }
}
