using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemoryCarDal
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _car;

        public InMemoryCarDal()
        {
            _car = new List<Car> {
            new Car { CarId = 1, BrandId = 1, ColorId = 1, DailyPrice = 200, ModelYear = 2010, Description = "aile Arabası" },
            new Car { CarId = 2, BrandId = 2, ColorId = 2, DailyPrice = 200, ModelYear = 2010, Description = "Rahat geniş aile Arabası" },
            new Car { CarId = 3, BrandId = 3, ColorId = 1, DailyPrice = 100, ModelYear = 2005, Description = "aile Arabası" },
            new Car { CarId = 4, BrandId = 1, ColorId = 3, DailyPrice = 300, ModelYear = 2020, Description = "4*4 Arabası" }
            };
        }

        public void Add(Car car)
        {
            _car.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete =_car.SingleOrDefault(c=>c.CarId == c.CarId);
            _car.Remove(carToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _car;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<CarDetailsDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public List<Car> GetColorId(int colorId)
        {
            return _car.Where(c => c.ColorId == colorId ).ToList();

        }

        public void Update(Car car)
        {
            Car carToUpdate = _car.SingleOrDefault(c => c.CarId == c.CarId);
            carToUpdate.BrandId= car.BrandId;
            carToUpdate.ColorId= car.ColorId;
            carToUpdate.ModelYear=car.ModelYear;
            carToUpdate.DailyPrice=car.DailyPrice;
            carToUpdate.Description=car.Description;
        }
    }
}
