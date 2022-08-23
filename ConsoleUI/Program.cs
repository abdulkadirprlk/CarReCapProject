using Business.Concrete;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car2 = new Car();
            car2.Id = 2;
            car2.BrandId = 2;
            car2.ColorId = 2;
            car2.Description = "4x4";
            car2.DailyPrice = 600;
            car2.ModelYear = 2009;

            InMemoryCarDal inMemoryCarDal = new InMemoryCarDal();
            CarManager carManager = new CarManager(inMemoryCarDal);

            inMemoryCarDal.Add(car2);

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Description);
            }

            inMemoryCarDal.Delete(car2);

            foreach (var car in carManager.GetById(1))
            {
                Console.WriteLine(car.Id);
            }

        }
    }
}