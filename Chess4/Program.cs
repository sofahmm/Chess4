/*Kymishbaeva sofia
 * 220 P 
 * Chess_figure
 */

using System;

namespace chess_figure
{
    class Program
    {
        static void Main(string[] args)
        {

            string pieceCode = Console.ReadLine();
            Figure fig = new Figure(1, 1);
            bool isRightMove = false;

            switch (pieceCode)
            {
                case "K":
                    King omg = new King(4, 4);
                    isRightMove = omg.Move(5, 5);
                    break;
                case "Q":
                    Queen omg1 = new Queen(1, 1);
                    isRightMove = omg1.Move(2, 2);
                    break;
                case "B":
                    Bishop omg2 = new Bishop(4, 4);
                    isRightMove = omg2.Move(5, 5);
                    break;
                case "N":
                    Knight omg3 = new Knight(1, 1);
                    isRightMove = omg3.Move(8, 8);
                    break;
                case "R":
                    Rook omg4 = new Rook(4, 4);
                    isRightMove = omg4.Move(5, 5);
                    break;

                default:
                    Console.WriteLine("Unknown piece code. Try again.");
                    break;
            }
            Console.WriteLine(isRightMove ? "YES" : "NO");
        }
    }
    class Figure
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
