using Evolution_DLL.World;
using Evolution_DLL.DrawerTools;
using System.Windows.Forms;

namespace Evolution
{
    public partial class Evolution : Form
    {
        private GameProcese _world = new GameProcese();
        

        public Evolution()
        {
            InitializeComponent();
            _world.EventChange += WorldOnEventChange;
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
            _world.GameStart();
            painBox.Refresh();
        }

        private void btNext_Click(object sender, System.EventArgs e)
        {
            _world.NextIteration();
            painBox.Refresh();
        }
    }
}
