using Midterm_MahanMoulaei.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Midterm_MahanMoulaei.Menu
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Master : FlyoutPage
    {
        public Master()
        {
            InitializeComponent();
        }

        private void button_Clicked(object sender, EventArgs e)
        {
            Button myButton = sender as Button;
            if (myButton == button1)
            {
                Detail = new Question1();
            }
            else if (myButton == button2)
            {
                Detail = new Question2();
            }
            else if (myButton == button3)
            {
                Detail = new Question3();
            }
            else if (myButton == button4)
            {
                Detail = new Question4();
            }
        }
    }
}