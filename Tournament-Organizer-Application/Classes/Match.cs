using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tournament_Organizer_Application.Classes
{
    [Serializable]
    public class Match
    {
        public decimal WeightClass { get; set; }
        public Wrestler HomeWrestler { get; set; }
        public Wrestler AwayWrestler { get; set; }
        public List<Point> PointsScored { get; set; } = new List<Point>();
        public string MatchName { get; set; }

        public override string ToString()
        {
            return $"{HomeWrestler.LastName},{HomeWrestler.FirstName} vs. {AwayWrestler.LastName},{AwayWrestler.FirstName} - {MatchName} - {WeightClass} lbs";
        }

        public Match()
        {
            PointsScored = new List<Point>();
        }

        public Match(Match match)
        {
            WeightClass = match.WeightClass;
            HomeWrestler = new Wrestler(match.HomeWrestler);
            AwayWrestler = new Wrestler(match.AwayWrestler);
            MatchName = match.MatchName;
            foreach (var point in match.PointsScored)
            {
                Point newPoint = new Point(point);
                {
                    PointsScored.Add(newPoint);
                }
            }
        }
    }
}
