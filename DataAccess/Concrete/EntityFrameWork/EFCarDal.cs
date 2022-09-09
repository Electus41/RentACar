using Core.DataAccess.EntittyFrameWork;
using DataAccess.Abstract;

using Entities.Concrete;
using Entities.Dto;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFrameWork
{
    public class EFCarDal : EfEntityRepositoryBase<Car, RentACarContext>, ICarDal
    {
        public List<CarDetailsDto> GetCarDetails()
        {
            using (RentACarContext rentACarContext = new RentACarContext())
            {
                var result = from c in rentACarContext.Cars
                             join b in rentACarContext.Brands
                             on c.BrandId equals b.Id
                             join co in rentACarContext.Colors
                             on c.ColorId equals co.ColorId
                             select new CarDetailsDto
                             {

                                 BrandName = b.BrandName,
                                 CarName = c.CarName,
                                 ColorName = co.ColorName,
                                 DailyPrice = c.DailyPrice
                             };
                return result.ToList();
                    
                

            }
        }
    }

}
