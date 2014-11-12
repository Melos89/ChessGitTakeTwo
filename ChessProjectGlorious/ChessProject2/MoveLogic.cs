using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessProject2
{
    class MoveLogic
    {
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
