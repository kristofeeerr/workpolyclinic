using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workGrandMouther
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int quantityPeople;
            int fixedTime = 10;
            int minutes = 60;
            
            Console.Write($" Введите количество человек:");
            quantityPeople = Convert.ToInt32( Console.ReadLine());

            int totalMinutes = quantityPeople * fixedTime;
            int hoursBeforeVisit = totalMinutes / minutes;
            int minutesBeforeVisit = totalMinutes % minutes; 

            Console.WriteLine($"Вы отстоите в очереди {hoursBeforeVisit} часа и {minutesBeforeVisit} минут");
        }
    }
}
