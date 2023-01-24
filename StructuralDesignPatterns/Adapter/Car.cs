namespace Adapter
{
    public class Car : ICar
    {
        public void StartEngine()
        {
            Console.WriteLine("Car Engine Started!");
        }

        public void StopEngine()
        {
            Console.WriteLine("Car Engine Stopped!");
        }
    }
}