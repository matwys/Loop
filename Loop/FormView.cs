static class Constants
{
    public const int Width = 6;
    public const int Height = 6;
}

namespace Loop
{
    public partial class FormView : Form
    {
        private Block[,] blockMatrix = new Block[Constants.Height, Constants.Width];
        //private bool change = false;
        private LoopGenerator generator = new LoopGenerator(Constants.Height, Constants.Width);
        private bool complite = false;
        public FormView()
        {
            InitializeComponent();
            generator.MatrixMove();

            for(int i = 0; i < Constants.Height; i++)
            {
                for(int j = 0; j < Constants.Width; j++)
                {
                    blockMatrix[i, j] = new Block(50+j*60,50+i*60, generator.logicMatrix[i,j].north, generator.logicMatrix[i, j].south, generator.logicMatrix[i, j].east, generator.logicMatrix[i, j].west);
                }
            }
            complite = Check_Loop();
        }

        private void FormView_Load(object sender, EventArgs e)
        {
            
        }

        private void FormView_Paint(object sender, PaintEventArgs e)
        {
            for (int i = 0; i < Constants.Height; i++)
            {
                for (int j = 0; j < Constants.Width; j++)
                {
                    blockMatrix[i, j].Block_Paint(e, complite);
                }
            }
        }

        private void FormView_Click(object sender, EventArgs e)
        {
            int _x, _y;
            _x = MousePosition.X - this.Location.X - 8;
            _y = MousePosition.Y - this.Location.Y - 30;

            if (_x > 50 && _x < Constants.Width * 60+50 && _y > 50 && _y < Constants.Height * 60 + 50)
            {
                blockMatrix[(_y - 50) / 60, (_x - 50) / 60].Block_Change();
                complite = Check_Loop();
                //change = true;
                Invalidate();
            }
        }

        private void TMR_Tick(object sender, EventArgs e)
        {
            //if(change) Invalidate();
            //change = false;
        }

        private bool Check_Loop()
        {
            for (int i = 0;i < Constants.Height; i++)
            {
                for(int j = 0;j < Constants.Width; j++)
                {
                    if (i == 0 && (blockMatrix[i,j].north == true) ) return false;
                    if (j == 0 && (blockMatrix[i,j].west == true) ) return false;

                    if (i != Constants.Height - 1 && (blockMatrix[i, j].south != blockMatrix[i + 1, j].north) ) return false;
                    if (i == Constants.Height - 1 && (blockMatrix[i, j].south == true) ) return false;

                    if (j != Constants.Width - 1 && (blockMatrix[i, j].east != blockMatrix[i, j + 1].west) ) return false;
                    if (j == Constants.Width - 1 && (blockMatrix[i, j].east == true) ) return false;
                }
            }
            return true;
        }
    }
}