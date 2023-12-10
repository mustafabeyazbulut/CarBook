using Carbook.Application.Features.Mediator.Results.TagCloudResults;
using MediatR;

namespace Carbook.Application.Features.Mediator.Queries.TagCloudQueries
{
    public class GetTagCloudByBlogIdQuery:IRequest<List<GetTagCloudByBlogIdQueryResult>>
    {
        public int Id { get; set; }
        public GetTagCloudByBlogIdQuery(int id)
        {
            Id = id;
        }
    }
}
