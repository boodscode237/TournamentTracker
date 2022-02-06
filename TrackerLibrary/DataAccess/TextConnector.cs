using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;
using TrackerLibrary.DataAccess.TextHelpers;

namespace TrackerLibrary.DataAccess
{
    public class TextConnector : IDataConnection
    {
        private const string PrizesFile = "PrizeModel.csv";
        // TODO - Wire up the CreatePrize for the text file
        public PrizeModel CreatePrize(PrizeModel model)
        {
            // Load the textFile and convert the text to a list<PrizeModel>
            List<PrizeModel> prizes = PrizesFile.FullFilePath().LoadFile().ConvertToPrizeModels();

            // Find the max id
            int currentId = 1;

            if (prizes.Count > 0)
            {
                currentId = prizes.OrderByDescending(x => x.Id).First().Id + 1;
            }

            model.Id = currentId;
            // Add the new record with the  new ID (max + 1)
            prizes.Add(model);

            // Convert the prizes to a List<string>
            // Save the list of string to the text file
            prizes.SaveToPrizeFile(PrizesFile);
            return model;
        }
    }
}
