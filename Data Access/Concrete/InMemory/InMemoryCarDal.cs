using Core.DataAccess;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{CarId=1,BrandId=1,ColorId=123,DailyPrice=50000,ModelYear=2016,Descriptions="BMW"},
                new Car{CarId=2,BrandId=1,ColorId=456,DailyPrice=40000,ModelYear=2010,Descriptions="TOYOTA"},
                new Car{CarId=3,BrandId=1,ColorId=789,DailyPrice=100000,ModelYear=2013,Descriptions="MERCEDES"},
                new Car{CarId=4,BrandId=1,ColorId=321,DailyPrice=110000,ModelYear=2017,Descriptions="AUDİ"}
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => car.CarId == c.CarId);
            _cars.Remove(carToDelete);
        }

        public List<Car> Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(int Id)
        {
            return _cars.Where(car => car.CarId == Id).ToList();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public List<CarDetailDto> GetCarDetails(Expression<Func<CarDetailDto, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carToDelete.CarId = car.CarId;
            carToDelete.DailyPrice = car.DailyPrice;
            carToDelete.BrandId = car.BrandId;
            carToDelete.ColorId = car.ColorId;
            carToDelete.Descriptions = car.Descriptions;
            carToDelete.ModelYear = car.ModelYear;
        }

        Car IEntityRepository<Car>.Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }
    }
}
