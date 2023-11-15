using PracticeOneConsole;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Выберите задание (1-7): ");
        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                TaskFirst taskFirst = new TaskFirst();
                taskFirst.runTaskFirst();
                break;
            case 2:
                TaskSecond taskSecond = new TaskSecond();
                taskSecond.runTaskSecond();
                break;
            case 3:
                TaskThree taskThree = new TaskThree();
                taskThree.runTaskThree();
                break;
            case 4:
                TaskFour taskFour = new TaskFour();
                taskFour.runTaskFour();
                break;
            case 5:
                TaskFive taskFive = new TaskFive();
                taskFive.runTaskFive();
                break;
            case 6:
                TaskSix taskSix = new TaskSix();
                taskSix.runTaskSix();
                break;
            case 7:
                TaskSeven taskSeven = new TaskSeven();
                taskSeven.runTaskSeven();
                break;
            default:
                Console.WriteLine("Ошибка! Нет такого задания!");
                break;
        }
    }
}