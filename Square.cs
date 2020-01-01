using System;
using System.Collections.Generic;
using System.Text;

namespace OopTest
{
    public class Square: Shape
    {
        private readonly float _width;

        public Square(float width)
        {
            _width = width;
        }

        public override float Area()
        {
            return _width * _width;
        }

        public override float Circumference()
        {
            return (4 * _width);
        }

        public override void PrintParameters()
        {
            Console.WriteLine("Square: width=" + _width.ToString());
        }
    }
}
