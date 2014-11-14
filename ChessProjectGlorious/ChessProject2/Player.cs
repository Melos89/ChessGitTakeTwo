using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessProject2
{
    public abstract class Player
    {
        public List<PieceFactory> MyPieces = new List<PieceFactory>();
        public void CheckEnemies(string[,] board)
        {
            foreach (var piece in MyPieces)
            {
                int x = piece.PositionX;
                int y = piece.PositionY;
                if (board[x + 1, y - 1] == "B")
                {

                }
                //board[x,y]
            }
        }


    }
    public class PlayerOne : Player
    {
        public PlayerOne(List<PieceFactory> pieces)
        {
            foreach (var piece in pieces)
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
        public PlayerTwo(List<PieceFactory> pieces)
        {
            foreach (var piece in pieces)
            {
                if (piece.Color == "B")
                {
                    MyPieces.Add(piece);
                }
            }
        }
    }
}

