using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;

namespace LancKodV2
{
    class FileManager
    {
        /* This calss create the specefic object from the storaged files! */

        public static Picture PictureFromFile(string fileName)
        {
            int maxChainNumber = 0; // Count the 'X' in the file and make it twice beacuse it can use backway as well.
            bool isFirst = true;
            Point selectStart = new Point(); // The coordinate of the first 'X' it is used to close chain.

            string[] lines = File.ReadAllLines(fileName); // The file first row contain the sizes!
            string[] strSize =  lines[0].Split(' ');

            char[,] map = new char[int.Parse(strSize[0]), int.Parse(strSize[1])]; // Contains the whole file by characters.

            //Count the X is in the file.
            for (int x = 0; x < int.Parse(strSize[0]); x++)
            {
                for (int y = 0; y < int.Parse(strSize[1]); y++) 
                {
                    map[x, y] = lines[x+1][y];

                    if (lines[x+1][y] == 'X')
                    {
                        if (isFirst)
                        {
                            selectStart = new Point(x, y);
                            isFirst = false;
                        }
                        maxChainNumber++;
                    }
                }
            }
            maxChainNumber *= 2; // Make it twice beacuse it can use backway as well.

            Picture retPicture = new Picture(map, selectStart,maxChainNumber);
            return retPicture;
        }
    }
}
