using Carbook.Application.Features.Mediator.Queries.RentACarQueries;
using Carbook.Application.Features.Mediator.Results.RentACarResults;
using Carbook.Application.Interfaces.RentACarInterfaces;
using MediatR;

namespace Carbook.Application.Features.Mediator.Handlers.RentACarHandlers
{
    public class GetRentACarQueryHandler : IRequestHandler<GetRentACarQuery, List<GetRentACarQueryResult>>
    {
        private readonly IRentACarRepository _repository;
        public GetRentACarQueryHandler(IRentACarRepository repository)
        {
            _repository = repository;
        }
        public async Task<List<GetRentACarQueryResult>> Handle(GetRentACarQuery request, CancellationToken cancellationToken)
        {
            var values =await _repository.GetByFilterAsync(x => x.LocationId == request.LocationId && x.Available == request.Available);
            var Results= values.Select(y=> new GetRentACarQueryResult
            {
                CarId=y.CarId
            }).ToList();
            return Results;
        }
    }
}
