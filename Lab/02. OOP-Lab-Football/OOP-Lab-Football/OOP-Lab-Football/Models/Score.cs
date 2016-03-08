using System;

namespace OOP_Lab_Football.Models
{
    public class Score
    {
        private int homeTeamGoals;
        private int aweyTeamGoals;

        public Score(int homeTeamGoals, int aweyTeamGols)
        {
            this.HomeTeamGoals = homeTeamGoals;
            this.AweyTeamGoals = aweyTeamGols;
        }

        public int HomeTeamGoals
        {
            get { return this.homeTeamGoals; }
            set
            {
                if (value<0)
                {
                    throw new ArgumentException("Goals cannot be negative!");
                }
                this.homeTeamGoals = value;
            }
        }

        public int AweyTeamGoals
        {
            get { return this.aweyTeamGoals; }
            set
            {
                if (value<0)
                {
                    throw new ArgumentException("Goals cannot be negative!");
                }
                this.homeTeamGoals = value;
            }
        }
    }
}