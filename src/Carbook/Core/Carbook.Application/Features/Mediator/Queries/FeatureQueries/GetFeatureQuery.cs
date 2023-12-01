using Carbook.Application.Features.Mediator.Results.FeatureResults;
using MediatR;

namespace Carbook.Application.Features.Mediator.Queries.FeatureQueries
{
    public class GetFeatureQuery:IRequest<List<GetFeatureQueryResult>>
    {
    }
}
