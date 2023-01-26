namespace Bridge
{
    public class CombustionCar : IBridge
    {
        public void TurnOn()
        {
            Console.WriteLine("Combustion Car Turned on!");
        }
        public void TurnOff()
        {
            Console.WriteLine("Combustion Car Turned off!");
        }
        public void Accelerate()
        {
            Console.WriteLine("Combustion Car Acelerating...");
        }
    }
}