using System;
using System.Collections.Generic;
using System.Text;

namespace OopTest
{
    public class Circle: Shape
    {
        private readonly float _radius;

        public Circle(float radius)
        {
            _radius = radius;
        }

        public override float Area()
        {
            return MathF.PI * MathF.Pow(_radius, 2);
        }

        public override float Circumference()
        {
            return MathF.PI * (_radius * 2);
        }

        public override void PrintParameters()
        {
            Console.WriteLine("Circle: r=" + _radius.ToString());
        }
    }
}
