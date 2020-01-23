using System;
using static System.Console;
using static System.Convert;
using System.Threading;
using System.ComponentModel;
using System.Threading.Tasks;

namespace BackgroundWorker
{
    class Program
    {
        static void DoSomeWork(int threadNumber)
        {
            for (int i = 0; i < 10; i++)
            {
                WriteLine($"Here am I, thread {threadNumber}!");
                Thread.Sleep(1000);
            }
        }

        static void NiceHowAboutReading()
        {
            WriteLine("Write something and I will do it again.");
            string s = ReadLine();
            WriteLine(s);
        }

        static void Main(string[] args)
        {
            var options = new ParallelOptions();
            Parallel.Invoke(() => DoSomeWork(1), () => NiceHowAboutReading());
            ReadKey();
        }
    }
}
