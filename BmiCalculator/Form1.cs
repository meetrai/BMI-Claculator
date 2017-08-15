using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*Name:Manmeet Singh
 Student no. : 300932996
 Description:Building a BMI calculator
 version :0.3 Added public variables and added fuctionality to the Metric radio button*/
namespace BmiCalculator
{
    public partial class TheCalculatorForm : Form
    {
        public TheCalculatorForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            UnitLabel.Text = "lbs";
            Unit2Label.Text = "inches";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ImperialRadio_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MetricRadioButtons_CheckedChanged(object sender, EventArgs e)
        {
            UnitLabel.Text = "kg";
            Unit2Label.Text = "m";
        }

        private void HeightTextBox_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void WeightTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_3(object sender, EventArgs e)
        {

        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            double height = Convert.ToDouble(HeightTextBox.Text);
            double weight = Convert.ToDouble(WeightTextBox.Text);
            double bmi;
            if (ImperialButton.Checked)
            {
                bmi = (weight * 703) / (height * height);
                string Result = Convert.ToString(Math.Round(bmi, 2)) + " - ";
                if (bmi < 18.5)
                { ResultTextBox.Text = Result + " YOU ARE UNDERWEIGHT"; }
                else if (bmi > 18.5 && bmi < 24.9)
                { ResultTextBox.Text = Result + "YOU ARE NORMAL"; }
                else if (bmi > 25 && bmi <= 29.9)
                { ResultTextBox.Text = Result + " YOU ARE OVERWEIGHT"; }
                else if (bmi >= 30)
                { ResultTextBox.Text = Result + " YOU ARE OBESE "; }
            }
            else if (MetricRadioButton.Checked)
            {
                bmi = (weight) / (height * height);
                string Result = Convert.ToString(Math.Round(bmi,2)) + " - ";
                if (bmi < 18.5)
                { ResultTextBox.Text = Result + " YOU ARE UNDERWEIGHT"; }
                else if (bmi > 18.5 && bmi < 24.9)
                { ResultTextBox.Text = Result + "YOU ARE NORMAL"; }
                else if (bmi > 25 && bmi <= 29.9)
                { ResultTextBox.Text = Result + " YOU ARE OVERWEIGHT"; }
                else if (bmi >= 30)
                { ResultTextBox.Text = Result + " YOU ARE OBESE "; }
            }
        }

        private void ResultTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            TheCalculatorForm NewForm = new TheCalculatorForm();
            NewForm.Show();
            this.Dispose(false);
        }
    }
}
