using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using DataAccess.DTOs;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;
        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }
        public Car Get(int id)
        {
            return _carDal.GetById(c => c.Id == id);
        }
        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }
        public void Add(Car car)
        {
            //Araba ismi minimum 2 karakter olmalıdır ve Araba günlük fiyatı 0'dan büyük olmalıdır.
            if (car.Name.Length>=2 && car.DailyPrice>0)
            {
                _carDal.Add(car);
            }
            else
            {
                throw new Exception("Araba ismi minimum 2 karakter olmalıdır ve Araba günlük fiyatı 0'dan büyük olmalıdır.");
            }
        }

        public void Delete(Car car)
        {
            _carDal.Delete(car);
        }

        public void Update(Car car)
        {
            _carDal.Update(car);
        }

        public List<CarDetailsDto> GetCarsByBrandId(int brandId)
        {
            return _carDal.GetCarsByBrandId(brandId);
        }

        public List<CarDetailsDto> GetCarsByColorId(int colorId)
        {
            return _carDal.GetCarsByColorId(colorId);
        }
    }
}
