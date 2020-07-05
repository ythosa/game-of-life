using System;
using System.Drawing;
using System.Windows.Forms;

namespace GameOfLife
{
    public partial class Form : System.Windows.Forms.Form
    {
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
            StartGame();
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
            if (timer.Enabled) return; // If game has already starts

            nudResolution.Enabled = false;
            nudDensity.Enabled = false;

            InitField();

            timer.Start();
        }

        private void StopGame()
        {
            if (!timer.Enabled) return; // If games hasn't started

            timer.Stop();

            nudResolution.Enabled = true;
            nudDensity.Enabled = true;
        }
    }
}
