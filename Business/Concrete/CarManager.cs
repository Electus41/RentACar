
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
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

        public void Add(Car car)
        {
            if (car.CarName.Length > 2 && car.DailyPrice > 0)
            {
                _carDal.Add(car);

            }
            else
            { 
                Console.WriteLine("kurallara uyulmadı");

            }
           

           
        }

        public List<Car> GetAll()
        {
            var result= _carDal.GetAll();

            return result;

        }

        public List<Car> GetCarsByColorId(int Id)
        {
            return _carDal.GetAll(c=> c.ColorId == Id);
        }

        

        public void Delete(Car car)
        {
            _carDal.Delete(car);
        }

        public void Update(Car car)
        {
            _carDal.Update(car);
        }

        public List<Car> GetCarsByDailPrice(decimal min, decimal max)
        {
            return _carDal.GetAll(c => c.DailyPrice > 0);
        }

        public Car GetById(int id)
        {
            return _carDal.Get(c => c.Id == id);
        }
    }

}
