using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
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

        }


        private static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            Console.WriteLine("Brand Ids & Names");
            foreach (var brand in brandManager.GetAll())
            {
                Console.WriteLine(brand.BrandId + "/ " + brand.BrandName);
            }
            Console.WriteLine();
        }
        private static void ColorTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            Console.WriteLine("Color Ids & Names");
            foreach (var color in colorManager.GetAll())
            {
                Console.WriteLine(color.ColorId + "/ " + color.ColorName);
            }
            Console.WriteLine();
        }


        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            Console.WriteLine("Car Details");
            foreach (var car in carManager.GetCarDetails())
            {
                Console.WriteLine($"Car Id:{car.Id} / Brand Id:{car.BrandId} / Brand Name:{car.BrandName} / Color Id:{car.ColorId} / Color Name:{car.ColorName} / Daily Price:{car.DailyPrice}");


            }



        }

    }


}