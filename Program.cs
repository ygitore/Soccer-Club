using System;

namespace SoccerClub
{
    class Program
    {
        static void Main(string[] args)
        {
            Player cristianoRonaldo = new Player(){
                FirstName = "Cristiano",
                LastName = "Ronaldo",
                Position = "striker",
                Assist = 203,
                Appearance = 90,
                CurrentClub = "Serie A",
                DateOfBirth = new DateTime(1985, 10,12),
                Goals = 76,
                Height = 186,
                Weight = 90,
                Joined = new DateTime(2018,08, 13),
                Nationality = "Portuguese",
                Number = 7,
                RedCard = 2,
                YellowCard = 4,
                Salary = 300000                
            };
            Player lionelMessi = new Player(){
                FirstName = "Lionel",
                LastName = "Messi",
                Position = "striker",
                Assist = 175,
                Appearance = 391,
                CurrentClub = "Barcelona",
                DateOfBirth = new DateTime(1986, 10,12),
                Goals = 565,
                Height = 145,
                Weight = 65,
                Joined = new DateTime(2002,08, 11),
                Nationality = "Argentina",
                Number = 10,
                RedCard = 1,
                YellowCard = 2,
                Salary = 320000                
            };
            Player thierryHenry = new Player(){
                FirstName = "Thierry",
                LastName = "Henry",
                Position = "Forward",
                Assist = 200,
                Appearance = 201,
                CurrentClub = "Arsenal",
                DateOfBirth = new DateTime(1978, 04,13),
                Goals = 75,
                Height = 145,
                Weight = 78,
                Joined = new DateTime(1998,08, 11),
                Nationality = "Argentina",
                Number = 14,
                RedCard = 0,
                YellowCard = 0,
                Salary = 120000                
            };
            Player patrickVieira = new Player(){
                FirstName = "Vieira",
                LastName = "Patrick",
                Position = "Forward",
                Assist = 3021,
                Appearance = 243,
                CurrentClub = "Arsenal",
                DateOfBirth = new DateTime(1975, 01,10),
                Goals = 121,
                Height = 190,
                Weight = 95,
                Joined = new DateTime(1994,04, 04),
                Nationality = "French",
                Number = 14,
                RedCard = 10,
                YellowCard = 13,
                Salary = 85000                
            };

            Club arsenal = new Club("Arsenal", "London", "England", 1886);
            Club barcelona = new Club("Barcelona", "Barcelona", "Spain", 1899);
            Club SerieA = new Club("Serie A", "Rom", "Italy", 1929);

            arsenal.AddPlayer(thierryHenry);
            arsenal.AddPlayer(patrickVieira);
            barcelona.AddPlayer(lionelMessi);
            SerieA.AddPlayer(cristianoRonaldo);

            System.Console.WriteLine("...............");
            cristianoRonaldo.PrintPlayerInfo();
            System.Console.WriteLine("...............");

            AllClubs clubs = new AllClubs();
            clubs.AddClub(arsenal);
            clubs.AddClub(barcelona);
            clubs.AddClub(SerieA);
            clubs.PrintClubs();
        }
    }
}
