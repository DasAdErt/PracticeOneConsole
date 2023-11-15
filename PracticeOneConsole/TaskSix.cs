namespace PracticeOneConsole
{
    internal class TaskSix
    {
        public void runTaskSix()
        {
            Console.Write("Введите температуру: ");
            double temperature = Convert.ToDouble(Console.ReadLine());

            Console.Write("Выберите операцию: \n1) Фаренгейт в Цельсий\n2) Цельсий в Фаренгейт\n\nВаш выбор: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            double result;
            switch (choice)
            {
                case 1:
                    result = fahrenheitToCelsius(temperature);
                    Console.WriteLine($"\nТемпература в Цельсиях: {result:F2}");
                    break;
                case 2:
                    result = celsiusToFahrenheit(temperature);
                    Console.WriteLine($"\nТемпература в Фаренгейтах: {result:F2}");
                    break;
                default:
                    Console.WriteLine("\n\aОшибка!");
                    break;
            }
        }

        static double fahrenheitToCelsius(double fahrenheit)
        {
            return (fahrenheit - 32) * 5 / 9;
        }

        static double celsiusToFahrenheit(double celsius)
        {
            return (celsius * 9 / 5) + 32;
        }
    }
}