namespace task1;
internal class Program
{
    static void Main(string[] args)
    {
        SquareEquation eq1 = new(4, 4, 1);

        Console.WriteLine($"Квадратное выражение: \n{eq1}");
        Console.WriteLine($"Коэффициенты квадратного выражения:\na = {eq1[0]} b = {eq1[1]} c = {eq1[2]}");

        eq1.Solution (out double root1, out double root2);

        if (eq1.HasRoots)
            Console.WriteLine($"Корни квадратного уравнения: \n{root1} \n{root2}");
        else Console.WriteLine("Квадратное уравнение не имеет корней");


        SquareEquation eq2 = new(4, 2, 2);

        Console.WriteLine($"\nКвадратное выражение: \n{eq2}");
        Console.WriteLine($"Коэффициенты квадратного выражения:\na = {eq2[0]} b = {eq2[1]} c = {eq2[2]}");

        eq2--;
        eq2 *= 3;
        Console.WriteLine($"Квадратное выражение после изменения: \n{eq2}");
        Console.WriteLine($"Коэффициенты квадратного выражения после измениния: \na = {eq2[0]} b = {eq2[1]} c = {eq2[2]}");
        eq2.Solution(out double root3, out double root4);

        if (eq2.HasRoots)
            Console.WriteLine($"Корни квадратного уравнения: \n{root3} \n{root4}");
        else Console.WriteLine("Квадратное уравнение не имеет корней");

        if (eq1 == eq2)
        {
            Console.WriteLine("Квадратные уравнения равны");
        }
        else Console.WriteLine("Квадратные уравнения не равны");
    }
}