using System;
using System.Collections.Generic;
using System.Text;

namespace CCA.CarLib
{
    public class CarRepository
    {
        private static List<Car> _carList = new List<Car>();
        private static int _nextId = 1;

        public List<Car> GetList()
        {
            return _carList;
        }

        public Car GetCarById(int id)
        {
            return _carList.Find(c => c.Id == id);
        }

        public void AddCar(Car newCar)
        {
            newCar.Id = _nextId++;
            _carList.Add(newCar);
        }
    }
}
