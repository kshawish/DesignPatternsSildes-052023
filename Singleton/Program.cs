namespace SingletonPattern
{
    class Program
    {
        public static void Main(string[] args)
        {

            //Client.DoTask();


            // As you can see, the Singleton pattern allows us to ensure that only
            // one instance of a class is created and provides a globally accessible
            // point of access to that instance.

            //Singleton obj1 = Singleton.GetInstance();
            //Singleton obj2 = Singleton.GetInstance();
            //Console.WriteLine("obj1 hash code: " + obj1.GetHashCode());
            //Console.WriteLine("obj2 hash code: " + obj2.GetHashCode());

            Parallel.Invoke(() =>
            {
                Singleton obj1 = Singleton.GetInstance();
                Console.WriteLine("obj1 hash code: " + obj1.GetHashCode());
            },
            () =>
            {
                Singleton obj1 = Singleton.GetInstance();
                Console.WriteLine("obj1 hash code: " + obj1.GetHashCode());
            });

        }
    }
}
