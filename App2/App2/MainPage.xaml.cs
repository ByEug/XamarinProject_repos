using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using Plugin.Multilingual;
using System.Globalization;
using System.ComponentModel;
using System.Reflection;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App2
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();


            /*ToolbarItem settings = new ToolbarItem
            {
                Order = ToolbarItemOrder.Secondary,
                Priority = 1,
                //Text = "Settings",
                Text = Resource.SettingsUp,
            };

            settings.Clicked += ClickOnSettings;

            ToolbarItems.Add(settings);

            ToolbarItem about = new ToolbarItem
            {
                Order = ToolbarItemOrder.Secondary,
                Priority = 2,
                //Text = "About",
                Text = Resource.AboutUp,
            };

            ToolbarItems.Add(about);

            about.Clicked += ClickOnAbout;*/
        }

        protected override void OnAppearing()
        {

            Resource.Culture = new CultureInfo(App.lang);
            CrossMultilingual.Current.CurrentCultureInfo = Resource.Culture;

            ToolbarItems.Clear();

            ToolbarItem settings = new ToolbarItem
            {
                Order = ToolbarItemOrder.Secondary,
                Priority = 1,
                //Text = "Settings",
                Text = Resource.SettingsUp,
            };

            settings.Clicked += ClickOnSettings;

            ToolbarItems.Add(settings);

            ToolbarItem about = new ToolbarItem
            {
                Order = ToolbarItemOrder.Secondary,
                Priority = 2,
                //Text = "About",
                Text = Resource.AboutUp,
            };

            ToolbarItems.Add(about);

            about.Clicked += ClickOnAbout;

            Players.Text = Resource.PlayersButton;
            Teams.Text = Resource.TeamsButton;
        }

        private async void ClickOnTeams(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TeamsPage());      
        }

        private async void ClickOnPlayers(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PlayersPage());
        }

        private async void ClickOnSettings(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SettingsPage());
        }

        private async void ClickOnAbout(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AboutPage());
        }

    }
}
