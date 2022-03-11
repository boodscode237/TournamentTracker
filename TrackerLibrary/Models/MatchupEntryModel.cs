using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class MatchupEntryModel
    {
        /// <summary>
        /// The Unique identifier for the matchupEntry
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Represents one team in the match up
        /// </summary>
        public TeamModel TeamCompeting { get; set; }

        /// <summary>
        /// Represents the score for this particular team
        /// </summary>
        public double Score { get; set; }
        /// <summary>
        /// Represent the matchup that this team 
        /// came from the winner
        /// </summary>
        public MatchupModel ParentMatchup { get; set; }

    }
}
