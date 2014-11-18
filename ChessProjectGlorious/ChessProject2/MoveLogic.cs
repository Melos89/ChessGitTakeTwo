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
                        else if (chessboard[piece.PositionX + 1,piece.PositionY + 1] != null || chessboard[piece.PositionX - 1, piece.PositionY + 1] != null)
                        {
                            // Calls another method to add capture moves into another list, might have to seperate conditions.
                        }

                        break;

                    case "W":
                        if (chessboard[piece.PositionX, piece.PositionY - 1] == null)
                        {
                            ThesePiecesCanMove.Add(piece);
                        }
                        else if (chessboard[piece.PositionX + 1,piece.PositionY - 1] != null || chessboard[piece.PositionX - 1, piece.PositionY - 1] != null)
                        {
                            // Calls another method to add capture moves into another list, might have to seperate conditions.
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
            if (Piece.Count != 0)
            {
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
}
