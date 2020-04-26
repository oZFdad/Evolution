using Evolution_DLL.World;
using Evolution_DLL.DrawerTools;
using System.Windows.Forms;
using System.IO;
using System.Collections.Generic;

namespace Evolution
{
    public partial class Evolution : Form
    {
        private GameProcese _world = new GameProcese();
        private List<int[]> _pointsList = new List<int[]>();
        

        public Evolution()
        {
            InitializeComponent();
            //_world.EventChange += WorldOnEventChange;
            _world.EndRound += () =>
            {
                using(var writer = new StreamWriter("C:/Users/Павел/source/repos/Evolution/123.txt", false))
                {
                    writer.WriteLine(_world.GetInfoForSave());
                    _pointsList.Add(new int[2] { _world.Generation, _world.Round });
                }
            };
        }

        private void WorldOnEventChange()
        {
            lbState.Text = _world.GerInfo();
            painBox.Refresh();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            var drawer = new MainDrawer(e.Graphics, painBox.Width, painBox.Height, _world);
            drawer.Draw();
        }

        private void btCheckPoint_Click(object sender, System.EventArgs e)
        {
            var b = _world.GetFullCells();
            int a = 0;
        }

        private void btStart_Click(object sender, System.EventArgs e)
        {
            _pointsList.Clear();
            var i = 0;
            while (i != 4096)
            {
                _world.GameStart();
                i++;
                painBox.Refresh();
            }
            painBoxForGraphics.Refresh();
        }

        private void btNext_Click(object sender, System.EventArgs e)
        {
            _world.NextIteration();
        }

        private void painBoxForGraphics_Paint(object sender, PaintEventArgs e)
        {
            GraphicsDrawer.Draw(e.Graphics, _pointsList);
        }
    }
}
