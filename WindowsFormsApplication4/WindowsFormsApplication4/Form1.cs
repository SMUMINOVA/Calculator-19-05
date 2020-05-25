using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {
        public List<double> array;
        public double firstNumb;
        public double secondNumb;
        public string action;
        public double result;
        public double save;
        public Form1()
        {
            InitializeComponent();
            textBox1.Text = "0";
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void button7_Click(object sender, EventArgs e)
        {
            SetNumb("1");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            SetNumb("0");
        }
        private void button21_Click(object sender, EventArgs e)
        {
            SetNumb("6");
        }
        private void button23_Click(object sender, EventArgs e)
        {
            SetNumb("4");
        }

        private void button22_Click(object sender, EventArgs e)
        {
            SetNumb("5");
        }
        private void button6_Click(object sender, EventArgs e)
        {
            SetNumb("2");
        }
        private void button5_Click(object sender, EventArgs e)
        {
            SetNumb("3");
        }
        private void button15_Click(object sender, EventArgs e)
        {
            SetNumb("9");
        }

        private void button16_Click(object sender, EventArgs e)
        {
            SetNumb("8");
        }

        private void button17_Click(object sender, EventArgs e)
        {
            SetNumb("7");
        }
        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }
        private void button25_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Length == 1)
            {
                textBox1.Text = "0";
            }
            else
            {
                int length = textBox1.Text.Length - 1;
                string s = textBox1.Text;
                textBox1.Text = "";
                for(int i = 0; i < s.Length - 1; i++)
                {
                    textBox1.Text += s[i];
                }
            }
        }

        private void button26_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void button27_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            firstNumb = 0;
            secondNumb = 0;
            action = "";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text = Math.Sqrt(double.Parse(textBox1.Text)).ToString();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            firstNumb = double.Parse(textBox1.Text);
            action = "/";
            textBox1.Text = "0";
        }
        private void button24_Click(object sender, EventArgs e)
        {
            save += Calculate();
            textBox1.Text = save.ToString();
            save = 0;
        }      

        private void button20_Click(object sender, EventArgs e)
        {

            firstNumb = double.Parse(textBox1.Text);
            action = "*";
            textBox1.Text = "0";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            textBox1.Text = (double.Parse(textBox1.Text) / 100).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = (1/double.Parse(textBox1.Text)).ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            firstNumb = double.Parse(textBox1.Text);
            action = "-";
            textBox1.Text = "0";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            firstNumb = double.Parse(textBox1.Text);
            action = "+";
            textBox1.Text = "0";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if ( textBox1.Text.IndexOf( "." , 0) == -1 )
                textBox1.Text += "."; 
        }
        private void button10_Click(object sender, EventArgs e)
        {
            firstNumb = double.Parse(textBox1.Text);
            firstNumb *= (-1);
            textBox1.Text = firstNumb.ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            save = result;
            result = 0;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            save += Calculate();
            textBox1.Text = "0";
        }
        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = Calculate().ToString();
            firstNumb = 0;
            secondNumb = 0;
        }
        public double Calculate()
        {
            secondNumb = double.Parse(textBox1.Text);
            switch (action)
            {
                case "/":
                    {
                        if (secondNumb != 0)
                            result = (firstNumb / secondNumb);
                        else
                            result = 0;
                    }; break;
                case "*": result = (firstNumb * secondNumb); break;
                case "-": result = (firstNumb - secondNumb); break;
                case "+": result = (firstNumb + secondNumb); break;
            }
            return result;
        }
        public void SetNumb(string s)
        {
            if (result != 0)
            {
                textBox1.Text = "0";
                result = 0;
            }
            if (textBox1.Text == "0")
            {
                textBox1.Text = s;
            }
            else
            {
                textBox1.Text += s;
            }
        }
    }
}
