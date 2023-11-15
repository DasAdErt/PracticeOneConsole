namespace PracticeOneConsole
{
    internal class TaskSeven
    {
        public void runTaskSeven()
        {
            Console.Write("Введите первое число: ");
            int numberOne = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите второе число: ");
            int numberTwo = Convert.ToInt32(Console.ReadLine());

            if (numberOne > numberTwo)
            {
                int temp = numberOne;
                numberOne = numberTwo;
                numberTwo = temp;
            }

            Console.WriteLine("\nЧетные числа в диапазоне: ");
            for (int i = numberOne; i <= numberTwo; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}