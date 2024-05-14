namespace CarFactoryLibrary
{
    public static class CarFactory
    {
        public static Car? NewCar(CarTypes carType)
        {
            switch (carType)
            {
                case CarTypes.Toyota:
                    return new Toyota();
                case CarTypes.BMW:
                    return new BMW();
                case CarTypes.Audi:
                    return null;
                default:
                    throw new NotImplementedException();
            }
        }
    }
}
