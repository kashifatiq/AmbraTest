using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestAmbra.AmbraModels
{
    public class SessionLoginResponse
    {
        public string HTTP_STATUS_CODE { get; set; }
        public string name { get; set; }
        public string uuid { get; set; }
        public string sid { get; set; }
        public string status { get; set; }
        public int training_todo { get; set; }
    }
}