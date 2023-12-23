using MediatR;
using Carbook.Application.Features.Mediator.Queries.StatisticsQueries;
using Carbook.Application.Features.Mediator.Results.FooterAddressResults;
using Carbook.Application.Features.Mediator.Results.StatisticsResults;
using Carbook.Application.Interfaces.CarInterfaces;

namespace Carbook.Application.Features.Mediator.Handlers.StatisticsHandlers
{
    public class GetCarCountQueryHandler : IRequestHandler<GetCarCountQuery, GetCarCountQueryResult>
    {
        private readonly ICarRepository _repository;

        public GetCarCountQueryHandler(ICarRepository repository)
        {
            _repository = repository;
        }

        public async Task<GetCarCountQueryResult> Handle(GetCarCountQuery request, CancellationToken cancellationToken)
        {
            var value = _repository.GetCarCount();
            return new GetCarCountQueryResult
            {
                CarCount = value,
            };
        }
    }
}
