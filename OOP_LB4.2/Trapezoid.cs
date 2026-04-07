using System;

namespace OOP_LB4_1
{
    public class Trapezoid : IFigure
    {
        private double _a;
        private double _b;
        private double _c;
        private double _d;

        public Trapezoid() { }
        public Trapezoid(double a, double b, double c, double d)
        {
            this._a = a;
            this._b = b;
            this._c = c;
            this._d = d;
        }

        public Trapezoid(Trapezoid other)
        {
            this._a = other.A;
            this._b = other.B;
            this._c = other.C;
            this._d = other.D;
        }

        public double Perimeter()
        {
            return _a + _b + _c + _d;
        }

        public double A { get => _a; set => _a = value; }
        public double B { get => _b; set => _b = value; }
        public double C { get => _c; set => _c = value; }
        public double D { get => _d; set => _d = value; }
    }
}
