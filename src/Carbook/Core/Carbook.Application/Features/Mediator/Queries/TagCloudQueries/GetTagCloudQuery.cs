using Carbook.Application.Features.Mediator.Results.TagCloudResults;
using MediatR;

namespace Carbook.Application.Features.Mediator.Queries.TagCloudQueries
{
    public class GetTagCloudQuery:IRequest<List<GetTagCloudQueryResult>>
    {
    }
}
