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
                B1ll.db.PopulateTheBoard(go.Pieces);
                B1ll.db.DrawTheBoard(go.Pieces);
                B1ll.ml.MoveThisPiece(B1ll.ml.CheckIfPiecesCanMove(B1ll.PieceCreator.Pieces,B1ll.db.PopulateTheBoard(B1ll.PieceCreator.Pieces)));
                //Check points value on board();
                //Choose piece to move();
                
                Console.ReadKey();
                Console.Clear();
                Su2an.db.PopulateTheBoard(go.Pieces);
                Su2an.db.DrawTheBoard(go.Pieces);
                Su2an.ml.MoveThisPiece(Su2an.ml.CheckIfPiecesCanMove(Su2an.PieceCreator.Pieces,Su2an.db.PopulateTheBoard(Su2an.PieceCreator.Pieces)));
                //Check points value on board();
                //Choose piece to move();
                
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
