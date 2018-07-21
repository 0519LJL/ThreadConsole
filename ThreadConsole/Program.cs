using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ThreadConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread thread = new Thread(new ThreadStart(consol));
            thread.Start();

            Console.WriteLine(string.Format("thread is {0}",(thread.IsAlive ? "alive":"off")));
            Console.WriteLine(string.Format("thread state is {0}", thread.ThreadState));

            Thread thread2 = new Thread(delegate() { Console.WriteLine("匿名内部类生成"); });
            thread2.Start();

            Thread thread3 = new Thread(() => { Console.WriteLine("limda 生成的");});
            thread3.Start();

            Console.ReadLine();

        }

        static void consol()
        {
            
            Console.WriteLine("这是一个无参线程");
        }
    }
}
