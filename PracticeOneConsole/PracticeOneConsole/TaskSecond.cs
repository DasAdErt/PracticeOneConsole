using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeOneConsole
{
    internal class TaskSecond
    {
        public void runTaskSecond()
        {
            Console.WriteLine("Введите число: ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите процент числа который хотите посчитать, до 100: ");
            int secondNumber = Convert.ToInt32(Console.ReadLine());

            int percentage = (firstNumber * secondNumber) / 100;

            Console.WriteLine("\nПроцент от числа: " + percentage);
        }
    }
}
