namespace CustomIoC.Servicers;

public class CarService : ICarService
{
    private  IEngineProvider _engineProvider;

    public CarService()
    {
        _engineProvider = new EngineProvider();
    }

    public CarService(IEngineProvider engineProvider)
    {
        _engineProvider = engineProvider;
    }

    public void Drive()
    {
        if (_engineProvider != null)
        {
            _engineProvider.Start();
            Console.WriteLine("The car is moving.");
            _engineProvider.Stop();
        }
        else
        {
            Console.WriteLine("Engine provider is not initialized.");
        }
    }
}