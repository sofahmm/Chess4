using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess_lib
{
     public class FigureFab
    {
        protected  string pieceCode;
        protected  int x1;
        protected  int y1;
        public Figure Make(string pieceCode, int x1, int y1)
        {
            

            Figure fig = null;
            switch (pieceCode)
            {
                case "K":
                    fig = new King(x1, y1);
                    break;
                case "Q":
                    fig = new Queen(x1, y1);
                    break;
                case "B":
                    fig = new Bishop(x1, y1);
                    break;
                case "N":
                    fig = new Knight(x1, y1);
                    break;
                case "R":
                    fig = new Rook(x1, y1);
                    break;

                default:
                    Console.WriteLine("Unknown piece code. Try again.");
                    fig = null;
                    break;
            }
            return fig;
        }
    }   
}
