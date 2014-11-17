using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessProject2
{
    public class CollectionOfLists
    {
        public List<PieceFactory> White { get; set; }
        public List<PieceFactory> Black { get; set; }

        public string[,] Chessboard { get; set; }
    }
}
