using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace TrackerLibrary.DataAccess.TextConnector
{
    public static class TextConnectorProcesoor
    {
        public static string FullFilePath(string fileName) // PrizeModel.csv
        {
            return $"{ ConfigurationManager.AppSettings["filePath"] }";
        }
    }
}
