using System;
using Plugin.Multilingual;
using System.Globalization;
using System.IO;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using Xamarin.Forms;
using System.Xml;
using Xamarin.Forms.Xaml;

namespace App2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SettingsPage : ContentPage
    {
        public ObservableCollection<Language> Languages { get; }
        public SettingsPage()
        {
            InitializeComponent();

            Languages = new ObservableCollection<Language>()
            {
                new Language {DisplayName = "English", ShortName = "en"},
                new Language {DisplayName = "Русский", ShortName = "ru"},
            };

            BindingContext = this;

            PickerLanguages.SelectedIndexChanged += PickerLanguages_SelectedIndexChanged;

            foreach (Language buffer in Languages)
            {
                if (App.lang == buffer.ShortName)
                {
                    PickerLanguages.SelectedItem = buffer;
                }
            }
        }



        private void PickerLanguages_SelectedIndexChanged(object sender, EventArgs e)
        {
            var language = Languages[PickerLanguages.SelectedIndex];

            try
            {
                App.lang = language.ShortName;
                var culture = new CultureInfo(App.lang);
                Resource.Culture = culture;
                CrossMultilingual.Current.CurrentCultureInfo = culture;
            }
            catch(Exception)
            {

            }

            LabelLang.Text = Resource.LanguageLabel;
            LanguageTitle.Title = Resource.SettingsUp;
            SwitchAnimation.Text = Resource.SwitchSet;

            
            

        }

        protected override void OnAppearing()
        {

            base.OnAppearing();

            if(App.SwitchAnim == true)
            {
                SwitchAnimation.On = true;
            }
            else
            {
                SwitchAnimation.On = false;
            }



        }

        protected override void OnDisappearing()
        {
            
            base.OnDisappearing();

            

        }

        private void ClickedOn(object sender, EventArgs e)
        {
            if (SwitchAnimation.On == true)
            {
                App.SwitchAnim = true;
            }
            else
            {
                App.SwitchAnim = false;
            }
        }

    }
}