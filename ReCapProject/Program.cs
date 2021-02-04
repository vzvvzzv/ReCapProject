using Business.Concrete;
using DataAccess.Concrete.InMemory;
using System;

namespace ReCapProject
{
    class Program
    {
        static void Main(string[] args)
        {

            CarManager carManager = new CarManager(new InMemoryCarDal());
            string s = "";

            foreach (var c in carManager.GetAll())
            {
                s += ($"Car Id: {c.Id} \nBrand ID: {c.BrandId} \nColor ID: {c.ColorId} \nModel Year: {c.ModelYear} \nDaily Price: {c.DailyPrice} \nDescription: {c.Description} \n\n");

            }

            Console.WriteLine(s);





        }
    }
}
