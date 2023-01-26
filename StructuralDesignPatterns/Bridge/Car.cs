namespace Bridge
{
    public abstract class Car
    {
        protected IBridge _bridge;

        public Car(IBridge bridge)
        {
            _bridge = bridge;
        }

        public void TurnOn()
        {
            _bridge.TurnOn();
        }

        public void TurnOff()
        {
            _bridge.TurnOff();
        }

        public void Accelerate()
        {
            _bridge.Accelerate();
        }
    }
}