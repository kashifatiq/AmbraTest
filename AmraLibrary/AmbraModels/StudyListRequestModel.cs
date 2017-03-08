namespace AmraLibrary.AmbraModels
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class StudyListRequestModel
    {
        public SessionLoginRequest Login = new SessionLoginRequest();
        public StudyListRequest studyRequest = new StudyListRequest();
    }

    public class StudyListRequest
    {
        public string URL { get { return "/study/list"; } }
        public string sid { get { return "{{sid}}"; } }
    }
}
