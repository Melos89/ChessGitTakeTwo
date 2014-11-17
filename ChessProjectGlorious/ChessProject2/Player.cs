using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessProject2
{
    public abstract class Player
    {
        public Factory PieceCreator;
        public CollectionOfLists lists = new CollectionOfLists();
        public MoveLogic ml = new MoveLogic();
        public DrawingBoard db = new DrawingBoard();
        public List<PieceFactory> MyPieces = new List<PieceFactory>();



    }
    public class PlayerOne : Player
    {
        public PlayerOne(Factory WorkPlace)
        {
            PieceCreator = WorkPlace;
            foreach (var piece in PieceCreator.Pieces)
            {
                if (piece.Color == "W")
                {
                    MyPieces.Add(piece);
                }
            }
        }
    }
    public class PlayerTwo : Player
    {
        public PlayerTwo(Factory WorkPlace)
        {
            PieceCreator = WorkPlace;
            foreach (var piece in PieceCreator.Pieces)
            {
                if (piece.Color == "B")
                {
                    MyPieces.Add(piece);
                }
            }
        }
    }
}

