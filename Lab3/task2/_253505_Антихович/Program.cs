using _253505_Антихович.Services;
namespace _253505_Антихович;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter number z:");
        double z = InputDouble();
        double result = Mathematic.Func(z);
        Console.WriteLine("Result = " + result);
    }
    static double InputDouble()
    {
        double a = 0.0;
        bool isIncorrect;
        do
        {
            isIncorrect = false;
            try
            {
                a = Convert.ToDouble(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Incorrect input. Try again..");
                isIncorrect = true;
            }
        } while (isIncorrect); 
        return a;
    }
}