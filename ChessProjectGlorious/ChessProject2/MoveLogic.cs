using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessProject2
{
    public class MoveLogic
    {
        /// <summary>
        /// Method that takes in a list of pieces along with the board in the shape of a 2d Array.
        /// it currently checks the pawns coords values and if there is space infront of the pawns.
        /// If there is they get put in a list called ThesePiecesCanMove, then this list is returned to the method caller.
        /// </summary>
        /// <param name="pieces"></param>
        /// <param name="chessboard"></param>
        /// <returns></returns>
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
        /// <summary>
        /// This method just simply moves the pawns one up or down, as long as the value is within given parameters and if the list given is more then 0.
        /// </summary>
        /// <param name="Piece"></param>
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
