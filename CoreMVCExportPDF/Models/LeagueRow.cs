using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreMVCExportPDF.Models
{
    public class LeagueRow
    {
        public int position { get; set; }
        public string club { get; set; }
        public int numGames { get; set; }
        public int points { get; set; }

        public LeagueRow(int position, string club, int numGames, int points)
        {
            this.position = position;
            this.club = club;
            this.numGames = numGames;
            this.points = points;
        }
    }
}
