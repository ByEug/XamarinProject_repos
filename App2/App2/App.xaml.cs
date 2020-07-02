using System;
using Xamarin.Forms;
using Plugin.Multilingual;
using System.Globalization;
using Xamarin.Forms.Xaml;

namespace App2
{
    public partial class App : Application
    {
        public static string lang = "en";

        public static bool SwitchAnim = true;
        
        public const string DATABASE_NAME = "SQLPlayers.db";
        public static PlayersAsyncRepository database;
        public static PlayersAsyncRepository Database
        {
            get
            {
                if (database == null)
                {
                    database = new PlayersAsyncRepository(DATABASE_NAME);
                }
                return database;
            }
        }
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new SplashPage());

            //MainPage.SetValue(NavigationPage.BarBackgroundColorProperty, Color.Black);
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
          
    }
}
