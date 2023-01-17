using Builder;

var director = new Director();
var carBuilder = new CarBuilder();
director.BuildCar(carBuilder);
var car = carBuilder.GetResult();
Console.WriteLine("Brand: " + car.Brand);
Console.WriteLine("Model: " + car.Model);
Console.WriteLine("Color: " + car.Color);
