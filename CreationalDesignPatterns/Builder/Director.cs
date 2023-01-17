namespace Builder
{
    public class Director
    {
        public void BuildCar(ICarBuilder carBuilder)
        {
            carBuilder.SetBrand("Ford");
            carBuilder.SetModel("Mustang");
            carBuilder.SetColor("Red");
        }
    }
}