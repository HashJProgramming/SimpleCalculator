using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int operators;
        string firstnumber;
        string secondnumber;
        private void button16_Click(object sender, EventArgs e)
        {
            //Clear
            textBox1.Clear();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            // number 0
            textBox1.Text +="0";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // number 1
            textBox1.Text += "1";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            // number 2
            textBox1.Text += "2";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            // number 3
            textBox1.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // number 4
            textBox1.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // number 5
            textBox1.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // number 6
            textBox1.Text += "6";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // number 7
            textBox1.Text += "7";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // number 8
            textBox1.Text += "8";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // number 9
            textBox1.Text += "9";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            // Devide
            if (firstnumber != null)
            {
                operators = 4;
            }
            else
            {
                operators = 4;
                firstnumber = textBox1.Text;
                textBox1.Clear();
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            // addition
            if (firstnumber != null)
            {
                operators = 1;
            }
            else
            {
                operators = 1;
                firstnumber = textBox1.Text;
                textBox1.Clear();
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            // subtraction
            if (firstnumber != null)
            {
                operators = 2;
            }
            else
            {
                operators = 2;
                firstnumber = textBox1.Text;
                textBox1.Clear();
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            // multiplication
            if (firstnumber != null)
            {
                operators = 3;
            }
            else
            {
                operators = 3;
                firstnumber = textBox1.Text;
                textBox1.Clear();
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            secondnumber = textBox1.Text;
            
            // Equal
           
            if (operators == 1)
            {
                int result = Convert.ToInt32(firstnumber) + Convert.ToInt32(secondnumber);
                textBox1.Text = result.ToString();
                firstnumber = null;
                secondnumber = null;
            }
            else if (operators == 2)
            {
                int result = Convert.ToInt32(firstnumber) - Convert.ToInt32(secondnumber);
                textBox1.Text = result.ToString();
                firstnumber = null;
                secondnumber = null;
            }
            else if (operators == 3)
            {
                int result = Convert.ToInt32(firstnumber) * Convert.ToInt32(secondnumber);
                textBox1.Text = result.ToString();
                firstnumber = null;
                secondnumber = null;
            }
            else if (operators == 4)
            {
                int result = Convert.ToInt32(firstnumber) / Convert.ToInt32(secondnumber);
                textBox1.Text = result.ToString();
                firstnumber = null;
                secondnumber = null;
            }
        }
    }
}
