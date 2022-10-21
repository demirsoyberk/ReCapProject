using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;

namespace DataAccess.Abstract
{
    //Araba ile ilgili veritabanında yapacağım operasyonları içerir.
    public interface ICarDal
    {
        List<Car> GetAll();
        List<Car> GetById(int brandId,int colorId);
        void Add(Car car);
        void Update(Car car);
        void Delete(Car car);
    }
}
