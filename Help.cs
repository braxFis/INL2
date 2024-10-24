using System.Globalization;

public class Help{

    DateTime dateTime = DateTime.Now;
    String[] cultureNames = {"en-US", "en-GB"};
    Health checkHealth2 = new Health();
    Damage dmg = new Damage();
    Search search = new Search();
    
    public static String msg;
    public string SearchHelpPage(){
        System.Console.WriteLine("Type 'search' to find all available objects");
        System.Console.WriteLine("search enemy|objects|environment");
        msg = Console.ReadLine();
        var word = msg.Split(" ");
        
        if (word[1] == "objects")
        {
            search.ObjectSearcher();
        } else if (word[1] == "enemy")
        {
            search.EnemySearcher();          
        } else if (word[1] == "environment")
        {
            search.EnvironmentSearcher();
        }
        else
        {
            System.Console.WriteLine("Please enter a valid word");
        }

        return string.Empty;
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
        foreach (var cultureName in cultureNames)
        {
            var culture = new CultureInfo(cultureName);
            System.Console.WriteLine("Local date and time:{0}, {1:G}", dateTime.ToString(culture), dateTime.Kind);
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

    public void MovementInformation()
    {
        Console.WriteLine("""
                          Movement is done by using the following keys.
                          W(UP) A(LEFT) S(DOWN) D(RIGHT)
                          """);
    }

    public void HealthInformation()
    {
        Health health = new Health();
        Damage dmg = new Damage();
        Console.WriteLine("Your health starts with {0}", health.standardHealth(new Player()));
        Console.WriteLine("Your health can be increased by picking up health items scattered out in various Room Locations: {0}, {1}, {2}", health.smallHealth, health.mediumHealth, health.largeHealth);
        Console.WriteLine("Your health can be reduced when the enemy damages you by the following amounts: {0}, {1}, {2}", dmg.smallDmg, dmg.mediumDmg, dmg.largeDmg);
    }
}