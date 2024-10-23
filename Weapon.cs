namespace GruppUppgift2;

public class Weapon
{
    //Set ammo level to 5 bullets
    public int ammo = 5;
    ConsoleKeyInfo key;
    public Weapon weapon = new Weapon();
    
    public Object2 object2 = new Object2();
    public Weapon Ammunition()
    {
            if (key.Key == ConsoleKey.T)
            {
                ammo -= 1;
            }

            if (ammo < 1)
            {
                //Disable the shooting mechanism
                return weapon.Reload();                
            }
            else
            {
                return new Weapon();
            }
        return new Weapon();
    }

    public Weapon Reload()
    {
        Console.WriteLine("Reloading...");
        if (key.Key == ConsoleKey.R)
        {
            ammo = 5;
        }

        return this;
    }
}