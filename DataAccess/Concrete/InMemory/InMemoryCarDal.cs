using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{CarId=1, BrandId=01 , ColorId=1111 , ModelYear=2011 , DailyPrice=800 , Description="BMW" },
                new Car{CarId=2, BrandId=02 , ColorId=2222 , ModelYear=2010 , DailyPrice=850 , Description="Audi" },
                new Car{CarId=3, BrandId=03 , ColorId=3333 , ModelYear=2017 , DailyPrice=900 , Description="Peugeot" },
                new Car{CarId=4, BrandId=04 , ColorId=4444 , ModelYear=2022 , DailyPrice=2500 , Description="BMW"},
                new Car{CarId=5, BrandId=05 , ColorId=5555 , ModelYear=2001 , DailyPrice=250 , Description="Peugeot" },
                new Car{CarId=6, BrandId=06 , ColorId=6666 , ModelYear=2022 , DailyPrice=6500 , Description="Mercedes"},
                new Car{CarId=7, BrandId=07, ColorId=7777 , ModelYear=1970 , DailyPrice=200 , Description="BMW"},
                new Car{CarId=8, BrandId=08 , ColorId=8888 , ModelYear=2022 , DailyPrice=5000 , Description="Tesla"},
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(car => car.CarId == car.CarId);
            _cars.Remove(carToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(int CarId)
        {
            return _cars.Where(car => car.ModelYear == car.ModelYear).ToList();

        }

        public List<CarDetailsDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public List<Car> GetCars()
        {
            return _cars;

        }

        public List<Car> GetCars(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(car => car.CarId == car.CarId);
            carToUpdate.CarId = car.CarId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;

        }
    }
}
