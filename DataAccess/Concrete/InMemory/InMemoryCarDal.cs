using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    class InMemoryCarDal : ICarDal
    {

        List <Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car {CarId=1 , BrandId= 2 ,ColorId=12 , DailyPrice=200 ,ModelYear=2, Description="Renoult Kangoo"},
                new Car {CarId=2 , BrandId= 3 ,ColorId=52 , DailyPrice=2540,ModelYear=3, Description="Fiat Egea"},
                new Car {CarId=3 , BrandId= 4 ,ColorId=22 , DailyPrice=4444 ,ModelYear=4, Description="Porsche"},
                new Car {CarId=4 , BrandId= 6 ,ColorId=87, DailyPrice=599,ModelYear=1, Description="BMW"},
                new Car {CarId=5 , BrandId= 7 ,ColorId=93 , DailyPrice=1442 ,ModelYear=9, Description="Ferrari"}

             };
               
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int carId)
        {
              return _cars.Where(c => c.CarId == carId).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpdate.CarId = car.CarId;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }
    }
}
