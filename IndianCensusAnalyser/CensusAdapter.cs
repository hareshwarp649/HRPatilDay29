using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndianCensusAnalyser
{
    public class CensusAdapter
    {
        protected string[] GetCensusData(string csvFilePath, string dataHeaders)
        {
            try
            {
                string[] censusData;

                if (!File.Exists(csvFilePath))
                {
                    throw new CensusException("File Not Found", CensusException.ExceptionType.FILE_NOT_FOUND);
                }

                if (Path.GetExtension(csvFilePath) != ".csv")
                {
                    throw new CensusException("Invalid File Type", CensusException.ExceptionType.INVALID_FILE_TYPE);
                }

                censusData = File.ReadAllLines(csvFilePath);
                if (censusData[0] != dataHeaders)
                {
                    throw new CensusException("Incorrect header in Data", CensusException.ExceptionType.INCORRECT_HEADER);
                }
                return censusData;
            }
            catch (CensusException ex)
            {
                throw ex;
            }
        }
    }
}
