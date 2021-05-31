/*Kymishbaeva sofia
 * 220 P 
 * Chess_figure
 */

using System;
using Chess_lib;


namespace chess_figure
{
    class Program
    {
        static void Main(string[] args)
        {
            string pieceCode = Console.ReadLine();
            int x1 = Convert.ToInt32(Console.ReadLine());
            int y1 = Convert.ToInt32(Console.ReadLine());
            int x2 = Convert.ToInt32(Console.ReadLine());
            int y2 = Convert.ToInt32(Console.ReadLine());
            //Figure fig = Fab.Make(pieceCode, x1, y1);
            FigureFab fig = new FigureFab();
            fig.Make(pieceCode, x1, y1) ;
            

            bool isRightMove = false;

            Figure fiG = new Figure(x2, y2);
            isRightMove = fiG.Move(x2, y2);
            Console.WriteLine(isRightMove ? "YES" : "NO");

            Console.ReadKey();
        }
    }
} 
