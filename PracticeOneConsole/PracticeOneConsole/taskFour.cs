using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeOneConsole
{
    internal class taskFour
    {
        public void runTaskFour()
        {
            Console.WriteLine("Введите 6-ти значное число: ");
            int sixDigitNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите число которое хотите поменять: ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите второе число которое хотите поменять: ");
            int secondNumber = Convert.ToInt32(Console.ReadLine());
        }
    }
}
