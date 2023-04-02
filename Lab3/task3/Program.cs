using System.Transactions;
using task3.Date;

namespace task3;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter date:");
        string? date = Console.ReadLine();
        DateService.GetDate(date);
        Console.WriteLine("\nEnter days: ");
        int day = DateService.InputInt();
        Console.WriteLine("Enter month: ");
        int month = DateService.InputInt();
        Console.WriteLine("Enter year: ");
        int year = DateService.InputInt();
        DateService.GetDaysSpan(day, month, year);
    }
}