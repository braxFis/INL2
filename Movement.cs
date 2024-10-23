using System;
using System.Windows;
using System.Drawing;
using System.Reflection;
using System.Numerics;
using System.Reflection.Emit;

public class Movement
{
    //The controlling of the player movement
    private static ConsoleKeyInfo input = Console.ReadKey();

    //The initialized variable to iterate the environment
    Environment environment = new Environment();

    //Move left
    public static Point Left(){
        if(input.Key == System.ConsoleKey.LeftArrow){
            Point currPos = new Point(-1, 0);
            //Vector LeftMove = new Vector(1,0);
            //Move Left
            System.Console.WriteLine("You have taken 1 step to the left");
            return currPos;
        }
        else
        {
            return new Point();
        }
    }

    //Move right
    public void Right(){
        if(input.Key == System.ConsoleKey.RightArrow){
            //Move Right...
            Point currPos = new Point(1, 0);
        }
        System.Console.WriteLine("You have taken 1 step to the right");
    }

    //Move up
    public void Up(){
        if(input.Key == System.ConsoleKey.UpArrow){
            //Move Up
            Point currPos = new Point(0, 1);
            System.Console.WriteLine("You have taken 1 step to the up");
        }
    }

    //Move down
    public void Down(){
        if(input.Key == System.ConsoleKey.DownArrow){
            //Move Down
            Point currPos = new Point(0, -1);
            System.Console.WriteLine("You have taken 1 step downwards");
        }
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