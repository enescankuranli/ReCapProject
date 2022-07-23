using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemoryCarDal;
using Entities.Concrete;

CarManager carManager = new CarManager(new EfCarDal());
var result = carManager.GetCarDetails();
if (result.Success == true)
{
    foreach (var car in result.Data)
    {
        Console.WriteLine(car.CarName + " => " + car.ColorName + " => " + car.BrandName + " => " + car.DailyPrice);
    }
}
    else
    {
        Console.WriteLine(result.Message);
    }

//GetAllTest();


//GetCarDetailsTest(carManager);

//static void AddCarTest(CarManager carManager)
//{
//    Car addCar = new Car
//    {
//        CarId = 5,
//        BrandId = 2,
//        ColorId = 3,
//        DailyPrice = 2000,
//        ModelYear = 2022,
//        Description = "Volvo x90C Mavi araba"
//    };
//    carManager.Add(addCar);
//}

//static void GetCarDetailsTest(CarManager carManager)
//{
//    foreach (var car in carManager.GetCarDetails())
//    {
//        Console.WriteLine("-Araç Id{0} , Araç Markası{1} , Araç Rengi{2} , Araç Model Yılı{3}  ", car.CarId, car.BrandName, car.ColorName, car.ModelYear);
//    }
//    //AddCarTest(carManager);
//}

//static void GetAllTest()
//{
//    CarManager carManager = new CarManager(new EfCarDal());

//    foreach (var car in carManager.GetAll())
//    {
//        Console.WriteLine($"{car.CarName} - {car.ModelYear}");
//    }
//}