using System;
using System.Threading;

namespace SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //PersionSingleton.GetInstance().SayHi();
            var thread1 = new Thread(() => PersionSingleton.GetInstance().SayHi());
            var thread2 = new Thread(() => PersionSingleton.GetInstance().SayHi());

            thread1.Start();
            thread2.Start();
        }
    }
}
