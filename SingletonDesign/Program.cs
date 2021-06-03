using System;

namespace SingletonDesign
{
    class Program
    {
        static void Main(string[] args)
        {
            Singletone singletone1 = Singletone.getInstance();
            Singletone singletone2 = Singletone.getInstance();

            Console.WriteLine(singletone1 == singletone2); // Only One Instance of Singleton
        }
    }

    class Singletone
    {
        private static Singletone instance;

        private Singletone() { }

        public static Singletone getInstance()
        {
            if (instance == null)
            {
                instance = new Singletone();
            }

            return instance;
        }
    }
}