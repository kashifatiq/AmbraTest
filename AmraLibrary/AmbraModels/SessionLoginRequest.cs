namespace AmraLibrary.AmbraModels
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class SessionLoginRequest
    {
        public string URL { get { return "/session/login"; } }
        public string login { get; set; }
        public string password { get; set; }
    }
}
