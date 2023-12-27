using CustomIoC.Servicers;

namespace CustomIoC.Controllers;


public class CarController
{
    private readonly ICarService _carService;

    public CarController(ICarService carService)
    {
        _carService = carService;
    }
    
    public void MyAction()
    {
        try
        {
            _carService.Drive();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }
}