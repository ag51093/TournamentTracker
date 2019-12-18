using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    /// <summary>
    /// Represents one Match in the Tournament.
    /// </summary>
    public class MatchupModel
    {
        /// <summary>
        /// The set of Teams that were involved in this match.
        /// </summary>
        public List<MatchupEntryModel> Entries { get; set; } = new List<MatchupEntryModel>();
        
        /// <summary>
        /// The winner of the Match.
        /// </summary>
        public TeamModel Winner { get; set; }

        /// <summary>
        /// Which Round this Match is a part of.
        /// </summary>
        public int MatchupRound { get; set; }

    }
}
