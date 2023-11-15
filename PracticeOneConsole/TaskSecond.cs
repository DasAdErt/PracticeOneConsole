namespace PracticeOneConsole
{
    internal class TaskSecond
    {
        public void runTaskSecond()
        {
            Console.Write("Введите число: ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите процент числа который хотите посчитать, до 100: ");
            int secondNumber = Convert.ToInt32(Console.ReadLine());

            int percentage = (firstNumber * secondNumber) / 100;

            Console.WriteLine("\nПроцент от числа: " + percentage);
        }
    }
}
