using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ch2Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {//removed button

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {//addition
            decimal input1;
            decimal input2;
            if (!(Decimal.TryParse(txtInput.Text, out input1)))
            {
                MessageBox.Show("Please Enter Numeric Value", "Error!");
                txtInput.Focus();
            }
            else if (!(Decimal.TryParse(txtInput2.Text, out input2)))
            {
                MessageBox.Show("Please Enter Numeric Value", "Error!");
                txtInput2.Focus();
            }
            else
            {
                string result = Convert.ToString(input1 + input2);
                MessageBox.Show(result, "Result");
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {//subtraction
            decimal input1;
            decimal input2;
            if (!(Decimal.TryParse(txtInput.Text, out input1)))
            {
                MessageBox.Show("Please Enter Numeric Value", "Error!");
                txtInput.Focus();
            }
            else if (!(Decimal.TryParse(txtInput2.Text, out input2)))
            {
                MessageBox.Show("Please Enter Numeric Value", "Error!");
                txtInput2.Focus();
            }
            else
            {
                string result = Convert.ToString(input1 - input2);
                MessageBox.Show(result, "Result");
            }
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {//multiplication
            decimal input1;//variable declaration
            decimal input2;

            //data validation
            if (!(Decimal.TryParse(txtInput.Text, out input1)))
            {
                //display error on bad data
                MessageBox.Show("Please Enter Numeric Value", "Error!");
                //return to input box with bad data to attempt new submission
                txtInput.Focus();
            }
            else if (!(Decimal.TryParse(txtInput2.Text, out input2)))
            {
                //display error on bad data
                MessageBox.Show("Please Enter Numeric Value", "Error!");
                //return to input box with bad data to attempt new submission
                txtInput2.Focus();
            }
            else
            {
                string result = Convert.ToString(input1 * input2);
                MessageBox.Show(result, "Result");
            }
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {//division
            decimal input1;
            decimal input2;
            if (!(Decimal.TryParse(txtInput.Text, out input1)))
            {
                //display error on bad data
                MessageBox.Show("Please Enter Numeric Value", "Error!");
                //return to input box with bad data to attempt new submission
                txtInput.Focus();
            }
            else if (!(Decimal.TryParse(txtInput2.Text, out input2)))
            {
                //display error on bad data
                MessageBox.Show("Please Enter Numeric Value", "Error!");
                //return to input box with bad data to attempt new submission
                txtInput2.Focus();
            }
            else
            {
                string result = Convert.ToString(input1 / input2);
                MessageBox.Show(result, "Result");
            }

        }

       

        private void btnExponent_Click(object sender, EventArgs e)
        {
            //exponentials
            double input1;
            double input2;
            if (!(Double.TryParse(txtInput.Text, out input1)))
            {
                //display error on bad data
                MessageBox.Show("Please Enter Numeric Value", "Error!");
                //return to input box with bad data to attempt new submission
                txtInput.Focus();
            }
            else if (!(Double.TryParse(txtInput2.Text, out input2)))
            {
                //display error on bad data
                MessageBox.Show("Please Enter Numeric Value", "Error!");
                //return to input box with bad data to attempt new submission
                txtInput2.Focus();
            }
            else
            {
                string result = Convert.ToString(Math.Pow(input1,input2));
                MessageBox.Show(result, "Result");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
                //modulus calculation
            float input1;
            float input2;
            if (!(float.TryParse(txtInput.Text, out input1)))
            {
                //display error on bad data
                MessageBox.Show("Please Enter Numeric Value", "Error!");
                //return to input box with bad data to attempt new submission
                txtInput.Focus();
            }
            else if (!(float.TryParse(txtInput2.Text, out input2)))
            {
                //display error on bad data
                MessageBox.Show("Please Enter Numeric Value", "Error!");
                //return to input box with bad data to attempt new submission
                txtInput2.Focus();
            }
            else
            {
                string result = (input1/input2).ToString("n0") + " r: " + 
                    (input1 - (input1 % input2)).ToString("n0");
                MessageBox.Show(result, "Result");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtInput.Text = "";
            txtInput2.Text = "";
        }
    }
}
