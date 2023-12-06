using CarBook.Domain.Entities;

namespace Carbook.Application.Interfaces.PricingInterfaces
{
    public interface ICarPricingRepository
    {
        List<CarPricing> GetCarPricingWithCars();
    }
}
