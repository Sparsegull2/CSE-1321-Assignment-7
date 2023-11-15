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

    public Player(int width, int height, int depth, int x, int y, int z)
    {
        this.width = width;
        this.height = height;
        this.depth = depth;
        this.x = x;
        this.y = y;
        this.z = z;
    }
    public int get_width() { return width; }
    public int get_height() { return height; }
    public int get_depth() { return depth; }
    public int get_x() { return x; }
    public int get_y() { return y; }
    public int get_z() { return z; }
    public void move_x(int move)
    {
        x += move;
    }
    public void move_y(int move) { y += move; }
    public void move_z(int move) { z += move; }
    public bool did_collide(Player p1, Player p2)
    {
        if (p1.get_x()<(p2.get_width()+p2.get_x())&&
            (p1.get_width()+p1.get_x())>p2.get_x()&&
            p1.get_y()<(p2.get_height()+p2.get_y())&&
            (p1.get_height()+p1.get_y())>p2.get_y()&&
            p1.get_z()<(p2.get_depth()+p2.get_z())&&
            (p1.get_depth()+p1.get_z()>p2.get_z()))
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
    public static void movement(Player p,string dir,int move)
    {
        if (dir == "up")
        {
            p.move_y(move);
        }
        else if(dir == "down")
        {
            move = move * (0 - 1);
            p.move_y(move);
        }
        else if( dir == "left")
        {
            move = move * (0 - 1);
            p.move_x(move);
        }
        else if (dir == "right")
        {
            p.move_x(move);
        }
        else if (dir == "forward")
        {
            p.move_z(move);
        }
        else if (dir == "backward")
        {
            move = move * (0 - 1);
            p.move_z(move);
        }
        else
        {
            Console.WriteLine("Invalid Direction");
        }
    }
    public static void Main(string[] args)
    {
        Console.WriteLine("[3D Collision Tester]\n");
        Console.WriteLine("Create Player 1");
        Console.Write("Enter X position: ");
        int x=int.Parse(Console.ReadLine());
        Console.Write("Enter Y position: ");
        int y=int.Parse(Console.ReadLine());
        Console.Write("Enter Z position: ");
        int z=int.Parse(Console.ReadLine());
        Console.Write("Enter Player Hitbox Width: "); 
        int width=int.Parse(Console.ReadLine());
        Console.Write("Enter Player Hitbox Height: ");
        int height=int.Parse(Console.ReadLine());
        Console.Write("Enter Player Hitbox Depth: ");
        int depth=int.Parse(Console.ReadLine());
        Player player1 = new Player(width, height, depth, x, y, z);
        
        Console.WriteLine("\nCreate Player 2");
        Console.Write("Enter X position: ");
        x = int.Parse(Console.ReadLine());
        Console.Write("Enter Y position: ");
        y = int.Parse(Console.ReadLine());
        Console.Write("Enter Z position: ");
        z = int.Parse(Console.ReadLine());
        Console.Write("Enter Player Hitbox Width: ");
        width = int.Parse(Console.ReadLine());
        Console.Write("Enter Player Hitbox Height: ");
        height = int.Parse(Console.ReadLine());
        Console.Write("Enter Player Hitbox Depth: ");
        depth = int.Parse(Console.ReadLine());
        Player player2=new Player(width,height, depth, x, y, z);
        string dir;
        int move;
        while (player1.did_collide(player1, player2)==false)
        {
            Console.WriteLine("\nPlayer 1 is at ("+player1.get_x()+","+player1.get_y()+","+
                player1.get_z()+") and Player 2 is at ("+player2.get_x()+","+player2.get_y()+","+player2.get_z()+")");
            Console.WriteLine("Which one do you want to move?");
            int choice =int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Which direction should Player 1 move (up, down, left, right, forward, or backward)?");
                    dir=Console.ReadLine();
                    dir = dir.ToLower();
                    Console.WriteLine("How far should Player 1 move?");
                    move = int.Parse(Console.ReadLine());
                    movement(player1,dir,move);
                    break;
                case 2:
                    Console.WriteLine("Which direction should Player 2 move (up, down, left, right, forward, or backward)?");
                    dir = Console.ReadLine();
                    dir = dir.ToLower();
                    Console.WriteLine("How far should Player 2 move?");
                    move = int.Parse(Console.ReadLine());
                    movement(player2 ,dir,move);
                    break;
                default: 
                    Console.WriteLine("Invalid Choice");
                    break;
            }
        }
        Console.WriteLine("\nThey collided!");
    }
}
