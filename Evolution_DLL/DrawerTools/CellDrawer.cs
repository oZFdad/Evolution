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
            var options = new Specification();
            if (element.GetType() == typeof(Eat))
            {
                return new SolidBrush(Color.Gray);
            }
            var hits = element.State.Life;
            return new SolidBrush(ColorRGB.HSL2RGB(0.3 * hits / options.OrganismMaxLife,1,0.4));
        }
    }
}
