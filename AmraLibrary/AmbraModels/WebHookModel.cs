namespace AmraLibrary.AmbraModels
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class WebHookModel
    {
        public object sid_user_id { get; set; }
        public string url { get; set; }
        public object filter_field { get; set; }
        public int once { get; set; }
        public int retry { get; set; }
        public object filter_regexp { get; set; }
        public int suspended { get; set; }
        public string method { get; set; }
        public string name { get; set; }
        public string @event { get; set; }
        public object node_id { get; set; }
        public string uuid { get; set; }
        public object parameters { get; set; }
        public object last_error { get; set; }
    }
}
