using System;

namespace StopwatchApplication
{
    public class StopwatchUI
    {
        private readonly StopwatchLogic stopwatchLogic = new StopwatchLogic();

        public void Run()
        {
            Console.WriteLine("Stopwatch Application\n");
            Console.WriteLine("Available Commands:");
            Console.WriteLine("start  - Start the stopwatch");
            Console.WriteLine("pause  - Pause the stopwatch");
            Console.WriteLine("resume - Resume the stopwatch");
            Console.WriteLine("reset  - Reset the stopwatch to 00:00:00");
            Console.WriteLine("stop   - Stop the stopwatch and show the final time");
            Console.WriteLine("exit   - Exit the application\n");

            bool isRunning = true;

            while (isRunning)
            {
                Console.Write("Enter command: ");
                string command = Console.ReadLine().ToLower();

                switch (command)
                {
                    case "start":
                        stopwatchLogic.Start();
                        Console.WriteLine("Stopwatch started.");
                        break;
                    case "pause":
                        stopwatchLogic.Pause();
                        Console.WriteLine("Stopwatch paused.");
                        break;
                    case "resume":
                        stopwatchLogic.Resume();
                        Console.WriteLine("Stopwatch resumed.");
                        break;
                    case "reset":
                        stopwatchLogic.Reset();
                        Console.WriteLine("Stopwatch reset.");
                        break;
                    case "stop":
                        stopwatchLogic.Stop();
                        Console.WriteLine($"Stopwatch stopped at: {stopwatchLogic.GetCurrentTime()}");
                        break;
                    case "exit":
                        isRunning = false;
                        Console.WriteLine("Exiting application...");
                        break;
                    default:
                        Console.WriteLine("Invalid command. Please try again.");
                        break;
                }

                if (command != "exit")
                {
                    Console.WriteLine($"Current Time: {stopwatchLogic.GetCurrentTime()}\n");
                }
            }
        }
    }
}
