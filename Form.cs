using System;
using System.Windows.Forms;

namespace GameOfLife
{
    public partial class Form : System.Windows.Forms.Form
    {
        private bool isPaused = false;

        public Form()
        {
            InitializeComponent();
        }

        private void Form_Load(object sender, EventArgs e)
        {
            Text = "Game of Life";
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            NextGeneration();
        }

        private void bStart_Click(object sender, EventArgs e)
        {
            if (isPaused)
            {
                ResumeGame();
                isPaused = false;
            } else
            {
                StartGame();
            }

            
        }

        private void bStop_Click(object sender, EventArgs e)
        {
            StopGame();
        }

        private void gameContent_MouseMove(object sender, MouseEventArgs e)
        {
            if (!timer.Enabled) return;

            if (e.Button == MouseButtons.Left)
                SetOnMousePos(e.Location.X, e.Location.Y, true);
            else if (e.Button == MouseButtons.Right)
                SetOnMousePos(e.Location.X, e.Location.Y, false);
        }

        private void StartGame()
        {
            if (timer.Enabled) return;

            nudResolution.Enabled = false;
            nudDensity.Enabled = false;

            InitGame();

            timer.Start();
        }

        private void StopGame()
        {
            if (!timer.Enabled) return;

            timer.Stop();

            nudResolution.Enabled = true;
            nudDensity.Enabled = true;

            if (isPaused)
            {
                bStop.Text = "Break";
                isPaused = false;
            } else
            {
                bStart.Text = "Resume";
                isPaused = true;
            }
        }

        private void ResumeGame()
        {
            if (timer.Enabled) return;

            timer.Start();

            bStart.Text = "Start";
            bStop.Text = "Stop";
        }
    }
}
