using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tournament_Organizer_Application.Classes
{
    [Serializable]
    public class Wrestler
    {
        public DateTime BirthDay { get; set; }
        public int Age { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string School { get; set; }
        public string WrestlerId { get; set; }

        public override string ToString()
        {
            return $"{LastName},{FirstName} - Age: {Age} {School}";
        }

        public void CalculateBirthday()
        {
            Age = (int.Parse(DateTime.Now.ToString("yyyyMMdd")) - int.Parse(BirthDay.ToString("yyyyMMdd"))) / 10000;
        }

        public Wrestler()
        {
            BirthDay = new DateTime(1900, 12, 07);
            Age = 0;
            FirstName = "Removed";
            LastName = "Wrestler";
            School = "No School";
            WrestlerId = "Dummy";
        }

        public void GenerateId()
        {
            WrestlerId = Guid.NewGuid().ToString("N");
        }

        public void RemoveWrestler()
        {
            BirthDay = new DateTime(1900, 12, 07);
            Age = 0;
            FirstName = "Removed";
            LastName = "Wrestler";
            School = "No School";
            WrestlerId = "Removed";
        }

        public Wrestler(Wrestler wrestler)
        {
            BirthDay = wrestler.BirthDay;
            Age = wrestler.Age;
            FirstName = wrestler.FirstName;
            LastName = wrestler.LastName;
            School = wrestler.School;
            WrestlerId = wrestler.WrestlerId;
        }
    }
}
