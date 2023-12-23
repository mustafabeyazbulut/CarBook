using Carbook.Application.Interfaces.CarInterfaces;
using Carbook.Persistence.Context;
using CarBook.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Carbook.Persistence.Repositories.CarRepositories
{
    public class CarRepository : ICarRepository
    {
        private readonly CarBookContext _context;
        public CarRepository(CarBookContext context)
        {
            _context = context;
        }

        public int GetCarCount()
        {
            var value = _context.Cars.Count();
            return value;
        }

        public List<Car> GetCarsListWithBrands()
        {
            var values= _context.Cars.Include(x=>x.Brand).ToList();
            return values;
        }
        public List<Car> GetLast5VarsWithBrands()
        {
            var values=_context.Cars.Include(_x => _x.Brand).OrderByDescending(x=>x.CarId).Take(5).ToList();
            return values;
        }
    }
}
