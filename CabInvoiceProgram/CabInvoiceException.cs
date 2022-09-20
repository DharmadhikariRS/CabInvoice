using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabInvoiceProgram
{
    public class CabInvoiceException : Exception
    {
        public string message;
        public enum cabException
        {
            ZERO_DISTANCE,
            ZERO_TIME
        }
        public cabException cabexception;
        public CabInvoiceException(cabException cabexception, string message) : base(message)
        {
            this.cabexception = cabexception;
            this.message = message;
        }
    }
}
