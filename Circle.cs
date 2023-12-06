using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Circle : Shape
    {
    public override int CalculateArea(int r)
    {
        return (22 / 7) *(r * r);
    }
}

