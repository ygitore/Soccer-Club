using System;
using System.Collections.Generic;

namespace SoccerClub
{
    class AllClubs
    {
        List<Club> clubs = new List<Club>();
        public void AddClub(Club club){
            clubs.Add(club);
        }
        public void PrintClubs(){
            foreach(Club club in clubs){
                System.Console.WriteLine("{0} is {1} club", club.ClubName, club.Country);
            }
        }
    }
}