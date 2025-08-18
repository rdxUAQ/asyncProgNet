using System;
using System.Threading.Tasks;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Start simulate delay");
           SimulateDelay().GetAwaiter().GetResult();

        }

        public static async Task SimulateDelay()
        {
            await Task.Delay(5000);
            System.Console.WriteLine("Operation completed after a delay");
        }
    }
}