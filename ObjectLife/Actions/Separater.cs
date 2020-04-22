using Evolution_DLL.Genes;

namespace Evolution_DLL.Actions
{
    internal static class Separater
    {
        internal static ActionAbstract GetAction (Gene gene)
        {
            if (gene.GetType() == typeof(AttackDawn))
            {
                return new Attack(-1, 0);
            }
            if (gene.GetType() == typeof(AttackUp))
            {
                return new Attack(1, 0);
            }
            if (gene.GetType() == typeof(AttackLeft))
            {
                return new Attack(0, -1);
            }
            if (gene.GetType() == typeof(AttackRight))
            {
                return new Attack(0, 1);
            }
            if (gene.GetType() == typeof(GoDawn))
            {
                return new Mover(-1, 0);
            }
            if (gene.GetType() == typeof(GoUp))
            {
                return new Mover(1, 0);
            }
            if (gene.GetType() == typeof(GoLeft))
            {
                return new Mover(0, -1);
            }
            if (gene.GetType() == typeof(GoRight))
            {
                return new Mover(0, 1);
            }
            if (gene.GetType() == typeof(Defense))
            {
                return new Defenser();
            }
            if (gene.GetType() == typeof(Scout))
            {
                return new Scouter();
            }
            return null;
        }
    }
}
