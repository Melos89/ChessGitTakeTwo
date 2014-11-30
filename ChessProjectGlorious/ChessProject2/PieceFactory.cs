using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessProject2
{
    public class PieceFactory
    {
        public string Color { get; set; }//property to set the piece colour

        public int PositionX { get; set; }//property to set the piece x value.

        public int PositionY { get; set; }//property to set the piece y value
        public string Type { get; set; } //property to set the piece type

        public bool inPlay = true; //bool flag that needs to be turned false when the piece is captured (work in progress)
        public List<List<Positions>> ShowMeMoves { get; set; } //property that sets a list of list of positions.

        
    }

    public class Pawn : PieceFactory
    {
        
        public Pawn(string colour,string type, int x, int y) //constructor that sets all the properties.
        {

            Color = colour;
            Type = type;
            PositionX = x;
            PositionY = y;
            ShowMeMoves = new List<List<Positions>>() {


            new List<Positions> //List of positions, where pawns are allowed to go in any one turn, its shown as x,y coords. White goes negative y and black positive.
            //Currently not in use
            {
                new Positions(0,1),
                new Positions(1,1),
                new Positions(-1,1),
                new Positions(0,-1),
                new Positions(1,-1),
                new Positions(-1,-1),
            },


            
            };

        }
    }

}
