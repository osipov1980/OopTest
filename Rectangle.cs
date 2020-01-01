using System;
using System.Collections.Generic;
using System.Text;

namespace OopTest
{
    public class Rectangle: Shape
    {
        private readonly float _width;
        private readonly float _height;

        public Rectangle(float width, float height)
        {
            _width = width;
            _height = height;
        }

        public override float Area()
        {
            return _width * _height;
        }

        public override float Circumference()
        {
            return (2 * _width) + (2 * _height);
        }

        public override void PrintParameters()
        {
            Console.WriteLine("Rectangle: width=" + _width.ToString() + ", height =" + _height.ToString());
        }
    }
}
