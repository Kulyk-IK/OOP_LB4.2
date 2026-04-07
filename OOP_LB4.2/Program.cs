using OOP_LB4_1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_LB4._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IFigure[] figures = new IFigure[8];

            // Через конструктор з параметрами
            figures[0] = new Circle(5.0);
            figures[1] = new Rectangle(4.0, 6.0);
            figures[2] = new RightTriangle(3.0, 4.0, 5.0);
            figures[3] = new Trapezoid(3.0, 5.0, 4.0, 4.0);

            // Через конструктор без параметрів + сетери
            figures[4] = new Circle();
            ((Circle)figures[4]).Radius = 7.0;

            figures[5] = new Rectangle();
            ((Rectangle)figures[5]).A = 2.0;
            ((Rectangle)figures[5]).B = 8.0;

            figures[6] = new RightTriangle();
            ((RightTriangle)figures[6]).A = 6.0;
            ((RightTriangle)figures[6]).B = 8.0;
            ((RightTriangle)figures[6]).C = 10.0;

            // Через конструктор копіювання
            figures[7] = new Trapezoid((Trapezoid)figures[3]);

            // Виведення результатів
            string[] names = { "Circle", "Rectangle", "RightTriangle", "Trapezoid",
                               "Circle", "Rectangle", "RightTriangle", "Trapezoid" };

            for (int i = 0; i < figures.Length; i++)
            {
                Console.WriteLine($"{names[i],-15} Perimeter = {figures[i].Perimeter():F2}");
            }
        }
    }
}
