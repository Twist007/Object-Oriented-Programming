using System;
using System.Collections.Generic;
using System.Linq;

namespace OOP_Lab_Football.Models
{
    public class Team
    {
        private string name;
        private string nickname;
        private DateTime dateFounded;
        private List<Player> players;

        public Team(string name, string nickname,DateTime dateFounded)
        {
            this.Name = name;
            this.NickName = nickname;
            this.DateFounded = dateFounded;
            this.players=new List<Player>();
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrEmpty(value)||value.Length<5)
                {
                    throw new ArgumentException("Name should be at last 5 chars long!");
                }
                this.name = value;
            }
        }

        public string NickName
        {
            get { return this.nickname; }
            set
            {
                if (string.IsNullOrEmpty(value) || value.Length < 5)
                {
                    throw new ArgumentException("Nickname should be at last 5 chars long!");
                }
                this.nickname = value;
            }
        }

        public DateTime DateFounded
        {
            get { return this.dateFounded; }
            set
            {
                if (value.Year<1850)
                {
                    throw new ArgumentException("Year must be after 1850!");
                }
                this.dateFounded = value;
            }
        }

        public IEnumerable<Player> Players
        {
            get { return this.players; }
        }

        public void AddPlayer(Player player)
        {
            if (CheckIfPlayerExists(player))
            {
                throw new InvalidOperationException("Player already exists for that team!");
            }
            this.players.Add(player);
        }

        private bool CheckIfPlayerExists(Player player)
        {
            return this.players.Any(p => p.FirstName == player.FirstName && p.LastName == player.LastName);
        }
    }
}