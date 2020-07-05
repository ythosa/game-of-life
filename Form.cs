using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameOfLife
{
    public partial class Form : System.Windows.Forms.Form
    {
        private Graphics graphics;
        private int resolution;
        private bool[,] field;
        private int rows;
        private int cols;

        public Form()
        {
            InitializeComponent();
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

        private void StartGame()
        {
            if (timer.Enabled) return; // If game has already starts

            nudResolution.Enabled = false;
            nudDensity.Enabled = false;

            resolution = (int)nudResolution.Value;
            rows = gameContent.Height / resolution;
            cols = gameContent.Width / resolution;
            field = new bool[cols, rows];
            InitField();

            gameContent.Image = new Bitmap(gameContent.Width, gameContent.Height);
            graphics = Graphics.FromImage(gameContent.Image);

            timer.Start();
        }

        private void StopGame()
        {
            if (!timer.Enabled) return; // If games hasn't started

            timer.Stop();

            nudResolution.Enabled = true;
            nudDensity.Enabled = true;


        }

        private void InitField()
        {
            Random random = new Random();
            for (int x = 0; x < cols; x++)
            {
                for (int y = 0; y < rows; y++)
                {
                    field[x, y] = random.Next((int)nudDensity.Value) == 0;
                }
            }
        }

        private void NextGeneration()
        {
            graphics.Clear(Color.Black);

            var newField = new bool[cols, rows];

            for (int x = 0; x < cols; x++)
            {
                for (int y = 0; y < rows; y++)
                {
                    var neighboursCount = CountNeightbours(x, y);
                    var hasLife = field[x, y];

                    if (!hasLife && neighboursCount == 3)
                        newField[x, y] = true;
                    else if (hasLife && (neighboursCount < 2 || neighboursCount > 3))
                        newField[x, y] = false;
                    else
                        newField[x, y] = field[x, y];
                    
                    if (hasLife)
                    {
                        graphics.FillRectangle(Brushes.Crimson, x * resolution, y * resolution, resolution, resolution);
                    }
                }
            }

            field = newField;
            gameContent.Refresh();
        }

        private int CountNeightbours(int x, int y)
        {
            return 0;
        }
    }
}
