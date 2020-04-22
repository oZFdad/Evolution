using Evolution_DLL.World;
using ObjectLife.DrawerTools;
using System.Windows.Forms;

namespace Evolution
{
    public partial class Evolution : Form
    {
        private GameProcese _world = new GameProcese();

        public Evolution()
        {
            InitializeComponent();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            var drawer = new MainDrawer(e.Graphics, painBox.Width, painBox.Height, _world);
            drawer.Draw();
        }

        private void Evolution_MouseDown(object sender, MouseEventArgs e)
        {
            painBox.Refresh();
        }

        private void btCheckPoint_Click(object sender, System.EventArgs e)
        {
            int a = 0;
        }

        private void btStart_Click(object sender, System.EventArgs e)
        {
            _world.GameStart();
            painBox.Refresh();
        }
    }
}
