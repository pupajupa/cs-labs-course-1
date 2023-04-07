using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6.Models
{
    public class PassengerCar : Transport
    {
        private int speed;
        private string brand;
        private int year;

        public PassengerCar(string brand, int year, int speed)
        {
            this.brand = brand;
            this.year = year;
            this.speed = speed;
        }
        public override double CalculateTime(int distance)
        {
            double time = (double)distance / speed;
            Console.WriteLine($"Travel time: {time.ToString("0.00")} hours");
            return time;
        }
        public new void StartEngine()
        {
            Console.WriteLine("Car started");
        }
        public new void StopEngine()
        {
            Console.WriteLine("Car stopped\n");
        }
        public void TurnOnHeadlights()
        {
            Console.WriteLine("Headlights turned on.");
        }

        public void TurnOffHeadlights()
        {
            Console.WriteLine("Headlights turned off.");
        }
    }
}
