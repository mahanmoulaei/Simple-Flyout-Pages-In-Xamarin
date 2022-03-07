using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Midterm_MahanMoulaei.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Question4 : ContentPage
    {
        public Question4()
        {
            InitializeComponent();
            Calculate();
            lblHeight.Text = height(heightSlider.Value.ToString());
            lblWeight.Text = weight(weightSlider.Value.ToString());
        }

        private void heightSlider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            lblHeight.Text = height(e.NewValue.ToString("0.##"));
            Calculate();
        }

        private void weightSlider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            lblWeight.Text = weight(e.NewValue.ToString("0.##"));
            Calculate();
        }

        private void Calculate()
        {
            double meter = heightSlider.Value / 100;
            double bmi = weightSlider.Value / (meter * meter);
            double progress = bmi / 100;
            if (bmi < 18.5)
            {
                lblBMIResult.Text = "Underweight";
                progressBMI.ProgressColor = Color.White;
            }
            else if (bmi >= 18.5 && bmi < 25.0)
            {
                lblBMIResult.Text = "Normal Weight";
                progressBMI.ProgressColor = Color.Green;
            }
            else if (bmi >= 25.0 && bmi < 30.0)
            {
                lblBMIResult.Text = "Overweight";
                progressBMI.ProgressColor = Color.Orange;
            }
            else if (bmi >= 30.0)
            {
                lblBMIResult.Text = "Obesity";
                progressBMI.ProgressColor = Color.Red;
            }
            progressBMI.ProgressTo(progress, 500, Easing.Linear);
            lblBMI.Text = bmi.ToString("0.##");
        }

        private string height(string str)
        {
            return str + " cm";
        }

        private string weight(string str)
        {
            return str + " kg";
        }
    }
}