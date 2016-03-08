using System;

namespace OOP_Lab_Football.Models
{
    public class Match
    {
        private Team homeTeam;
        private Team aweyTeam;
        private Score score;
        private int id;

        public Match(string homeTeam, string aweyTeam, Score score, int id)
        {
            this.AweyTeam = aweyTeam;
            this.HomeTeam = homeTeam;
            this.Score = score;
            this.Id = id;
        }

        public Team AweyTeam
        {
            get { return this.aweyTeam; }
            set
            {
                if (aweyTeam==homeTeam)
                {
                    throw new ArgumentException("Name must be different!");
                }
                this.aweyTeam = value;
            }
        }

        public Team HomeTeam
        {
            get { return this.homeTeam; }
            set
            {
                if (aweyTeam == homeTeam)
                {
                    throw new ArgumentException("Name must be different!");
                }
                this.homeTeam = value;
            }
        }

        public Score Score { get; set; }
        public int Id { get; set; }

        public Team GetWinner()
        {
            if (this.IsDraw())
            {
                return null;
            }

            return this.Score.HomeTeamGoals > this.Score.AweyTeamGoals
                ? this.HomeTeam
                : this.AweyTeam;
        }

        private bool IsDraw()
        {
            return this.Score.AweyTeamGoals == this.Score.HomeTeamGoals;
        }
    }
}