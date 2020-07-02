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
    public partial class RosterPage : ContentPage
    {
        public NBATeam TeamRoster { get; set; }
        public RosterPage()
        {
            InitializeComponent();

            /*ToolbarItem about = new ToolbarItem
            {
                Order = ToolbarItemOrder.Secondary,
                Priority = 2,
                Text = "About",
            };

            ToolbarItems.Add(about);*/
        }

        protected override async void OnAppearing()
        {

            ToolbarItem about = new ToolbarItem
            {
                Order = ToolbarItemOrder.Secondary,
                Priority = 2,
                Text = Resource.AboutUp,
            };

            ToolbarItems.Add(about);

            about.Clicked += ClickOnAbout;
            // создание таблицы, если ее нет
            await App.Database.CreateTable();
            // привязка данных
            //PlayerRepos BufferR = new PlayerRepos();

            TeamRoster = new NBATeam { };
            for (int i = 1; ; i++)
            {

                PlayerRepos BufferR = await App.Database.GetItemAsync(i);
                if (BufferR.Surname == "EMPTY")
                {
                    break;
                }
                else
                {
                    if (BufferR.Club == BindingContext as string)
                    {
                        TeamRoster.AddToRoster(BufferR.Surname, BufferR.Name, BufferR.DateBirth, BufferR.Position, BufferR.Nationality, BufferR.Number, BufferR.Club, BufferR.ClubLogo, BufferR.PlayerPict, BufferR.PPG, BufferR.RPG, BufferR.APG, BufferR.MPG, BufferR.Id);
                    }
                   
                }

            }
            RosterList.ItemsSource = TeamRoster;
            base.OnAppearing();
        }

        public async void SelectedPlayer(object sender, ItemTappedEventArgs e)
        {
            var player = (Player)e.Item;
            var TabPlayer = new TabbedPlayerPage
            {
                BindingContext = player
            };
            await Navigation.PushAsync(TabPlayer);

        }

        private async void ClickOnAbout(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AboutPage());
        }
    }
}