using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Series_Calculator.HelperLibrary;

namespace Series_Calculator.Entity
{
    public class OutputResult
    {
        public string Message { get; set; }
        public object Result { get; set; }
        public Status OutputStatus { get; set; }
    }
}
