using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, ReCapProjectContext>, IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetail()
        {
            using (ReCapProjectContext reCapProjectContextDal = new ReCapProjectContext())
            {
                var result = from r in reCapProjectContextDal.Rentals
                             join c in reCapProjectContextDal.Cars on r.CarId equals c.CarId
                             join cu in reCapProjectContextDal.Customers on r.CustomerId equals cu.UserId
                             join u in reCapProjectContextDal.Users on cu.UserId equals u.Id
                             join b in reCapProjectContextDal.Brands on c.BrandId equals b.Id
                             join co in reCapProjectContextDal.Colors on c.ColorId equals co.Id

                             select new RentalDetailDto
                             {
                                 BrandName = b.BrandName,
                                 ColorName = co.ColorName,
                                 CompanyName = cu.CompanyName,
                                 DailyPrice = c.DailyPrice,
                                 Description = c.Description,
                                 Email = u.Email,
                                 FirstName = u.FirstName,
                                 LastName = u.LastName,
                                 ModelYear = c.ModelYear,
                                 RentalId = r.Id,
                                 RentDate = r.RentDate,
                                 ReturnDate = r.ReturnDate,
                                 
                             };
                return result.ToList();
            }

        }
    }
}

