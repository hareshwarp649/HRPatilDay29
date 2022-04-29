using IndianCensusAnalyser.DTOcen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndianCensusAnalyser
{
    public class CsvFactory
    {

        public Dictionary<string, CensusDTO> LoadCsvData(CensusAnalyser.Country country, string csvFilePath, string dataHeaders)
        {
            switch (country)
            {
                case (CensusAnalyser.Country.INDIA):
                    return new IndiaCensusAnalyser().LoadCensusData(csvFilePath, dataHeaders);
                default:
                    throw new CensusException("No Such Country", CensusException.ExceptionType.NO_SUCH_COUNTRY);
            }
        }
    }
}
