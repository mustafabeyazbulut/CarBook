using MediatR;
using Carbook.Application.Features.Mediator.Queries.StatisticsQueries;
using Carbook.Application.Features.Mediator.Results.StatisticsResults;
using Carbook.Application.Interfaces.StatisticsInterfaces;

namespace Carbook.Application.Features.Mediator.Handlers.StatisticsHandlers
{
    internal class GetAvgRentPriceForDailyQueryHandler : IRequestHandler<GetAvgRentPriceForDailyQuery, GetAvgRentPriceForDailyQueryResult>
    {
        private readonly IStatisticsRepository _repository;

        public GetAvgRentPriceForDailyQueryHandler(IStatisticsRepository repository)
        {
            _repository = repository;
        }

        public async Task<GetAvgRentPriceForDailyQueryResult> Handle(GetAvgRentPriceForDailyQuery request, CancellationToken cancellationToken)
        {
            var value = _repository.GetAvgRentPriceForDaily();
            return new GetAvgRentPriceForDailyQueryResult
            {
                AvgPriceForDaily = value
            };
        }
    }
}
