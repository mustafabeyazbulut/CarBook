using Carbook.Application.Features.Mediator.Results.BlogResults;
using MediatR;

namespace Carbook.Application.Features.Mediator.Queries.BlogQueries
{
    public class GetBlogQuery:IRequest<List<GetBlogQueryResult>>
    {
    }
}
