namespace Singleton
{
    public sealed class Singleton
    {
        private static Singleton _instance = null;
        private static readonly object _padlock = new object();
        
        public static Singleton Instance 
        {
            get
            {
                lock (_padlock)
                {
                    return _instance ??= new Singleton();
                }
            }
        }
    }
}