using System.Windows.Forms;

namespace L3MegaEscritorio
{
        // Model
        class Desk
        {
            int width = 0;
            int depth = 0;
            int numOfDrawers = 0;
            DesktopMaterial material;
            int rushOrderDays = 0;
            int deskPriceQuote = 0;

            public Desk(int inWidth, int inDepth, int inNumOfDrawers, DesktopMaterial inMaterial, int inRushOrderDays, int inDeskPriceQuote)
            {
                width = inWidth;
                depth = inDepth;
                numOfDrawers = inNumOfDrawers;
                material = inMaterial;
                rushOrderDays = inRushOrderDays;
                deskPriceQuote = inDeskPriceQuote;
            }

            public static int DeskArea(int width, int depth)
            {
                int area = width * depth;
                return area;
            }
        }
}
