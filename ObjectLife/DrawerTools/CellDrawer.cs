using Evolution_DLL.Objects;
using Evolution_DLL.World;
using System.Drawing;

namespace Evolution_DLL.DrawerTools
{
    internal class CellDrawer
    {
        internal static void Draw(Graphics graphic, GameProcese gameProcese)
        {
            foreach(var element in gameProcese.ThisWorld.StorageElements.GetElementsList())
            {
                if(element.State.Cell != null)
                {
                    graphic.FillRectangle(GetBrush(element), element.State.Cell.GetRectangle());
                }
            }
        }

        private static Brush GetBrush(Element element)
        {
            if (element.GetType() == typeof(Eat))
            {
                return new SolidBrush(Color.Gray);
            }
            var hits = element.State.Life;
            if (hits > 66)
            {
                return new SolidBrush(Color.Green);
            }
            if (hits > 33)
            {
                return new SolidBrush(Color.Yellow);
            }
            if (hits > 0)
            {
                return new SolidBrush(Color.Red);
            }
            return new SolidBrush(Color.Black);
        }
    }
}
