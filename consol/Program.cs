using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFrameWork;
using Entities.Concrete;


//CarManager carManager = new CarManager( new EFCarDal());

//Car car = new Car() { Id = 10, CarName = "Ahmet", ModelYearId = 2, ColorId = 3, BrandId = 1, DailyPrice = 100, Description = "hatalı"  };
//Car car1 = new Car() { Id = 10, CarName = "Mustafa", ModelYearId = 2, ColorId = 3, BrandId = 1, DailyPrice = 100, Description = "hatalı" };
//carManager.Add(car);
////carManager.Update(car1);
////carManager.Delete(car);

//foreach (var item in carManager.GetAll())
//{
//    Console.WriteLine(item.CarName);
//}

//Console.WriteLine("*************");

//Console.WriteLine(carManager.GetById(2).Description);





BrandManager brandManager = new BrandManager(new EFBrandDal());

Brand brand = new Brand() { Id = 9, BrandName = "UçAR" };

brandManager.Add(brand);




