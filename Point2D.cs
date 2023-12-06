using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public struct Point2D
    {
   public  float X;
    public float Y;
    public Point2D(float x, float y)
    {
        this.X = x;
        this.Y = y;
    }
    }

class AnotherClassThatUsesPoint2D
{
    public void CalculateDistance(Point2D p1, Point2D p2)
    {
        float p1XAxis=p1.X;
        float p1YAxis = p1.Y;
        float p2XAxis = p2.X;
        float p2YAxis = p2.Y;
        float equation2= p2XAxis - p1XAxis;
        float equation1 = p2YAxis - p1YAxis;
        double equation = Math.Sqrt((equation2 * equation2) + (equation1 * equation1));
        Console.WriteLine($"The euclidean distance is {equation}");
     }

}

