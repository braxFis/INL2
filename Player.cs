using System.Drawing;

public class Player : Movement{
    public int health = 10;
    public int speed;
    public int strength;

    Damage damage = new Damage();
    public int standardHealth(){
        return health;
    }

    //Fast stats
    public void Jake(){
        speed = 10;
        strength = 5;
    }

    //Strong stats
    public void Derek(){
        speed = 5;
        strength = 10;
    }

    //Average stats
    public void Brett(){
        speed = 7;
        strength = 7;
    }

    public void Attack(){
        damage.KnifeDmg();
    }

    public static Point Position()
    {
        Point pos = new Point();
        pos = Movement.Left();
        return pos;
    }
}