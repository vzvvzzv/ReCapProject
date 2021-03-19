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
    public class EfCustomerDal : EfEntityRepositoryBase<Customer, ReCapContext>, ICustomerDal
    {
        public List<CustomerDetailDto> GetCustomerDetails()
        {
            using (ReCapContext context = new ReCapContext())
            {
                var result = from u in context.Users
                             join c in context.Customers
                             on u.Id equals c.Id

                             select new CustomerDetailDto
                             {
                                 CustomerId = c.CustomerId,
                                 FirstName = u.FirstName,
                                 LastName = u.LastName,
                                 Email = u.Email,
                                 CompanyName = c.CompanyName




                             };
                return result.ToList();

            }
            {

            }
        }
    }
}
