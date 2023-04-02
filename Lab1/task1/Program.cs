namespace _253505_Antikhovithc
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число:");
            double one = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            double two = Convert.ToDouble(Console.ReadLine());
            double c = one / two;
            Console.Write("Частное двух чисел = " + c);
        }
    }
}