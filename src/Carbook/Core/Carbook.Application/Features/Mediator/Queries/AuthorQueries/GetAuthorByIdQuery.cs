using Carbook.Application.Features.Mediator.Results.AuthorResults;
using MediatR;

namespace Carbook.Application.Features.Mediator.Queries.AuthorQueries
{
    public class GetAuthorByIdQuery:IRequest<GetAuthorByIdQueryResult>
    {
        public int Id { get; set; }
        public GetAuthorByIdQuery(int id)
        {
            Id = id;
        }
    }
}
