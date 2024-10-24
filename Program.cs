using System.Drawing;
using System.Reflection;
using System.Media;
namespace GruppUppgift2;

class Program
{
    static void Main(string[] args)
    {
        // Help help = new Help();
        // Console.WriteLine("""
        //                   Welcome to the interactive game.
        //                   Let's get started.
        //                   Following is an onscreen instruction to take you through
        //                   the menu items and how to start the game. Press space key to continue.
        //                   """);
        //
        // ConsoleKeyInfo input = Console.ReadKey();
        // if (Console.ReadKey(true).Key == ConsoleKey.Spacebar)
        // {
        //     //Keep going to the next menu
        //     Console.WriteLine("Type 'menu' or 'play'");
        //     string word = Console.ReadLine();
        //     var search2 = word.Split(" ");
        //
        //     if (search2[0] == "menu")
        //     {
        //         Console.WriteLine("Type 'search|help|movement|health|environment|date' to see a list of available commands.");
        //         var word2 = Console.ReadLine();
        //         var search3 = word2.Split(" ");
        //         if (search3[0] == "search")
        //         {
        //             //Display search menu options
        //             Console.WriteLine($"{help.SearchHelpPage()}");
        //         } else if (search3[0] == "movement")
        //         {
        //             //Display movement keys
        //             help.MovementInformation();
        //         } else if (search3[0] == "health")
        //         {
        //             //Display health information
        //             help.HealthInformation();
        //         } else if (search3[0] == "date")
        //         {
        //             help.checkDateAndTime();
        //         }
        //     } else if (search2[0] == "play")
        //     {
        //         //Start the game.
        //         Console.WriteLine("Starting the game...please wait..loading..");
        //         //Load all necessary classes and functions to enable the game
        //         //You need movement
        //         while (Console.ReadKey().Key != ConsoleKey.Escape)
        //         {
        //             Movement movement = new Movement();
        //         }
        //
        //         //You need player
        //         //You need weapons and objects to interact with
        //     }
        Point p1 = new Point(5, 2);
        Point p2 = new Point(3, 5);
        ConsoleKeyInfo input = Console.ReadKey();
        while (Console.ReadKey().Key != ConsoleKey.Escape)
        {
            if (input.Key == ConsoleKey.UpArrow)
            {
                p1.Y++;
                Console.WriteLine($"Y value: {p1.Y}");
            } else if (input.Key == ConsoleKey.DownArrow)
            {
                p1.Y--;
                Console.WriteLine($"Y value: {p1.Y}");
            } else if (input.Key == ConsoleKey.LeftArrow)
            {
                p1.X--;
                Console.WriteLine($"X value: {p1.X}");
            } else if (input.Key == ConsoleKey.RightArrow)
            {
                p1.X++;
                Console.WriteLine($"X value: {p1.X}");
            }
            input = Console.ReadKey();
        }
        Console.WriteLine($"{p1.X}, {p1.Y}");
        // Size Point2 = new Size(100, 100);
        // Point p3 = Point.Add(p1, Point2);
        // Console.WriteLine(p3.ToString());
    }
}