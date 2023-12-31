﻿using CarBook.Domain.Entities;

namespace Carbook.Application.Interfaces.CarInterfaces
{
    public interface ICarRepository
    {
        List<Car> GetCarsListWithBrands();
        List<Car> GetLast5VarsWithBrands();
        int GetCarCount();
    }
}
