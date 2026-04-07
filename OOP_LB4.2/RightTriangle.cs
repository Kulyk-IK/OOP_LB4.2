using System;

namespace OOP_LB4_1
{
    public class RightTriangle : IFigure
    {
        private double _a;
        private double _b;
        private double _c;

        public RightTriangle() { }

        public RightTriangle(double a, double b)
        {
            this._a = a; 
            this._b = b;
        }

        public RightTriangle(double a, double b, double c)
        {
            this._a = a;
            this._b = b;
            this._c = c; 

        }

        public RightTriangle(RightTriangle other)
        {
            this._a = other.A; 
            this._b = other.B; 
            this._c = other.C;
        }

        public double Perimeter()
        {
            return this._a + this._b + this._c;
        }

        public double A { get => _a; set => _a = value; }
        public double B { get => _b; set => _b = value; }
        public double C{ get => _c; set => _c = value; }
    }
}
