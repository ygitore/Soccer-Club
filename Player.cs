using System;

namespace SoccerClub
{
    class Player
    {
        private string _firstName = "cristiano";
        private string _lastName = "ronaldo dostanto savero";
        private int number = 7;
        private int _yearBorn = 1985;
        public string Age {
            get {
                return DateTime.Now.ToString("MM/dd/yyyy");
            }
        }
    }
}