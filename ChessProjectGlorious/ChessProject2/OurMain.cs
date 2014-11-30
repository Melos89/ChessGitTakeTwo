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

                Factory go = new Factory();
                PlayerOne B1ll = new PlayerOne(go);
                PlayerTwo Su2an = new PlayerTwo(go);
                while (true)
                {

                string[,] theBoard = B1ll.db.DrawTheBoard(go.Pieces);
                B1ll.ml.MoveThisPiece(B1ll.ml.CheckIfPiecesCanMove(B1ll.MyPieces,theBoard));

                
                Console.ReadKey();
                Console.Clear();
                theBoard = Su2an.db.DrawTheBoard(go.Pieces);
                Su2an.ml.MoveThisPiece(Su2an.ml.CheckIfPiecesCanMove(Su2an.MyPieces,theBoard));

                
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
