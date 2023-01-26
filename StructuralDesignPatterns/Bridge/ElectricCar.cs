namespace Bridge
{
    public class ElectricCar : IBridge
    {
        public void TurnOn()
        {
            Console.WriteLine("Electric Car Turned on!");
        }
        public void TurnOff()
        {
            Console.WriteLine("Electric Car Turned off!");
        }
        public void Accelerate()
        {
            Console.WriteLine("Electric Car Acelerating...");
        }
    }
}