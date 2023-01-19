namespace Prototype
{
    public class CarFactory
    {
        private Dictionary<string, ICar> prototypes;

        public CarFactory()
        {
            prototypes = new Dictionary<string, ICar>();
            prototypes.Add("Model1", new Car { Brand = "Brand1", Model = "Model1", Color = "Red" });
            prototypes.Add("Model2", new Car { Brand = "Brand2", Model = "Model2", Color = "Blue" });
        }

        public ICar GetPrototype(string model)
        {
            return prototypes[model].Clone();
        }
    }
}