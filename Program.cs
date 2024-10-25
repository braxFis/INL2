using System.Drawing;
namespace GruppUppgift2;

class Program
{
    static void Main(string[] args)
    {
        Appearance appearance = new Appearance();
        Help help = new Help();
        Console.WriteLine("""
                          Welcome to the interactive game.
                          Let's get started.
                          Following is an onscreen instruction to take you through
                          the menu items and how to start the game. Press space key to continue.
                          """);

        ConsoleKeyInfo input = Console.ReadKey();
        if (Console.ReadKey(true).Key == ConsoleKey.Spacebar)
        {
            //Keep going to the next menu
            Console.WriteLine("Type 'menu' or 'play'");
            string word = Console.ReadLine();
            var search2 = word.Split(" ");

            if (search2[0] == "menu")
            {
                Console.WriteLine(
                    "Type 'search|help|movement|health|environment|date' to see a list of available commands.");
                var word2 = Console.ReadLine();
                var search3 = word2.Split(" ");
                if (search3[0] == "search")
                {
                    //Display search menu options
                    Console.WriteLine($"{help.SearchHelpPage()}");
                }
                else if (search3[0] == "movement")
                {
                    //Display movement keys
                    help.MovementInformation();
                }
                else if (search3[0] == "health")
                {
                    //Display health information
                    help.HealthInformation();
                }
                else if (search3[0] == "date")
                {
                    help.CheckDateAndTime();
                }
            }
            else if (search2[0] == "play")
            {
                //Start the game.
                Console.WriteLine("Starting the game...please wait..loading..");
                //Load all necessary classes and functions to enable the game
                //You need movement
                while (Console.ReadKey().Key != ConsoleKey.Escape)
                {
                    Movement movement = new Movement();
                }
            }
        }
    }
}