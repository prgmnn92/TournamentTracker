using System;
using System.Collections.Generic;
using System.Text;
using TrackerLibrary.Models;

namespace TrackerLibrary.DataAccess
{
    public class TextConnector : IDataConnection
    {

        //TODO - Wire up the CreatePrize For the text files.
        public PrizeModel CreatePrize(PrizeModel model)
        {
            // Load the text file
            // Convert the text to List<PrizeModel>
            // Find the max ID
            // Add the new record with the new ID
            //Convert the prizes to a list<string>
            //save the list<string> to the text file


        }
    }
}
