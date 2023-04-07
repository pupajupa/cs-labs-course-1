using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6.Models
{
    public sealed class SportCar:Transport
    {
        private int speed;
        private string brand;
        private int year;
        private double accelerationTime;
        public SportCar(string brand, int year, int speed, double accelerationTime)
        {
            this.brand = brand;
            this.year = year;
            this.speed = speed;
            this.accelerationTime = accelerationTime;
        }
        public override double CalculateTime(int distance)
        {
            double time = (double)distance / speed;
            Console.WriteLine($"Travel time:{time.ToString("0.00")} hours");
            return time;
        }
        public override void StartEngine()
        {
            Console.WriteLine("Sport car started");
        }
        public override void StopEngine()
        {
            Console.WriteLine("Sport car stopped\n");
        }
        public void Accelerate()
        {
            Console.WriteLine($"Acceleration to 100km/h takes {accelerationTime} seconds");
        }
    }
}
