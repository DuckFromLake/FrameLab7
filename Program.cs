using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrameLab7
{
    internal class Program
    {
        public static int ShowArray(int[,] array, int a, int b)
        {
            for (int i = 0; i < a; i++ )
            {
                for (int j = 0; j < b; j++)
                {
                    Console.Write(array[i,j] + " ");
                }
                Console.WriteLine();
            }
            return 0;
        }
        public static int RandomArray(int[,] array, int a, int b)
        {
            Random random = new Random();
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    array[i, j] = random.Next(-1,2);
                }
            }
            return 0;
        }

        public static int BelowZeroArray(int[,] array, int a, int b)
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
                if (s/b < 0)
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


        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            string s, s1;
            int v = -1;
            while (v != 0)
            {
                Console.Clear();
                Console.WriteLine("1) Консольное приложение \n2) Windows Forms \n\n0) Выход \n\nВведите номер метода : ");
                s = Console.ReadLine();
                v = Convert.ToInt32(s);
                switch (v)
                {
                    case 1:
                        {
                            Console.Clear();
                            int v1 = -1;
                            string sn;
                            while (v1 != 0)
                            {
                                Console.Clear();
                                Console.WriteLine("1) Задание 1.1\n2) Задание 1.2\n3) Задание 1.3 \n\n0) Выход \n\nВведите номер метода : ");
                                sn = Console.ReadLine();
                                v1 = Convert.ToInt32(sn);
                                switch (v1)
                                {
                                    case 1:
                                        {
                                            Console.Clear();
                                            int a, b;
                                            int[,] array;

                                            Console.WriteLine("Введите количество строк массива: ");
                                            s1 = Console.ReadLine();
                                            a = Convert.ToInt32(s1);
                                            Console.WriteLine("Введите количество столбцов массива: ");
                                            s1 = Console.ReadLine();
                                            b = Convert.ToInt32(s1);
                                            array = new int[a, b];

                                            RandomArray(array, a, b);
                                            Console.WriteLine("Массив: ");
                                            ShowArray(array, a , b);
                                            Console.WriteLine("Количество строк, у которых среднее арифметическое элементов меньше 0: " + BelowZeroArray(array, a, b));

                                            Console.WriteLine("Нажмите любую кнопку для продолжения...");
                                            s1 = Console.ReadLine();
                                            break;

                                        }
                                    case 2:
                                        {
                                            Console.Clear();
                                            double x, y, z;
                                            string s2;
                                            Console.WriteLine("Введите x: ");
                                            s2 = Console.ReadLine();
                                            x = Convert.ToDouble(s2);
                                            Console.WriteLine("Введите y: ");
                                            s2 = Console.ReadLine();
                                            y = Convert.ToDouble(s2);
                                            Console.WriteLine("Введите z: ");
                                            s2 = Console.ReadLine();
                                            z = Convert.ToDouble(s2);

                                            Console.WriteLine("a = " + Func1(x,y));
                                            Console.WriteLine("b = " + Func2(x,z));
                                            Console.WriteLine("Нажмите любую кнопку для продолжения...");
                                            s1 = Console.ReadLine();
                                            break;

                                        }
                                    case 3:
                                        {
                                            Console.Clear();
                                            int a;
                                            int[] array;
                                            Random random = new Random();
                                            Console.WriteLine("Введите размер массива: ");
                                            s1 = Console.ReadLine();
                                            a = Convert.ToInt32(s1);
                                            array = new int[a]; 
                                            for (int i = 0; i < a; i++)
                                            {
                                                array[i] = random.Next(10);
                                            }
                                            Console.Write("Массив: ");
                                            for (int i = 0; i < a; i++)
                                            {
                                               Console.Write(array[i] + " ");
                                            }
                                            Console.WriteLine();
                                            Console.WriteLine("Cуммв всех элементов равна: " + Task3(array, a));
                                            Console.WriteLine("Нажмите любую кнопку для продолжения...");
                                            s1 = Console.ReadLine();
                                            break;

                                        }
                                    case 0:
                                        {
                                            Console.Clear();
                                            break;
                                        }

                                    default:
                                        {
                                            Console.Clear();
                                            Console.WriteLine("Введено невернрое значение!");
                                            Console.WriteLine("Нажмите любую кнопку для продолжения...");
                                            s = Console.ReadLine();
                                            break;
                                        }
                                }
                            }
                            break;
                        }
                    case 2:
                        {
                            Console.Clear();
                            Application.Run(new Form1());
                            Console.WriteLine("Нажмите любую кнопку для продолжения...");
                            s = Console.ReadLine();
                            break;
                        }

                    case 0:
                        {
                            Console.Clear();
                            break;
                        }

                    default:
                        {
                            Console.Clear();
                            Console.WriteLine("Введено невернрое значение!");
                            Console.WriteLine("Нажмите любую кнопку для продолжения...");
                            s = Console.ReadLine();
                            break;
                        }

                }
            }
        }
    }
}
