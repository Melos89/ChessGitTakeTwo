using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessProject2
{
    class MoveLogic
    {
        public void CheckLists(List<PieceFactory> pieces)
        {
            List<PieceFactory> PiecesThatCanMove = new List<PieceFactory>();
            foreach (var item in pieces)
            {
                if (item.Color == "W" && item.Type == "P")
                {
                    int x = item.PositionX;
                    int y = item.PositionY;

                    foreach (var piece in pieces)
                    {
                        if (piece.PositionX == x + 1 && piece.PositionY == y - 1 || piece.PositionX == x - 1 && piece.PositionY == y - 1)
                        {
                            if (piece.Color == "B")
                            {
                                PiecesThatCanMove.Add(piece);
                            }
                        }
                            //-----------------------------------------------------------
                        else if (piece.PositionX == x && piece.PositionY == y - 1)
                        {

                        }
                    }
                }
                else if(item.Color == "B" && item.Type == "P")
                {
                    int x = item.PositionX;
                    int y = item.PositionY;
                    foreach (var piece in pieces)
                    {
                        if (piece.PositionX == x + 1 && piece.PositionY == y + 1 || piece.PositionX == x - 1 && piece.PositionY == y + 1)
                        {
                            if(piece.Color == "B")
                            {
                                PiecesThatCanMove.Add(piece);
                            }
                        }
                        else if (piece.PositionX == x && piece.PositionY == y - 1)
                        {

                        }
                    }
                }
            }
        }
        public void MoveThisPiece(List<PieceFactory> Piece)
        {
            Random rnd = new Random();
            int number = rnd.Next(Piece.Count);
            
            if (Piece[number].Color == "W")
            {

                if(Piece[number].PositionY > 0)
                {
                Piece[number].PositionY--;
                }


            }
            else if (Piece[number].Color == "B")
            {

                if(Piece[number].PositionY < 7)
                {
                Piece[number].PositionY++;
                }

            }
            
        }
    }
}
