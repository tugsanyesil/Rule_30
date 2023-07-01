using System;
using System.Drawing;
using System.Windows.Forms;

namespace Rule_30
{
    public partial class Form_Rule_30 : Form
    {
        public Form_Rule_30()
        {
            InitializeComponent();
            TextBox_Size_Length.Text = SizeLength.ToString();
            TextBox_Array_Length.Text = ArrayLength.ToString();
        }

        Bitmap MatrixBitmap;
        bool[,] Matrix;
        int SizeLength = 1;
        int ArrayLength = 500;
        int Padding = 12;
        private void Form_Rule_30_Load(object sender, EventArgs e)
        {
            Size UnitSize = new Size(SizeLength, SizeLength);
            Matrix = new bool[ArrayLength, ArrayLength * 2 + 1];
            Matrix[0, ArrayLength] = true;
            Matrix = Rule_30(Matrix);
            MatrixBitmap = Matrix_2_Bitmap(Matrix, UnitSize);
            PictureBox_Matrix.Size = MatrixBitmap.Size;
            PictureBox_Matrix.Image = MatrixBitmap;
            ClientSize = new Size(PictureBox_Matrix.Location.X + PictureBox_Matrix.Size.Width + Padding, PictureBox_Matrix.Location.Y + PictureBox_Matrix.Size.Height + Padding);
        }

        public bool[,] Rule_30(bool[,] Matrix)
        {
            int height = Matrix.GetLength(0);
            int width = Matrix.GetLength(1);
            bool right;
            bool middle;
            bool left;
            for (int i = 1; i < height; i++)
            {
                for (int j = 1; j < width - 1; j++)
                {
                    right = Matrix[i - 1, j + 1];
                    middle = Matrix[i - 1, j];
                    left = Matrix[i - 1, j - 1];

                    Matrix[i, j] = (left == true && middle == false && right == false) || (left == false && middle == true && right == false) || (left == false && middle == false && right == true) || (left == false && middle == true && right == true);
                }
            }
            return Matrix;
        }

        public Bitmap Matrix_2_Bitmap(bool[,] Matrix, Size UnitSize)
        {
            int height = Matrix.GetLength(0);
            int width = Matrix.GetLength(1);
            Bitmap Bitmap = new Bitmap(width * UnitSize.Width, height * UnitSize.Height);
            using (Graphics g = Graphics.FromImage(Bitmap))
            {
                g.Clear(Color.White);
                for (int i = 0; i < Matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < Matrix.GetLength(1); j++)
                    {
                        if (Matrix[i, j])
                        {
                            g.FillRectangle(Brushes.Black, j * UnitSize.Width, i * UnitSize.Height, UnitSize.Width, UnitSize.Height);
                        }
                    }
                }
            }

            return Bitmap;
        }

        private void TextBox_Size_Length_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (int.TryParse(TextBox_Size_Length.Text, out int result))
                {
                    SizeLength = result;
                    Form_Rule_30_Load(null, EventArgs.Empty);
                }
            }
        }

        private void TextBox_Array_Length_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (int.TryParse(TextBox_Array_Length.Text, out int result))
                {
                    ArrayLength = result;
                    Form_Rule_30_Load(null, EventArgs.Empty);
                }
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            PictureBox_Matrix.Image.Save("Rule_30.png");
        }
    }
}
