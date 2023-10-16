using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrameLab7
{
    public partial class Form4 : Form
    {
        public static int chetvert(in int x, in int y, out int quad)
        {
            quad = 0;
            if (x > 0 && y > 0) { quad = 1; }
            if (x < 0 && y > 0) { quad = 2; }
            if (x < 0 && y < 0) { quad = 3; }
            if (x > 0 && y < 0) { quad = 4; }
            return 0;
        }
        public Form4()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x1 = 0, y1 = 0, x2 = 0, y2 = 0, quad1, quad2;
            x1 = Convert.ToInt32(textBox1.Text);
            y1 = Convert.ToInt32(textBox2.Text);
            x2 = Convert.ToInt32(textBox4.Text);
            y2 = Convert.ToInt32(textBox3.Text);
            chetvert(in x1, in y1, out quad1);
            chetvert(in x2, in y2, out quad2);
            if (quad1 == quad2)
            {
                label8.Text = "Точки лежат в одной четверти";
            }
            else
            {
                label8.Text = "Точки НЕ лежат в одной четверти";
            }
        }
    }
}
