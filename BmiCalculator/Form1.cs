using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*Name:MAnmeet Singh
 Student no. : 300932996
 Description:Building a BMI calculator
 version :0.1 Added the Unit changing Functionality on radio button*/
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
    }
}
