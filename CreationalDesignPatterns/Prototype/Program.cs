using Prototype;

CarFactory factory = new CarFactory();
ICar car1 = factory.GetPrototype("Model1");
ICar car2 = factory.GetPrototype("Model2");
ICar car3 = car1.Clone();

Console.WriteLine("Passou");