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
            int res1 = 0;
            int res2 = 0;
            int i = 0;
            StreamWriter sw = new StreamWriter("..\\..\\Тест комбинаторного покрытия условий (не пройдено).txt");
            int limCondition = 4;

            //Решение задачи
            //if (a == b && c == d && a == c)
            //{
            //    textBox5.Text = "Квадрат или ромб";
            //}
            //else if (a == c && b == d)
            //{
            //    textBox5.Text = "Параллелограмм или прямоугольник";
            //}
            //else if (a + b + c > d && b + c + d > a && a + c + d > b && a + b + d > c)
            //{
            //    textBox5.Text = "Трапеция или обыкновенный четырёхугольник";
            //}
            //else
            //{
            //    textBox5.Text = "Не четырёхугольник";
            //}

            //1 Метод покрытия операторов
            //for (int a = 1; a <= limCondition; a++)
            //{
            //    for (int b = 1; b <= limCondition; b++)
            //    {
            //        for (int c = 1; c <= limCondition; c++)
            //        {
            //            for (int d = 1; d <= limCondition; d++)
            //            {
            //                //Мутированный алгоритм
            //                if (a > b && c == d && a == c)
            //                {
            //                    res1 = 1;
            //                }
            //                else if (a > c && b == d)
            //                {
            //                    res1 = 2;
            //                }
            //                else if (a + b + c == d || b + c + d == a || a + c + d == b || a + b + d == c)
            //                {
            //                    res1 = 3;
            //                }
            //                else
            //                {
            //                    res1 = 4;
            //                }

            //                //Нормальный алгоритм
            //                if (a == b && c == d && a == c)
            //                {
            //                    res2 = 1;
            //                }
            //                else if (a == c && b == d)
            //                {
            //                    res2 = 2;
            //                }
            //                else if (a + b + c > d && b + c + d > a && a + c + d > b && a + b + d > c)
            //                {
            //                    res2 = 3;
            //                }
            //                else
            //                {
            //                    res2 = 4;
            //                }

            //                if (res1 == res2)
            //                {
            //                    i++;
            //                    sw.WriteLine(i + ") " + a + ", " + b + ", " + c + ", " + d + " --  res1 = " + res1 + ", res2 = " + res2);
            //                }
            //                textBox5.Text = i.ToString();
            //            }
            //        }
            //    }
            //}
            //sw.Close();
            //Process.Start("D:\\Study\\Тестирование\\Тест покрытия операторов (Не пройдено).txt");
            //textBox5.Text = "Готово";

            // 2 Метод покрытия условий
            //string ways = "";
            //for (int a = 1; a <= limCondition; a++)
            //{
            //    for (int b = 1; b <= limCondition; b++)
            //    {
            //        for (int c = 1; c <= limCondition; c++)
            //        {
            //            for (int d = 1; d <= limCondition; d++)
            //            {
            //                ways = "";
            //                //Мутированный алгоритм
            //                if (a > b)
            //                {
            //                    ways += "a > b, ";
            //                    if (c == d)
            //                    {
            //                        ways += "c == d, ";
            //                        if (a == c)
            //                        {
            //                            ways += "a == c, ";
            //                            res1 = 1;
            //                            goto a;
            //                        }
            //                    }
            //                }
            //                if (a > c)
            //                {
            //                    ways += "a > c, ";
            //                    if (b == d)
            //                    {
            //                        ways += "b == d, ";
            //                        res1 = 2;
            //                        goto a;
            //                    }
            //                }
            //                if (a + b + c == d)
            //                {
            //                    ways += "a + b + c == d, ";
            //                    res1 = 3;
            //                    goto a;
            //                }
            //                if (b + c + d == a)
            //                {
            //                    ways += "b + c + d == a, ";
            //                    res1 = 3;
            //                    goto a;
            //                }
            //                if (a + c + d == b)
            //                {
            //                    ways += "a + c + d == b, ";
            //                    res1 = 3;
            //                    goto a;
            //                }
            //                if (a + b + d == c)
            //                {
            //                    ways += "a + b + d == c, ";
            //                    res1 = 3;
            //                    goto a;
            //                }
            //                else
            //                {
            //                    res1 = 4;
            //                }
            //            a:
            //                //Нормальный алгоритм
            //                if (a == b)
            //                {
            //                    if (c == d)
            //                    {
            //                        if (a == c)
            //                        {
            //                            res2 = 1;
            //                            goto b;
            //                        }
            //                    }
            //                }
            //                if (a == c)
            //                {
            //                    if (b == d)
            //                    {
            //                        res2 = 2;
            //                        goto b;
            //                    }
            //                }
            //                if (a + b + c > d)
            //                {
            //                    if (b + c + d > a)
            //                    {
            //                        if (a + c + d > b)
            //                        {
            //                            if (a + b + d > c)
            //                            {
            //                                res2 = 3;
            //                                goto b;
            //                            }
            //                        }
            //                    }
            //                }
            //                //else
            //                res2 = 4;
            //            b:
            //                if (res1 == res2)
            //                {
            //                    i++;
            //                    ways = ways.Length > 0 ? ways.Remove(ways.Length - 2) : ways;
            //                    sw.WriteLine(i + ") " + a + ", " + b + ", " + c + ", " + d + " --  " + ways /* res1 = " + res1 + ", res2 = " + res2 */);
            //                }
            //                textBox5.Text = i.ToString();
            //            }
            //        }
            //    }
            //}

            // Метод комбинаторного покрытия условий
            string ways = "";
            for (int a = 1; a <= limCondition; a++)
            {
                for (int b = 1; b <= limCondition; b++)
                {
                    for (int c = 1; c <= limCondition; c++)
                    {
                        for (int d = 1; d <= limCondition; d++)
                        {
                            ways = "";
                            //Мутированный алгоритм
                            //1 решение
                            if (a > b)
                            {
                                ways += "a > b, ";
                            }
                            if (c == d)
                            {
                                ways += "c == d, ";
                            }
                            if (a == c)
                            {
                                ways += "a == c, ";
                            }
                            if (a <= b)
                            {
                                ways += "a <= b, ";
                            }
                            if (c != d)
                            {
                                ways += "c != d, ";
                            }
                            if (a != c)
                            {
                                ways += "a != c, ";
                            }
                            //2 решение
                            if (a > c)
                            {
                                ways += "a > c, ";
                            }
                            if (b == d)
                            {
                                ways += "b == d, ";
                            }
                            if (a <= c)
                            {
                                ways += "a <= c, ";
                            }
                            if (b != d)
                            {
                                ways += "b != d, ";
                            }
                            //3 решение
                            if (a + b + c == d)
                            {
                                ways += "a+b+c == d, ";
                            }
                            if (b + c + d == a)
                            {
                                ways += "b+c+d == a, ";
                            }
                            if (a + c + d == b)
                            {
                                ways += "a+c+d == b, ";
                            }
                            if (a + b + d == c)
                            {
                                ways += "a+b+d == c, ";
                            }
                            if (a + b + c != d)
                            {
                                ways += "a+b+c != d, ";
                            }
                            if (b + c + d != a)
                            {
                                ways += "b+c+d != a, ";
                            }
                            if (a + c + d != b)
                            {
                                ways += "a+c+d != b, ";
                            }
                            if (a + b + d != c)
                            {
                                ways += "a+b+d != c, ";
                            }

                            //Мутированный алгоритм
                            if (a > b && c == d && a == c)
                            {
                                res1 = 1;
                            }
                            else if (a > c && b == d)
                            {
                                res1 = 2;
                            }
                            else if (a + b + c == d || b + c + d == a || a + c + d == b || a + b + d == c)
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

                            if (res1 == res2)
                            {
                                i++;
                                ways = ways.Length > 0 ? ways.Remove(ways.Length - 2) : ways;
                                sw.WriteLine(i + ") " + a + "; " + b + "; " + c + "; " + d + " --  " + ways /* res1 = " + res1 + ", res2 = " + res2 */);
                            }
                            textBox5.Text = i.ToString();
                        }
                    }
                }
            }

            sw.Close();
            Process.Start("..\\..\\Тест комбинаторного покрытия условий (не пройдено).txt");
            textBox5.Text = "Готово";
        }
    }
}