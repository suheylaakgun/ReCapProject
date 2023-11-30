using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;

CarManager carManager = new CarManager(new EfCarDal());
BrandManager brandManager = new BrandManager(new EfBrandDal());
ColorManager colorManager = new ColorManager(new EfColorDal());

//************CAR ADD*************************//
//Car audi = new Car { BrandId = 2, ColorId = 3, Name = "Q7", DailyPrice = 3000, Description = "D:Q7" };
//Car mercedes = new Car { BrandId = 1, ColorId = 2, Name = "C200", DailyPrice = 2000, Description = "D:C200" };
//Car peugeot = new Car { BrandId = 3, ColorId = 1, Name = "206", DailyPrice = 500, Description = "D:206" };

//carManager.Add(audi);
//carManager.Add(mercedes);
//carManager.Add(peugeot);

//************CAR DELETE*************************//
//Car audi = new Car { Id = 1003, BrandId = 2, ColorId = 3, Name = "Q7", DailyPrice = 3000, Description = "D:Q7" };
//Car mercedes = new Car { Id = 1004, BrandId = 1, ColorId = 2, Name = "C200", DailyPrice = 2000, Description = "D:C200" };
//Car peugeot = new Car { Id = 1005, BrandId = 3, ColorId = 1, Name = "206", DailyPrice = 500, Description = "D:206" };

//carManager.Delete(audi);
//carManager.Delete(mercedes);
//carManager.Delete(peugeot);

//************CAR UPDATE*************************//
//int carIdToUpdate = 2;

//Car carToUpdate = new Car
//{
//    Id = carIdToUpdate,
//    BrandId = 2,
//    ColorId = 2,
//    Name = "M8",
//    DailyPrice = 4500,
//    ModelYear=1995,
//    Description="D:M8"
//};

//carManager.Update(carToUpdate);


//**********
//using (RentACarContext context = new RentACarContext())
//{
//    int carIdToUpdate = 2; 
//    var carToUpdate = context.Cars.Find(carIdToUpdate);

//    if (carToUpdate != null)
//    {
//        carToUpdate.Id = carIdToUpdate;
//        carToUpdate.Name = "M7";
//        carToUpdate.BrandId = 2;
//        carToUpdate.ColorId = 3;
//        carToUpdate.DailyPrice = 3000;
//        carToUpdate.Description = "BMW is Faster car";
//        carManager.Update(carToUpdate);
//    }
//    else
//    {
//        Console.WriteLine("The match failed!");
//    }
//}

//************CAR GET ALL*************************//
//List<Car> cars = carManager.GetAll();

//foreach (var car in cars)
//{
//    Console.WriteLine(car.Name);
//}

//************CAR GET DETAILS (DTO)*************************//
//foreach (var car in carManager.GetCarsByBrandId(2))
//{
//    Console.WriteLine("araba ismi : " + car.CarName + " *********marka ismi : " + car.BrandName + " ************renk:" + car.ColorName + " ************günlük fiyat:" + car.DailyPrice);
//}

//foreach (var car in carManager.GetCarsByColorId(2))
//{
//    Console.WriteLine(car.CarName);
//}

//ColorAddTest(colorManager);
//ColorDeleteTest(colorManager);
//ColorUpdateTest(colorManager);
//ColorGetAllTest(colorManager);
//GetColorByIdTest(colorManager);

///////////////////////////////////////////////////////////////////

//BrandAddTest(brandManager);
//BrandDeleteTest(brandManager);
//BrandUpdateTest(brandManager);
//BrandGetAllTest(brandManager);
//GetBrandByIdTest(brandManager);


//static void ColorAddTest(ColorManager colorManager)
//{
//    Color color1 = new Color();
//    color1.Name = "Beyaz";
//    colorManager.Add(color1);
//}

//static void ColorDeleteTest(ColorManager colorManager)
//{
//        Color color = new Color();
//        color = colorManager.GetById(4);
//        colorManager.Delete(color);
//}

//static void ColorUpdateTest(ColorManager colorManager)
//{
//    Color color = new Color();
//    color = colorManager.GetById(3);
//    color.Name = "Gri";
//    colorManager.Update(color);
//}
//static void ColorGetAllTest(ColorManager colorManager)
//{
//    foreach (var color in colorManager.GetAll())
//    {
//        Console.WriteLine(color.Name);
//    }
//}

//static void GetColorByIdTest(ColorManager colorManager)
//{
//    Color color = new Color();
//    color = colorManager.GetById(3);
//    Console.WriteLine(color.Name);
//}

//static void BrandAddTest(BrandManager brandManager)
//{
//    Brand brand1 = new Brand();
//    brand1.Name = "Volkswagen";

//    Brand brand2 = new Brand();
//    brand2.Name = "Porsche";

//    brandManager.Add(brand1);
//    brandManager.Add(brand2);
//}
//static void BrandDeleteTest(BrandManager brandManager)
//{
//    Brand brand = new Brand();
//    brand = brandManager.GetById(7);
//    brandManager.Delete(brand);
//}
//static void BrandUpdateTest(BrandManager brandManager)
//{
//    Brand brand = new Brand();
//    brand = brandManager.GetById(6);
//    brand.Name = "Skoda";
//    brandManager.Update(brand);

//}
//static void BrandGetAllTest(BrandManager brandManager)
//{
//    foreach (var brand in brandManager.GetAll())
//    {
//        Console.WriteLine(brand.Name);
//    }
//}

//static void GetBrandByIdTest(BrandManager brandManager)
//{
//    Brand brand = new Brand();
//    brand = brandManager.GetById(6);
//    Console.WriteLine(brand.Name);
//}


Console.WriteLine("ok");
Console.ReadLine();





