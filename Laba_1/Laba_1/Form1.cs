using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       /*  interface ICalculator 
        {
            static string Sin(string data);
            static string Cos(string data);
            static string Tan(string data);
            static string Ctg(string data);
            static string Sqrt(string data);
            static string Cbrt(string data);
            static string Pow(string[] data);

        }*/

        public class Calculator
        {
            public static string Sin(string data) 
            {
                float num = Convert.ToSingle(data);
                string result = $"{Math.Sin((num*Math.PI)/180)}";
                return result;
            }
            public static string Cos(string data)
            {
                float num = Convert.ToSingle(data);
                string result = $"{Math.Cos((num * Math.PI) / 180)}";
                return result;
            }
            public static string Tan(string data)
            {
                float num = Convert.ToSingle(data);
                string result = $"{Math.Tan((num * Math.PI) / 180)}";
                return result;
            }
            public static string Ctg(string data)
            {
                float num = Convert.ToSingle(data);
                string result = $"{1.0 / Math.Tan((num * Math.PI) / 180)}";
                return result;
            }
            public static string Sqrt(string data)
            {
                float num = Convert.ToSingle(data);
                string result = $"{Math.Sqrt(num)}";
                return result;
            }
            public static string Cbrt(string data)
            {
                float num = Convert.ToSingle(data);
                string result = $"{Math.Pow(num, 1.0/3.0)}";
                return result;
            }
            public static string Pow(string[] data) 
            {
                float num1 = Convert.ToSingle(data[0]);
                int num2 = Convert.ToInt32(data[2]);
                string result = $"{Math.Pow(num1, num2)}";
                return result;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void buttonClean_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void buttonDot_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Contains(",")) 
            {
                textBox1.Text += ",";
            }
        }

        private void buttonSin_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Contains("sin "))
            {
                textBox1.Text += "sin ";
            }
        }

        private void buttonEquals_Click(object sender, EventArgs e)
        {
            string[] data = textBox1.Text.Split(' ');
            textBox1.Clear();
            if (data[1] == "^")
            {
                textBox1.Text += Calculator.Pow(data);
            }
            else
            {
                switch (data[0])
                {
                    case "sin":
                        {
                            textBox1.AppendText(Calculator.Sin(data[1]));
                            break;
                        }
                    case "cos":
                        {
                            textBox1.AppendText(Calculator.Cos(data[1]));
                            break;
                        }
                    case "tan":
                        {
                            textBox1.AppendText(Calculator.Tan(data[1]));
                            break;
                        }
                    case "ctg":
                        {
                            textBox1.AppendText(Calculator.Ctg(data[1]));
                            break;
                        }
                    case "sqrt":
                        {
                            textBox1.AppendText(Calculator.Sqrt(data[1]));
                            break;
                        }
                    case "cbrt":
                        {
                            textBox1.AppendText(Calculator.Cbrt(data[1]));
                            break;
                        }
                }
                    
            }
        }

        private void buttonCos_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Contains("cos "))
            {
                textBox1.Text += "cos ";
            }
        }

        private void buttonTan_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Contains("tan "))
            {
                textBox1.Text += "tan ";
            }
        }

        private void buttonCtg_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Contains("ctg "))
            {
                textBox1.Text += "ctg ";
            }
        }

        private void buttonSqrt_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Contains("sqrt "))
            {
                textBox1.Text += "sqrt ";
            }
        }

        private void buttonCbrt_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Contains("cbrt "))
            {
                textBox1.Text += "cbrt ";
            }
        }

        private void buttonPow_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Contains(" ^ "))
            {
                textBox1.Text += " ^ ";
            }
        }
    }
}
