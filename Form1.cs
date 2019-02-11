using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //close program
        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonCalcFat_Click(object sender, EventArgs e)
        {
            //test for double
            double tstDbl;
            if (!double.TryParse(textFatGrams.Text, out tstDbl))
            {
                //display message when double not entered
                MessageBox.Show("Enter Valid Double", "Input Error");
                textFatGrams.Text = "";
                textFatGrams.Focus();
            }
            else
            {
                //calculate calories
                textFatCalories.Text = Convert.ToString(FatCalories(tstDbl));
            }
        }

        private void buttonCalcCarbs_Click(object sender, EventArgs e)
        {
            //test for double
            double tstDbl;
            if(!double.TryParse(textCarbsGrams.Text, out tstDbl))
            {
                //display message when double not entered
                MessageBox.Show("Enter Valid Double", "Inut Error");
                textCarbsGrams.Text = "";
                textCarbsGrams.Focus();
            }
            else
            {
                //calculate calories 
                textCarbCalories.Text = Convert.ToString(CarbCalories(tstDbl));
            }
        }

        //convert fat grams to calories
        public double FatCalories(double fatGram)
        {
            return fatGram * 9.0;
        }

        //convert carbs grams to calo
        public double CarbCalories(double carbGrams)
        {
            return carbGrams * 4.0;
        }
    }
}
