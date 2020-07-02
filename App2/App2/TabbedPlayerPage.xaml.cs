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
    public partial class TabbedPlayerPage : TabbedPage
    {
        public TabbedPlayerPage()
        {
            InitializeComponent();

        }

        private void YoutubeClicked(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("vnd.youtube://www.youtube.com/results?search_query=" + LabelName.Text + " " + LabelSurname.Text));
        }
    }
}