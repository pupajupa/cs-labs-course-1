namespace task1;

class Program
{
    static void Main(string[] args)
    {
        double a, b;
        Console.WriteLine("Enter the number a");
        a = InputDouble();
        Console.WriteLine("Enter the number b");
        b = InputDouble();
        if(Mathematic.Func(a)>Mathematic.Func(b))
        {
            Console.WriteLine("The function takes the smallest value at the point = a");
        }
        else if (Mathematic.Func(a) < Mathematic.Func(b))
        {
            Console.WriteLine("The function takes the smallest value at the point = b");
        }
        else
        {
            Console.WriteLine("The values of the functions at the points are");
        }
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