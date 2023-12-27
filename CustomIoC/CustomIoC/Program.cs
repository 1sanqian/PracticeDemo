using CustomIoC.Containers;
using CustomIoC.Controllers;
using CustomIoC.Servicers;

public class Program
{
    public static void Main(string[] args)
    {
        var myContainer = new MyContainer();
        
        myContainer.Register<ICarService,CarService>();
        
        var carController = new CarController(myContainer.Resolve<ICarService>());
        
        carController.MyAction();
    }
}