
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

     class Rectangle
    {
    private float width;
    private float length;
    public Rectangle(float width, float length)
    {
        this.width = width;
        this.length = length;
    }
    public float CalculateArea()
    {
        return this.length * this.width;
    }
    public void Display() => Console.WriteLine($"The area is {CalculateArea()}");
}

