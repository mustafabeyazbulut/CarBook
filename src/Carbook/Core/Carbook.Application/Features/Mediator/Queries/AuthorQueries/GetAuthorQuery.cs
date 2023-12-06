using Carbook.Application.Features.Mediator.Results.AuthorResults;
using MediatR;

namespace Carbook.Application.Features.Mediator.Queries.AuthorQueries
{
    public class GetAuthorQuery:IRequest<List<GetAuthorQueryResult>>
    {
    }
}
