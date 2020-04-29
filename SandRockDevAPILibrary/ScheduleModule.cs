using System;
using System.Collections.Generic;
using System.Text;

namespace SandRockDevAPILibrary
{
    public class ScheduleModule
    {
        public int ScheduleId { get; set; }
        public int LeagueId { get; set; }
        public virtual ClubModel League { get; set; }
        public int HomeTeam { get; set; }
        public virtual ClubModel HomeClub { get; set; }
        public int AwayTeam { get; set; }
        public virtual ClubModel AwayClub { get; set; }
        public DateTime ScheduledDateTime { get; set; }
        public bool Played { get; set; }

        public string ScheduleName
        {
            get
            {
                return HomeClub.Name + " vs " + AwayClub.Name;
            }
        }
    }
}
