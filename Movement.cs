using System;
using System.Windows;
using System.Drawing;
using System.Reflection;
using System.Numerics;
using System.Reflection.Emit;

public class Movement{
    static ConsoleKeyInfo input;
    Environment environment = new Environment();
    
    public static Point Left(){
        input = Console.ReadKey();
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
    public void Right(){
        if(input.Key == System.ConsoleKey.RightArrow){
            //Move Right...
            Point currPos = new Point(1, 0);
        }
        System.Console.WriteLine("You have taken 1 step to the right");
    }
    public void Up(){
        if(input.Key == System.ConsoleKey.UpArrow){
            //Move Up
            Point currPos = new Point(0, 1);
            System.Console.WriteLine("You have taken 1 step to the up");
        }
    }
    public void Down(){
        if(input.Key == System.ConsoleKey.DownArrow){
            //Move Down
            Point currPos = new Point(0, -1);
            System.Console.WriteLine("You have taken 1 step to the down");
        }
    }

    public bool hasMovement()
    {
        return new bool();
    }

    public void Debug()
    {
        MethodBase getMethod = MethodBase.GetMethodFromHandle("Left");
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