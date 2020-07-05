using System;
using System.Drawing;

namespace GameOfLife
{
    public partial class Form : System.Windows.Forms.Form
    {
        private Graphics graphics;
        private int currentGeneration = 0;
        private int resolution;
        private bool[,] field;
        private int rows;
        private int cols;

        private void SetOnMousePos(int mouseX, int mouseY, bool value)
        {
            var x = mouseX / resolution;
            var y = mouseY / resolution;
            var isValidationPassed = ValidateMousePosition(x, y);

            if (isValidationPassed) field[x, y] = value;
        }

        private bool ValidateMousePosition(int x, int y)
        {
            return x >= 0 && y >= 0 && x < cols && y < rows;
        }

        private void InitGame()
        {
            currentGeneration = 0;
            Text = $"Game of Life. Generation: {currentGeneration}";

            InitField();

            gameContent.Image = new Bitmap(gameContent.Width, gameContent.Height);
            graphics = Graphics.FromImage(gameContent.Image);
        }

        private void InitField()
        {
            resolution = (int)nudResolution.Value;
            rows = gameContent.Height / resolution;
            cols = gameContent.Width / resolution;
            field = new bool[cols, rows];

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

            Text = $"Game of Life. Generation: {++currentGeneration}";
            field = newField;
            gameContent.Refresh();
        }

        private int CountNeightbours(int x, int y)
        {
            int count = 0;

            for (int i = -1; i < 2; i++)
            {
                for (int j = -1; j < 2; j++)
                {
                    int col = (x + i + cols) % cols;
                    int row = (y + j + rows) % rows;

                    bool isSelfChecking = col == x && row == y;
                    bool hasLife = field[col, row];

                    if (!isSelfChecking && hasLife) count++;
                }
            }

            return count;
        }
    }
}
