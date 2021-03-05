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
            //UserCustomerTest();
            //RentalTest();

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
                Console.WriteLine($"Car Id:{car.CarId} / Brand Id:{car.BrandId} / Brand Name:{car.BrandName} / Color Id:{car.ColorId} / Color Name:{car.ColorName} / Daily Price:{car.DailyPrice}");


            }



        }

        //private static void UserCustomerTest()
        //{
        //    UserManager userManager = new UserManager(new EfUserDal());
        //    Console.WriteLine("New User Customer");
        //    userManager.Add(new User
        //    {
        //        UserId = 88,
        //        FirstName = "Olivia",
        //        LastName = "Jay",
        //        Email = "o.jay@aol.com",
        //        Password = "45834"
        //    });

        //    foreach (var user in userManager.GetAll().Data)
        //    {
        //        Console.WriteLine($"User Id:{user.UserId} / First Name:{user.FirstName} / Last Name:{user.LastName} / E-mail:{user.Email} / Password:{user.Password}");
        //    }
        //    Console.WriteLine();


        //    CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
        //    customerManager.Add(new Customer
        //    {
        //        CustomerId = 10888,
        //        UserId = userManager.GetUserById(88).Data.UserId,
        //        CompanyName = "BlueJay"
        //    });

        //    foreach (var customer in customerManager.GetAll().Data)
        //    {
        //        Console.WriteLine($"Customer Id:{customer.CustomerId} / User Id:{customer.UserId} / Company Name:{customer.CompanyName}");
        //    }
        //    Console.WriteLine();


        //}

        //private static void RentalTest()
        //{
        //    RentalManager rentalManager = new RentalManager(new EfRentalDal());
        //    Console.WriteLine("Rentals");
        //    _ = rentalManager.Add(new Rental
        //    {
        //        RentalId = 555,
        //        Id = 2,
        //        CustomerId = 10888,
        //        RentDate = new DateTime(2021, 01, 28),
        //        ReturnDate = new DateTime(2021, 02, 04)
        //    });
        //    foreach (var rental in rentalManager.GetAll().Data)
        //    {
        //        Console.WriteLine($"Rental Id:{rental.RentalId} / Id:{rental.Id} / Customer Id:{rental.CustomerId} / Rent Date:{rental.RentDate} / Return Date: {rental.ReturnDate}");
        //    }
        //    Console.WriteLine();
        //}

    }


}