
using Evolution_DLL.World;
using System.Collections.Generic;
using System.Drawing;

namespace Evolution_DLL.DrawerTools
{
    public class GraphicsDrawer
    {
        public static void Draw (Graphics graphics, List<int[]> pointsList)
        {
            if (pointsList.Count == 0) return;

            var penLine = new Pen(Color.Red);
            var penPoint = new Pen(Color.Black);
            var penAverege = new Pen(Color.Blue);
            graphics.DrawLine(penLine, 1 , 349, 969, 349); //x
            graphics.DrawLine(penLine, 1, 349, 1, 1);//y
            var points = new Point[pointsList.Count];
            
            for(var i = 0; i < pointsList.Count; i++)
            {
                points[i] = new Point(pointsList[i][0] / 4, pointsList[i][1]);
            }

            graphics.DrawLines(penPoint, points);
            graphics.DrawLine(penAverege, 1, 170, 969, 170);
        }
    }
}
