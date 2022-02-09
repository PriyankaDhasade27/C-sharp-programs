using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Assignment_2.first
{

    public class Run
    {
        public static void RunThis()
        {
            Rectangle objRect = new Rectangle(20, 30);
            Console.WriteLine("RECTANGLE");
            Console.WriteLine("Length of rectangle: {0}, Breadth of rectangle {1}",objRect.Length, objRect.Breadth);
            Console.WriteLine("Perimeter is: {0}", objRect.Perimeter);
            Console.WriteLine("Area is: {0}", objRect.Area());
            Console.WriteLine();

            Square square = new Square(80);
            Console.WriteLine("SQUARE");
            Console.WriteLine("Side of square is: {0}", square.Side);
            Console.WriteLine("Perimeter is: {0}", square.Perimeter);
            Console.WriteLine("Area is: {0}", square.Area());
            Console.WriteLine();

        }
    }

    abstract class GeometricSymbols
    {
        abstract public decimal Perimeter { get; }

        abstract public decimal Area();
    }

    class Triangle : GeometricSymbols
    {
        private int side1,side2,side3;

        public Triangle(int side1, int side2, int side3)
        {
            this.side1 = side1;
            this.side2 = side2;
            this.side3 = side3;
        }

        public override decimal Perimeter
        {
            get
            {
                return this.side1 +this.side2 +this.side3;
            }
        }

        public override decimal Area()
        {
            return 0.00M;
        }
    }

    abstract class Quadrilateral : GeometricSymbols
    {
        protected int side1, side2, side3, side4;

        public override decimal Perimeter
        {
            get
            {
                return this.side1 + this.side2 + this.side3 + this.side4;
            }
        }

        public abstract override decimal Area();
    }

    class Square : Quadrilateral
    {
        public Square(int side)
        {
            base.side1 = base.side2 = base.side3 = base.side4 = side;
        }

        public int Side
        {
            get
            {
                return base.side1;
            }
        }

        public override decimal Area()
        {
            return this.Side * this.Side;
        }
    }

    class Rectangle : Quadrilateral
    {
        public Rectangle(int length, int breadth)
        {
            base.side1 = base.side3 = length;
            base.side2 = base.side4 = breadth;
        }

        public int Length
        {
            get
            {
                return base.side1;
            }
        }

        public int Breadth
        {
            get
            {
                return base.side2;
            }
        }

        public override decimal Area()
        {
            return this.Length *this.Breadth;
        }
    }

}
