using System;
using System.IO;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task.Run(delegate
            {
                string localAppData = @"C:\Users\jjask\AppData\Local\FluentStoreBeta";
                bool exists = Directory.Exists(localAppData);
            });
        }
    }
}