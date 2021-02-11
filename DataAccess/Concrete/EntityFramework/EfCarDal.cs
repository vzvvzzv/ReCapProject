using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, ReCapContext>, ICarDal

    {
        public List<CarDetailsDto> GetCarDetails()
        {
            using (ReCapContext context = new ReCapContext())
            {
                var result = from ca in context.Cars
                             join co in context.Colors
                             on ca.ColorId equals co.ColorId
                             join br in context.Brands
                             on ca.BrandId equals br.BrandId

                             select new CarDetailsDto
                             {
                                 Id = ca.Id,
                                 ColorId = co.ColorId,
                                 BrandId = br.BrandId,
                                 ColorName = co.ColorName,
                                 BrandName = br.BrandName,
                                 ModelYear = ca.ModelYear,
                                 DailyPrice = ca.DailyPrice,
                                 Description = ca.Description



                             };
                return result.ToList();

            }
            {

            }
        }

    }
}
