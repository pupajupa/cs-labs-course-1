namespace _253505_Антихович
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isIncorrect;
            do
            {
                isIncorrect = false;
                Console.Write("Введите число: ");
                double num = Convert.ToDouble(Console.ReadLine());
                double res = num % 10;
                if(res == 7)
                {
                    Console.WriteLine("Данное число оканчивается на 7");
                }
                else
                {
                    Console.WriteLine("Данное число не оканчивается на 7");
                }
                Console.Write("1 - Продолжить\n2 - Закончиить\nВаш выбор: ");
                int n = Convert.ToInt32(Console.ReadLine());
                switch (n)
                {
                    case 1:
                        {
                            isIncorrect = true;
                            break;
                        }
                    case 2:
                        {
                            isIncorrect = false;
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Неверное значение!!!");
                            isIncorrect = false;
                            break;
                        }
                }
            } while (isIncorrect);
        }
    }
}