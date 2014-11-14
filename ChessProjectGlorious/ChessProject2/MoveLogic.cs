using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessProject2
{
    class MoveLogic
    {
        //public List<PieceFactory> CheckLists(List<PieceFactory> pieces)
        //{
        //    List<PieceFactory> PiecesThatCanMove = new List<PieceFactory>();


        //    foreach (var item in pieces)//Foreach start
        //    {
        //        int x = item.PositionX;
        //        int y = item.PositionY;

        //        foreach (var piece in pieces)
        //        {
        //            if (item.Color == "W")
        //            {
        //                if (piece.PositionX == x + 1 && piece.PositionY == y - 1 || piece.PositionX == x - 1 && piece.PositionY == y - 1)
        //                {
        //                    if (piece.Color == "B")
        //                    {
        //                        //PiecesThatCanMove.Add(item);

        //                    }
        //                }
        //                else if (piece.PositionX == x && piece.PositionY == y - 1)
        //                {

        //                }
        //                else
        //                {
        //                    PiecesThatCanMove.Add(item);
        //                }
        //            }
        //            ////----------------------------------------------------------------------  End of checking movement for WhitePawns
        //            else if (item.Color == "B" && item.Type == "P")
        //            {
        //                x = item.PositionX;
        //                y = item.PositionY;

        //                if (piece.PositionX == x + 1 && piece.PositionY == y + 1 || piece.PositionX == x - 1 && piece.PositionY == y + 1)
        //                {
        //                    if (piece.Color == "W")
        //                    {
        //                        PiecesThatCanMove.Add(item);
        //                    }
        //                }
        //                else if (piece.PositionX == x && piece.PositionY == y - 1)
        //                {

        //                }
        //                else
        //                {
        //                    PiecesThatCanMove.Add(item);
        //                }

        //            }


        //        }


        //    }
        //    return PiecesThatCanMove;
        //}

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
