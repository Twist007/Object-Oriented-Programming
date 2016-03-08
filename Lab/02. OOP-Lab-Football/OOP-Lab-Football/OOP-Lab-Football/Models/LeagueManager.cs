using System;

namespace OOP_Lab_Football.Models
{
    public static class LeagueManager
    {
        public static void HandleInput(string input)
        {
            var inputArgs = input.Split();
            switch (inputArgs[0])
            {
                case "AddTeam":
                    league.AddTeam(inputArgs[1], inputArgs[2], DateTime.Parse(inputArgs[3]));
                    break;
                case"AddMatch":
                    league.AddMatch(int.Parse(inputArgs[1]), inputArgs[2], inputArgs[3],
                       int.Parse(inputArgs[4]), int.Parse(inputArgs[5]));
                    break;
                case"AddPlayerToTeam":
                    AddPlayerToTeam(inputArgs[1], inputArgs[2],
                        DateTime.Parse(inputArgs[3]), decimal.Parse(inputArgs[4]), inputArgs[5]);
                    break;
                case"ListTeams":
                    break;
                case "ListMatches":
                    break;
                
            }
        }

        private static void AddPlayerToTeam(string firstName, string lastName, DateTime dateOfBirth,
            decimal salary, string team)
        {
           
           
           
        }

      

       
    }
}