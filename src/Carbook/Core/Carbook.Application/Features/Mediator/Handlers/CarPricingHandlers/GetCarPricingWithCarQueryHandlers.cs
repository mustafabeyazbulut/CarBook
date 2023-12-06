using Carbook.Application.Features.Mediator.Queries.CarPricingQueries;
using Carbook.Application.Features.Mediator.Results.CarPricingResults;
using Carbook.Application.Interfaces.PricingInterfaces;
using MediatR;

namespace Carbook.Application.Features.Mediator.Handlers.CarPricingHandlers
{
    public class GetCarPricingWithCarQueryHandlers : IRequestHandler<GetCarPricingWithCarQuery, List<GetCarPricingWithCarQueryResult>>
    {
        private readonly ICarPricingRepository _repository;
        public GetCarPricingWithCarQueryHandlers(ICarPricingRepository repository)
        {
            _repository = repository;
        }
        public async Task<List<GetCarPricingWithCarQueryResult>> Handle(GetCarPricingWithCarQuery request, CancellationToken cancellationToken)
        {
            var values = _repository.GetCarPricingWithCars();
            return values.Select(x => new GetCarPricingWithCarQueryResult
            {
                Amount = x.Amount,
                Brand=x.Car.Brand.Name,
                CarPricingId=x.CarPricingId,
                CoverImageUrl=x.Car.CoverImageUrl,
                Model=x.Car.Model
            }).ToList();
        }
    }
}
