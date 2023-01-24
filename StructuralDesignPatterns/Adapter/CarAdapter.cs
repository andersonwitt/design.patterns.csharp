namespace Adapter
{
    public class CarAdapter : ICar
    {
        private readonly Car _car;
        public CarAdapter(Car car)
        {
            _car = car;
        }
        public void StartEngine()
        {
            _car.StartEngine();
        }

        public void StopEngine()
        {
            _car.StopEngine();
        }
    }
}