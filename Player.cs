using System;
using System.Collections.Generic;

namespace SoccerClub
{
    class Player
    {
        public string FirstName {get;set;}
        public string LastName {get;set;}
        public int Number {get;set;}
        public int Position {get;set;}
        public int Appearance {get;set;}
        public int Goals {get;set;}
        public int Nationality {get;set;}
        public DateTime Joined {get;set;}
        public DateTime DateOfBirth {get;set;}
        public int Assist {get;set;}
        public int Height {get;set;}
        public int Weight {get;set;}
        public double Salary {get;set;}
        public int RedCard {get;set;}
        public int YellowCard {get;set;}
        public string CurrentClub {get;set;}           
        public DateTime DateLeftClub {get;set;}           
        public int Age {
            get {
                return DateTime.Now.Year - DateOfBirth.Year;
            }
        }
        public string FullName{
            get {
                return FirstName + " "+LastName;
            }
        } 
    }
}