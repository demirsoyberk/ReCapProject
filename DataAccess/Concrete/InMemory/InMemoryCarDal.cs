using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>()
            {
                new Car{Id = 1,BrandId = 1,ColorId = 2,DailyPrice =50000,Description = "Fast Car",ModelYear = 2001},
                new Car{Id = 2,BrandId = 1,ColorId = 1,DailyPrice =60000,Description = "Fast Car",ModelYear = 2003},
                new Car{Id = 3,BrandId = 2,ColorId = 2,DailyPrice =70000,Description = "Fast Car",ModelYear = 2007},
                new Car{Id = 4,BrandId = 3,ColorId = 3,DailyPrice =80000,Description = "Fast Car",ModelYear = 2004},
                new Car{Id = 5,BrandId = 2,ColorId = 4,DailyPrice =90000,Description = "Fast Car",ModelYear = 2010},

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

        public List<Car> GetById(int brandId,int colorId)
        {
            return _cars.Where(c => c.BrandId == brandId && c.ColorId==colorId).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);

            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;
        }
    }
}
