using Carbook.Application.Features.CQRS.Results.CarResults;
using Carbook.Application.Interfaces.CarInterfaces;

namespace Carbook.Application.Features.CQRS.Handlers.CarHandlers
{
    public class GetLast5CarsWithBrandQueryHandler
    {
        private readonly ICarRepository _repository;
        public GetLast5CarsWithBrandQueryHandler(ICarRepository repository)
        {
            _repository = repository;
        }
        public List<GetLast5CarsWithBrandQueryResult> Handle()
        {
            var values = _repository.GetLast5VarsWithBrands();
            return values.Select(x => new GetLast5CarsWithBrandQueryResult
            {
                CarId = x.CarId,
                BrandId = x.BrandId,
                BrandName=x.Brand.Name,
                Model = x.Model,
                CoverImageUrl = x.CoverImageUrl,
                Km = x.Km,
                Transmission = x.Transmission,
                Seat = x.Seat,
                Luggage = x.Luggage,
                Fuel = x.Fuel,
                BigImageUrl = x.BigImageUrl
            }).ToList();
        }
    }
}
