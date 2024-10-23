namespace GruppUppgift2;

public class Weapon
{
    //Set ammo level to 5 bullets
    public int ammo = 5;
    ConsoleKeyInfo key;
    
    public Weapon Ammunition()
    {
            if (key.Key == ConsoleKey.T)
            {
                ammo -= 1;
            }

            if (ammo < 1)
            {
                //Disable the shooting mechanism
                return this.Reload();                
            }
            else
            {
                return this;
            }

            return this;
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