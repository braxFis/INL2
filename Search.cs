using System.Runtime.InteropServices.Marshalling;

public class Search
{
    public void ObjectSearcher(){
        Object2 @object = new Object2();
        Type t = @object.GetType();
        var count = 0;
        Console.WriteLine("You have the following weapons in your inventory");
            foreach(var u in t.GetMethods())
            {
                count++;
                var u1 = u.ToString();
                var u3 = u1.Split(" ");
                if (count <= 3)
                {
                    Console.WriteLine(u3[1]);
                }
            }
        }
        public void EnemySearcher(){
        Enemies @enemy = new Enemies();
        Type t = @enemy.GetType();
        var count = 0;
        Console.WriteLine("You have the following enemies");
            foreach(var u in t.GetMethods())
            {
                count++;
                var u1 = u.ToString();
                var u3 = u1.Split(" ");
                if (count <= 3)
                {
                    Console.WriteLine(u3[1]);
                }
            }
        }

        public void EnvironmentSearcher(){
            
            Environment @environment = new Environment();
            Type t = @environment.GetType();
            var count = 0;
            Console.WriteLine("You have the following rooms");
                foreach(var u in t.GetMethods())
                {
                    count++;
                    var u1 = u.ToString();
                    var u3 = u1.Split(" ");
                    if (count <= 4)
                    {
                        Console.WriteLine(u3[1]);
                    }
                }
            }
        }