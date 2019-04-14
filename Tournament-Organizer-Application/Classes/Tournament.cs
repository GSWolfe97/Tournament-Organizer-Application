using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tournament_Organizer_Application.Classes
{
    [Serializable]
    public class Tournament
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public DateTime Date { get; set; }
        public List<Match> AllMatches { get; set; } = new List<Match>();
        public string TournamentId { get; set; }
        public override string ToString()
        {
            return $"Name: {Name} Location: {Location} Date: {Date}";
        }

        public void GenerateId()
        {
            TournamentId = Guid.NewGuid().ToString("N");
        }


        public Tournament()
        {
            Name = "No Tournament Name";
            Location = "No Location";
            Date = DateTime.Now;
            AllMatches = new List<Match>();
            TournamentId = "New Tournament";
        }

        public Tournament(Tournament tournament)
        {
            Name = tournament.Name;
            Location = tournament.Location;
            Date = tournament.Date;

            foreach (var match in tournament.AllMatches)
            {
                Match newMatch = new Match(match);
                AllMatches.Add(newMatch);
            }

            TournamentId = tournament.TournamentId;
        }
    }
}
