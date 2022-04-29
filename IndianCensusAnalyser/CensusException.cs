using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndianCensusAnalyser
{
    public class CensusException: Exception
    {
       
        public enum ExceptionType
        {
            FILE_NOT_FOUND, INVALID_FILE_TYPE, INCORRECT_HEADER,
            NO_SUCH_COUNTRY,
            INCOREECT_DELIMITER,
            INCORRECT_DELIMITER
        }
        public ExceptionType dType;
        public double eType;

        public CensusException(string message, ExceptionType exception) : base(message)
        {
            this.dType = exception;
        }
    }
}
