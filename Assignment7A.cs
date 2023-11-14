/* 
Class: CSE 1321L 
Section: #03 
Term: Fall 2023
Instructor: John Blake 
Name: Christopher Morrison
Lab#: Assignment7A 
*/

using System;
class SVGRect
{
    private float width;
    private float height;
    private string fill_color;
    private string stroke_color;
    private float stroke_width;
    private float x_offset;
    private float y_offset;

    public SVGRect()
    {
        width=1f; 
        height=1f;
        fill_color="#0000FF";
        stroke_color = "#0F0F0F";
        stroke_width = 1.0f;
        x_offset = 0f;
        y_offset = 0f;
    }
    public SVGRect(float width,float height,string fill,string stroke)
    {
        this.width = width;
        this.height = height;
        fill_color = fill;
        stroke_color = stroke;
        stroke_width = 1.0f;
        x_offset = 0f;
        y_offset = 0f;
    }
    public bool set_dim (float new_width,float new_height)
    {
        if (new_width > 0&&new_height>0) 
        {
            width = new_width;
            height = new_height;
            return true;
        }
        else { return false; }
    }
    public void set_offsets(float x,float y)
    {
        x_offset=x; 
        y_offset=y; 
    }
    public bool set_fill_and_stoke(string fill, string stroke_c, float stroke_w)
    {
        if (stroke_w > 0)
        {
            fill_color = fill;
            stroke_color=stroke_c;
            stroke_width = stroke_w;
            return true;
        }
        else {return false; }
    }
    public void print_XML()
    {
        Console.WriteLine("<?xml version=\"1.0\" encoding=\"UTF-8\"?>");
        Console.WriteLine("<svg");
        Console.WriteLine("    xmlns=\"http://www.w3.org/2000/svg\"");
        Console.WriteLine("    xmlns:svg=\"http://www.w3.org/2000/svg\">");
        Console.WriteLine("   <rect");
        Console.WriteLine("      style=\"fill:"+fill_color+"; stroke:"+stroke_color+"; stroke-width:"+stroke_width+"\"");
        Console.WriteLine("      width=\""+width+"\"");
        Console.WriteLine("      height=\""+height+"\"");
        Console.WriteLine("      x=\""+x_offset+"\"");
        Console.WriteLine("      y=\""+y_offset+"\" />");
        Console.WriteLine("</svg>");
    }
}

class Assignment7A
{

    public static void Main(string[] args)
    {
        Console.WriteLine("[SVG Class]");
        Console.Write("Rectangle width: ");
        float width =float.Parse(Console.ReadLine());
        Console.Write("Rectangle height: ");
        float height =float.Parse(Console.ReadLine());
        Console.Write("Fill color: ");
        string f_color= Console.ReadLine();
        Console.Write("Stroke color: ");
        string s_color= Console.ReadLine();
        SVGRect rect = new SVGRect(width,height,f_color,s_color);
        bool cont = true;
        do
        {
            Console.WriteLine("\nWhat would you like to do?");
            Console.WriteLine("1) Change the Rectangle size");
            Console.WriteLine("2) Update the Fill and Stroke settings");
            Console.WriteLine("3) Move the Rectangle");
            Console.WriteLine("4) Print valid XML");
            Console.WriteLine("5) Quit");
            Console.Write("Option: ");
            int choice =int.Parse(Console.ReadLine());
            Console.WriteLine();

            switch (choice)
            {
                case 1:
                    Console.Write("Enter a width: ");
                    width =float.Parse(Console.ReadLine());
                    Console.Write("Enter a height: ");
                    height =float.Parse(Console.ReadLine());
                    if (rect.set_dim(width, height))
                    {
                        Console.WriteLine("Rectangle updated!");
                    }
                    else
                    {
                        Console.WriteLine("Invalid input – rectangle not changed.");
                    }
                    break;
                case 2:
                    Console.Write("Enter a new fill color: ");
                    f_color = Console.ReadLine();
                    Console.Write("Enter a new stroke color: ");
                    s_color = Console.ReadLine();
                    Console.Write("Enter a new stroke width: ");
                    float s_width= float.Parse(Console.ReadLine());
                    if(rect.set_fill_and_stoke(f_color, s_color, s_width))
                    {
                        Console.WriteLine("Rectangle updated!");
                    }
                    else
                    {
                        Console.WriteLine("Invalid input – rectangle not changed.");
                    }
                    break;
                case 3:
                    Console.Write("Enter a new offset x: ");
                    float x=float.Parse(Console.ReadLine());
                    Console.Write("Enter a new offset y: ");
                    float y=float.Parse(Console.ReadLine());
                    rect.set_offsets(x, y);
                    Console.WriteLine("Rectangle updated!");
                    break;
                case 4:
                    rect.print_XML();
                    break;
                case 5:
                    Console.WriteLine("Closing!");
                    cont= false;
                    break;
                default:
                    Console.WriteLine("Invalid Option");
                    break;

            }
        } while (cont);
        
    }
}
