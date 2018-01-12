using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesCSharp.Shapes
{
    public class Octagon : IRegularPolygon
    {
        public Octagon(int sideLength)
        {
            NumberOfSides = 8;
            SideLength = sideLength;
        }

        public int NumberOfSides { get; set; }
        public int SideLength { get; set; }

        public double GetArea()
        {
            return NumberOfSides * NumberOfSides;
        }

        public double GetPerimeter()
        {
            return SideLength * SideLength * (2 + 2 * Math.Sqrt(2));
        }
    }
}
