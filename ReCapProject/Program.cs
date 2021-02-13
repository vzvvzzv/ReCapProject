using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ReCapProject
{
    class Program
    {
        static void Main(string[] args)
        {

            BrandTest();
            ColorTest();
            CarTest();

            RentalTest();

        }


        private static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            Console.WriteLine("Brand Ids & Names");
            foreach (var brand in brandManager.GetAll().Data)
            {
                Console.WriteLine(brand.BrandId + "/ " + brand.BrandName);
            }
            Console.WriteLine();
        }
        private static void ColorTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            Console.WriteLine("Color Ids & Names");
            foreach (var color in colorManager.GetAll().Data)
            {
                Console.WriteLine(color.ColorId + "/ " + color.ColorName);
            }
            Console.WriteLine();
        }


        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            Console.WriteLine("Car Details");
            foreach (var car in carManager.GetCarDetails().Data)
            {
                Console.WriteLine($"Car Id:{car.Id} / Brand Id:{car.BrandId} / Brand Name:{car.BrandName} / Color Id:{car.ColorId} / Color Name:{car.ColorName} / Daily Price:{car.DailyPrice}");


            }



        }



        private static void RentalTest()
        {
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            Console.WriteLine("Rentals");
            _ = rentalManager.Add(new Rental
            {
                RentalId = 10,
                Id = 2,
                CustomerId = 33,
                RentDate = new DateTime(2021, 01, 28),
                ReturnDate = new DateTime(2021, 02, 04)
            });
            foreach (var rental in rentalManager.GetAll().Data)
            {
                Console.WriteLine(rental.RentalId + "/ " + rental.Id + "/ " + rental.CustomerId + "/ " + rental.RentDate + "/ " + rental.ReturnDate);
            }
            Console.WriteLine();
        }

    }


}