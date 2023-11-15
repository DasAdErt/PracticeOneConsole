using System.Globalization;

namespace PracticeOneConsole
{
    internal class TaskFive
    {
        public void runTaskFive()
        {
            Console.Write("Введите дату в формате dd.MM.yyyy: ");
            string input = Console.ReadLine();

            DateTime date;
            if (!DateTime.TryParseExact(input, "dd.MM.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out date))
            {
                Console.WriteLine("\n\aОшибка! Введенная дата имеет неверный формат");
                return;
            }

            string season = TaskFive.season(date);
            string dayOfWeek = date.ToString("dddd", new CultureInfo("ru-RU"));

            Console.WriteLine($"{season} , {dayOfWeek}");
        }

        static string season(DateTime date)
        {
            int month = date.Month;
            if (month == 12 || month == 1 || month == 2) return "Зима";
            if (month == 3 || month == 4 || month == 5) return "Весна";
            if (month == 6 || month == 7 || month == 8) return "Лето";
            return "Осень";
        }
    }
}