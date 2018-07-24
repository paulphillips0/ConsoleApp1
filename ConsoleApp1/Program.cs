using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            DateTime now = DateTime.Now.ToUniversalTime();
            Console.WriteLine($"Current UTC time is {now}");
        }
    }
}
