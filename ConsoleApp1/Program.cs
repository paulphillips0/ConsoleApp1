namespace ConsoleApp1
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            DateTime now = DateTime.Now.ToUniversalTime();
            Console.WriteLine($"Current UTC time is {now}");
        }
    }
}
