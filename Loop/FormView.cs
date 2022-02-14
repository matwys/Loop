namespace Loop
{
    public partial class FormView : Form
    {
        private int number;
        private string fileName;
        private string[] fileNames = {"1000","0010","0100","0001" };
        private Block[,] blockArrey = new Block[10,10];
        private bool change = false;
        public FormView()
        {
            
            InitializeComponent();
            number = 0;
            for(int i = 0; i < 10; i++)
            {
                for(int j = 0; j < 10; j++)
                {
                    blockArrey[i, j] = new Block(50+j*60,50+i*60, true, false, true, true);
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
                    blockArrey[i, j].Block_Paint(e);
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
                blockArrey[(_y - 50) / 60, (_x - 50) / 60].Block_Change();
                change = true;
            }
        }

        private void TMR_Tick(object sender, EventArgs e)
        {
            if(change) Invalidate();
            change = false;
        }
    }
}