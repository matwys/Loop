using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop
{
    internal class Block
    {
        public int xTopLeft { get; set; }
        public int yTopLeft { get; set; }
        public bool north { get; set; }
        public bool south { get; set; }
        public bool east { get; set; }
        public bool west { get; set; }
        public bool type { get; set; }

        public Block(int x, int y, bool n, bool s, bool e, bool w)
        {
            xTopLeft = x;
            yTopLeft = y;
            north = n;
            south = s;
            east = e;
            west = w;
        }
        private string North01()
        {
            if (north == true) return "1";
            else return "0";
        }

        private string South01()
        {
            if (south == true) return "1";
            else return "0";
        }

        private string East01()
        {
            if (east == true) return "1";
            else return "0";
        }

        private string West01()
        {
            if (west == true) return "1";
            else return "0";
        }
        public void Block_Paint(PaintEventArgs e)
        {
            if(north == true)
            {
                e.Graphics.FillRectangle(Brushes.Cyan, xTopLeft + 25, yTopLeft, 10, 35);
            }
            if(south == true)
            {
                e.Graphics.FillRectangle(Brushes.Cyan, xTopLeft + 25, yTopLeft+25, 10, 35);
            }
            if(east == true)
            {
                e.Graphics.FillRectangle(Brushes.Cyan, xTopLeft + 25, yTopLeft + 25, 35, 10);
            }
            if (west == true)
            {
                e.Graphics.FillRectangle(Brushes.Cyan, xTopLeft, yTopLeft + 25, 35, 10);
            }
            //e.Graphics.DrawImage(new Bitmap("../../Resources/" +North01()+South01()+East01()+West01()+ ".png"), xTopLeft, yTopLeft, 60, 60);
        }

        public void Block_Change()
        {
            bool temp = north;
            north = west;
            west = south;
            south = east;
            east = temp;
        }
    }
}
