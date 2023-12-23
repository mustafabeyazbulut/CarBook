using MediatR;
using Carbook.Application.Features.Mediator.Results.StatisticsResults;

namespace Carbook.Application.Features.Mediator.Queries.StatisticsQueries
{
    public class GetAvgRentPriceForDailyQuery:IRequest<GetAvgRentPriceForDailyQueryResult>
    {
    }
}
