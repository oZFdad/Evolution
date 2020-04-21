
using ObjectLife;
using PainBox_DLL;
using System.Windows.Forms;

namespace Evolution
{
    public partial class Form1 : Form
    {
        private Grid[,] _grid;
        private Organism [] _organismList = new Organism[64];

        public Form1()
        {
            InitializeComponent();
            CreatGrid();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Grid.PainGrid(e.Graphics, painBox.Width, painBox.Height);
        }

        private void CreatGrid()
        {
            _grid = new Grid[painBox.Width / 10, painBox.Height / 10];
            for (var i = 0; i < painBox.Width - 1; i += 10)
            {
                for (var j = 0; j < painBox.Height - 1; j += 10)
                {
                    _grid[i / 10, j / 10] = new Grid(i, j);
                }
            }
        }
    }
}
