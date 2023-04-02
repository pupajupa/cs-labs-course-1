namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            do
            {
                int x = 10, y = 10, x1 = 5, y1 = 5;
                Console.Write("Введите координаты точки\nВведите x: ");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите y: ");
                int b = Convert.ToInt32(Console.ReadLine());
                if ((a * a + b * b < x * y) && (a * a + b * b > x1 * y1) && (b > 0))
                {
                    Console.WriteLine("Да");
                }
                else if (Math.Abs(a) >= 5 && Math.Abs(a) <= 10 && b == 0)
                {
                    Console.WriteLine("На границе ");
                }
                else if (b > 0 && (a * a + b * b == x * y || a * a + b * b == x1 * y1))
                {
                    Console.WriteLine("На границе ");
                }
                else
                {
                    Console.WriteLine("Нет");
                }
                Console.Write("Хотите продолжить?\n1 - Да\t0 - Нет\nВаш выбор: ");
                int choice = Convert.ToInt32(Console.ReadLine());
                if(choice == 0)
                {
                    Console.WriteLine("Спасибо за внимание!");
                    flag = false;
                }
                else if(choice==1)
                {
                    Console.Clear();
                    flag = true;
                }
            } while (flag);
        }
    }
}