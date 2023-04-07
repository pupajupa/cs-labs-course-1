using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6.Models
{
    public class Motorcycle : Transport
    {
        private int speed;
        private string brand;
        private int numberOfWheels;
        public Motorcycle(string brand, int numberOfWheels, int speed)
        {
            this.brand = brand;
            this.numberOfWheels = numberOfWheels;
            this.speed = speed;
        }
        public override double CalculateTime(int distance)
        {
            double time = (double)distance / speed;
            Console.WriteLine($"Travel time: {time.ToString("0.00")} hours");
            return time;
        }
        public override void StartEngine()
        {
            Console.WriteLine("Motorcycle started");
        }
        public override void StopEngine()
        {
            Console.WriteLine("Motorcycle stopped\n");
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
