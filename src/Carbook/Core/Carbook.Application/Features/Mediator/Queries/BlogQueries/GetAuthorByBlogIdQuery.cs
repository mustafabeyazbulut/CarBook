using Carbook.Application.Features.Mediator.Results.BlogResults;
using MediatR;

namespace Carbook.Application.Features.Mediator.Queries.BlogQueries
{
    public class GetAuthorByBlogIdQuery:IRequest<List<GetAuthorByBlogIdQueryResult>>
    {
        public int Id { get; set; }
        public GetAuthorByBlogIdQuery(int id)
        {
            Id = id;
        }
    }
}
