using System;
using System.Collections;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Xamarin.Forms;
using SQLite;

namespace App2
{
    public class Language
    {
        public string DisplayName { get; set; }
        public string ShortName { get; set; }
    }
    public class TeamStructure
    {
        public string PictName { get; set; }

        public string Pict { get; set; }

    }
    public class FranchiseData
    {
        public string City { get; set; }
        public string Name { get; set; }
        public string Year { get; set; }
        public string Pict { get; set; }
        public string ChampAmount { get; set; }
        public string Conference { get; set; }
        public List<TeamStructure> Things { get; set; }


        public FranchiseData(string city, string name, string year, string pict, string champ, string conf, List<TeamStructure> things)
        {
            City = city;
            Name = name;
            Year = year;
            Pict = pict;
            ChampAmount = champ;
            Conference = conf;
            Things = things;
        }
    }

    [Table("Players")]

    public class PlayerRepos
    {
        [PrimaryKey, AutoIncrement, Column("_id")]
        public int Id { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string DateBirth { get; set; }
        public string Position { get; set; }
        public string Nationality { get; set; }
        public string Number { get; set; }
        public string Club { get; set; }
        public string ClubLogo { get; set; }
        public string PlayerPict { get; set; }
        public string PPG { get; set; }
        public string RPG { get; set; }
        public string APG { get; set; }
        public string MPG { get; set; }

    }

    public class Player
    {
        public string Surname { get; set; }
        public string Name { get; set; }
        public string DateBirth { get; set; }
        public string Position { get; set; }
        public string Nationality { get; set; }
        public string Number { get; set; }
        public string Club { get; set; }
        public string ClubLogo { get; set; }
        public string PlayerPict { get; set; }
        public string PPG { get; set; }
        public string RPG { get; set; }
        public string APG { get; set; }
        public string MPG { get; set; }
        public int Identification { get; set; }

        public Player(string SName, string name, string date, string pos, string nation, string num, string club, string clublogo, string playerpict, string ppg, string rpg, string apg, string mpg, int id)
        {
            Surname = SName;
            Name = name;
            DateBirth = date;
            Position = pos;
            Nationality = nation;
            Number = num;
            Club = club;
            ClubLogo = clublogo;
            PlayerPict = playerpict;
            Identification = id;
            PPG = ppg;
            RPG = rpg;
            APG = apg;
            MPG = mpg;
        }

    }

    public class NBATeam : IEnumerable, IEnumerator
    {
        //public Player[] TeamRoster = null;
        public int PlayersNumber;
        readonly Player[] TeamRoster =  new Player[5];

        public Player this[int index]
        {
            get { return TeamRoster[index]; }
            set { TeamRoster[index] = value; }
        }
        int position = -1;

        public NBATeam()
        {
            PlayersNumber = 0;
        }

        public void AddToRoster(string SName, string Name, string date, string pos, string nation, string num, string club, string clublogo, string playerpict, string ppg, string rpg, string apg, string mpg, int id)
        {
            TeamRoster[PlayersNumber] = new Player(SName, Name, date, pos, nation, num, club, clublogo, playerpict, ppg, rpg, apg, mpg, id);
            PlayersNumber++;
        }
        
        public void DeletePlayer(Player play)
        {
            foreach (Player player in TeamRoster)
            {
                if (player == play)
                {
                    TeamRoster[position] = TeamRoster[PlayersNumber - 1];
                    PlayersNumber--;
                }
            }
        }

        bool IEnumerator.MoveNext()
        {
            if (position < TeamRoster.Length - 1)
            {
                position++;
                return true;
            }
            else
            {
                ((IEnumerator)this).Reset();
                return false;
            }
        }
        void IEnumerator.Reset()
        {
            position = -1;
        }
        object IEnumerator.Current
        {
            get { return TeamRoster[position]; }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator)this;
        }
    }

    public class PlayersDictionary : KeyedCollection<int, Player>
    {
        protected override int GetKeyForItem(Player player)
        {
            return player.Identification;
        }

    }

}
