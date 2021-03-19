using Core.DataAccess.EntityFramework;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using DataAccess.Abstract;
namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, ReCapContext>, IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetails()
        {
            using (ReCapContext context = new ReCapContext())
            {
                var result = from c in context.Cars
                             join r in context.Rentals
                             on c.CarId equals r.CarId
                             join br in context.Brands
                             on c.BrandId equals br.BrandId
                             join cu in context.Customers
                             on r.CustomerId equals cu.CustomerId
                             join u in context.Users
                             on cu.Id equals u.Id

                             select new RentalDetailDto
                             {
                                 RentalId = r.RentalId,
                                 CarId = c.CarId,
                                 BrandName = br.BrandName,
                                 FirstName = u.FirstName,
                                 LastName = u.LastName,
                                 CompanyName = cu.CompanyName,
                                 RentDate = r.RentDate,
                                 ReturnDate = r.ReturnDate,


                             };
                return result.ToList();

            }

        }
    }
}
