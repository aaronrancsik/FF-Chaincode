using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace LancKodV2
{
    class Picture
    {
        // A dataclass for the processed input

        char[,] map;
        Point selectionStart;
        int maxChainNumber;

        public Picture(char[,] map, Point selectionStart,int maxChainNumber)
        {
            this.map = map;
            this.selectionStart = selectionStart;
            this.maxChainNumber = maxChainNumber;
        }

        public char[,] Map { get => map;  }
        public Point SelectionStart { get => selectionStart; }
        public int MaxChainNumber { get => maxChainNumber; set => maxChainNumber = value; }
    }
}
