// Implementing Inheritance in C#

using System;

namespace implementinginheritance
{
    public class Shape
    {
        public double Base;
        public double Height;
        public void ShowDim()
        {
            Console.WriteLine("Base and height are " + Base + " and " + Height);
        }
    }

    public class Triangle : Shape
    {
        public double TriSideA;
        public double TriSideC;
        public double Area()
        {
            return Base * Height / 2;
        }
        public double Perimeter()
        {
            return TriSideA * Base * TriSideC;
        }
    }

    public class RightTriangle : Triangle
    {
        new public double Area()
        {
            return Base * Height / 2;
        }
        new public double Perimeter()
        {
            return ((TriSideA + Base) + Math.Sqrt((TriSideA * TriSideA) + (Base * Base)));
        }
    }

    public abstract class Quadrilateral : Shape
    {
        public double QuadriSideA;
        public double QuadriSideC;
        public double QuadriSideD;

        public abstract double Area();
        public abstract double Perimeter();

    }

    public class Rectangle : Quadrilateral
    {
        public override double Area()
        {
            return (Base * QuadriSideA);
        }

        public override double Perimeter()
        {
            return (2 * (Base + QuadriSideA));
        }
    }

    public class Square : Rectangle
    {
        public override double Area()
        {
            return (Base * Base);
        }

        public override double Perimeter()
        {
            return (4 * Base);
        }
    }

    public class program
    {
        public static void Main()
        {
            Triangle T = new Triangle();
            RightTriangle RT = new RightTriangle();
            Rectangle RECT = new Rectangle();
            Square S = new Square();

            Console.WriteLine("\nInfo for Triangle:");
            Console.WriteLine("------------------");

            T.Base = 4.0;
            T.Height = 5.0;
            T.TriSideA = 3.0;
            T.TriSideC = 5.0;

            Console.WriteLine("=> Area is: " + T.Area());
            Console.WriteLine("=> Perimeter is: " + T.Perimeter());
            Console.WriteLine();

            Console.WriteLine("Info for RightTriangle:");
            Console.WriteLine("-----------------------");

            RT.Base = 4.0;
            RT.Height = 5.0;
            RT.TriSideA = 3.0;

            Console.WriteLine("=> Area is: " + RT.Area());
            Console.WriteLine("=> Perimeter is: " + RT.Perimeter());
            Console.WriteLine();

            Console.WriteLine("Info for Rectangle:");
            Console.WriteLine("-------------------");

            RECT.Base = 4.0;
            RECT.QuadriSideA = 3.0;

            Console.WriteLine("=> Area is: " + RECT.Area());
            Console.WriteLine("=> Perimeter is: " + RECT.Perimeter());
            Console.WriteLine();

            Console.WriteLine("Info for Square:");
            Console.WriteLine("----------------");

            S.Base = 4.0;

            Console.WriteLine("=> Area is: " + S.Area());
            Console.WriteLine("=> Perimeter is: " + S.Perimeter());

        }
    }
}