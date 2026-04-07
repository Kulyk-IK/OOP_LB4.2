using System;

namespace OOP_LB4_1
{
    public class Circle : IFigure
    {
        private double _radius;

        public Circle() { }

        public Circle(double radius) { this._radius = radius; }

        public Circle(Circle other) { this._radius = other.Radius; }

        public double Perimeter()
        {
            return 2 * Math.PI * _radius;
        }

        public double Radius { get =>  _radius; set =>  _radius = value; }
    }
}
