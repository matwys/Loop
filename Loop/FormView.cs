namespace Loop
{
    public partial class FormView : Form
    {
        private int number = 10;
        private string fileName;
        private string[] fileNames = {"1000","0010","0100","0001" };
        private Block[,] blockMatrix = new Block[10,10];
        private bool change = false;
        private LoopGenerator generator = new LoopGenerator();
        public FormView()
        {
            InitializeComponent();
            generator.MatrixMove();
            number = 0;
            for(int i = 0; i < 10; i++)
            {
                for(int j = 0; j < 10; j++)
                {
                    blockMatrix[i, j] = new Block(50+j*60,50+i*60, generator.logicMatrix[i,j].north, generator.logicMatrix[i, j].south, generator.logicMatrix[i, j].east, generator.logicMatrix[i, j].west);
                }
            }
        }

        private void FormView_Load(object sender, EventArgs e)
        {
            
        }

        private void FormView_Paint(object sender, PaintEventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    blockMatrix[i, j].Block_Paint(e);
                }
            }
        }

        private void FormView_Click(object sender, EventArgs e)
        {
            int _x, _y;
            _x = MousePosition.X - this.Location.X - 8;
            _y = MousePosition.Y - this.Location.Y - 30;

            if (_x > 50 && _x < 10*60+50 && _y > 50 && _y < 10 * 60 + 50)
            {
                blockMatrix[(_y - 50) / 60, (_x - 50) / 60].Block_Change();
                change = true;
                Invalidate();
            }
        }

        private void TMR_Tick(object sender, EventArgs e)
        {
            //if(change) Invalidate();
            //change = false;
        }
    }
}