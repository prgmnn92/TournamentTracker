using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary.Models
{
    public class MatchupModel
    {
        /// <summary>
        /// Represents the Entries.
        /// </summary>
        public List<MatchupEntryModel> Entries { get; set; } = new List<MatchupEntryModel>();

        /// <summary>
        /// Represents the winner in a Matchup.
        /// </summary>
        public TeamModel Winner { get; set; }

        public int MatchupRound { get; set; }
    }
}
