using System.Drawing;
using Evolution_DLL.World;

namespace Evolution_DLL.DrawerTools
{
    internal static class FieldDrawer
    {
        internal static void Draw (Graphics graphics, Size size, ThisWorld thisWorld)
        {
            var options = new Specification();
            var pen = new Pen(Color.Black);

            for (var i = 0; i <= options.CountField; i++)
            {
                graphics.DrawLine(pen, i * options.SizeCell, 0, i * options.SizeCell, options.CountField * options.SizeCell);
            }

            for (var i = 0; i <= options.CountField; i++)
            {
                graphics.DrawLine(pen, 0, i * options.SizeCell, options.CountField * options.SizeCell, i * options.SizeCell);
            }
        }
    }
}
