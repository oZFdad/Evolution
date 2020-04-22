using Evolution_DLL.Objects;


namespace Evolution_DLL.World
{
    public class GameProcese
    {
        private StorageForElements _storageElements;
        private ThisWorld _thisWorld;

        internal ThisWorld ThisWorld { get => _thisWorld; }
        internal StorageForElements StorageElements { get => _storageElements; }

        public GameProcese()
        {
            _storageElements = new StorageForElements();
            _thisWorld = new ThisWorld();
        }
    }
}
