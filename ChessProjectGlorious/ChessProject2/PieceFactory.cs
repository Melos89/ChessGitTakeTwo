using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessProject2
{
    public class PieceFactory
    {
        public string Color { get; set; }

        public int PositionX { get; set; }

        public int PositionY { get; set; }
        public string Type { get; set; }

        
    }

    public class Pawn : PieceFactory
    {
        public Pawn(string colour,string type, int x, int y)
        {

            Color = colour;
            Type = type;
            PositionX = x;
            PositionY = y;

        }
    }

}
