using System.Globalization;

public class Help{

    DateTime dateTime = DateTime.Now;
    String[] cultureNames = {"en-US", "en-GB"};

    Health checkHealth2 = new Health();

    Damage dmg = new Damage();

    public static String msg;
    public static string SearchHelpPage(string msg){
        System.Console.WriteLine("Type 'search' to find all available objects");
        System.Console.WriteLine("search enemy|objects|environment");
        return msg = Console.ReadLine();
    }

    public void OpenHelpPage(string msg){
        System.Console.WriteLine("Type 'open' to open current item");
    }

    public void PickUpHelpPage(string msg){
        System.Console.WriteLine("Type 'pickup' to take current item");
    }

    public void SayHelpPage(string msg){
        System.Console.WriteLine("Type 'say' to convey a message to one of the NPC's");
        System.Console.WriteLine("say hi|enter|exit");
    }

    public void checkDateAndTime(){
        ConsoleKeyInfo input;
        input = Console.ReadKey();
        if(input.Key == ConsoleKey.T){
            foreach(var cultureName in cultureNames){
                var culture = new CultureInfo(cultureName);
                System.Console.WriteLine("Local date and time:{0}, {1:G}", dateTime.ToString(culture), dateTime.Kind);
            }
        }
    }
    public void checkHealth(){
        ConsoleKeyInfo input;
        input = Console.ReadKey();
        if(input.Key == ConsoleKey.H){
            System.Console.WriteLine(checkHealth2.standardHealth(new Player()));
        }
    }
    
    public void checkAttacks(){
        ConsoleKeyInfo input;
        input = Console.ReadKey();
        if(input.Key == ConsoleKey.J){
            //Go through all the attacks done
            //Check Knife
            dmg.knifeCount++;
            //Check Gun
            dmg.gunCount++;
            //Check Bazooka
            dmg.bazookaCount++;
        }
    }
}