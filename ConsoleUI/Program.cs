using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemoryCarDal;
using Entities.Concrete;

CarManager carManager = new CarManager(new EfCarDal());
foreach (var car in carManager.GetAll())
{
    Console.WriteLine(car.Description);
}