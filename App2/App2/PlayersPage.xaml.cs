using System;
using Plugin.Multilingual;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.IO;
using System.Reflection;

namespace App2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PlayersPage : ContentPage
    {
        public PlayersDictionary AllPlayers { get; set; }

        public PlayersPage()
        {
            InitializeComponent();

            /*ToolbarItem search = new ToolbarItem
            {
                Order = ToolbarItemOrder.Primary,
                Priority = 0,
                IconImageSource = new FileImageSource
                {
                    File = "sort.png"
                },
            };

            search.Clicked += ClickedOnSearch;

            ToolbarItems.Add(search);

            ToolbarItem about = new ToolbarItem
            {
                Order = ToolbarItemOrder.Secondary,
                Priority = 2,
                Text = "About",
            };

            ToolbarItems.Add(about);*/
        }

        async void ClickedOnSearch(object sender, EventArgs e)
        {
            string action = await DisplayActionSheet(Resource.SortLabel, Resource.Cancel, null, Resource.PositionSort, Resource.SurnameSort, Resource.TeamSort);
            if (action != null)
            {
                if (action == Resource.PositionSort)
                {
                    var SortedAllPlayers = from Player in AllPlayers
                                           orderby Player.Position
                                           select Player;
                    PlayersList.ItemsSource = SortedAllPlayers;
                }
                else
                {
                    if (action == Resource.SurnameSort)
                    {
                        var SortedAllPlayers = from Player in AllPlayers
                                               orderby Player.Surname
                                               select Player;
                        PlayersList.ItemsSource = SortedAllPlayers;
                    }
                    else
                    {
                        if (action == Resource.TeamSort)
                        {
                            var SortedAllPlayers = from Player in AllPlayers
                                                   orderby Player.Club
                                                   select Player;
                            PlayersList.ItemsSource = SortedAllPlayers;
                        }
                    }
                }
                /*switch (action)
                {
                    case "Position":
                        {
                            var SortedAllPlayers = from Player in AllPlayers
                                                   orderby Player.Position
                                                   select Player;
                            PlayersList.ItemsSource = SortedAllPlayers;
                            break;
                        }
                    case "Surname":
                        {
                            var SortedAllPlayers = from Player in AllPlayers
                                                   orderby Player.Surname
                                                   select Player;
                            PlayersList.ItemsSource = SortedAllPlayers;
                            break;
                        }
                    case "Team":
                        {
                            var SortedAllPlayers = from Player in AllPlayers
                                                   orderby Player.Club
                                                   select Player;
                            PlayersList.ItemsSource = SortedAllPlayers;
                            break;
                        }
                }*/
            }
        }

        protected override async void OnAppearing()
        {
            Resource.Culture = new CultureInfo(App.lang);
            CrossMultilingual.Current.CurrentCultureInfo = Resource.Culture;

            ToolbarItems.Clear();

            ToolbarItem search = new ToolbarItem
            {
                Order = ToolbarItemOrder.Primary,
                Priority = 0,
                IconImageSource = new FileImageSource
                {
                    File = "sort.png"
                },
            };

            search.Clicked += ClickedOnSearch;

            ToolbarItems.Add(search);

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
            //PlayersList.ItemsSource = await App.Database.GetItemsAsync();
            PlayerRepos BufferR = new PlayerRepos();
            //BufferR = await App.Database.GetItemAsync(1);
            
            AllPlayers = new PlayersDictionary { };
            for (int i = 1; ; i++)
            {
                
                BufferR = await App.Database.GetItemAsync(i);
                if (BufferR.Surname == "EMPTY")
                {
                    break;
                }
                else
                {
                    Player Buff = new Player(BufferR.Surname, BufferR.Name, BufferR.DateBirth, BufferR.Position, BufferR.Nationality, BufferR.Number, BufferR.Club, BufferR.ClubLogo, BufferR.PlayerPict, BufferR.PPG, BufferR.RPG, BufferR.APG, BufferR.MPG, BufferR.Id);
                    AllPlayers.Add(Buff);
                }
                //Player Buff = new Player(BufferR.Surname, BufferR.Name, BufferR.DateBirth, BufferR.Position, BufferR.Nationality, BufferR.Number, BufferR.Id);
                //AllPlayers.Add(Buff);
                
            }
            PlayersList.ItemsSource = AllPlayers;
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