using System;
using System.Collections.Generic;

namespace SoccerClub
{
    class Player
    {
        public string FirstName {get;set;}
        public string LastName {get;set;}
        public int Number {get;set;}
        public string Position {get;set;}
        public int Appearance {get;set;}
        public int Goals {get;set;}
        public string Nationality {get;set;}
        public DateTime Joined {get;set;}
        public DateTime DateOfBirth {get;set;}
        public int Assist {get;set;}
        public int Height {get;set;}
        public int Weight {get;set;}
        public double Salary {get;set;}
        public int RedCard {get;set;}
        public int YellowCard {get;set;}
        public string CurrentClub {get;set;}                    
        public int Age {
            get {
                return DateTime.Now.Year - DateOfBirth.Year;
            }
        }
        public void PrintPlayerInfo(){
            string playInfo = 
            @$"
                Full Name:{FirstName} {LastName} 
                Number: {Number} 
                Position: {Position} 
                Appearance: {Appearance}
                Goals: {Goals}
                Nationality: {Nationality}
                Joined: {Joined} 
                Date of birth: {DateOfBirth}
                Assisted: {Assist}
                Height: {Height}
                Weight: {Weight}
                Salary: {Salary}
                Yellow Card: {YellowCard}
                Red Card: {RedCard}
                Current Club: {CurrentClub}";
            System.Console.WriteLine(playInfo);
        }
    }
}