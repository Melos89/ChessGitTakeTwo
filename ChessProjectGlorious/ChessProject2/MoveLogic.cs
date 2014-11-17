using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessProject2
{
    public class MoveLogic
    {

        public List<PieceFactory> CheckIfPiecesCanMove(List<PieceFactory> pieces, string[,] chessboard)
        {
            List<PieceFactory> ThesePiecesCanMove = new List<PieceFactory>();
            
            foreach (var piece in pieces)
            {
                switch (piece.Color)
                {
                    case "B":
                        if(chessboard[piece.PositionX,piece.PositionY + 1] == null)
                        {
                            ThesePiecesCanMove.Add(piece);
                        }
                        break;

                    case "W":
                        if (chessboard[piece.PositionX, piece.PositionY - 1] == null)
                        {
                            ThesePiecesCanMove.Add(piece);
                        }
                        break;
                }
            }
            return ThesePiecesCanMove;
        }
        //-----------------------------------------------------------------------------------------------------
        public void MoveThisPiece(List<PieceFactory> Piece)
        {
            Random rnd = new Random();
            int number = rnd.Next(Piece.Count);

            if (Piece[number].Color == "W")
            {

                if (Piece[number].PositionY > 0)
                {
                    Piece[number].PositionY--;
                }


            }
            else if (Piece[number].Color == "B")
            {

                if (Piece[number].PositionY < 7)
                {
                    Piece[number].PositionY++;
                }

            }

        }
       
    }
}
