using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesCSharp.Shapes
{
    public class Triangle : AbstractRegularPolygon
    {
        public Triangle(int sideLength) : base(3, sideLength)
        {
        }

        public override double GetArea()
        {
            return SideLength * SideLength * Math.Sqrt(3) / 4;
        }
    }
}
