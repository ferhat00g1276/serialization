using System.Text.Json;

void JsonSerializeMethod()
{
    /*  Car[] cars = {
          new Car{Model="Priora",Marka= "Lada",Year = 2013},
          new Car{Model="2107",Marka= "Lada",Year = 2011},
          new Car{Model="2106",Marka= "Lada",Year = 1999},
      };*/
    new Car { Model = "Priora", Marka = "Lada", Year = 2013 };
    new Car { Model = "2107", Marka = "Lada", Year = 2011 };
    new Car { Model = "2106", Marka = "Lada", Year = 1999 };
    List<Car> cars = new List<Car>();
    foreach (Car car in cars)
    {
        cars.Add(car);
    }
    
    CarGallery carGallery = new CarGallery("carGallery1",cars);

    //Way 1

    JsonSerializerOptions op = new JsonSerializerOptions();
    op.WriteIndented = true;
    Console.WriteLine(JsonSerializer.Serialize(carGallery.Cars,op));
    var jsonStringCars = JsonSerializer.Serialize(carGallery.Cars, op);
    File.WriteAllText("cars.json", jsonStringCars);

    //Way 2
    //var jsonString = JsonConvert.SerializeObject(cars,Newtonsoft.Json.Formatting.Indented);
    //File.WriteAllText("carNewtonSoftJson.json", jsonString);


}

void JsonDesiriazlizeMethod()
{
    Car[] cars = null;

    //Way1

    using FileStream fs = new FileStream("cars.json", FileMode.Open);
    cars = System.Text.Json.JsonSerializer.Deserialize<Car[]>(fs);


    //Way2

    //var stringData = File.ReadAllText("carNewtonSoftJson.json");
    //cars = JsonConvert.DeserializeObject<Car[]>(stringData);


    foreach (var car in cars)
    {
        Console.WriteLine(car);
    }

}JsonSerializeMethod();

JsonDesiriazlizeMethod();