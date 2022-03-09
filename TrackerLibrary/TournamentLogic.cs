using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;

namespace TrackerLibrary
{
    public static class TournamentLogic
    {
        // Order our list of teams randomly
        // check if it is big enough - if not, add in byes 2*2*2*2 - 2^4
        // create our first round of matchups
        //Create any rounds after that

        public static void CreateRounds(TournamentModel model)
        {
            List<TeamModel> randomizeTeams = RandomizeTeamModel(model.EnteredTeams);
        }

        private static List<TeamModel> RandomizeTeamModel(List<TeamModel> teams)
        {
            return teams.OrderBy(x => Guid.NewGuid()).ToList();
        }
    }
}
