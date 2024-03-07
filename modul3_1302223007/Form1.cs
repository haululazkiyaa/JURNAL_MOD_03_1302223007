using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace modul3_1302223007
{
    public partial class CalculatorApp1302223007 : Form
    {
        public CalculatorApp1302223007()
        {
            InitializeComponent();
        }

        String value1;
        String value2;
        String selectedOperator;
        String valueResult;

        public void CalculateOutput()
        {
            if (selectedOperator == null && value1 == null && value2 == null)
            {
                valueResult = "0";
            } 
            else if (selectedOperator == null && value1 != null && value2 == null) {
                valueResult = value1.ToString();
            }
            else if (selectedOperator != null && value1 != null && value2 == null)
            {
                valueResult = value1 + selectedOperator;
            }
            else 
            {
                valueResult = value2 + selectedOperator + value1;
            }

            labelOutput.Text = valueResult;
        }
        public void clickNumber(String value)
        {
            if (selectedOperator != null)
            {
                if (value1 == "0" && value == "0")
                {
                    value1 = null;
                }
                else
                {
                    value1 += value;
                }
            } else
            {
                value2 += value;
            }
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            if (selectedOperator == null)
            {
                selectedOperator += "+";
            }
            CalculateOutput();
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            if (value1 != null && selectedOperator != null && value2 != null)
            {
                int result = int.Parse(value1) + int.Parse(value2);
                selectedOperator = null;
                value1 = null;
                value2 = null;
                labelOutput.Text = result.ToString();
            } 
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            clickNumber("0");
            CalculateOutput();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            clickNumber("1");
            CalculateOutput();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            clickNumber("2");
            CalculateOutput();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            clickNumber("3");
            CalculateOutput();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            clickNumber("4");
            CalculateOutput();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            clickNumber("5");
            CalculateOutput();
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            clickNumber("6");
            CalculateOutput();
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            clickNumber("7");
            CalculateOutput();
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            clickNumber("8");
            CalculateOutput();
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            clickNumber("9");
            CalculateOutput();
        }
    }
}
