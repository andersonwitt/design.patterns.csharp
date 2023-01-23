namespace Singleton
{
    public class Car
    {
        private static Car? instance;
        private Car() { }

        public static Car Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Car();
                }
                return instance;
            }
        }
    }
}