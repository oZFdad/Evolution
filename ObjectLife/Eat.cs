namespace ObjectLife
{
    public class Eat : Obj
    {
        private State _state;

        public Eat(int x, int y)
        {
            _state = new State(x, y);
        }
    }
}