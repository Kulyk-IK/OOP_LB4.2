using System;

namespace OOP_LB4_1
{
    public class Rectangle : IFigure
    {
        private double _a;
        private double _b;

        public Rectangle() { }
        public Rectangle(double a, double b)
        {
            this._a = a;
            this._b = b;
        }

        public Rectangle(Rectangle other)
        {
            this._a = other.A;
            this._b = other.B;
        }

        public double Perimeter()
        {
            return _a * 2  + _b * 2;
        }

        public double A { get => _a; set => _a = value; }
        public double B { get => _b; set => _b = value; }
    }
}
