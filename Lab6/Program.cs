using Lab6.Models;

namespace Lab6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PassengerCar transport = new PassengerCar("BMW", 2008, 220);
            Transport rt = transport;
            transport.StartEngine();
            transport.TurnOnHeadlights();
            double travelTime = transport.CalculateTime(200);
            transport.TurnOffHeadlights();
            transport.StopEngine();
            Truck truck = new Truck("Mersedes-Benz", 1000, 180);
            truck.Load(500);
            truck.StartEngine();
            travelTime = truck.CalculateTime(590);
            truck.StopEngine();
            truck.Unload();
            Motorcycle bike = new Motorcycle("Harley",2,310);
            bike.StartEngine();
            bike.TurnOnHeadlights();
            travelTime = bike.CalculateTime(1000);
            bike.TurnOffHeadlights();
            bike.StopEngine();
            SportCar sportCar = new("Audi R8", 2021, 290, 3.7);
            sportCar.StartEngine();
            sportCar.Accelerate();
            travelTime = sportCar.CalculateTime(378);
            sportCar.StopEngine();
        }
    }
}