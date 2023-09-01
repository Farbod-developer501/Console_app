
//Mirzaee
using Microsoft.VisualBasic.FileIO;
using System.ComponentModel.Design;

class Program
{
    static void Main(string[] args)
    {
        //disign console
        for (int i = 12; i < 50; i++)
        {
            Console.SetCursorPosition(i, 1);
            Console.WriteLine(" Farbod_mirzaee_console_app ");
            Thread.Sleep(75);
        }
        for (int i = 50; i > 0; i--)
        {
            Console.SetCursorPosition(i, 1);
            Console.Write(" Farbod_mirzaee_console_app ");
            Thread.Sleep(75);
        }

        Console.BackgroundColor = ConsoleColor.Black; Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("Choose your Gender");

        string mustGoToMiliteryService;
        Console.WriteLine("are you female or male? if your male choose false or your female choose true ");
        mustGoToMiliteryService = Console.ReadLine();

        bool mustGoToMiliteryServiceBoolean = Convert.ToBoolean(mustGoToMiliteryService);
        Console.WriteLine("your choose was " + mustGoToMiliteryServiceBoolean);

        bool famale = true;
        bool male = false;

        //if statement name  
        Console.WriteLine("Please enter your name");
        String name = Console.ReadLine();

        const int V = 10;
        if (name.Length > V)
        {
            Console.WriteLine("you can't enter character more than 10 do again ");
            Console.ReadLine();
        }

        else if (name == "")
        {
            Console.WriteLine("you did not enter your name do again ");
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine("Hello " + name);
        }
        //last name
        Console.WriteLine("Please enter your last name");
        String lastname = Console.ReadLine();
        const int G = 20;
        if (lastname.Length > G)
        {
            Console.WriteLine("you can't enter character more than 10");
        }
        else if (name == "")
        {
            Console.WriteLine("you did not enter your last name!");
        }
        else
        {
            Console.WriteLine("ok " + name + " " + lastname);
        }
        Console.WriteLine("Please enter your father name");
        String fathername = Console.ReadLine();

        if (name == "")
        {
            Console.WriteLine("you did not enter your father name!");
        }
        else
        {
            Console.WriteLine("ok");
        }
        //cell phone
        string cellphone;
        Console.WriteLine("Please enter your cell phone ");
        cellphone = Console.ReadLine();
        const int b = 11;
        if (CheckInt(cellphone))
        {
            string result = cellphone.Substring(0, 4);
            Console.WriteLine("4 ragham aval " + result);
        }
        else if (cellphone.Length > b)
        {
            Console.WriteLine("you enter wrong format do it again");
            Console.ReadLine();
            Thanks();
        }
        else
        {
            Thanks();
        }

        //age
        byte age;
        Console.WriteLine("plaese enter your age:");
        age = byte.Parse(Console.ReadLine());

        if (age <= 0)
        {
            Console.WriteLine("your not born yet!");
        }
        else if (age > 100)
        {
            Console.WriteLine("You are too old");
        }
        else
        {
            Console.WriteLine("sale tavolode shoma = ");
            Console.WriteLine(1402 - age);
        }

        int x, y;
        Console.WriteLine("Do you want detail or summury press 1 for detail and 2 for summury");
        int select = Convert.ToInt32(Console.ReadLine());

        if (select == 1)
        {
            Console.WriteLine("here your detailes " + name + " " + lastname + " " + age + fathername + " " + mustGoToMiliteryServiceBoolean);
        }
        else if (select == 2)
        {
            //sorry teacher i didn't catch your mean about summury
            Console.WriteLine("your a good person ");
        }
        else
        {
            Console.WriteLine("you didn't press key");
        }


        Console.ReadKey();
    }
    public static bool CheckInt(string input)
    {
        int temp;
        return int.TryParse(input, out temp);
    }
    static void Thanks()
    {
        Console.WriteLine("Thanks");

    }
}