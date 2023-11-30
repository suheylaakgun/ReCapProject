using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.DTOs;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, RentACarContext>, ICarDal
    {
        List<CarDetailsDto> ICarDal.GetCarsByBrandId(int brandId)
        {
            using (RentACarContext context = new RentACarContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands on c.BrandId equals b.Id
                             join co in context.Colors on c.ColorId equals co.Id
                             where c.BrandId == brandId
                             select new CarDetailsDto
                             {
                                 Id = c.Id,
                                 BrandId = c.BrandId,
                                 ColorId = c.ColorId,
                                 CarName = c.Name,
                                 BrandName = b.Name,
                                 ColorName = co.Name,
                                 DailyPrice = c.DailyPrice
                             };
                return result.ToList();
            }
        }

        List<CarDetailsDto> ICarDal.GetCarsByColorId(int colorId)
        {
            using (RentACarContext context = new RentACarContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands on c.BrandId equals b.Id
                             join co in context.Colors on c.ColorId equals co.Id
                             where c.ColorId == colorId
                             select new CarDetailsDto
                             {
                                 Id = c.Id,
                                 BrandId = c.BrandId,
                                 ColorId = c.ColorId,
                                 CarName = c.Name,
                                 BrandName = b.Name,
                                 ColorName = co.Name,
                                 DailyPrice = c.DailyPrice
                             };
                return result.ToList();
            }
        }
    }
}
