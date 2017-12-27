using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace LancKodV2
{
    class Step
    {
        public static Move MakeAStep(int startDirection, Point lastSelected, char[,] map)
        {
            // Select a move start from previous coordinates move index, and check circle right.
            for (int i = 0; i < Move.Moves.Length; i++)
            {
                if (startDirection == Move.Moves[i].Index) // Select 
                {
                    for (int j = i; j < i + Move.Moves.Length; j++)
                    {
                        int revShift = (j+5) % Move.Moves.Length; // 'j' is last, '+5' oposite, '%' shift to moves length: this is the most beautiful bussines logic :) start from oposite go to right
                        int x = lastSelected.X + Move.Moves[revShift].Direction.X;
                        int y = lastSelected.Y + Move.Moves[revShift].Direction.Y;
                        if (map[x, y] == 'X')
                        {                  
                            return Move.Moves[revShift]; // The new step
                        }

                    }
                    break;
                }
            }
            return null;
        }
    }
}
