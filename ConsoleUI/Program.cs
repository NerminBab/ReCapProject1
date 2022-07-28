using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            // Car();


            RentalManager rentalsManager = new RentalManager(new EfRentalDal());
            var result = rentalsManager.Add(new Entities.Concrete.Rental
            {
                Id = 1,
                CarId = 2,
                CustomerId = 3,
                RentDate = DateTime.Now,
            });
            Console.WriteLine(result.Message);
           

        }

        private static void Car()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            var result = carManager.GetCarDetails();
            if (result.Success == true)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine("Kiralanacak Araba: " + car.CarName + car.ColorName +
                        " renginde " + "Markası: " + car.BrandName + "/" + car.DailyPrice);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }

            


        }
    }
}
