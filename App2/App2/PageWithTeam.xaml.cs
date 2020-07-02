using System;
using System.Globalization;
using Plugin.Multilingual;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageWithTeam : ContentPage
    {
        public PageWithTeam()
        {

            InitializeComponent();

            Resource.Culture = new CultureInfo(App.lang);
            CrossMultilingual.Current.CurrentCultureInfo = Resource.Culture;

            Roster.Text = Resource.RosterButton;
        }

        private async void ClickOnRoster(object sender, EventArgs e)
        {
            var buffer = LabelWithName.Text;
            var RosPage = new RosterPage
            {
                BindingContext = buffer
            };
            await Navigation.PushAsync(RosPage);
        }
    }
}