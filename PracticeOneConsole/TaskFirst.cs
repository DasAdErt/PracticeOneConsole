namespace PracticeOneConsole
{
    internal class TaskFirst
    {
        public void runTaskFirst()
        {
            Console.Write("Введите число: ");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number >= 1 && number < 101)
            {
                int multipleOfThree = number % 3;
                int multipleOfFive = number % 5;

                if (multipleOfThree == 0 && multipleOfFive == 0)
                {
                    Console.WriteLine("\nFizz Buzz");
                }
                else if (multipleOfThree == 0)
                {
                    Console.WriteLine("\nFizz");
                }
                else if (multipleOfFive == 0)
                {
                    Console.WriteLine("\nBuzz");
                }
            }
            else
            {
                Console.Error.WriteLine("\a\nОшибка! Значение больше или меньше заданного диапозона!");
            }
        }
    }
}
