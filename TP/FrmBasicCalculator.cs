using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CalculatorPrivateAssembly;

namespace TP
{
    public partial class FrmBasicCalculator : Form
    {
        public FrmBasicCalculator()
        {
            InitializeComponent();
        }

        private void FrmBasicCalculator_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (CBoperator.Text == "+" ) 
            {
                label3.Text = BasicComputation.Add(float.Parse(num1.Text), float.Parse(num2.Text)).ToString(); 
            }
            else if (CBoperator.Text == "-" )
            {
                label3.Text = BasicComputation.Subtract(float.Parse(num1.Text), float.Parse(num2.Text)).ToString();
            }
            else if (CBoperator.Text == "*" )
            {
                label3.Text = BasicComputation.Multiply(float.Parse(num1.Text), float.Parse(num2.Text)).ToString();
            }
            else if (CBoperator.Text == "/" )
            {
                label3.Text = BasicComputation.Divide(float.Parse(num1.Text), float.Parse(num2.Text)).ToString();
            }
            
            
            
        }
    }
}
