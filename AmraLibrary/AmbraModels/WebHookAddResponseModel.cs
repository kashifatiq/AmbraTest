namespace AmraLibrary.AmbraModels
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class WebHookAddResponseModel
    {
        public string HTTP_STATUS_CODE { get; set; }
        public string uuid { get; set; }
        public string status { get; set; }
        public string error_type { get; set; }
    }
}
