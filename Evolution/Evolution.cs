
using System;
using Evolution_DLL.World;
using System.Windows.Forms;
using ObjectLife.DrawerTools;

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
    }
}
