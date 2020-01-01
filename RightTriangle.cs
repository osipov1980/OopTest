using System;
using System.Collections.Generic;
using System.Text;

namespace OopTest
{
    public class RightTriangle: Shape
    {
        private readonly float _width;
        private readonly float _height;

        public RightTriangle(float width, float height)
        {
            _width = width;
            _height = height;
        }

        public override float Area()
        {
            return (_width * _height) / 2;
        }

        public override float Circumference()
        {
            return _height + _width + MathF.Sqrt(_width*_width + _height*_height);
        }

        public override void PrintParameters()
        {
            Console.WriteLine("RightTriangle: width=" + _width.ToString() + ", height =" + _height.ToString());
        }
    }
}
