using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessProject2
{
    class OurMain
    {
        static void Main(string[] args)
        {

                Factory go = new Factory(); //Creates an instance of factory where we create our pawns and put them in a list

                PlayerOne B1ll = new PlayerOne(go); //Creates a player called Bill

                PlayerTwo Su2an = new PlayerTwo(go); //Creates a player called Susan


                while (true)//GameLoop, swap true for boolflag when no more pieces can move at some point
                {

                string[,] theBoard = B1ll.db.DrawTheBoard(go.Pieces);//calls on a method to draw the board in the console window and saves it away in theBoard variable.
                B1ll.ml.MoveThisPiece(B1ll.ml.CheckIfPiecesCanMove(B1ll.MyPieces,theBoard)); //Method calling galore, the initial method is to move a piece, 
                    //it gets the result of a method call to see what pieces can move which has Bills pieces and theBoard as inparameters.

                
                Console.ReadKey();
                Console.Clear();


                theBoard = Su2an.db.DrawTheBoard(go.Pieces);//Same as bill but via Su2an instead so the board refreshes after each movement.
                Su2an.ml.MoveThisPiece(Su2an.ml.CheckIfPiecesCanMove(Su2an.MyPieces,theBoard));//Same method calling galore as Bill, but its Su2an instead.

                
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
