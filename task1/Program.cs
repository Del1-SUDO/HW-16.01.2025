using System.Drawing;

Rectangle result = new Rectangle();
result.Width = 10;
result.Height = 5;
result.Color = "Red";

int area = result.GetArea();
System.Console.WriteLine("Area of the rectangle: " + area);

int perimeter = result.GetPerimeter();
System.Console.WriteLine("Perimeter of the rectangle: " + perimeter);

class Rectangle{
    public int Width;
    public int Height;
    public string? Color;

    public int GetArea(){
        return Width*Height;
    }

    public int GetPerimeter(){
        return 2*(Width+Height);
    }
}