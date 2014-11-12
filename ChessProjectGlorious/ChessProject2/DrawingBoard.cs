using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessProject2
{
    public class DrawingBoard
    {
        //public string[,] chessboard = new string[8,8];
        public DrawingBoard()
        {
        }
        public void DrawTheBoard(List<PieceFactory> white,List<PieceFactory> black)
        {
            string[,] chessboard = PopulateTheBoard(white,black);
            for (int y = 0; y <= 7; y++)
            {
                for (int x = 0; x <= 7; x++)
			{
                if(chessboard[x,y] == null)
                {
                    Console.Write("  ");
                }

                    Console.Write("" + chessboard[x, y] + "|");
                

			}
                Console.WriteLine("");
            }
        }
        public string[,] PopulateTheBoard(List<PieceFactory> white, List<PieceFactory> black)
        {
            string[,] chessboard = new string[8, 8];
            foreach (var piece in white)
            {
                chessboard[piece.PositionX, piece.PositionY] = piece.Color + piece.Type;
            }
            foreach (var piece in black)
            {
                chessboard[piece.PositionX, piece.PositionY] = piece.Color + piece.Type;
            }
            return chessboard;
        }
        }
    
}
