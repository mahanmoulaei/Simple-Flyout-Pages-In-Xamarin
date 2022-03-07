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
    public partial class Question2 : ContentPage
    {
        Dictionary<string, string> myDict = new Dictionary<string, string> 
        {
            { "user1@hotmail.com", "user123" },
            { "user2@hotmail.com", "user321" }
        };
        public Question2()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            if (myDict.ContainsKey(txtEmail.Text))
            {
                if (txtPassword.Text == myDict[txtEmail.Text])
                {
                    showResult("You are logged", Color.Green);
                }
                else
                {
                    showResult("Invalid Password", Color.Red);
                }
            }
            else
            {
                showResult("Email does not exist", Color.Red);
            }
        }

        private void showResult(string str, Color color)
        {
            lblResult.Text = str;
            lblResult.TextColor = color;
        }
    }
}