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
    public partial class TeamsPage : ContentPage
    {
        public TeamsPage()
        {
            InitializeComponent();

        }

        private async void Celtics(object sender, EventArgs e)
        {
            var things = new List<TeamStructure>
            {
                new TeamStructure {PictName = "TD Garden", Pict =  "celticsarena.jpg"},
                new TeamStructure {PictName = Resource.HeadCoach + " Brad Stevens", Pict =  "celticscoach.jpg"},
                new TeamStructure {PictName = Resource.TrainingCamp, Pict =  "celticstrain.jpeg"}
            };

            var dataForPage = new FranchiseData("Boston", "Celtics", "1946", "boston128.png", Resource.BostonString, Resource.EasternConference, things);
            var PWT = new PageWithTeam
            {
                BindingContext = dataForPage
            };
            await Navigation.PushAsync(PWT);
        }

        private async void Heat(object sender, EventArgs e)
        {
            var things = new List<TeamStructure>
            {
                new TeamStructure {PictName = "American Airlines arena", Pict =  "miamiarena.jpg"},
                new TeamStructure {PictName = Resource.HeadCoach + " Eric Spoelstra", Pict =  "miamicoach.jpg"},
                new TeamStructure {PictName = Resource.TrainingCamp, Pict =  "miamitrain.jpg"}
            };

            var dataForPage = new FranchiseData("Miami", "Heat", "1988", "miami128.png", Resource.MiamiString, Resource.EasternConference, things);
            var PWT = new PageWithTeam
            {
                BindingContext = dataForPage
            };
            await Navigation.PushAsync(PWT);
        }

        private async void Knicks(object sender, EventArgs e)
        {
            var things = new List<TeamStructure>
            {
                new TeamStructure {PictName = "Madison Square Garden", Pict =  "knicksarena.jpg"},
                new TeamStructure {PictName = Resource.HeadCoach + " David Fizdale", Pict =  "knickscoach.jpg"},
                new TeamStructure {PictName = Resource.TrainingCamp, Pict =  "knickstrain.jpg"}
            };

            var dataForPage = new FranchiseData("New York", "Knicks", "1946", "new_york128.png", Resource.NewYorkString, Resource.EasternConference, things);
            var PWT = new PageWithTeam
            {
                BindingContext = dataForPage
            };
            await Navigation.PushAsync(PWT);
        }

        private async void Lakers(object sender, EventArgs e)
        {
            var things = new List<TeamStructure>
            {
                new TeamStructure {PictName = "Staples Center", Pict =  "lalakersarena.jpg"},
                new TeamStructure {PictName = Resource.HeadCoach + " Frank Vogel", Pict =  "lalakerscoach.jpg"},
                new TeamStructure {PictName = Resource.TrainingCamp, Pict =  "lalakerstrain.jpg"}
            };

            var dataForPage = new FranchiseData("L. A.", "Lakers", "1947", "lalakers128.png", Resource.LALakersString, Resource.WesternConference, things);
            var PWT = new PageWithTeam
            {
                BindingContext = dataForPage
            };
            await Navigation.PushAsync(PWT);
        }

        private async void Spurs(object sender, EventArgs e)
        {
            var things = new List<TeamStructure>
            {
                new TeamStructure {PictName = "AT&T Center", Pict =  "sanantonioarena.jpg"},
                new TeamStructure {PictName = Resource.HeadCoach + " Gregg Popovich", Pict =  "sanantoniocoach.jpg"},
                new TeamStructure {PictName = Resource.TrainingCamp, Pict =  "sanantoniotrain.jpg"}
            };

            var dataForPage = new FranchiseData("S.Antonio", "Spurs", "1967", "sanantonio128.png", Resource.SpursString, Resource.WesternConference, things);
            var PWT = new PageWithTeam
            {
                BindingContext = dataForPage
            };
            await Navigation.PushAsync(PWT);
        }

        private async void Trailblazers(object sender, EventArgs e)
        {
            var things = new List<TeamStructure>
            {
                new TeamStructure {PictName = "Moda Center", Pict =  "portlandarena.jpg"},
                new TeamStructure {PictName = Resource.HeadCoach + " Terry Stotts", Pict =  "portlandcoach.jpg"},
                new TeamStructure {PictName = Resource.TrainingCamp, Pict =  "portlandtrain.jpg"}
            };

            var dataForPage = new FranchiseData("Portland", "Blazers", "1970", "portland128.png", Resource.PortlandString, Resource.WesternConference, things);
            var PWT = new PageWithTeam
            {
                BindingContext = dataForPage
            };
            await Navigation.PushAsync(PWT);
        }

        private async void Cavaliers(object sender, EventArgs e)
        {
            var things = new List<TeamStructure>
            {
                new TeamStructure {PictName = "Quicken Loans Arena", Pict =  "clevelandarena.jpg"},
                new TeamStructure {PictName = Resource.HeadCoach + " John Beilein", Pict =  "clevelandcoach.jpg"},
                new TeamStructure {PictName = Resource.TrainingCamp, Pict =  "clevelandtrain.jpg"}
            };

            var dataForPage = new FranchiseData("Cleveland", "Cavaliers", "1970", "cleveland128.png", Resource.ClevelandString, Resource.EasternConference, things);
            var PWT = new PageWithTeam
            {
                BindingContext = dataForPage
            };
            await Navigation.PushAsync(PWT);
        }

        private async void Nets(object sender, EventArgs e)
        {
            var things = new List<TeamStructure>
            {
                new TeamStructure {PictName = "Barclays Center", Pict =  "brooklynarena.jpg"},
                new TeamStructure {PictName = Resource.HeadCoach + " Kenny Atkinson", Pict =  "brooklyncoach.jpg"},
                new TeamStructure {PictName = Resource.TrainingCamp, Pict =  "brooklyntrain.jpg"}
            };

            var dataForPage = new FranchiseData("Brooklyn", "Nets", "1967", "brooklyn128.png", Resource.BrooklynString, Resource.EasternConference, things);
            var PWT = new PageWithTeam
            {
                BindingContext = dataForPage
            };
            await Navigation.PushAsync(PWT);
        }

        private async void Sixers(object sender, EventArgs e)
        {
            var things = new List<TeamStructure>
            {
                new TeamStructure {PictName = "Wells Fargo Center", Pict =  "philaarena.jpg"},
                new TeamStructure {PictName = Resource.HeadCoach + " Brett Brown", Pict =  "philacoach.jpg"},
                new TeamStructure {PictName = Resource.TrainingCamp, Pict =  "philatrain.jpg"}
            };

            var dataForPage = new FranchiseData("Phila", "76ers", "1946", "phila128.png", Resource.PhilaString, Resource.EasternConference, things);
            var PWT = new PageWithTeam
            {
                BindingContext = dataForPage
            };
            await Navigation.PushAsync(PWT);
        }

        private async void Rockets(object sender, EventArgs e)
        {
            var things = new List<TeamStructure>
            {
                new TeamStructure {PictName = "Toyota Center", Pict =  "houstonarena.jpg"},
                new TeamStructure {PictName = Resource.HeadCoach + " Mike D’Antoni", Pict =  "houstoncoach.jpg"},
                new TeamStructure {PictName = Resource.TrainingCamp, Pict =  "houstontrain.jpg"}
            };

            var dataForPage = new FranchiseData("Houston", "Rockets", "1967", "houston128.png", Resource.HoustonString, Resource.WesternConference, things);
            var PWT = new PageWithTeam
            {
                BindingContext = dataForPage
            };
            await Navigation.PushAsync(PWT);
        }

        private async void Suns(object sender, EventArgs e)
        {
            var things = new List<TeamStructure>
            {
                new TeamStructure {PictName = "Talking Stick Resort Arena", Pict =  "phoenixarena.jpg"},
                new TeamStructure {PictName = Resource.HeadCoach + " Monty Williams", Pict =  "phoenixcoach.jpg"},
                new TeamStructure {PictName = Resource.TrainingCamp, Pict =  "phoenixtrain.jpg"}
            };

            var dataForPage = new FranchiseData("Phoenix", "Suns", "1968", "phoenix128.png", Resource.PhoenixString, Resource.WesternConference, things);
            var PWT = new PageWithTeam
            {
                BindingContext = dataForPage
            };
            await Navigation.PushAsync(PWT);
        }

        private async void Nuggets(object sender, EventArgs e)
        {
            var things = new List<TeamStructure>
            {
                new TeamStructure {PictName = "Pepsi Center", Pict =  "denverarena.jpg"},
                new TeamStructure {PictName = Resource.HeadCoach + " Michael Malone", Pict =  "denvercoach.jpg"},
                new TeamStructure {PictName = Resource.TrainingCamp, Pict =  "denvertrain.jpg"}
            };

            var dataForPage = new FranchiseData("Denver", "Nuggets", "1967", "denver128.png", Resource.DenverString, Resource.WesternConference, things);
            var PWT = new PageWithTeam
            {
                BindingContext = dataForPage
            };
            await Navigation.PushAsync(PWT);
        }

        private async void Raptors(object sender, EventArgs e)
        {
            var things = new List<TeamStructure>
            {
                new TeamStructure {PictName = "Scotiabank Arena", Pict =  "torontoarena.jpg"},
                new TeamStructure {PictName = Resource.HeadCoach + " Nick Nurse", Pict =  "torontocoach.jpg"},
                new TeamStructure {PictName = Resource.TrainingCamp, Pict =  "torontotrain.jpg"}
            };

            var dataForPage = new FranchiseData("Toronto", "Raptors", "1995", "toronto128.png", Resource.TorontoString, Resource.EasternConference, things);
            var PWT = new PageWithTeam
            {
                BindingContext = dataForPage
            };
            await Navigation.PushAsync(PWT);
        }

        private async void Pistons(object sender, EventArgs e)
        {
            var things = new List<TeamStructure>
            {
                new TeamStructure {PictName = "Little Caesars Arena", Pict =  "detroitarena.jpg"},
                new TeamStructure {PictName = Resource.HeadCoach + " Dwane Casey", Pict =  "detroitcoach.jpg"},
                new TeamStructure {PictName = Resource.TrainingCamp, Pict =  "detroittrain.jpg"}
            };

            var dataForPage = new FranchiseData("Detroit", "Pistons", "1941", "detroit128.png", Resource.DetroitString, Resource.EasternConference, things);
            var PWT = new PageWithTeam
            {
                BindingContext = dataForPage
            };
            await Navigation.PushAsync(PWT);
        }

        private async void Hawks(object sender, EventArgs e)
        {
            var things = new List<TeamStructure>
            {
                new TeamStructure {PictName = "State Farm Arena", Pict =  "atlantaarena.jpg"},
                new TeamStructure {PictName = Resource.HeadCoach + " Lloyd Pierce", Pict =  "atlantacoach.jpg"},
                new TeamStructure {PictName = Resource.TrainingCamp, Pict =  "atlantatrain.jpg"}
            };

            var dataForPage = new FranchiseData("Atlanta", "Hawks", "1946", "atlanta128.png", Resource.AtlantaString, Resource.EasternConference, things);
            var PWT = new PageWithTeam
            {
                BindingContext = dataForPage
            };
            await Navigation.PushAsync(PWT);
        }

        private async void Jazz(object sender, EventArgs e)
        {
            var things = new List<TeamStructure>
            {
                new TeamStructure {PictName = "Vivint Smart Home Arena", Pict =  "utaharena.jpg"},
                new TeamStructure {PictName = Resource.HeadCoach + " Quin Snyder", Pict =  "utahcoach.jpeg"},
                new TeamStructure {PictName = Resource.TrainingCamp, Pict =  "utahtrain.jpg"}
            };

            var dataForPage = new FranchiseData("Utah", "Jazz", "1974", "utah128.png", Resource.UtahString, Resource.WesternConference, things);
            var PWT = new PageWithTeam
            {
                BindingContext = dataForPage
            };
            await Navigation.PushAsync(PWT);
        }

        private async void Mavericks(object sender, EventArgs e)
        {
            var things = new List<TeamStructure>
            {
                new TeamStructure {PictName = "American Airlines Center", Pict =  "dallasarena.jpg"},
                new TeamStructure {PictName = Resource.HeadCoach + " Rick Carlisle", Pict =  "dallascoach.jpg"},
                new TeamStructure {PictName = Resource.TrainingCamp, Pict =  "dallastrain.jpg"}
            };

            var dataForPage = new FranchiseData("Dallas", "Mavericks", "1980", "dallas128.png", Resource.DallasString, Resource.WesternConference, things);
            var PWT = new PageWithTeam
            {
                BindingContext = dataForPage
            };
            await Navigation.PushAsync(PWT);
        }

        private async void Pelicans(object sender, EventArgs e)
        {
            var things = new List<TeamStructure>
            {
                new TeamStructure {PictName = "Smoothie King Center", Pict =  "neworleansarena.jpg"},
                new TeamStructure {PictName = Resource.HeadCoach + " Alvin Gentry", Pict =  "neworleanscoach.jpg"},
                new TeamStructure {PictName = Resource.TrainingCamp, Pict =  "neworleanstrain.jpg"}
            };

            var dataForPage = new FranchiseData("New Orleans", "Pelicans", "2002", "neworleans128.png", Resource.NewOrleansString, Resource.WesternConference, things);
            var PWT = new PageWithTeam
            {
                BindingContext = dataForPage
            };
            await Navigation.PushAsync(PWT);
        }

        private async void Bulls(object sender, EventArgs e)
        {
            var things = new List<TeamStructure>
            {
                new TeamStructure {PictName = "United Center", Pict =  "chicagoarena.jpg"},
                new TeamStructure {PictName = Resource.HeadCoach + " Jim Boylen", Pict =  "chicagocoach.jpg"},
                new TeamStructure {PictName = Resource.TrainingCamp, Pict =  "chicagotrain.jpg"}
            };

            var dataForPage = new FranchiseData("Chicago", "Bulls", "1966", "chicago128.png", Resource.ChicagoString, Resource.EasternConference, things);
            var PWT = new PageWithTeam
            {
                BindingContext = dataForPage
            };
            await Navigation.PushAsync(PWT);
        }

        private async void Pacers(object sender, EventArgs e)
        {
            var things = new List<TeamStructure>
            {
                new TeamStructure {PictName = "Bankers Life Fieldhouse", Pict =  "indianaarena.jpg"},
                new TeamStructure {PictName = Resource.HeadCoach + " Nate McMillan", Pict =  "indianacoach.jpg"},
                new TeamStructure {PictName = Resource.TrainingCamp, Pict =  "indianatrain.jpg"}
            };

            var dataForPage = new FranchiseData("Indiana", "Pacers", "1967", "indiana128.png", Resource.IndianaString, Resource.EasternConference, things);
            var PWT = new PageWithTeam
            {
                BindingContext = dataForPage
            };
            await Navigation.PushAsync(PWT);
        }

        private async void Hornets(object sender, EventArgs e)
        {
            var things = new List<TeamStructure>
            {
                new TeamStructure {PictName = "Spectrum Center", Pict =  "charlottearena.jpg"},
                new TeamStructure {PictName = Resource.HeadCoach + " James Borrego", Pict =  "charlottecoach.jpg"},
                new TeamStructure {PictName = Resource.TrainingCamp, Pict =  "charlottetrain.jpg"}
            };

            var dataForPage = new FranchiseData("Charlotte", "Hornets", "1988", "charlotte128.png", Resource.CharlotteString, Resource.EasternConference, things);
            var PWT = new PageWithTeam
            {
                BindingContext = dataForPage
            };
            await Navigation.PushAsync(PWT);
        }

        private async void Thunder(object sender, EventArgs e)
        {
            var things = new List<TeamStructure>
            {
                new TeamStructure {PictName = "Chesapeake Arena", Pict =  "oklahomaarena.jpg"},
                new TeamStructure {PictName = Resource.HeadCoach + " Billy Donovan", Pict =  "oklahomacoach.jpg"},
                new TeamStructure {PictName = Resource.TrainingCamp, Pict =  "oklahomatrain.jpg"}
            };

            var dataForPage = new FranchiseData("Oklahoma", "Thunder", "1967", "oklahoma128.png", Resource.OklahomaString, Resource.WesternConference, things);
            var PWT = new PageWithTeam
            {
                BindingContext = dataForPage
            };
            await Navigation.PushAsync(PWT);
        }

        private async void Warriors(object sender, EventArgs e)
        {
            var things = new List<TeamStructure>
            {
                new TeamStructure {PictName = "Chase Center", Pict =  "gswarena.jpg"},
                new TeamStructure {PictName = Resource.HeadCoach + " Steve Kerr", Pict =  "gswcoach.jpg"},
                new TeamStructure {PictName = Resource.TrainingCamp, Pict =  "gswtrain.jpg"}
            };

            var dataForPage = new FranchiseData("G. State", "Warriors", "1946", "gsw128.png", Resource.GSWString, Resource.WesternConference, things);
            var PWT = new PageWithTeam
            {
                BindingContext = dataForPage
            };
            await Navigation.PushAsync(PWT);
        }

        private async void Kings(object sender, EventArgs e)
        {
            var things = new List<TeamStructure>
            {
                new TeamStructure {PictName = "Golden 1 Center", Pict =  "sacramentoarena.jpg"},
                new TeamStructure {PictName = Resource.HeadCoach + " Luke Walton", Pict =  "sacramentocoach.jpg"},
                new TeamStructure {PictName = Resource.TrainingCamp, Pict =  "sacramentotrain.jpg"}
            };

            var dataForPage = new FranchiseData("Sac-nto", "Kings", "1923", "sacramento128.png", Resource.SacramentoString, Resource.WesternConference, things);
            var PWT = new PageWithTeam
            {
                BindingContext = dataForPage
            };
            await Navigation.PushAsync(PWT);
        }

        private async void Magic(object sender, EventArgs e)
        {
            var things = new List<TeamStructure>
            {
                new TeamStructure {PictName = "Amway Center", Pict =  "orlandoarena.jpg"},
                new TeamStructure {PictName = Resource.HeadCoach + " Steve Clifford", Pict =  "orlandocoach.jpg"},
                new TeamStructure {PictName = Resource.TrainingCamp, Pict =  "orlandotrain.jpg"}
            };

            var dataForPage = new FranchiseData("Orlando", "Magic", "1989", "orlando128.png", Resource.OrlandoString, Resource.EasternConference, things);
            var PWT = new PageWithTeam
            {
                BindingContext = dataForPage
            };
            await Navigation.PushAsync(PWT);
        }

        private async void Bucks(object sender, EventArgs e)
        {
            var things = new List<TeamStructure>
            {
                new TeamStructure {PictName = "Fiserv Forum", Pict =  "milwaukeearena.jpg"},
                new TeamStructure {PictName = Resource.HeadCoach + " Mike Budenholzer", Pict =  "milwaukeecoach.jpg"},
                new TeamStructure {PictName = Resource.TrainingCamp, Pict =  "milwaukeetrain.jpg"}
            };

            var dataForPage = new FranchiseData("Milwaukee", "Bucks", "1968", "milwaukee128.png", Resource.MilwaukeeString, Resource.EasternConference, things);
            var PWT = new PageWithTeam
            {
                BindingContext = dataForPage
            };
            await Navigation.PushAsync(PWT);
        }

        private async void Wizards(object sender, EventArgs e)
        {
            var things = new List<TeamStructure>
            {
                new TeamStructure {PictName = "Capital One Arena", Pict =  "washingtonarena.jpg"},
                new TeamStructure {PictName = Resource.HeadCoach + " Scott Brooks", Pict =  "washingtoncoach.jpg"},
                new TeamStructure {PictName = Resource.TrainingCamp, Pict =  "washingtontrain.jpg"}
            };

            var dataForPage = new FranchiseData("Wash-ton", "Wizards", "1961", "washington128.png", Resource.WashingtonString, Resource.EasternConference, things);
            var PWT = new PageWithTeam
            {
                BindingContext = dataForPage
            };
            await Navigation.PushAsync(PWT);
        }

        private async void Timberwolves(object sender, EventArgs e)
        {
            var things = new List<TeamStructure>
            {
                new TeamStructure {PictName = "The Target Center", Pict =  "minnesotaarena.jpg"},
                new TeamStructure {PictName = Resource.HeadCoach + " Ryan Saunders", Pict =  "minnesotacoach.jpeg"},
                new TeamStructure {PictName = Resource.TrainingCamp, Pict =  "minnesotatrain.jpg"}
            };

            var dataForPage = new FranchiseData("Minnesota", "T-Wolves", "1989", "minnesota128.png", Resource.MinnesotaString, Resource.WesternConference, things);
            var PWT = new PageWithTeam
            {
                BindingContext = dataForPage
            };
            await Navigation.PushAsync(PWT);
        }

        private async void Clippers(object sender, EventArgs e)
        {
            var things = new List<TeamStructure>
            {
                new TeamStructure {PictName = "Staples Center", Pict =  "laclippersarena.jpg"},
                new TeamStructure {PictName = Resource.HeadCoach + " Doc Rivers", Pict =  "laclipperscoach.jpg"},
                new TeamStructure {PictName = Resource.TrainingCamp, Pict =  "laclipperstrain.jpg"}
            };

            var dataForPage = new FranchiseData("L. A.", "Clippers", "1970", "laclippers128.png", Resource.LAClippersString, Resource.WesternConference, things);
            var PWT = new PageWithTeam
            {
                BindingContext = dataForPage
            };
            await Navigation.PushAsync(PWT);
        }

        private async void Grizzlies(object sender, EventArgs e)
        {
            var things = new List<TeamStructure>
            {
                new TeamStructure {PictName = "FedExForum", Pict =  "memphisarena.jpg"},
                new TeamStructure {PictName = Resource.HeadCoach + " Taylor Jenkins", Pict =  "memphiscoach.jpg"},
                new TeamStructure {PictName = Resource.TrainingCamp, Pict =  "memphistrain.jpg"}
            };

            var dataForPage = new FranchiseData("Memphis", "Grizzlies", "1995", "memphis128.png", Resource.MemphisString, Resource.WesternConference, things);
            var PWT = new PageWithTeam
            {
                BindingContext = dataForPage
            };
            await Navigation.PushAsync(PWT);
        }
    }

}