using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace OOP_Lab_Football.Models
{
    public static class league
    {
        private static List<Team> teams = new List<Team>();
        private static List<Match> matches = new List<Match>();

        public static IEnumerable<Team> Teams
        {
            get { return teams; }
        }

        public static IEnumerable<Match> Matches
        {
            get { return matches; }
        }

        public static void AddTeam(string nameTeam, string nickName, DateTime dateOfFounded)
        {
            Team team=new Team(nameTeam,nickName,dateOfFounded);
            
            if (teams.All(t => t.Name != team.Name))
            {
                teams.Add(team);
                Console.WriteLine("Team Added");
           
            }
            else
            {
                throw new ArgumentException("Team contains");
            }
           
        }

        public static void AddMatch(int id, string homeTeam, string aweyTeam, int homeGoals, int aweyGoals)
        {
            Score score=new Score(homeGoals,aweyGoals);
            Match mach=new Match(homeTeam, aweyTeam,score,id);
            if (matches.All(m => m.Id != mach.Id))
            {
                matches.Add(mach);
                Console.WriteLine("Mach Added");
            }
            else
            {
                throw new ArgumentException("Mach contains");
            }
        }
    }
}