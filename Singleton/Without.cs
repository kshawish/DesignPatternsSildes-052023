using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    public class MyClass
    {
        private static int counter = 0;
        public MyClass() 
        {
            counter++;
            Console.WriteLine("Counter Value " + counter.ToString());
        }

    }

    // The Client class uses the GetInstance method to get two instances of
    // the MyClass class and prints out their hash codes.
    public static class Client
    {
        public static void DoTask()
        {
            MyClass obj1 = new MyClass();
            MyClass obj2 = new MyClass();
            Console.WriteLine("obj1 hash code: " + obj1.GetHashCode());
            Console.WriteLine("obj2 hash code: " + obj2.GetHashCode());
        }
    }

}
