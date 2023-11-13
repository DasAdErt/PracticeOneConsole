using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeOneConsole
{
    internal class TaskThree
    {
        public void runTaskThree()
        {
            Console.WriteLine("Введите 1 цифру: ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите 2 цифру: ");
            int secondNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите 3 цифру: ");
            int threeNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите 4 цифру: ");
            int fourNumber = Convert.ToInt32(Console.ReadLine());

            int decision = (firstNumber * 1000 + secondNumber * 100 + threeNumber * 10 + fourNumber);
            Console.WriteLine("\aОтвет: " + decision);
        }
    }
}
