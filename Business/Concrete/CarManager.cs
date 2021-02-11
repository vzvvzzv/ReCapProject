using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
#pragma warning disable

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
            if (car.DailyPrice > 0 && car.Description.Length >= 2)
            {
                _carDal.Add(car);
                Console.WriteLine("Car has been added successfully.");

            }
            else Console.WriteLine("Please enter a valid daily price.");
        }

        public void Delete(Car car)
        {
            _carDal.Delete(car);
            Console.WriteLine("Car has been deleted.");
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public List<CarDetailsDto> GetCarDetails()
        {
            return _carDal.GetCarDetails();
        }

        public List<Car> GetCarsByBrandId(int brandId)
        {
            return _carDal.GetAll(c => c.BrandId == brandId);
        }

        public List<Car> GetCarsByColorId(int colorId)
        {
            return _carDal.GetAll(c => c.ColorId == colorId);
        }

        public void Update(Car car)
        {
            if (car.DailyPrice > 0 && car.Description.Length >= 2)
            {
                _carDal.Add(car);
                Console.WriteLine("Car has been updated successfully.");

            }
            else Console.WriteLine("Please enter a valid daily price.");
        }
    }
}
