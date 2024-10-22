using System;
using System.Drawing;
public class Environment{
    public static Point Room1(){
        //Location of Room1
        //while (x || y)
        //{
            Point Room1 = new Point(5, 2);
        //}

        //Point Room2 = new Point(2,1);
        //Objects
        //Health
        //Enemies
        //Location of Fly
        //Point FlyCoords = new Point(4,1);
        return Room1;
    }
    public static Point Room2(int x, int y){
        //Location of Room2
        Point Room2 = new Point(x, y);
        //Objects
        //Health
        //Enemies
        //Location of Spider
        //Point SpiderCoords = new Point(1,3);
        return Room2;
    }
    public static Point Room3(int x, int y){
        //Location of Room 3
        Point Room3 = new Point(x, y);
        //Objects
        //Health
        //Enemies
        //Location of Snake
        // Point SnakeCoords = new Point();
        return Room3;
    }
    public static Point Room4(int x, int y){
        //Location of Room4
        Point Room4 = new Point(x, y);
        //Location of Boss
        // Point BossCoords = new Point();
        return Room4;
    }

}