using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1_cw2_sam
{
    public partial class Form1 : Form
    {
        string sign;
        double num1;
        double num2;
        bool startNewNumber = true;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NumberBt_ckilck("1");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NumberBt_ckilck("2");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            NumberBt_ckilck("3");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            NumberBt_ckilck("4");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            NumberBt_ckilck("5");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            NumberBt_ckilck("6");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            NumberBt_ckilck("7");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            NumberBt_ckilck("8");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            NumberBt_ckilck("9");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            NumberBt_ckilck("0");
        }

        private void NumberBt_ckilck(string number)
        {
            if (startNewNumber == false)
            {
                textBox1.Text += number;
            }
            else
            {
                textBox1.Text = number;
                startNewNumber = false;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            num2 = Convert.ToDouble(textBox1.Text);
            label1.Text = String.Empty;
            switch(sign)
            {
                case "+":
                    textBox1.Text = Convert.ToString(num1 + num2);
                    break;
                case "-":
                    textBox1.Text = Convert.ToString(num1 - num2);
                    break;
                case "*":
                    textBox1.Text = Convert.ToString(num1 * num2);
                    break;
                case "/":
                    if (num2 == 0)
                    {
                        textBox1.Text = "bląd";
                    }
                    else
                    {
                        textBox1.Text = Convert.ToString(num1 / num2);
                    }
                    break;
            }
            sign = String.Empty;
            startNewNumber = true;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Operation("+");
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Operation("*");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Operation("/");
        }
        private void button13_Click(object sender, EventArgs e)
        {
            Operation("-");
        }



        private void button14_Click(object sender, EventArgs e)
        {
           if(textBox1.Text.IndexOf(',') == -1)
            {
                textBox1.Text += ",";
                startNewNumber = false;
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            label1.Text = String.Empty;
            sign = String.Empty;
            startNewNumber = true;
        }

        private void Operation(string sing)
        {
            num1 = Convert.ToDouble(textBox1.Text);
            label1.Text = textBox1.Text;
            label1.Text += sing;
            this.sign = sing;
            startNewNumber = true;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
