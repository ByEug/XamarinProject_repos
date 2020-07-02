using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AboutPage : ContentPage
    {
        public AboutPage()
        {
            InitializeComponent();
        }

        private async void ClickedOnPicture(object sender, EventArgs e)
        {
            if (App.SwitchAnim == true)
            {
                await NBAImage.RotateTo(180, 1000, Easing.SpringOut);
                await NBAImage.RotateTo(0, 1000, Easing.SpringOut);
            }
        }
    }
}