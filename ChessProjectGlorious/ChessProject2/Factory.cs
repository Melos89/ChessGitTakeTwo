using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessProject2
{
    public class Factory
    {
        CollectionOfLists lists = new CollectionOfLists();
        DrawingBoard db = new DrawingBoard();
        MoveLogic ml = new MoveLogic();
        public Factory()
        {
            Pawn wp1 = new Pawn("W", "P",0,6); //Creates Pawns
            Pawn wp2 = new Pawn("W", "P" ,1, 6);
            Pawn wp3 = new Pawn("W", "P",2,6);
            Pawn wp4 = new Pawn("W", "P",3,6);
            Pawn wp5 = new Pawn( "W", "P",4,6);
            Pawn wp6 = new Pawn( "W", "P",5,6);
            Pawn wp7 = new Pawn( "W", "P",6,6);
            Pawn wp8 = new Pawn( "W", "P",7,6);
            Pawn bp1 = new Pawn("B", "P",0,1);
            Pawn bp2 = new Pawn("B", "P",1,1);
            Pawn bp3 = new Pawn("B", "P",2,1);
            Pawn bp4 = new Pawn("B", "P",3,1);
            Pawn bp5 = new Pawn("B", "P",4,1);
            Pawn bp6 = new Pawn("B", "P",5,1);
            Pawn bp7 = new Pawn("B", "P",6,1);
            Pawn bp8 = new Pawn("B", "P",7,1);

           


            List<PieceFactory> Pieces = new List<PieceFactory>();

            



            Pieces.Add(wp1);//Adds all white pieces to a list.
            Pieces.Add(wp2);
            Pieces.Add(wp3);
            Pieces.Add(wp4);
            Pieces.Add(wp5);
            Pieces.Add(wp6);
            Pieces.Add(wp7);
            Pieces.Add(wp8);
            Pieces.Add(bp1);//Adds all black pieces to a list.
            Pieces.Add(bp2);
            Pieces.Add(bp3);
            Pieces.Add(bp4);
            Pieces.Add(bp5);
            Pieces.Add(bp6);
            Pieces.Add(bp7);
            Pieces.Add(bp8);

            PlayerOne B1ll = new PlayerOne(Pieces);
            PlayerTwo Su2an = new PlayerTwo(Pieces);

            List<PieceFactory> AllPieces = B1ll.MyPieces.Concat(Su2an.MyPieces).ToList();
            while (true)
            {
                db.DrawTheBoard(AllPieces);
                B1ll.MyPieces = ml.CheckLists(B1ll.MyPieces);
                ml.MoveThisPiece(B1ll.MyPieces);
                Console.ReadKey();
                Console.Clear();
                db.DrawTheBoard(AllPieces);
                Su2an.MyPieces = ml.CheckLists(Su2an.MyPieces);
                ml.MoveThisPiece(Su2an.MyPieces);
                Console.ReadKey();
                Console.Clear();
            }

        }
    }
}
