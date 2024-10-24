public class Damage{
    
    //Instantiate the enemy class
    //And start reducing the health of the enemies
    Enemies enemy = new Enemies();

    //Implement how much damage each attack
    //Gives an enemy
    public int smallDmg = 1;
    public int mediumDmg = 2;
    public int largeDmg = 3;

    //Control the game through the console using the keyboard
    private ConsoleKeyInfo input;
    
    //Start implementing the counting operation for every weapon
    //and how many attacks are made
    public int knifeCount = 0;
    public int gunCount = 0;
    public int bazookaCount = 0;
    
    public int KnifeDmg(){
        Console.WriteLine("Press Enter to issue Knife Damage to Enemy");
        input = Console.ReadKey();
        if (Object2.Knife())
        {
            if (input.Key == ConsoleKey.Enter /*&& Player.Position().ToString() == "{X=5,Y=2}"*/)
            {
                knifeCount++;
                Console.WriteLine(knifeCount);
                System.Console.WriteLine("You have injured me. My health is now: " + enemy.health);
                return enemy.health -= smallDmg;
            }
            else
            {
                return enemy.health;
            }
        }

        return 1;
    }
    public int GunDmg(){
        if (Object2.Gun())
        {
            Console.WriteLine("Press Enter to issue Gun Damage on Enemy.");
            input = Console.ReadKey();
            if (input.Key == ConsoleKey.Enter)
            {
                gunCount++;
                Console.WriteLine($"Current Gun Count : {gunCount}");
                enemy.health -= mediumDmg;
                var newHealth = enemy.health;
                System.Console.WriteLine($"You have injured me. My health is now: {newHealth}");
                return newHealth;
            }
            else
            {
                return enemy.health;
            }
        }

        return 1;
    }
    public int BazookaDmg(){
        if (Object2.Bazooka())
        {
            Console.WriteLine("Press Enter to issue Bazooka Damage on Enemy.");
            input = Console.ReadKey();
            if (input.Key == ConsoleKey.Enter)
            {
                bazookaCount++;
                Console.WriteLine(bazookaCount);
                System.Console.WriteLine("You have injured me. My health is now: " + enemy.health);
                return enemy.health -= largeDmg;
            }
            else
            {
                return enemy.health;
            }
        }

        return 1;
    }

    public int FlyDmg(Player player){
        return player.health -= smallDmg;
    }

    public int SpiderDmg(Player player){
        return player.health -= mediumDmg;
    }

    public int SnakeDmg(Player player){
        return player.health -= largeDmg;
    }

    public int BossDmg(Player player, int value){
        return player.health -= value;
    }
}