using System;
namespace SingletonPattern
{
    public class PersionSingleton
    {
        private int index;
        private static readonly object lockObject = new object();
        private static volatile PersionSingleton uniqueInstance;

        private PersionSingleton(int index)
        {
            this.index = index;
        }

        public static PersionSingleton GetInstance()
        {
            if (uniqueInstance == null)
            { 
                lock (lockObject)
                {
                    if (uniqueInstance == null)
                    {
                        var random = new Random();
                        uniqueInstance = new PersionSingleton(random.Next(1, 4));
                    }
                }
            }
            return uniqueInstance;
        }

        public void SayHi()
        {
            Console.WriteLine("Say hello Persion" + index);
        }
    }
}
