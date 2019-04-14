using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tournament_Organizer_Application.Classes
{
    [Serializable]
    public class Point
    {
        public int PointValue { get; set; }
        public string MethodScored { get; set; }
        public Wrestler HomeWrestler { get; set; }
        public Wrestler AwayWrestler { get; set; }
        public bool? HomeScored { get; set; }
        public string VideoDirectory { get; set; }
        public Point()
        {
            HomeScored = null;
        }

        public Point(Point point)
        {
            PointValue = point.PointValue;
            MethodScored = point.MethodScored;
            HomeScored = point.HomeScored;
            HomeWrestler = new Wrestler(point.HomeWrestler);
            AwayWrestler = new Wrestler(point.AwayWrestler);
            VideoDirectory = point.VideoDirectory;
        }

        public override string ToString()
        {
            if (HomeScored == true)
            {
                return $"{HomeWrestler.LastName}, {HomeWrestler.FirstName} scored {PointValue} points through {MethodScored}";
            }
            else
            {
                return $"{AwayWrestler.LastName}, {AwayWrestler.FirstName} scored {PointValue} points through {MethodScored}";
            }
        }
    }
}
