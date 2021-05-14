using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        Double value = 0;
        String operation = "";
        bool operation_pressed = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            if ((result.Text == "0") || (operation_pressed))
                result.Clear();

            operation_pressed = false;
            Button a = (Button)sender;
            if (a.Text == ".")
            {
                if (!result.Text.Contains("."))
                    result.Text = result.Text + a.Text;
            }
            else
                result.Text = result.Text + a.Text;
        }

        private void button21_Click(object sender, EventArgs e)
        {

        }

        private void button24_Click(object sender, EventArgs e)
        {
            result.Text = "0";
        }


        private void button19_Click(object sender, EventArgs e)
        {
            result.Text = "0";
            value = 0;
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button a = (Button)sender;

            if (value != 0)
            {
                if (a.Text == "√")
                    result.Text = Math.Sqrt(Double.Parse(result.Text)).ToString();
                equal.PerformClick();
                operation_pressed = true;
                operation = a.Text;
                equation.Text = value + " " + operation;
            }
            else if (a.Text == "√")
            {
                result.Text = Math.Sqrt(Double.Parse(result.Text)).ToString();
                value = Math.Sqrt(Double.Parse(result.Text));
            }

            else
            {
                operation = a.Text;
                value = Double.Parse(result.Text);
                operation_pressed = true;
                equation.Text = value + " " + operation;
            }
            _ = label2.Focus();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            equation.Text = "";
            switch (operation)
            {
                case "+":
                    result.Text = (value + Double.Parse(result.Text)).ToString();
                    break;
                case "-":
                    result.Text = (value - Double.Parse(result.Text)).ToString();
                    break;
                case "*":
                    result.Text = (value * Double.Parse(result.Text)).ToString();
                    break;
                case "/":
                    result.Text = (value / Double.Parse(result.Text)).ToString();
                    break;
                default:
                    break;
                case " √":
                    result.Text = (Math.Sqrt(double.Parse(result.Text)).ToString());
                    break;

                case "%":
                    result.Text = (1 / value).ToString();
                    break;


            }
            value = Int32.Parse(result.Text);
            operation = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {

            switch (e.KeyChar.ToString())
            {
                case "0":
                    zero.PerformClick();
                    break;
                case "1":
                    one.PerformClick();
                    break;
                case "2":
                    two.PerformClick();
                    break;
                case "3":
                    three.PerformClick();
                    break;
                case "4":
                    four.PerformClick();
                    break;
                case "5":
                    five.PerformClick();
                    break;
                case "6":
                    six.PerformClick();
                    break;
                case "7":
                    seven.PerformClick();
                    break;
                case "8":
                    eight.PerformClick();
                    break;
                case "9":
                    nine.PerformClick();
                    break;
                case "+":
                    plus.PerformClick();
                    break;
                case "-":
                    min.PerformClick();
                    break;
                case "*":
                    times.PerformClick();
                    break;
                case "/":
                    div.PerformClick();
                    break;
                case "=":
                    equal.PerformClick();
                    break;
                case ".":
                    dec.PerformClick();
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Calculate_Click(object sender, EventArgs e)
        {

            decimal MemoryStore = 0;
            Button membutton = (Button)sender;
            string ButtonText = membutton.Text;
            decimal EndResult = 0;



            {


                if (ButtonText == "button20")
                {
                    MemoryStore = 0;
                    return;
                }

                if (ButtonText == "button22")
                {
                    result.Text = MemoryStore.ToString();
                    return;
                }

                if (ButtonText == "button21")
                {
                    MemoryStore -= EndResult;
                    return;
                }

                if (ButtonText == "button23")
                {
                    MemoryStore += EndResult;
                    return;

                }
            }


        }
    }
}

//private void button11_Click(object sender, EventArgs e)
//{
//    result.Text = result.Text + "3";
//}

//private void button9_Click(object sender, EventArgs e)
//{
//    result.Text = result.Text + "2";
//}

//private void button8_Click(object sender, EventArgs e)
//{
//    result.Text = result.Text + "4";
//}

//private void button7_Click(object sender, EventArgs e)
//{
//    result.Text = result.Text + "5";
//}

//private void button2_Click(object sender, EventArgs e)
//{
//    result.Text = result.Text + "6";
//}

//private void button1_Click(object sender, EventArgs e)
//{
//    result.Text = result.Text + "7";
//}

//private void button10_Click(object sender, EventArgs e)
//{
//    result.Text = result.Text + "8";
//}

//private void button3_Click(object sender, EventArgs e)
//{
//    result.Text = result.Text + "9";
//}

//private void button5_Click_1(object sender, EventArgs e)
//{
//    result.Text = result.Text + "0";
//}

//private void button4_Click(object sender, EventArgs e)
//{
//    result.Text = result.Text + ".";
//}
