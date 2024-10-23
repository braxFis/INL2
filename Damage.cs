public class Damage{

    Enemies enemy = new Enemies();
    public int smallDmg = 1;
    public int mediumDmg = 2;
    public int largeDmg = 3;
    ConsoleKeyInfo input;
    public Damage damage = new Damage();
    public int knifeCount = 0;
    public int gunCount = 0;
    public int bazookaCount = 0;
    public int KnifeDmg(){
        input = Console.ReadKey();
        if(input.Key == ConsoleKey.Enter && Player.Position().ToString() == "{X=5,Y=2}"){
            knifeCount++;
            System.Console.WriteLine("You have injured me. My health is now: " + enemy.health);
            return enemy.health -= smallDmg;
        } else{
            return enemy.health;
        }
    }
    public int GunDmg(){
        input = Console.ReadKey();
        if(input.Key == ConsoleKey.Enter){
            gunCount++;
            System.Console.WriteLine("You have injured me. My health is now: " + enemy.health);
            return enemy.health -= mediumDmg;
        } else{
            return enemy.health;
        }
    }
    public int BazookaDmg(){
        input = Console.ReadKey();
        if(input.Key == ConsoleKey.Enter){
            bazookaCount++;
            System.Console.WriteLine("You have injured me. My health is now: " + enemy.health);
            return enemy.health -= largeDmg;
        } else{
            return enemy.health;
        }
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