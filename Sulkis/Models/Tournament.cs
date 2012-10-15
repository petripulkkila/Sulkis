using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sulkis.Models
{
    public class Tournament
    {
        public int Id { get; set; }

        public string Description { get; set; }

        public List<Match> PlayedMatches { get; set; }
        public List<Match> MatchesToCome { get; set; }
    }
}