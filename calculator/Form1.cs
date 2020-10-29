using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        float a, b; //а - первое введеное число, b - результат операции
        int operation; //номер операции 1 - "+", 2 - "-", 3 - "*", 4 - "/"
        bool sign; //знак числа
        private void calculate()
        {
            switch (operation)
            {
                case 1:
                    b = a + float.Parse(textBox1.Text);
                    textBox1.Text = b.ToString();
                    break;
                case 2:
                    b = a - float.Parse(textBox1.Text);
                    textBox1.Text = b.ToString();
                    break;
                case 3:
                    b = a * float.Parse(textBox1.Text);
                    textBox1.Text = b.ToString();
                    break;
                case 4:
                    float divider;
                    divider = float.Parse(textBox1.Text);
                    if (divider == 0.0) MessageBox.Show("Деление на ноль!");
                    else
                    {
                        b = a / divider;
                        textBox1.Text = b.ToString();
                    }
                    break;

                default:
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 3;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 4;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 5;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 6;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 7;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 8;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 9;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 0;
        }

        //сложение
        private void button11_Click(object sender, EventArgs e)
        {
            a = float.Parse(textBox1.Text);
            textBox1.Clear();
            operation = 1;
            label1.Text = a.ToString() + "+";
            sign = true;
        }

        //вычитание
        private void button12_Click(object sender, EventArgs e)
        {
            a = float.Parse(textBox1.Text);
            textBox1.Clear();
            operation = 2;
            label1.Text = a.ToString() + "-";
            sign = true;
        }

        //умножение
        private void button13_Click(object sender, EventArgs e)
        {
            a = float.Parse(textBox1.Text);
            textBox1.Clear();
            operation = 3;
            label1.Text = a.ToString() + "*";
            sign = true;
        }

        //деление
        private void button14_Click(object sender, EventArgs e)
        {
            a = float.Parse(textBox1.Text);
            textBox1.Clear();
            operation = 4;
            label1.Text = a.ToString() + "/";
            sign = true;
        }

        //очистка
        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            label1.Text = "";
        }

        //удаление последнего символа
        private void button17_Click(object sender, EventArgs e)
        {
            int length = textBox1.Text.Length - 1;
            string text = textBox1.Text;
            textBox1.Clear();
            for (int i = 0; i < length; i++)
            {
                textBox1.Text += text[i];
            }
        }
        //изменение знака числа
        private void button18_Click(object sender, EventArgs e)
        {
            if (sign == true)
            {
                textBox1.Text = "-" + textBox1.Text;
                sign = false;
            }
            else if (sign == false)
            {
                textBox1.Text = textBox1.Text.Replace("-", "");
                sign = true;
            }
        }

        //добавление дробной части
        private void button19_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.IndexOf(',') <0)//проверяем нет ли уже запятой
            {
                textBox1.Text += ",";
            }
        }

        //получить результат
        private void button15_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text != "") 
                calculate();
            else 
                MessageBox.Show("Введите число!");
            label1.Text = "";
        }
    }
}
