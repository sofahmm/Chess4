using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess_lib
{
    public class Figure
    {
        protected int x1;
        protected int y1;

        public Figure(int newX, int newY)
        {
            x1 = newX;
            y1 = newY;
        }

        public virtual bool Move(int newX, int newY)
        {

            return false;
        }
    }

    class Rook : Figure
    {
        public Rook(int x1, int y1) : base(x1, y1)
        {
        }

        public override bool Move(int x2, int y2)
        {
            return (x1 == x2 || y1 == y2);
        }
    }
    class King : Figure
    {
        public King(int x1, int y1) : base(x1, y1)
        {
        }

        public override bool Move(int x2, int y2)
        {
            return (Math.Abs(x1 - x2) <= 1 && Math.Abs(y1 - y2) <= 1);
        }
    }
    class Queen : Figure
    {
        public Queen(int x1, int y1) : base(x1, y1)
        {
        }
        public override bool Move(int x2, int y2)
        {
            return (x1 == x2 || y1 == y2 ||
                 Math.Abs(x1 - x2) == Math.Abs(y1 - y2));
        }
    }
    class Bishop : Figure
    {
        public Bishop(int x1, int y1) : base(x1, y1)
        {
        }
        public override bool Move(int x2, int y2)
        {
            return (Math.Abs(x1 - x2) == Math.Abs(y1 - y2));
        }
    }
    class Knight : Figure
    {
        public Knight(int x1, int y1) : base(x1, y1)
        {
        }
        public override bool Move(int x2, int y2)
        {
            return ((Math.Abs(x1 - x2) == 2 && Math.Abs(y1 - y2) == 1) ||
            (Math.Abs(x1 - x2) == 1 && Math.Abs(y1 - y2) == 2));
        }
    }
}
