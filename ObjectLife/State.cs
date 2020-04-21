namespace ObjectLife
{
    public class State
    {
        private int _life;
        private int _x;
        private int _y;

        public State(int x, int y)
        {
            _life = 100;
            _x = x;
            _y = y;
        }
    }
}