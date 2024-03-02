using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Form1 : Form
    {
        int sizeCells = 4;
        int[,] fieldColors;
        int countRows = 1;
        public Form1()
        {
            InitializeComponent();
            Init();
        }

        void Init()
        {
            ClientSize = new Size(750, 600);
            fieldColors = new int[(ClientSize.Width - 150) / sizeCells, ClientSize.Height / sizeCells];
            MouseDown += Draw;
            DoubleBuffered = true;
        }

        private void Draw(object sender, MouseEventArgs e)
        {
            var thisX = e.X;
            fieldColors[0, thisX / sizeCells] = fieldColors[0, thisX / sizeCells] == 1 ? 0 : 1;
            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            InitCells(e.Graphics);
            InitGrid(e.Graphics);
        }

        private void InitGrid(Graphics g)
        {
            for (int i = 0; i <= countRows; i++)
            {
                g.DrawLine(new Pen(Color.Black, 1), new Point(0, sizeCells * i), new Point(ClientSize.Width - 150, sizeCells * i));
            }
            for (int i = 0; i <= (ClientSize.Width - 150) / sizeCells; i++)
            {
                g.DrawLine(new Pen(Color.Black, 1), new Point(sizeCells * i, 0), new Point(sizeCells * i, sizeCells * countRows));
            }
        }

        private void InitCells(Graphics g)
        {
            for (int i = 0; i < countRows; i++)
            {
                for (int j = 0; j < (ClientSize.Width - 150) / sizeCells; j++)
                {
                    g.DrawLine(new Pen(fieldColors[i, j] == 1 ? Color.Black : Color.White, sizeCells), sizeCells * j, sizeCells * i + sizeCells / 2, sizeCells * j + sizeCells, sizeCells * i + sizeCells / 2);
                }
            }
        }
        private void masked_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (int.Parse(masked.Text) > 255)
                {
                    masked.Text = "255";
                }
            }
            catch { }
        }
        string Converter()
        {
            var binarySys = "";
            var decimalSys = int.Parse(masked.Text);
            while (decimalSys >= 2)
            {
                binarySys = decimalSys % 2 + binarySys;
                decimalSys /= 2;
            }

            if (decimalSys == 1) binarySys = 1 + binarySys;

            var tempLength = binarySys.Length;
            for (int i = 0; i < 8 - tempLength; i++)
            {
                binarySys = 0 + binarySys;
            }
            return binarySys;
        }
        private void btResult_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            irows = 1;
            for (int i = 0; i < countRows; i++)
            {
                for (int j = 0; j < (ClientSize.Width - 150) / sizeCells; j++)
                {
                    fieldColors[i, j] = 0;
                }
            }
            Invalidate();
        }
        int irows = 1;
        private void timer1_Tick(object sender, EventArgs e)
        {
            var rule = Converter();
            countRows = ClientSize.Height / sizeCells;
            if ((irows < countRows) && (timer1.Enabled == true))
            {
                for (int j = 0; j < (ClientSize.Width - 150) / sizeCells; j++)
                {
                    var left = j - 1;
                    var right = j + 1;
                    if (j == (ClientSize.Width - 150) / sizeCells - 1)
                    {
                        right = 0;
                    }
                    if (j == 0)
                    {
                        left = (ClientSize.Width - 150) / sizeCells - 1;
                    }
                    if (fieldColors[irows - 1, left].ToString() + fieldColors[irows - 1, j].ToString() + fieldColors[irows - 1, right].ToString() == "111")
                    {
                        fieldColors[irows, j] = int.Parse(rule[0].ToString());
                    }
                    if (fieldColors[irows - 1, left].ToString() + fieldColors[irows - 1, j].ToString() + fieldColors[irows - 1, right].ToString() == "110")
                    {
                        fieldColors[irows, j] = int.Parse(rule[1].ToString());
                    }
                    if (fieldColors[irows - 1, left].ToString() + fieldColors[irows - 1, j].ToString() + fieldColors[irows - 1, right].ToString() == "101")
                    {
                        fieldColors[irows, j] = int.Parse(rule[2].ToString());
                    }
                    if (fieldColors[irows - 1, left].ToString() + fieldColors[irows - 1, j].ToString() + fieldColors[irows - 1, right].ToString() == "100")
                    {
                        fieldColors[irows, j] = int.Parse(rule[3].ToString());
                    }
                    if (fieldColors[irows - 1, left].ToString() + fieldColors[irows - 1, j].ToString() + fieldColors[irows - 1, right].ToString() == "011")
                    {
                        fieldColors[irows, j] = int.Parse(rule[4].ToString());
                    }
                    if (fieldColors[irows - 1, left].ToString() + fieldColors[irows - 1, j].ToString() + fieldColors[irows - 1, right].ToString() == "010")
                    {
                        fieldColors[irows, j] = int.Parse(rule[5].ToString());
                    }
                    if (fieldColors[irows - 1, left].ToString() + fieldColors[irows - 1, j].ToString() + fieldColors[irows - 1, right].ToString() == "001")
                    {
                        fieldColors[irows, j] = int.Parse(rule[6].ToString());
                    }
                    if (fieldColors[irows - 1, left].ToString() + fieldColors[irows - 1, j].ToString() + fieldColors[irows - 1, right].ToString() == "000")
                    {
                        fieldColors[irows, j] = int.Parse(rule[7].ToString());
                    }
                }
                Invalidate();
                irows += 1;
            }
            else
            {
                timer1.Stop();
                irows = 1;
            }
        }
    }
}
