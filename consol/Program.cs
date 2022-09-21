

using Business.Concrete;
using DataAccess.Concrete.EntityFrameWork;

CarManager carManager = new CarManager(new EFCarDal());

var result = carManager.GetCarsByDailPrice(2,3);

if (result.Success == true)
{
    foreach (var car in result.Data)
    {
        Console.WriteLine(car.Id + "/" + car.Description);
    }
}
else
{
    Console.WriteLine(result.Message);
}