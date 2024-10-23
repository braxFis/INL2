using System.Reflection;
using System.Media;
namespace GruppUppgift2;

class Program
{
    static void Main(string[] args)
    {
        // Player player1 = new Player();
        // Enemies enemies1 = new Enemies();
        // Damage dmg = new Damage();
        // //10 is standard health
        // System.Console.WriteLine(player1.standardHealth());
        // dmg.FlyDmg(player1);
        // System.Console.WriteLine(player1.standardHealth());
        // Health health = new Health();
        // health.Type1(player1);
        // System.Console.WriteLine(player1.standardHealth());
        // Search search = new Search();
        // search.ObjectSearcher();
        // search.EnemySearcher();
        // search.EnvironmentSearcher();
        //
        // //Take the knife object
        // Object item = new Object();
        // item.Knife();
        //
        // //Injure the enemy
        // player1.Attack();
        //
        // Console.WriteLine(Environment.Room1().ToString());
        // Console.WriteLine(Environment.Room2(2, 4).ToString());
        // Console.WriteLine(Environment.Room3(1, 5).ToString());
        // Console.WriteLine(Environment.Room4(2, 7).ToString());
        // Movement movement = new Movement();
        // movement.Left();
        // movement.Left().ToString();
        // Health health = new Health();
        // Console.WriteLine(health.standardHealth(new Player()));
        // Console.WriteLine(health.Type1(player: new Player()));
        // Console.WriteLine(health.Type2(player: new Player()));
        //
        // MethodBase methodBase = MethodBase.GetCurrentMethod();
        // Console.WriteLine("{0}, {1}", methodBase.ReflectedType.Name, methodBase.Name);
        // Movement movement = new Movement();
        // movement.Debug();
        // Search search = new Search();
        // search.EnvironmentSearcher();
        // var search = Help.SearchHelpPage(Help.msg).ToString();
        // var search2 = search.Split(" ");
        // if (search2[1] == "object")
        // {
        //     Search search3 = new Search();
        //     search3.ObjectSearcher();
        // } else if (search2[1] == "enemy")
        // {
        //     Search search3 = new Search();
        //     search3.EnemySearcher();
        // }
        // else if (search2[1] == "environment")
        // {
        //     Search search3 = new Search();
        //     search3.EnvironmentSearcher();
        // }
        // Help help = new Help();
        // help.checkDateAndTime();
        // Object2 object2 = new Object2();
        // var count = 0;
        // //Ask teacher how to count per key press...
        // if (object2.Knife())
        // {
        //     count++;
        //     Console.WriteLine(count);
        // }
        // Console.WriteLine(weapon.ammo);
        // Console.WriteLine(object2.Gun());
        // Object2 object2 = new Object2();
        Weapon weapon = new Weapon();
        weapon.Ammunition();
        Console.WriteLine(weapon.ammo);
    }
}