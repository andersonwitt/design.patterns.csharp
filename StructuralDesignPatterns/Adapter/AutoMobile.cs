namespace Adapter
{
    public class AutoMobile
    {
        private readonly ICar _car;
        public AutoMobile(ICar car)
        {
            _car = car;
        }

        public void Run()
        {
            _car.StartEngine();
        }
        public void Stop()
        {
            _car.StopEngine();
        }
    }
}