using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ware_house.Schemas
{
    public class Result
    {
        public bool hasError { get; set; }
        public string successMessage { get; set; }
        public string errorMessage { get; set; }
        public Object result { get; set; }
    }
    public class ResultFactor : Result { 
    
    }


}
