using Carbook.Application.Features.Mediator.Results.BlogResults;
using MediatR;

namespace Carbook.Application.Features.Mediator.Queries.BlogQueries
{
    public class GetAllBlogWithAuthorQuery:IRequest<List<GetAllBlogWithAuthorQueryResult>>
    {
    }
}
