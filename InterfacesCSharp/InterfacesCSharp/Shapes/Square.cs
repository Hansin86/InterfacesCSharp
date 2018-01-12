using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesCSharp.Shapes
{
    public class Square : ConcreteRegularPolygon
    {
        public Square(int sideLength) : base(4, sideLength)
        {
        }

        public override double GetArea()
        {
            return SideLength * SideLength;
        }
    }
}
