﻿using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        void Add(Car car);
        void Update(Car car);
        void Delete(Car car);

        List<Car> GetCars();
        List<Car> GetCarsById(int id);
        List<CarDetailsDto> GetCarDetails();

    }
}
