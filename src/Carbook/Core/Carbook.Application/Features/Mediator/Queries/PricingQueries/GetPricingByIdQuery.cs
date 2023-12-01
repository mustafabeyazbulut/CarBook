using Carbook.Application.Features.Mediator.Results.PricingResults;
using MediatR;

namespace Carbook.Application.Features.Mediator.Queries.PricingQueries
{
    public class GetPricingByIdQuery:IRequest<GetPricingByIdQueryResult>
    {
        public int Id { get; set; }
        public GetPricingByIdQuery(int id)
        {
            Id = id;
        }
    }
}
