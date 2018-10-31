using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace _20181031_SystemTimer
{ 
    class Program
    {
        static void Main(string[] args)
        {
            Timer T1 = new Timer();

            T1.Start();

            T1.Interval = 1000;
                       
            T1.Elapsed += T1_Elapsed;

            Console.ReadKey();
        }

        private static void T1_Elapsed(object sender, ElapsedEventArgs e)
        {
            Console.Clear();

            Console.WriteLine($"Actual time: {DateTime.Now.ToString("HH:mm:ss")} ");
        }
    }
}
