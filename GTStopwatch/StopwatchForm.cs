using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GTStopwatch
{
    // ---[[[ GT STOPWATCH ]]]---
    // A winform for a basic timer, many thanks to Mark Ashley Bell for
    // a quickstart version of the code, I have modified it a bit to add in
    // drag handling, pause/play and removed the total time timer
    // Ref: https://markb.co.uk/creating-a-simple-stopwatchtimer-application-with-c-windows-forms.html
    // Created by Glynn Taylor for use in timelapse recording
    // http://www.glynntaylor.co.uk
    //--------------------------------------------------------
    public partial class StopwatchForm : Form
    {
        #region ---[[[ DRAG HANDLING VARIABLES / REFERENCES ]]]---
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        #endregion

        #region ---[[[ PRIVATE VARIABLES ]]]---
        private Timer timer;
        private DateTime startTime = DateTime.MinValue;
        private TimeSpan previousElapsedTime = TimeSpan.Zero;
        private bool timerRunning = false;
        #endregion

        #region ---[[[ START AND UPDATE ]]]---
        public StopwatchForm()
        {
            InitializeComponent();
            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += new EventHandler(_timer_Tick);
            this.MouseDown += FormMouseDown;
        }

        void _timer_Tick(object sender, EventArgs e)
        {
            var timeSinceStartTime = DateTime.Now - startTime;
            timeSinceStartTime = new TimeSpan(timeSinceStartTime.Hours,
                                              timeSinceStartTime.Minutes,
                                              timeSinceStartTime.Seconds);
            timeDisplayLbl.Text = (timeSinceStartTime + previousElapsedTime).ToString();
        }
        #endregion

        #region ---[[[ BUTTONS ]]]---
        private void StartStopClick(object sender, EventArgs e)
        {
            if (!timerRunning)
            {
                StartTimer();
            }
            else
            {
                PauseTimer();
            }
        }

        private void OnResetClick(object sender, EventArgs e)
        {
            StopTimer();
        }

        private void QuitClick(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // FORM DRAG HANDLING FOR REPOSITIONING
        private void FormMouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        #endregion

        #region ---[[[ TIMER FUNCTIONS ]]]---
        public void StartTimer()
        {
            startTime = DateTime.Now;
            timer.Start();
            timerRunning = true;
            startStopBtn.Text = "Pause";
        }

        public void PauseTimer()
        {
            timer.Stop();
            timerRunning = false;
            previousElapsedTime = previousElapsedTime + (DateTime.Now - startTime);
            startStopBtn.Text = "Start";
        }

        public void StopTimer()
        {
            PauseTimer();
            timeDisplayLbl.Text = "00:00:00";
            previousElapsedTime = TimeSpan.Zero;
        }
        #endregion
    }
}
