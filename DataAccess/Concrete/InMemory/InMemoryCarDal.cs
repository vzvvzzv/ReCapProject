﻿using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Linq.Expressions;
using Entities.DTOs;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        public List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{CarId=1,BrandId=10,ColorId=2523, ModelYear=2021, DailyPrice=120000, Description = "Coupe, 5.2L V10 Gas"},
                new Car{CarId=2,BrandId=11,ColorId=4345, ModelYear=2019, DailyPrice=80000, Description = "SUV, Turbocharged"},
                new Car{CarId=3,BrandId=12,ColorId=8511, ModelYear=2020, DailyPrice=115000, Description = "Sedan, All wheel drive"},
                new Car{CarId=4,BrandId=13,ColorId=1673, ModelYear=2017, DailyPrice=122000, Description = "SUV, Twin turbocharged"},
                new Car{CarId=5,BrandId=14,ColorId=6845, ModelYear=2018, DailyPrice=108000, Description = "Sedan, S Tronic"},
            };

        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId);

            _cars.Remove(carToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Car GetById(int carId)
        {
            return _cars.SingleOrDefault(c => c.CarId == carId);

        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpdate.CarId = car.CarId;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;



        }
    }
}
