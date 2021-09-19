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
    public partial class Assignment2_Slider : ContentPage
    {
        public Assignment2_Slider()
        {
            InitializeComponent();
        }
        private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            string[] a = new string[35] { "a", "b", "c", "d", "e", "f", "g", "a", "b", "c", "d", "e", "f", "g", "a", "b", "c", "d", "e", "f", "g", "a", "b", "c", "d", "e", "f", "g", "a", "b", "c", "d", "e", "f", "g" };
            int b = (int)e.NewValue - 16;
            quote.Text = a[b];
            quote.FontSize = b + 16;
            fsize.Text = "Font Size:" + (b + 16).ToString();
        }
    }
}