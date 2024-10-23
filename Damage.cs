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
    private ConsoleKeyInfo input = Console.ReadKey();
    
    //Start implementing the counting operation for every weapon
    //and how many attacks are made
    public int knifeCount = 0;
    public int gunCount = 0;
    public int bazookaCount = 0;
    
    public int KnifeDmg(){
        if (Object2.Knife())
        {
            if (input.Key == ConsoleKey.Enter /*&& Player.Position().ToString() == "{X=5,Y=2}"*/)
            {
                knifeCount++;
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
            if (input.Key == ConsoleKey.Enter)
            {
                gunCount++;
                System.Console.WriteLine("You have injured me. My health is now: " + enemy.health);
                return enemy.health -= mediumDmg;
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
            if (input.Key == ConsoleKey.Enter)
            {
                bazookaCount++;
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