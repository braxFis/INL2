using System;
using System.Drawing;
public class Environment{
    Health health = new Health();
    public Point Room1(){
        
        //Location of Room1
        Point Room1 = new Point(5, 2);

        //Objects
        Object2.Gun(); //Pick up by pressing O key
        
        //Health
        health.Type1(new Player()); //Pick up by pressing H
        
        //Enemies
        Enemies.Fly();
        
        //Location of Fly
        //Point FlyCoords = new Point(4,1);

        //Return the function value
        return Room1;
    }
    public Point Room2(){
        //Location of Room2
        Point Room2 = new Point(3,0);

        //Objects
        //Health
        //Enemies
        //Location of Spider
        //Point SpiderCoords = new Point(1,3);
        return Room2;
    }
    public Point Room3(){
        //Location of Room 3
        Point Room3 = new Point(0,3);
        //Objects
        //Health
        //Enemies
        //Location of Snake
        // Point SnakeCoords = new Point();
        return Room3;
    }
    public Point Room4(){
        //Location of Room4
        Point Room4 = new Point(1,2);
        
        //Location of Boss
        // Point BossCoords = new Point();
        return Room4;
    }

}