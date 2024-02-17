using System;
using StopwatchApplication;

namespace stopwatch
{
    class Program
    {
        static void Main(string[] args)
        {
            // Example usage of StopwatchLogic - this will be replaced or extended by Christa's UI logic
            var stopwatch = new StopwatchLogic();
            
            Console.WriteLine("Starting stopwatch...");
            stopwatch.Start();
            System.Threading.Thread.Sleep(2000); // Simulate stopwatch running for 2 seconds.
            
            Console.WriteLine($"Current Time: {stopwatch.GetCurrentTime()}");
            stopwatch.Stop();
            
            Console.WriteLine($"Stopwatch stopped at: {stopwatch.GetCurrentTime()}");
        }
    }
}
