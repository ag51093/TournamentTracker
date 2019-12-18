using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    /// <summary>
    /// Represents one Team in the Matchup.
    /// </summary>
    public class MatchupEntryModel
    {
        /// <summary>
        /// Represents one Team in the Matchup.
        /// </summary>
        public TeamModel TeamCompeting { get; set; }
        
        /// <summary>
        /// Represents the Score for this particular Team.
        /// </summary>
        public double Score { get; set; }

        /// <summary>
        /// Represents the Matchup that this team came from 
        /// as the Winner.
        /// </summary>
        public MatchupModel ParentMatchup { get; set; } 

    }
}
