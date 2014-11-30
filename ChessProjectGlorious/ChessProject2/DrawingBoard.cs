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
        public string[,] DrawTheBoard(List<PieceFactory> pieces)
        {
            string[,] chessboard = PopulateTheBoard(pieces);
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
            return chessboard;
        }
        public string[,] PopulateTheBoard(List<PieceFactory> items)
        {
            //CollectionOfLists lists;
            string[,] chessboard = new string[8, 8];
            foreach (var piece in items)
            {
                chessboard[piece.PositionX, piece.PositionY] = piece.Color + piece.Type;
            }
            return chessboard;
        }
        }
    
}
