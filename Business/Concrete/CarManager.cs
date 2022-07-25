﻿using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;
        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }
        public void Add(Car car)
        {
            _carDal.Add(car);
        }

        public void Delete(Car car)
        {
            _carDal.Delete(car);
        }

        public List<CarDetailsDto> GetCarDetails()
        {
            return _carDal.GetCarDetails();
        }

        public List<Car> GetCars()
        {
            return _carDal.GetCars();
        }

        public List<Car> GetCarsById(int id)
        {
            return _carDal.GetCars(p => p.CarId == id);
        }

        public void Update(Car car)
        {
            _carDal.Update(car);
        }
    }
}
