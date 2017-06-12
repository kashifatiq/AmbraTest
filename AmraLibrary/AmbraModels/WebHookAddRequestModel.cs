using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AmraLibrary.AmbraModels
{
    public class WebHookAddRequestModel
    {
        public SessionLoginRequest Login = new SessionLoginRequest();
        public WebHookAddRequest webHookAddRequest = new WebHookAddRequest();
    }

    public class WebHookAddRequest
    {
        public string URL { get { return "/webhook/add"; } }
        public string sid { get { return "{{sid}}"; } }
        public string account_id { get; set; }
        public string name { get; set; }
        public string @event { get; set; }
        public string method { get; set; }
        public string url { get; set; }
        public Parameters Parameters { get; set; }
    }

    public class Parameters
    {
        public string StudyUuid { get; set; }
        public string PatientId { get; set; }
        public string NamespaceId { get; set; }
        public string StudyDescription { get; set; }
        public string AccessionNo { get; set; }
        public string PatientName { get; set; }
        public string StudyInstanceUid { get; set; }
        public string PatientBirthDate { get; set; }
        public string StudyDate { get; set; }
        public string GatewayID { get; set; }
    }
}
