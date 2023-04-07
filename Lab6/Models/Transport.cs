using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6.Models
{
    //abstract class
    //используется для создания классов-наследников
    public abstract class Transport 
    {
        public abstract double CalculateTime(int distance);
        public virtual void StartEngine() 
        {
            Console.WriteLine("Transport started engine");
        }
        public virtual void StopEngine() 
        {
            Console.WriteLine("Transport stopped engine");
        }
    }
}
