public class Object2
{
    public static ConsoleKeyInfo input = Console.ReadKey();
    public static bool Knife(){
        //if Position == KnifePosition ([4,0])
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
        if(input.Key == System.ConsoleKey.O){
            //Steg 1
            System.Console.WriteLine("You have picked up the gun..");
            return true;
        }
        else
        {
            return false;
        }
    }
    
    //if Position == BazookaPosition ([3,5])
    public static bool Bazooka(){
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