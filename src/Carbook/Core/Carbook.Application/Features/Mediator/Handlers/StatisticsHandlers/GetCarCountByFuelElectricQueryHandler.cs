﻿using MediatR;
using Carbook.Application.Features.Mediator.Queries.StatisticsQueries;
using Carbook.Application.Features.Mediator.Results.StatisticsResults;
using Carbook.Application.Interfaces.StatisticsInterfaces;

namespace Carbook.Application.Features.Mediator.Handlers.StatisticsHandlers
{
    public class GetCarCountByFuelElectricQueryHandler : IRequestHandler<GetCarCountByFuelElectricQuery, GetCarCountByFuelElectricQueryResult>
    {
        private readonly IStatisticsRepository _repository;

        public GetCarCountByFuelElectricQueryHandler(IStatisticsRepository repository)
        {
            _repository = repository;
        }

        public async Task<GetCarCountByFuelElectricQueryResult> Handle(GetCarCountByFuelElectricQuery request, CancellationToken cancellationToken)
        {
            var value = _repository.GetCarCountByFuelElectric();
            return new GetCarCountByFuelElectricQueryResult
            {
                CarCountByFuelElectric = value
            };
        }
    }
}
