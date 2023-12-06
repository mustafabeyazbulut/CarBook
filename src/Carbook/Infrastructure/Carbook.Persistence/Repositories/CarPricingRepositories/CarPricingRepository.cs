using Carbook.Application.Interfaces.PricingInterfaces;
using Carbook.Persistence.Context;
using CarBook.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Carbook.Persistence.Repositories.CarPricingRepositories
{
    public class CarPricingRepository:ICarPricingRepository
    {
        private readonly CarBookContext _context;
        public CarPricingRepository(CarBookContext context)
        {
            _context = context;
        }
        public List<CarPricing> GetCarPricingWithCars()
        {
            var values = _context.CarPricings.Include(x => x.Car).ThenInclude(y => y.Brand)
                .Include(z => z.Pricing)
                .Where(x=>x.PricingId==3)
                .ToList();
            return values;
        }
    }
}
