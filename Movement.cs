using System;
using System.Windows;
using System.Drawing;
using System.Reflection;
using System.Numerics;
using System.Reflection.Emit;

public class Movement
{
    //The controlling of the player movement
    public ConsoleKeyInfo input;
    
    //Starting location of the player
    private Point playerLocation = new Point(0, 0);
    public Movement()
    {
        input = Console.ReadKey(true);
        while (Console.ReadKey().Key != ConsoleKey.Escape)
        {
            if (input.Key == ConsoleKey.UpArrow || input.Key == ConsoleKey.W)
            {
                this.Up();
            }
            else if (input.Key == ConsoleKey.DownArrow || input.Key == ConsoleKey.S)
            {
                this.Down();
            }
            else if (input.Key == ConsoleKey.LeftArrow || input.Key == ConsoleKey.A)
            {
                this.Left();
            }
            else if (input.Key == ConsoleKey.RightArrow || input.Key == ConsoleKey.D)
            {
                this.Right();
            }
            input = Console.ReadKey(true);
        }
    }
    
    //The initialized variable to iterate the environment
    Environment environment = new Environment();

    //Move left
    public Point Left(){
        if (input.Key == System.ConsoleKey.LeftArrow || input.Key == ConsoleKey.A) 
        {
            //Move Left
            playerLocation.X--;
            System.Console.WriteLine("You have taken {0} step to the left and {1} step to the up|down direction",
            playerLocation.X, playerLocation.Y);
            return playerLocation;
        }
        return new Point();
    }

    //Move right
    public Point Right(){
        if(input.Key == System.ConsoleKey.RightArrow || input.Key == ConsoleKey.D){
            //Move Right...
            playerLocation.X++;
            System.Console.WriteLine("You have taken {0} step to the right {1} step up|down direction", playerLocation.X, playerLocation.Y);
        }

        return playerLocation;
    }

    //Move up
    public Point Up(){
        if(input.Key == System.ConsoleKey.UpArrow || input.Key == ConsoleKey.W){
            //Move Up
            playerLocation.Y++;
            System.Console.WriteLine("You have taken {0} steps up and {1} step to the left|right direction", playerLocation.Y, playerLocation.X);
        }

        return playerLocation;
    }

    //Move down
    public Point Down(){
        if(input.Key == System.ConsoleKey.DownArrow || input.Key == ConsoleKey.S){
            //Move Down
            playerLocation.Y--;
            System.Console.WriteLine("You have taken {0} step downwards and {1} step left|right", playerLocation.Y, playerLocation.X);
        }
        return playerLocation;
    }

    public bool hasMovement()
    {
        if (input.Key == System.ConsoleKey.LeftArrow ||
            input.Key == System.ConsoleKey.RightArrow ||
            input.Key == System.ConsoleKey.DownArrow ||
            input.Key == System.ConsoleKey.UpArrow ||
            input.Key == ConsoleKey.W ||
            input.Key == ConsoleKey.A ||
            input.Key == ConsoleKey.S ||
            input.Key == ConsoleKey.D)
        {
            return true;
        }
        return false;
    }

    public void Debug()
    {
        MethodBase getMethod = MethodBase.GetCurrentMethod();
        Console.WriteLine("{0}, {1}", getMethod.ReflectedType.Name, getMethod.Name);
        if (getMethod.Name == "Debug")
        {
            Console.WriteLine("DEBUG");
        }
    }

    public void Debug2()
    {
        
    }
    /*
     *
     * Rotation for later stages...
     * public void Rotate(){
     * Matrix or other rotation function
     * }
     */
}