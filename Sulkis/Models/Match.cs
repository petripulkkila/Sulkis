using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sulkis.Models
{
    public enum MatchStatus { Planned, InProgress, Finished, Cancelled }

    public class Match
    {
        public int Id { get; set; }
        public DateTime PlayAt { get; set; }

        public string Team1Players { get; set; }
        public string Team2Players { get; set; }

        public List<Set> Sets { get; set; }

        public MatchStatus Status { get; set; }
    }
}