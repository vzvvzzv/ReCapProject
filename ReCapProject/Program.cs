using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using System;


namespace ReCapProject
{
    class Program
    {
        static void Main(string[] args)
        {

            CarManager carManager = new CarManager(new EfCarDal());


            string s = "";

            foreach (var c in carManager.GetAll())
            {
                s += ($"Car Id: {c.Id} \nBrand ID: {c.BrandId} \nColor ID: {c.ColorId} \nModel Year: {c.ModelYear} \nDaily Price: {c.DailyPrice} \nDescription: {c.Description} \n\n");

            }

            Console.WriteLine(s);


            Console.WriteLine("\nCars with brand id 1: ");
            foreach (var c in carManager.GetCarsByBrandId(1))
            {

                Console.WriteLine("Car Id: " + c.Id);

            }

            Console.WriteLine("\nCars with color id 2: ");
            foreach (var c in carManager.GetCarsByColorId(2))
            {
                Console.WriteLine("Car Id: " + c.Id);

            }




        }
    }
}
