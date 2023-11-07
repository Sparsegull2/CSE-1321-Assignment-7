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
        Console.WriteLine("      style=\"fill:#0909FF; stroke:#00EE00; stroke-width:8.9\"");
        Console.WriteLine("      width=\"230\"");
        Console.WriteLine("      height=\"390\"");
        Console.WriteLine("      x=\"4\"");
        Console.WriteLine("      y=\"19\" />");
        Console.WriteLine("</svg>");
    }
}

class Assignment7A
{

    public static void Main(string[] args)
    {
        SVGRect rect = new SVGRect();
        rect.print_XML();
    }
}
