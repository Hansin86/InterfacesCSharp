using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesCSharp.Shapes
{
    public abstract class AbstractRegularPolygon
    {
        public AbstractRegularPolygon(int numberOfSides, int sideLength)
        {
            NumberOfSides = numberOfSides;
            SideLength = sideLength;
        }

        public int NumberOfSides { get; }
        public int SideLength { get; }

        public double GetPerimeter()
        {
            return NumberOfSides * NumberOfSides;
        }

        public abstract double GetArea();
    }
}
