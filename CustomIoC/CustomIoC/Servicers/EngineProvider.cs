namespace CustomIoC.Servicers;

public class EngineProvider : IEngineProvider
{
    public void Start()
    {
        Console.WriteLine("The car is ready to go");
    }

    public void Stop()
    {
        Console.WriteLine("The car is ready to stop");
    }
}