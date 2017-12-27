using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Threading;

namespace LancKodV2
{
    class UI
    {
        public static void VisualChainSteps(string chaincode, Point startPoint, char[,] map)
        {
            


            for (int i = 0; i < map.GetLength(0); i++)
            {
                for (int j = 0; j < map.GetLength(1); j++)
                {
                    Console.Write(map[i,j]);
                }
                Console.WriteLine();
            }
            
            Point aktCursorPosiotion = startPoint;
            Console.SetCursorPosition(aktCursorPosiotion.Y, aktCursorPosiotion.X );
            Console.BackgroundColor = ConsoleColor.Magenta;
            Console.Write('X');
            Console.BackgroundColor = ConsoleColor.Black;
            for (int i = 2; i < chaincode.Length; i++)
            {
                for (int j = 0; j < Move.Moves.Length; j++)
                {
                    if (Move.Moves[j].Index == int.Parse(chaincode[i].ToString()))
                    {
                        aktCursorPosiotion = new Point(aktCursorPosiotion.X + Move.Moves[j].Direction.X, aktCursorPosiotion.Y + Move.Moves[j].Direction.Y);
                        Console.SetCursorPosition(aktCursorPosiotion.Y, aktCursorPosiotion.X );
                        Console.BackgroundColor = ConsoleColor.Magenta;
                        Console.Write('X');
                        Thread.Sleep(80);
                        Console.BackgroundColor = ConsoleColor.Black;
                        break;
                    }
                }
            }
        }
    }
}
