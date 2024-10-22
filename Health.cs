public class Health{
    public int health = 10;
    public int smallHealth = 1;
    public int mediumHealth = 2;
    public int largeHealth = 3;

    public int standardHealth(Player player)
    {
        return player.health;
    }
    
    //Increases health by 1 bar
    public int Type1(Player player){
        return player.health += smallHealth;
    }

    //Increases health by 2 bars
    public int Type2(Player player){
        return player.health += mediumHealth;
    }

    //Increases health by 3 bars
    public int Type3(Player player){
        return player.health += largeHealth;
    }

    public int FlyHealth(){
        return health = 5;
    }

    public int SpiderHealth(){
        return health = 7;
    }

    public int SnakeHealth(){
        return health = 8;
    }

    public int BossHealth(){
        return health = 9;
    }
}