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
    public partial class Form2 : Form
    {
        public int ShowArray(int[,] array, int a, int b)
        {
         
            return 0;
        }
        public int RandomArray(int[,] array, int a, int b)
        {
            Random random = new Random();
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    array[i, j] = random.Next(-1, 2);
                }
            }
            return 0;
        }

        public int BelowZeroArray(int[,] array, int a, int b)
        {
            int count = 0;
            double s;
            for (int i = 0; i < a; i++)
            {
                s = 0;
                for (int j = 0; j < b; j++)
                {
                    s += array[i, j];
                }
                if (s / b < 0)
                {
                    count++;
                }
            }
            return count;
        }
        public static double Func1(double x, double y)
        {
            double a;
            a = (Math.Sqrt(Math.Abs(x - 1)) - Math.Sqrt(Math.Abs(y))) / (1 + (Math.Pow(2, x) / 2) + (Math.Pow(2, y) / 4));
            return a;
        }

        public static double Func2(double x, double z)
        {
            double b;
            b = x * (Math.Atan(z) + Math.Exp(1));
            return b;
        }

        public static int Task3(int[] array, int a)
        {
            int S = 0;
            for (int i = 0; i < a; i++)
            {
                S += array[i];
            }
            return S;
        }
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a, b;
            int[,] array;

            a = Convert.ToInt32(textBox1.Text);
            b = Convert.ToInt32(textBox2.Text);
            array = new int[a, b];

            RandomArray(array, a, b);
            string str;
            label6.Text = "";
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    str = Convert.ToString(array[i, j]);
                    label6.Text += str + " ";
                }
                label6.Text += "\n";
            }
            str = Convert.ToString(BelowZeroArray(array, a, b));
            label8.Text = str;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double x, y, z;
            string s2;
            x = Convert.ToInt32(textBox3.Text);
            y = Convert.ToDouble(textBox4.Text);
            z = Convert.ToDouble(textBox5.Text);

            s2 = Convert.ToString(Func1(x,y));
            label13.Text = s2;
            s2 = Convert.ToString(Func2(x, z));
            label14.Text = s2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int a;
            int[] array;
            Random random = new Random();

            a = Convert.ToInt32(textBox6.Text);
            array = new int[a];
            for (int i = 0; i < a; i++)
            {
                array[i] = random.Next(10);
            }
            label18.Text = "";
            for (int i = 0; i < a; i++)
            {
                label18.Text += Convert.ToString(array[i]) + " ";
            }
            label20.Text = Convert.ToString(Task3(array, a));
        }
    }
}
