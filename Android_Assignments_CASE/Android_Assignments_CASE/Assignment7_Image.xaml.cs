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
    public partial class Assignment7_Image : ContentPage
    {
        int i = 0;
        string[] a = new string[5] { "https://i.pinimg.com/originals/0a/d5/33/0ad533a35d7a8657233ac672215533b7.jpg",
                "https://live.staticflickr.com/8472/8111383524_2ff85cefa1_z.jpg",
                "https://wallpaperboat.com/wp-content/uploads/2020/06/05/43675/hunter-x-hunter-08.jpg",
                "https://wallpapercave.com/wp/wp2855219.jpg",
                "https://wallpaperaccess.com/full/957573.jpg" };
        public Assignment7_Image()
        {
            InitializeComponent();
            var imgso = (UriImageSource)ImageSource.FromUri(new Uri(a[i]));
            imgso.CachingEnabled = false;
            img.Source = imgso;
        }
        private void back_Clicked(object sender, EventArgs e)
        {
            if (i > 0)
            {
                i = i - 1;
                var imgso = (UriImageSource)ImageSource.FromUri(new Uri(a[i]));
                imgso.CachingEnabled = false;
                img.Source = imgso;
            }

        }

        private void next_Clicked(object sender, EventArgs e)
        {
            if (i < 4)
            {
                i = i + 1;
                var imgso = (UriImageSource)ImageSource.FromUri(new Uri(a[i]));
                imgso.CachingEnabled = false;
                img.Source = imgso;
            }

        }
    }
}