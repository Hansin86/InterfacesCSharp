using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesCSharp.Shapes
{
    public class ConcreteRegularPolygon
    {
        public int NumberOfSides { get; }
        public int SideLength { get; }

        public ConcreteRegularPolygon(int numberOfSides, int sideLength)
        {
            NumberOfSides = numberOfSides;
            SideLength = sideLength;
        }

        public double GetPerimeter()
        {
            return NumberOfSides * NumberOfSides;
        }

        public virtual double GetArea()
        {
            throw new NotImplementedException();
        }
    }
}
