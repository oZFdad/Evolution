
using System;
using System.Drawing;
using Evolution_DLL;
using Evolution_DLL.World;

namespace PainBox_DLL
{
    internal static class FieldDrawer
    {
        internal static void Draw (Graphics graphics, Size size, ThisWorld thisWorld)
        {
            var pen = new Pen(Color.Black);

            for (var i = 0; i <= thisWorld.Count; i++)
            {
                graphics.DrawLine(pen, i * thisWorld.CellSize, 0, i * thisWorld.CellSize, thisWorld.Count * thisWorld.CellSize);
            }

            for (var i = 0; i <= thisWorld.Count; i++)
            {
                graphics.DrawLine(pen, 0, i * thisWorld.CellSize, thisWorld.Count * thisWorld.CellSize, i * thisWorld.CellSize);
            }
        }
    }
}
