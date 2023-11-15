namespace PracticeOneConsole
{
    internal class TaskFour
    {
        public void runTaskFour()
        {
            Console.Write("Введите шестизначное число: ");
            string sixDigitNumber = Console.ReadLine();

            if (sixDigitNumber.Length != 6 || !long.TryParse(sixDigitNumber, out _))
            {
                Console.Write("\n\aОшибка: введенное число не является шестизначным.");
                return;
            }

            Console.Write("Введите какое 1 число хотите поменять: ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите какое 2 число хотите поменять: ");
            int secondNumber = Convert.ToInt32(Console.ReadLine());

            if (firstNumber < 1 || firstNumber > 6 || secondNumber < 1 || secondNumber > 6)
            {
                Console.WriteLine("\n\aОшибка: вы ввели значения больше 6 или меньше 1");
                return;
            }

            char[] numberArray = sixDigitNumber.ToCharArray();

            char temp = numberArray[firstNumber - 1];
            numberArray[firstNumber - 1] = numberArray[secondNumber - 1];
            numberArray[secondNumber - 1] = temp;

            string result = new string(numberArray);
            Console.Write($"\nРезультат обмена: {result}");
        }
    }
}
