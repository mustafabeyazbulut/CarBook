using Carbook.Application.Features.Mediator.Results.BlogResults;
using MediatR;

namespace Carbook.Application.Features.Mediator.Queries.BlogQueries
{
    public class GetBlogByIdQuery:IRequest<GetBlogByIdQueryResult>
    {
        public int Id { get; set; }
        public GetBlogByIdQuery(int id)
        {
            Id = id;
        }
    }
}
