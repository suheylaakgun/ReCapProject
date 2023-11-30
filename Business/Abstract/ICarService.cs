using DataAccess.DTOs;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICarService
    {
        List<Car> GetAll();
        List<CarDetailsDto> GetCarsByBrandId(int id);
        List<CarDetailsDto> GetCarsByColorId(int id);
    }
}
