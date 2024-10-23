public class Object2
{
    public ConsoleKeyInfo input = Console.ReadKey();
    public bool Knife(){
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
    public bool Gun(){
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
    public bool Bazooka(){
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