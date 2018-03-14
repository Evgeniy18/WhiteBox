using System;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace WhiteBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //float a = (float)Convert.ToDouble(textBox1.Text);
            //float b = (float)Convert.ToDouble(textBox2.Text);
            //float c = (float)Convert.ToDouble(textBox3.Text);
            //float d = (float)Convert.ToDouble(textBox4.Text);
            int res1 = 0;
            int res2 = 0;
            int i = 0;
            StreamWriter sw = new StreamWriter("D:\\Study\\Тестирование\\Тест мутации квадрата.txt");
            int limCondition = 4;

            sw.WriteLine("a > b && c == d && a == c, для квадрата");
            for (int a = 1; a <= limCondition; a++)
            {
                for (int b = 1; b <= limCondition; b++)
                {
                    for (int c = 1; c <= limCondition; c++)
                    {
                        for (int d = 1; d <= limCondition; d++)
                        {
                            //Мутированный алгоритм
                            if (a > b && c == d && a == c)
                            {
                                res1 = 1;
                            }
                            else if (a == c && b == d)
                            {
                                res1 = 2;
                            }
                            else if (a + b + c > d && b + c + d > a && a + c + d > b && a + b + d > c)
                            {
                                res1 = 3;
                            }
                            else
                            {
                                res1 = 4;
                            }

                            //Нормальный алгоритм
                            if (a == b && c == d && a == c)
                            {
                                res2 = 1;
                            }
                            else if (a == c && b == d)
                            {
                                res2 = 2;
                            }
                            else if (a + b + c > d && b + c + d > a && a + c + d > b && a + b + d > c)
                            {
                                res2 = 3;
                            }
                            else
                            {
                                res2 = 4;
                            }

                            if (res1 != res2)
                            {
                                i++;
                                sw.WriteLine(i + ") " + a + ", " + b + ", " + c + " " + d + " - " + res1);
                                //sw.WriteLine(i + ") a = " + a + ", b = " + b + ", c = " + c + " d = " + d);
                            }
                            textBox5.Text = i.ToString();
                        }
                    }
                }
            }
            sw.Close();
            Process.Start("D:\\Study\\Тестирование\\Тест мутации квадрата.txt");
            textBox5.Text = "Готово";
            //if (a == b && c == d && a == c)
            //{
            //    textBox5.Text = "Квадрат или ромб";
            //}
            //else if (a == c && b == d)
            //{
            //    textBox5.Text = "Параллелограмм";
            //}
            //else if (a + b + c > d && b + c + d > a && a + c + d > b && a + b + d > c)
            //{
            //    textBox5.Text = "Трапеция или обыкновенный четырёхугольник";
            //}
            //else
            //{
            //    textBox5.Text = "Не четырёхугольник";
            //}
        }
    }
}