using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {

            CarManager carManager = new CarManager(new EfCarDal());

            Car car1 = new Car();
            car1.Id = 1;
            car1.BrandId = 1;
            car1.ModelYear = 2004;
            car1.DailyPrice = 500;
            car1.ColorId = 1;
            car1.Description = "Temiz Araç";

            carManager.Add(car1);

            foreach (var car in carManager.GetCarsByColorId(1))
            {
                Console.WriteLine(car.Description);
            }

            

        }
    }
}