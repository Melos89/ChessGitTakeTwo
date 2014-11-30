using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessProject2
{
    public class DrawingBoard
    {
        public DrawingBoard()
        {
        }
        /// <summary>
        /// This method draws the board in the console using two for-loops, one for x coords and one for y. it get the coords by means of
        /// a second method call to get a populated 2d string array
        /// 
        ///before using consoleWrite to print out the values in the arrays coords, unless empty then it prints out two empty spaces.
        ///it also returns the array to the methodcaller.
        /// </summary>
        /// <param name="pieces"></param>
        /// <returns></returns>
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
        /// <summary>
        /// This method takes in the list of all pieces, creates a 2d array then put the pieces in the array via their x and y values then returns the array.
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        public string[,] PopulateTheBoard(List<PieceFactory> items)
        {

            string[,] chessboard = new string[8, 8];
            foreach (var piece in items)
            {
                chessboard[piece.PositionX, piece.PositionY] = piece.Color + piece.Type;
            }
            return chessboard;
        }
        }
    
}
