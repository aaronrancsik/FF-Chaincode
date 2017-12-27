using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace LancKodV2
{
    class ChainCode
    {
        public static string FromPicture(Picture picture)
        {
            string chainCode = ""; // The return chain code.
            chainCode += (picture.SelectionStart.X+1).ToString()+(picture.SelectionStart.Y+1).ToString(); // Chain start with first coordinates.

            //Select the first elment as last selected.
            Point lastSelected = picture.SelectionStart;

            //Try to make a step from the first coordinates, it's null if no another X in map.
            int stepFromTopIndex = 5;
            Move lastMove = Step.MakeAStep(stepFromTopIndex, lastSelected, picture.Map);



            //Calculate chain code.
            if (lastMove != null)
            {
                lastSelected = new Point(lastSelected.X + lastMove.Direction.X, lastSelected.Y + lastMove.Direction.Y); // lastSelect + lastMove = the new last select coordinates
                chainCode += lastMove.Index.ToString(); //Make chaincode for the  first success move.

                for (int i = 0; i < picture.MaxChainNumber; i++)
                {
                    //Make a step from the lastSelected coordinates.
                    lastMove = Step.MakeAStep(lastMove.Index, lastSelected, picture.Map);
                    lastSelected = new Point(lastSelected.X + lastMove.Direction.X, lastSelected.Y + lastMove.Direction.Y);

                    if (lastSelected.Y == picture.SelectionStart.Y && lastSelected.X == picture.SelectionStart.X) // If we returned to the start coordinate.
                    {
                        chainCode += lastMove.Index.ToString();
                        return chainCode;
                    }
                    chainCode += lastMove.Index.ToString();
                }
            }
            return chainCode;
        }
    }
}
