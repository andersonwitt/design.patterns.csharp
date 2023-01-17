namespace Builder
{
    public class CarBuilder : ICarBuilder
    {
        private Car car;

        public CarBuilder()
        {
            car = new Car();
        }

        public void SetBrand(string brand)
        {
            car.Brand = brand;
        }

        public void SetModel(string model)
        {
            car.Model = model;
        }

        public void SetColor(string color)
        {
            car.Color = color;
        }

        public Car GetResult()
        {
            return car;
        }
    }
}