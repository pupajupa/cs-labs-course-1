using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6.Models
{
    public class Truck : Transport
    {
        private int carryingCapacity;
        private int speed;
        private string brand;

        public Truck(string brand, int carryingCapacity, int speed)
        {
            this.brand = brand;
            this.carryingCapacity = carryingCapacity;
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
            Console.WriteLine("Truck started");
        }
        public override void StopEngine()
        {
            Console.WriteLine("Truck stopped");
        }
        public void Load(int weight)
        {
            Console.WriteLine($"Loaded {weight} kg");
        }
        public void Unload()
        {   
            Console.WriteLine("Unloaded\n");
        }
    }
}
