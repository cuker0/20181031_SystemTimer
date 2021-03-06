﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.IO;


namespace _20181031_SystemTimer
{ 
    class Program
    {
        static void Main(string[] args)
        {
            Timer T1 = new Timer();

     //       T1.Start();

            T1.Interval = 1000;
                       
            T1.Elapsed += T1_Elapsed;
            FileSystemWatcher check = new FileSystemWatcher(@"D:\C#\");
            check.EnableRaisingEvents = true;

            check.Created += EventHandler;
            check.Deleted += EventHandler;
            check.Changed += EventHandler;
            check.Renamed+= EventHandler;

            Console.ReadKey();
                    
        }

        private static void EventHandler(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine($"Zmiana w folderze: {e.Name}, {e.ChangeType}");
            
        }

        private static void T1_Elapsed(object sender, ElapsedEventArgs e)
        {
            Console.Clear();
            
            Console.WriteLine($"Actual time: {DateTime.Now.ToString("HH:mm:ss")} ");
            Console.WriteLine("###################################");

            
           
        }
    }
}
