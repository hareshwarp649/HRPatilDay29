using IndianCensusAnalyser.DTOcen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndianCensusAnalyser
{
    public class CensusAnalyser
    {

        public enum Country
        {
            INDIA, US
        }
        Dictionary<string, CensusDTO> datamap;
        public Dictionary<string, CensusDTO> LoadCensusData(Country country, string csvFilePath, string dataHeaders)
        {
            datamap = new CsvFactory().LoadCsvData(country, csvFilePath, dataHeaders);
            return datamap;
        }
    }
}
