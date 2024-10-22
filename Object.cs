public class Object{
    ConsoleKeyInfo input;
    public Object(){}
    public void Knife(){
        input = Console.ReadKey();
        if(input.Key == System.ConsoleKey.I){
            //Steg 1
            System.Console.WriteLine("You have picked up the knife..");
        }
    }
    public void Gun(){
        if(input.Key == System.ConsoleKey.O){
            //Steg 1
            System.Console.WriteLine("You have picked up the gun..");
        }
    }
    public void Bazooka(){
        if(input.Key == System.ConsoleKey.P){
            //Steg 1
            System.Console.WriteLine("You have picked up the bazooka..");
        }
    }
}