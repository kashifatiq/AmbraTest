using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AmraLibrary.AmbraModels
{
    public class WebHookListRequestModel
    {
        public SessionLoginRequest Login = new SessionLoginRequest();
        public WebHookListRequest webHookRequest = new WebHookListRequest();
    }

    public class WebHookListRequest
    {
        public string URL { get { return "/webhook/list"; } }
        public string sid { get { return "{{sid}}"; } }
        public string account_id { get; set; }
    }
}
