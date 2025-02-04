using ApplicationTODOlist;
using System.ComponentModel.Design;
using System.Diagnostics.Tracing;
using System.Dynamic;

class Program
{
    static ItemsTodoList list;
    static ItemsTodoList Itemslist;
    //static ItemsTodoList listCreated;
    static string[] MainMenuOptions = { "View all list(PRIORITY)", "Add list", "View calendar", "Settings" };
    static string[] PrioritiesOptions = { "Important & urgent", "Urgent", "Important", "OK" };
    static string[] PlansOptions = {"Personal", "Work"};
    public static void Main(string[] args)
    {
        list = new ItemsTodoList();
        ShowMainMenu();
        }
    static void ShowMainMenu()
    {
        int input;
        ShowOptions(MainMenuOptions);
        //do
        //{
            
            Console.WriteLine();
            input = ReadInput();
            switch (input)
            {
                case 0:
                    ViewAllListByPriority();
                    break;
                case 1:
                    AddItemsList();
                //list.todolist.Add(new Item(aInput,));
                    break;
                    //case 2:
                    //    ViewCalendar();
                    //    break;
                    //case 3:
                    //    ModifySettings();
                    //    break;
            }

        //} while (true);

    }
    static void ShowOptions(string[] commands)
    {
        for (int i = 0; i < commands.Length; i++)
        {
            Console.WriteLine(i + " : " + commands[i]);
        }
    }
    static int ReadInput()
    {
        int a;

        Console.Write("Select an option:");
        string aInput = Console.ReadLine();
        bool aValid = int.TryParse(aInput, out a);

        while (!aValid)
        {
            Console.WriteLine("You haven't written correctly. Try again!");
            Console.WriteLine("Select an option:");
            aInput = Console.ReadLine();
            aValid = int.TryParse(aInput, out a);
        }
        return a;
    }

    static void ViewAllListByPriority()
    {

    }

    static void AddItemsList()
    {
        Console.Clear();

        Console.Write("Write a description :");
        string aInput = Console.ReadLine();
        //ReadInputForAddedList();
        ChoseAPriorityforyourList();
        ChoseADateforyourList();
        ChoseAPlanForyourList();
       // string listCreated = new Item(aInput);
        //Console.WriteLine(list.todolist[0]);
        //list.todolist.Add(list.todolist[0]);
        Console.WriteLine($"The list {aInput} was created");

    }

    public static void ChoseAPriorityforyourList()
    {
        do
        {
            Console.WriteLine("Choose a priority level :");
            ShowOptions(PrioritiesOptions);
            int input_priority = ReadInput();
            if (input_priority > 3)
            {
                Console.WriteLine("The priority chosen does not exist!!");
                break;
            };
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Priority level chosen : " + PrioritiesOptions[input_priority]);
            Console.ForegroundColor = ConsoleColor.White;
            //list = new Item(PrioritiesOptions[input_priority]);

        } while (!true);
        
    }
    static void ChoseADateforyourList()
    {
        Console.WriteLine();
        Console.WriteLine("Choose a date to finalize the list:");

        Console.Write("Enter year: ");
        int year = int.Parse(Console.ReadLine());
        Console.Write("Enter month (1-12): ");
        int month = int.Parse(Console.ReadLine());
        //string dayOfWeek = Console.ReadLine();
        DisplayCalendar(year, month); //dayOfWeek);
        Console.Write("Enter day : ");
        int day = int.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.WriteLine($"List finalization date :  {day}-{month:D2}-{year}");
    }
    static void DisplayCalendar(int year, int month)
    {
        Console.WriteLine($"\nCalendar for {year}-{month:D2}\n");

        string[] daysOfWeek = { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };
        foreach (string day in daysOfWeek)
        {
            Console.Write(day + "\t");
        }
        Console.WriteLine();

        DateTime firstDayOfMonth = new DateTime(year, month, 1);
        int daysInMonth = DateTime.DaysInMonth(year, month);
        int currentDayOfWeek = (int)firstDayOfMonth.DayOfWeek;

        for (int i = 0; i < currentDayOfWeek; i++)
        {
            Console.Write("\t");
        }

        for (int day = 1; day <= daysInMonth; day++)
        {
            Console.Write(day + "\t");
            currentDayOfWeek++;
            if (currentDayOfWeek > 6)
            {
                currentDayOfWeek = 0;
                Console.WriteLine();
            }
        }
        Console.WriteLine();

    }

    static void ChoseAPlanForyourList()
    {
            Console.WriteLine();
            Console.WriteLine("Chose a plan :");
            ShowOptions(PlansOptions);
            int input_plan = ReadInput();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("The chosen plan is : " + PlansOptions[input_plan]);
            Console.ForegroundColor = ConsoleColor.White;

    }
}
