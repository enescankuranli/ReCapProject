using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemoryCarDal;
using Entities.Concrete;

Rental rental = new Rental() { Id=1,CarId = 3, CustomerId = 1, RentDate = new DateTime(2022, 07, 15), ReturnDate = new DateTime(2022, 07, 22) };
Rental rental1 = new Rental() { Id=2,CarId = 1, CustomerId = 2, RentDate = new DateTime(2022, 07, 18), ReturnDate = new DateTime(2022, 07, 29) };
Rental rental2 = new Rental() { CarId = 2, CustomerId = 3, RentDate = new DateTime(2022, 08, 18), ReturnDate = new DateTime(2022, 08, 30) };
Rental rental3 = new Rental() { Id=4,CarId = 2, CustomerId = 4, RentDate = new DateTime(2022, 08, 18), ReturnDate = new DateTime(2022, 08, 30) };


RentalManager rentalManager = new RentalManager(new EfRentalDal());
Console.WriteLine(rentalManager.Add(rental).Message);

var result = rentalManager.Add(rental);
if (result.Success)
{
    Console.WriteLine(result.Message);
}
else
{
    Console.WriteLine(result.Message);
}
        

//CarDetailsDtoTest();

static void CarDetailsDtoTest()
{
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