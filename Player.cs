using System.Drawing;

public class Player : Movement{
    public int health = 10;
    
    Movement movement = new Movement();
    Damage damage = new Damage();   
    public int standardHealth(){
        return health;
    }

    public void Attack(){
        damage.KnifeDmg();
    }

    public static Point Position()
    {
        return new Point();
    }
}