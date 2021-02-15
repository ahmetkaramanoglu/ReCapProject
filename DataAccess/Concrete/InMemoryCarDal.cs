using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>()
            {
                new Car{Id=1,BrandId=1,ColorId=1,ModelYear="2020",DailyPrice=100,Description="New Car" },
                new Car{Id=2,BrandId=1,ColorId=2,ModelYear="2019",DailyPrice=85,Description="15.000km" },
                new Car{Id=3,BrandId=2,ColorId=3,ModelYear="2006",DailyPrice=40,Description="250.213km" },
                new Car{Id=4,BrandId=2,ColorId=2,ModelYear="2017",DailyPrice=60,Description="25.000km" },
                new Car{Id=5,BrandId=2,ColorId=5,ModelYear="2020",DailyPrice=100,Description="New Car" },
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAllBrandId(int brand)
        {
            return _cars.Where(c => c.BrandId == brand).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }
    }
}
