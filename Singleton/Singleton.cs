namespace SingletonPattern
{
    public class Singleton
    {
        private static int counter = 0;
        private static Singleton instance = null; 
        private static readonly object Instancelock = new object();

        // Private constructor to prevent direct instantiation
        private Singleton()
        {
            counter++;
            Console.WriteLine("Counter Value " + counter.ToString());
        }

        public static Singleton GetInstance()
        {
            // Double checked locking mechanism, Performing lock is heavy.
            // So to avoid the lock first we need to check the null value.
            if (instance == null)
            {
                // Thread Safety
                lock (Instancelock)
                {
                    // lazy initialization
                    if (instance == null)
                    {
                        instance = new Singleton();
                    }
                }
            }
            return instance;

        }
    }
}
