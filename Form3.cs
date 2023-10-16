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
    public partial class Form3 : Form
    {
        public static double FindK(in double u, in double v, out double k)
        {
            k = Math.Min(u + (v * 2), 3.14);
            return 0;
        }

        public static double FindU(in double a, in double b, out double u)
        {
            u = Math.Max(a, b - a);
            return 0;
        }

        public static double FindV(in double a, in double b, out double v)
        {
            v = Math.Min(a * b, a + b);
            return 0;
        }
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a, b, v, u, k;
            a = Convert.ToInt32(textBox1.Text);
            b = Convert.ToInt32(textBox2.Text);
            FindU(in a, in b, out u);
            FindV(in a, in b, out v);
            FindK(in u, in v, out k);
            label5.Text = u.ToString();
            label6.Text = v.ToString();
            label8.Text = k.ToString();
        }
    }
}
