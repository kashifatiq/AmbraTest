namespace AmraLibrary.AmbraModels
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class StudyRequestModel
    {
        public SessionLoginRequest Login = new SessionLoginRequest();
        public StudyRequest studyRequest = new StudyRequest();
    }

    public class StudyRequest
    {
        public string URL { get { return "/study/get"; } }
        public string sid { get { return "{{sid}}"; } }
        public string uuid { get; set; }
    }
}
