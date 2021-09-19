using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Android_Assignments_CASE
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Assignment3_Dialer : ContentPage
    {
        public Assignment3_Dialer()
        {
            InitializeComponent();
        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            var enteredNumber = (sender as Button).Text;
            if (phoneNumber.Text == "Dialling...")
            {
                phoneNumber.Text = enteredNumber;
            }
            else
            {
                phoneNumber.Text += enteredNumber;
            }


        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            phoneNumber.Text = "Dialling...";
        }
    }
}