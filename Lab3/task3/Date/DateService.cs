using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3.Date;

class DateService
{
    static public void GetDate(string date)
    {
        bool isIncorreect;
        do
        {
            DateTime dateTime;
            if (DateTime.TryParse(date, out dateTime))
            {
                isIncorreect = false;
                Console.WriteLine($"Day: {dateTime.DayOfWeek}");
            }
            else
            {
                isIncorreect = true;
                Console.WriteLine("Unable to parse the specified date. Try again...");
                    date = Console.ReadLine();
            }
        } while (isIncorreect);
    }
    static public void GetDaysSpan(int day,int month,int year)
    {
        bool isIncorreect;
        do
        {
            try
            {
                var dayCount = (DateTime.Now - new DateTime(year, month, day)).Days;
                Console.WriteLine($"Days count between two days = {Math.Abs(dayCount)}");
                isIncorreect = false;
            }
            catch (FormatException)
            {
                isIncorreect = true;
                Console.WriteLine("Unable to parse the specified date. Try again...");
            }

        } while (isIncorreect);
    }
    static public int InputInt()
    {
        int a = 0;
        bool isIncorrect;
        do
        {
            isIncorrect = false;
            try
            {
                a = Convert.ToInt32(Console.ReadLine());
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
