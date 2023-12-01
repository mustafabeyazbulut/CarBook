using Carbook.Application.Features.CQRS.Queries.CarQueries;
using Carbook.Application.Features.CQRS.Results.CarResults;
using Carbook.Application.Interfaces;
using CarBook.Domain.Entities;

namespace Carbook.Application.Features.CQRS.Handlers.CarHandlers
{
    public class GetCarByIdQueryHandler
    {
        private readonly IRepository<Car> _repository;

        public GetCarByIdQueryHandler(IRepository<Car> repository)
        {
            _repository = repository;
        }
        public async Task<GetCarByIdQueryResult> Handle(GetCarByIdQuery query)
        {
            var values = await _repository.GetByIdAsync(query.CarId);
            return new GetCarByIdQueryResult
            {
                CarId = values.CarId,
                BrandId = values.BrandId,
                Model = values.Model,
                CoverImageUrl = values.CoverImageUrl,
                Km = values.Km,
                Transmission = values.Transmission,
                Seat = values.Seat,
                Luggage = values.Luggage,
                Fuel = values.Fuel,
                BigImageUrl = values.BigImageUrl
            };
        }
    }
}
