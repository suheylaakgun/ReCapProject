using DataAccess.DTOs;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface ICarDal : IEntityRepository<Car>
    {
        //GetById, GetAll, Add, Update, Delete ; 
        //List<Car> GetAll();
        //Car GetById(int carId);
        //void Add(Car car);
        //void Update(Car car);
        //void Delete(Car car);
        List<CarDetailsDto> GetCarsByBrandId(int brandId);
        List<CarDetailsDto> GetCarsByColorId(int colorId);
    }
}
