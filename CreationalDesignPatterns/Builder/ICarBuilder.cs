namespace Builder
{
    public interface ICarBuilder
    {
        void SetBrand(string brand);
        void SetModel(string model);
        void SetColor(string color);
        Car GetResult();
    }
}