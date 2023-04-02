using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _253505_Антихович.Services;

class Mathematic
{
    public static double Func(double z)
    {
        double y = 0.0;
        if (z < 1)
        {
            Console.WriteLine("Branch Number = 1 (z<1)");
            double x = z * z * z + 0.2;
            
        }
        else
        {
            Console.WriteLine("Branch Number = 2 (z>=1)");
            double x = z + Math.Log(z);
           
        } 
        
        y = Math.Cos(Math.Cos(Math.Cos(x * x))) + Math.Sin(Math.Sin(x * x * x));
            return y;
    }
}
