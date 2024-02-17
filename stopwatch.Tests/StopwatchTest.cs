using Microsoft.VisualStudio.TestTools.UnitTesting;
using StopwatchApplication;
using System.Threading;

[TestClass]
public class StopwatchTests
{
    [TestMethod]
    public void TestStartAndStop()
    {
        var stopwatch = new StopwatchLogic();
        stopwatch.Start();
        Thread.Sleep(1000); // Simulate 1 second passing
        stopwatch.Stop();
        Assert.AreEqual("00:00:01", stopwatch.GetCurrentTime());
    }

    [TestMethod]
    public void TestPauseAndResume()
    {
        var stopwatch = new StopwatchLogic();
        stopwatch.Start();
        Thread.Sleep(1000); // Simulate 1 second passing
        stopwatch.Pause();
        var timeAfterPause = stopwatch.GetCurrentTime();
        Thread.Sleep(1000); // Simulate another second passing, but stopwatch is paused
        stopwatch.Resume();
        Thread.Sleep(1000); // Simulate another second passing after resuming
        stopwatch.Stop();
        Assert.AreEqual("00:00:02", stopwatch.GetCurrentTime(), "Stopwatch did not resume correctly.");
    }

    [TestMethod]
    public void TestReset()
    {
        var stopwatch = new StopwatchLogic();
        stopwatch.Start();
        Thread.Sleep(1000); // Simulate 1 second passing
        stopwatch.Stop();
        stopwatch.Reset();
        Assert.AreEqual("00:00:00", stopwatch.GetCurrentTime(), "Stopwatch did not reset correctly.");
    }
}
