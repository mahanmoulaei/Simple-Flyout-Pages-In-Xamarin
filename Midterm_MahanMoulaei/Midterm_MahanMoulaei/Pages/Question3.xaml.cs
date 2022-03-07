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
    public partial class Question3 : ContentPage
    {
        public Question3()
        {
            InitializeComponent();
            lblBMI.Text = "";
            lblHeight.Text = height(heightSlider.Value.ToString());
            lblWeight.Text = weight(weightSlider.Value.ToString());
        }

        private void heightSlider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            lblHeight.Text = height(e.NewValue.ToString("0.##"));
        }

        private void weightSlider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            lblWeight.Text = weight(e.NewValue.ToString("0.##"));
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            double meter = heightSlider.Value / 100;
            lblBMI.Text = (weightSlider.Value / (meter * meter)).ToString("0.##");
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