using System;
using System.Windows.Forms;
using StopwatchApplication;
using Timer = System.Windows.Forms.Timer;

namespace StopwatchApplication
{
    public partial class StopwatchForm : Form
    {
        private StopwatchLogic stopwatchLogic = new StopwatchLogic();
        private Label lblTime;
        private Button btnStart, btnPause, btnResume, btnReset, btnStop, btnExit;
        private Timer uiTimer = new Timer();

        public StopwatchForm()
        {
            InitializeFormComponents();
            uiTimer.Interval = 1000;
            uiTimer.Tick += UiTimer_Tick;
        }

        private void InitializeFormComponents()
        {
            lblTime = new Label { Width = 200, Height = 30, Text = "00:00:00", Location = new System.Drawing.Point(50, 20) };

            btnStart = new Button { Text = "Start", Location = new System.Drawing.Point(50, 60) };
            btnPause = new Button { Text = "Pause", Location = new System.Drawing.Point(150, 60) };
            btnResume = new Button { Text = "Resume", Location = new System.Drawing.Point(250, 60) };
            btnReset = new Button { Text = "Reset", Location = new System.Drawing.Point(50, 100) };
            btnStop = new Button { Text = "Stop", Location = new System.Drawing.Point(150, 100) };
            btnExit = new Button { Text = "Exit", Location = new System.Drawing.Point(250, 100) };

            btnStart.Click += (sender, e) => { stopwatchLogic.Start(); uiTimer.Start(); };
            btnPause.Click += BtnPause_Click;
            btnResume.Click += (sender, e) => { stopwatchLogic.Resume(); uiTimer.Start(); };
            btnReset.Click += (sender, e) => { stopwatchLogic.Reset(); UpdateTimeDisplay(); };
            btnStop.Click += BtnStop_Click;
            btnExit.Click += (sender, e) => Application.Exit();

            Controls.Add(lblTime);
            Controls.AddRange(new Control[] { btnStart, btnPause, btnResume, btnReset, btnStop, btnExit });
        }

        private void BtnPause_Click(object sender, EventArgs e)
        {
            stopwatchLogic.Pause();
            uiTimer.Stop();
            UpdateTimeDisplay();
        }

        private void BtnStop_Click(object sender, EventArgs e)
        {
            string lastReadValue = stopwatchLogic.GetCurrentTime(); 
            stopwatchLogic.Stop(); 
            uiTimer.Stop();
            UpdateTimeDisplay(); 
            MessageBox.Show($"Stopped at: {lastReadValue}", "Stopwatch Stopped", MessageBoxButtons.OK, MessageBoxIcon.Information); // Show the last read value
            stopwatchLogic.Reset(); 
        }

        private void UiTimer_Tick(object sender, EventArgs e)
        {
            UpdateTimeDisplay();
        }

        private void UpdateTimeDisplay()
        {
            lblTime.Text = stopwatchLogic.GetCurrentTime();
        }
    }
}
