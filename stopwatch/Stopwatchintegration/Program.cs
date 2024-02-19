using System;
using StopwatchApp = StopwatchApplication;

public class Program
{
    static void Main(string[] args)
    {
        StopwatchApp.StopwatchUI stopwatchUI = new StopwatchApp.StopwatchUI();
        stopwatchUI.Run();
    }
}