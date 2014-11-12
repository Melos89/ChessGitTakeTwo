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




            List<PieceFactory> WhitePieces = new List<PieceFactory>();//Creates a list for white folk and
            List<PieceFactory> BlackPieces = new List<PieceFactory>();//for the other mongrels
            



            WhitePieces.Add(wp1);//Adds all white pieces to a list.
            WhitePieces.Add(wp2);
            WhitePieces.Add(wp3);
            WhitePieces.Add(wp4);
            WhitePieces.Add(wp5);
            WhitePieces.Add(wp6);
            WhitePieces.Add(wp7);
            WhitePieces.Add(wp8);
            BlackPieces.Add(bp1);//Adds all black pieces to a list.
            BlackPieces.Add(bp2);
            BlackPieces.Add(bp3);
            BlackPieces.Add(bp4);
            BlackPieces.Add(bp5);
            BlackPieces.Add(bp6);
            BlackPieces.Add(bp7);
            BlackPieces.Add(bp8);
            


            lists.White = WhitePieces;
            lists.Black = BlackPieces;
            while (true)
            {
                db.DrawTheBoard(WhitePieces, BlackPieces);
                ml.MoveThisPiece(WhitePieces);
                Console.ReadKey();
                Console.Clear();
                db.DrawTheBoard(WhitePieces, BlackPieces);
                ml.MoveThisPiece(BlackPieces);
                Console.ReadKey();
                Console.Clear();
            }

        }
    }
}
