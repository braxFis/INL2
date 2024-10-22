public class Search{
    public void ObjectSearcher(){
        Object @object = new Object();
        Type t = @object.GetType();
            foreach(var u in t.GetMethods()){
                System.Console.WriteLine(u);
            }
        }
        public void EnemySearcher(){
        Enemies @enemy = new Enemies();
        Type t = @enemy.GetType();
            foreach(var u in t.GetMethods()){
                System.Console.WriteLine(u);
            }
        }

        public void EnvironmentSearcher(){
            Environment @environment = new Environment();
            Type t = @environment.GetType();
                foreach(var u in t.GetMethods()){
                    System.Console.WriteLine(u);
                }
            }
    }