using System;
using System.Collections.Generic;

namespace SoccerClub
{
    class Club
    {
        private int YearEstablished {get; set;}
        public string ClubName{get;set;}
        private string City{get;set;}
        public string Country {get;set;}
        private List<Player> players = new List<Player>();
        public Club(string name, string city, string country, int year){
            this.ClubName = name;
            this.City = city;
            this.Country = country;
            this.YearEstablished = year;
        }
        public void AddPlayer(Player newPlayer){
            players.Add(newPlayer);
        }
        public void PrintPlayers(){
            foreach (Player player in players)
            {
                System.Console.WriteLine(player);
            }
        }
    }
}