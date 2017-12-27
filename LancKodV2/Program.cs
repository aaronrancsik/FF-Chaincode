using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Diagnostics;

namespace LancKodV2
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch b = new Stopwatch();
            b.Start();

            Picture picture= FileManager.PictureFromFile("FOLT1.BE");
            string chainCode = ChainCode.FromPicture(picture);
            b.Stop();

            Console.WriteLine(b.ElapsedMilliseconds);
            Console.WriteLine("chain: " + chainCode);
            Console.ReadLine();
            Console.Clear();

            UI.VisualChainSteps(chainCode, picture.SelectionStart, picture.Map);
            Console.ReadLine();
        }


    }
}
