using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessProject2
{
    public abstract class Player
    {
        public Factory PieceCreator;//Creates an instance of the factory
        public CollectionOfLists lists = new CollectionOfLists(); //Creates an instance of the CollectionOfLists class (Work in progress)
        public MoveLogic ml = new MoveLogic(); //Creates an instance of the moveLogic
        public DrawingBoard db = new DrawingBoard(); //Creates an instance of the drawingBoard
        public List<PieceFactory> MyPieces = new List<PieceFactory>(); //Creates an instance of a list containing pieces



    }
    public class PlayerOne : Player //Player one, == White
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
    public class PlayerTwo : Player //player two == Black
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

