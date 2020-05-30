using System;
using System.Collections.Generic;

namespace SoccerClub
{
    class Club
    {
        private int _yearEstablished {get; set;}
        private string ClubName{get;set;}
        private string City{get;set;}
        private string Country {get;set;}
        List<Player> players = new List<Player>();
        public Club(string name, string city, string country, int year){
            this.ClubName = name;
            this.City = city;
            this.Country = country;
            this._yearEstablished = year;
        }
        public void AddPlayer(Player newPlayer){
            players.Add(newPlayer);
        }
    }
}