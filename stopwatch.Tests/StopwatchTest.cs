using System;

namespace StopWatchApplication.Tests
{
    public class StopwatchApp Tests{
        public static void Main(string[] args)
        {
            RunAllTests();
        }

        private static void RunAllTests()
        {
            Console.WriteLine("Running StopwatchUI Tests\n");

            StopwatchUI stopwatchUI = new StopwatchUI();

            try
            {
                // Test1: Start
                Console.WriteLine("Test 1: Start");
                stopwatchUI.RunCommand("start");
                PrintCurrentState(stopwatchUI);
                WaitForUserInput();

                //Test 2: Pause
                Console.WriteLine("Test 2: Pause");
                stopwatchUI.RunCommand("pause");
                PrintCurrentState(stopwatchUI);
                WaitForUserInput();

                //Test 3: Resume
                Console.WriteLine("Test 3: Resume");
                stopwatchUI.RunCommand("resume");
                PrintCurrentState(stopwatchUI);
                WaitForUserInput();

                //Test 4: Reset
                Console.WriteLine("Test 4: Reset");
                stopwatchUI.RunCommand("reset");
                PrintCurrentState(stopwatchUI);
                WaitForUserInput();

                //Test 5: Stop
                Console.WriteLine("Test 5: Stop");
                stopwatchUI.RunCommand("stop");
                PrintCurrentState(stopwatchUI);
                WaitForUserInput();

                //Test 6: Exit Command
                Console.WriteLine("Test 6: Exit");
                stopwatchUI.RunCommand("exit");
                Console.WriteLine(" Test completion");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Test failed: {ex.Message}");
            }
        }
        
        private static void PrintCurrentState(StopwatchApp UI stopwatchUI)
        {
            Console.WriteLine($"Current Time: {stopwatchUI.GetCurrentTime()}\n");
        }

        private static void WaitForUserInput()
        {
            Console.WriteLine("Press Enter to continue...");
            Console.ReadLine();
            Console.Clear();
        }
    }
}