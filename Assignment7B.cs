/* 
Class: CSE 1321L 
Section: #03 
Term: Fall 2023
Instructor: John Blake 
Name: Christopher Morrison
Lab#: Assignment7B
*/

using System;

class Player
{
    private int width;
    private int height;
    private int depth;
    private int x;
    private int y;
    private int z;

    public Player(int width, int height, int depth,int x,int y,int z)
    {
        this.width = width;
        this.height = height;
        this.depth = depth;
        this.x = x;
        this.y = y;
        this.z = z;
    }
    public int get_width(){return width; }
    public int get_height() { return height; }
    public int get_depth(){return depth;}
    public int get_x(){return x; }
    public int get_y() { return y; }
    public int get_z() { return z;}
    public void move_x(int move)
    {
        x += move;
    }
    public void move_y(int move) {  y += move; }
    public void move_z(int move) {  z += move; }
    public bool did_collide(Player p1, Player p2)
    {
        if () 
        { 
            return true; 
        }
        else 
        {
            return false; 
        }
    }
}
class Assignment7B
{

    public static void Main(string[] args)
    {

    }
}


