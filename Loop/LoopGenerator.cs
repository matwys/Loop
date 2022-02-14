using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop
{
    internal class LoopGenerator
    {
        public LogicBlock[,] logicMatrix;
        private Random rnd = new Random();
        private int width;
        private int height;

        public LoopGenerator(int h, int w)
        {
            width = w;
            height = h;
            logicMatrix = new LogicBlock[h, w];
            for (int i = 0; i < h; i++)
            {
                for(int j = 0; j < w; j++)
                {
                    logicMatrix[i, j] = new LogicBlock(false,false,false,false);
                }
            }
            for(int i = 0;i < h; i++)
            {
                for( int j = 0;j < w; j++)
                {
                    if (i == 0) logicMatrix[i, j].north = false;
                    if (j == 0) logicMatrix[i, j].west = false;

                    if(i != h-1)
                    {
                        bool rndBool = RndBool();
                        logicMatrix[i, j].south = rndBool;
                        logicMatrix[i+1, j].north = rndBool;
                    } else logicMatrix[i, j].south = false;

                    if (j != w-1)
                    {
                        bool rndBool = RndBool();
                        logicMatrix[i, j].east = rndBool;
                        logicMatrix[i, j+1].west = rndBool;
                    }
                    else logicMatrix[i, j].east = false;
                }
            }
        }

        private bool RndBool()
        {
            if(rnd.Next(1,3) == 1) return true;
            else return false;
        }

        public void MatrixMove()
        {
            for(int i = 0; i < height; i++)
            {
                for(int j = 0; j < width; j++)
                {
                    int moves = rnd.Next(0, 4);
                    for(int k = 0; k < moves; k++)
                    {
                        bool temp = logicMatrix[i, j].north;
                        logicMatrix[i, j].north = logicMatrix[i, j].west;
                        logicMatrix[i, j].west = logicMatrix[i, j].south;
                        logicMatrix[i, j].south = logicMatrix[i, j].east;
                        logicMatrix[i, j].east = temp;
                    }
                }
            }
        }
    }
}
