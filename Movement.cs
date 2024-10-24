using System;
using System.Windows;
using System.Drawing;
using System.Reflection;
using System.Numerics;
using System.Reflection.Emit;

public class Movement
{
    //The controlling of the player movement

    public static ConsoleKeyInfo input;
    public Movement()
    {
        input = Console.ReadKey(true);
        if (input.Key == ConsoleKey.UpArrow || input.Key == ConsoleKey.W)
        {
            this.Up();
        } else if(input.Key == ConsoleKey.DownArrow || input.Key == ConsoleKey.S)
        {
            this.Down();
        } else if (input.Key == ConsoleKey.LeftArrow || input.Key == ConsoleKey.A)
        {
            this.Left();
        } else if (input.Key == ConsoleKey.RightArrow || input.Key == ConsoleKey.D)
        {
            this.Right();
        }
    }
    
    //The initialized variable to iterate the environment
    Environment environment = new Environment();

    //Move left
    public Point Left(){
        if(input.Key == System.ConsoleKey.LeftArrow || input.Key == ConsoleKey.A){
            Point currPos = new Point(-1, 0);
            //Vector LeftMove = new Vector(1,0);
            //Move Left
            System.Console.WriteLine("You have taken {0} step to the left and {1} step to the up|down direction", currPos.X, currPos.Y);
            return currPos;
        }
        else
        {
            return new Point();
        }
    }

    //Move right
    public void Right(){
        if(input.Key == System.ConsoleKey.RightArrow || input.Key == ConsoleKey.D){
            //Move Right...
            Point currPos = new Point(1, 0);
            System.Console.WriteLine("You have taken {0} step to the right", currPos);
        }
    }

    //Move up
    public void Up(){
        if(input.Key == System.ConsoleKey.UpArrow || input.Key == ConsoleKey.W){
            //Move Up
            Point currPos = new Point(0, 1);
            System.Console.WriteLine("You have taken {0} steps to the up", currPos);
        }
    }

    //Move down
    public void Down(){
        if(input.Key == System.ConsoleKey.DownArrow || input.Key == ConsoleKey.S){
            //Move Down
            Point currPos = new Point(0, -1);
            System.Console.WriteLine("You have taken {0} step downwards", currPos);
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