namespace Prototype
{
    public class Car : ICar
    {
        public string Brand { get; set; } = "";
        public string Model { get; set; } = "";
        public string Color { get; set; } = "";

        public ICar Clone()
        {
            return (ICar)MemberwiseClone();
        }
    }
}