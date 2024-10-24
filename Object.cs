public class Object2
{
    public static ConsoleKeyInfo input;
    public static bool Knife(){
        //if Position == KnifePosition ([4,0])
        Console.WriteLine("Press I to pick up the Knife.");
        input = Console.ReadKey();
        if(input.Key == System.ConsoleKey.I){
            //Steg 1
            System.Console.WriteLine("You have picked up the knife..");
            return true;
        }
        else
        {
            return false;
        }
    }
    
    //if Position == GunPosition ([2,0])
    public static bool Gun(){
        Console.WriteLine("Press O to pick the Gun.");
        input = Console.ReadKey();
        if(input.Key == System.ConsoleKey.O){
            //Steg 1
            System.Console.WriteLine("You have picked up the gun..");
            return true;
        }
        else
        {
            Console.WriteLine("You did not enter the correct key. Too bad.");
            return false;
        }
    }
    
    //if Position == BazookaPosition ([3,5])
    public static bool Bazooka(){
        Console.WriteLine("Press P to pick up the Bazooka.");
        input = Console.ReadKey();
        if(input.Key == System.ConsoleKey.P){
            //Steg 1
            System.Console.WriteLine("You have picked up the bazooka..");
            return true;
        }
        else
        {
            return false;
        }
    }
}