using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2.second
{
    class Run
    {
        public static void RunThis()
        {

        }
    }

    interface TheSquare
    {
        decimal Perimeter { get; }
    }

    interface TheRectangle
    {
        decimal Perimeter { get; }
    }

    interface TheTriangle
    {
        decimal Perimeter { get; }
    }

    class GeometricSymbols
        : TheTriangle, TheSquare, TheRectangle
    {

        enum SymbolType
        {
            
            Rectangle,
            Triangle,
            Square,
        }


        private int side1, side2, side3, side4;
        private SymbolType symbolType;

        public GeometricSymbols(int side)
        {
            this.side1 = this.side2 = this.side3 = this.side4 = side;
            this.symbolType = SymbolType.Square;
        }

        public GeometricSymbols(int side1, int side2, int side3)
        {
            this.side1 = side1;
            this.side2 = side2;
            this.side3 = side3;
            this.side4 = -1;
            this.symbolType = SymbolType.Triangle;
        }

        public GeometricSymbols(int length, int breadth)
        {
            this.side1 = this.side3 = length;
            this.symbolType = SymbolType.Rectangle;
        }

        decimal TheTriangle.Perimeter
        {
            get
            {
                return this.side1 + this.side2 + this.side3;
            }
        }

        decimal TheSquare.Perimeter
        {
            get
            {
                return 4 *this.side1;
            }
        }

        decimal TheRectangle.Perimeter
        {
            get
            {
                return 2 *(this.side1 + this.side2);
            }
        }
    }
}
