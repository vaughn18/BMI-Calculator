using System;
using System.Windows.Forms;

namespace BMICalculator
{
    public partial class Form1 : Form
    {
        BMIClass calculation = new BMIClass();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your BMI is" + " " + calculation.Calculate(txtbxHeight.Text, txtbxWeight.Text));
        }
    }
}
