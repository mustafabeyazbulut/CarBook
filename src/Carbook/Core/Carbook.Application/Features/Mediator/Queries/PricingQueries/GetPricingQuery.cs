using Carbook.Application.Features.Mediator.Results.PricingResults;
using MediatR;

namespace Carbook.Application.Features.Mediator.Queries.PricingQueries
{
    public class GetPricingQuery:IRequest<List<GetPricingQueryResult>>
    {
    }
}
