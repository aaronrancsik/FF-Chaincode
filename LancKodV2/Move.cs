using System.Drawing;

namespace LancKodV2
{
    class Move
    {
        static Move[] moves = new Move[]{
                new Move(1, new Point(-1, 0)),
                new Move(8, new Point(-1, 1)),
                new Move(7, new Point(0,  1)),
                new Move(6, new Point(1, 1)),
                new Move(5, new Point(1, 0)),
                new Move(4, new Point(1,-1)),
                new Move(3, new Point(0, -1)),
                new Move(2, new Point(-1, -1))
         };

        internal static Move[] Moves { get => moves; }

        int index;
        Point direction;
        public Move(int index, Point direction)
        {
            this.index = index;
            this.direction = direction;
        }

        public int Index { get => index; }
        public Point Direction { get => direction; }
    }
}
