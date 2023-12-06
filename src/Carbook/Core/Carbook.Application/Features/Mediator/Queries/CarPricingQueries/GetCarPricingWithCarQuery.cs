using Carbook.Application.Features.Mediator.Results.CarPricingResults;
using MediatR;

namespace Carbook.Application.Features.Mediator.Queries.CarPricingQueries
{
    public class GetCarPricingWithCarQuery:IRequest<List<GetCarPricingWithCarQueryResult>>
    {
    }
}
