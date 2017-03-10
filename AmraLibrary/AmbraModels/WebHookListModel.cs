namespace AmraLibrary.AmbraModels
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class WebHookListModel
    {
        public int training_todo { get; set; }
        public string HTTP_STATUS_CODE { get; set; }
        public string sid { get; set; }
        public string name { get; set; }
        public string status { get; set; }
        public string uuid { get; set; }
        public List<WebHookModel> webhooks { get; set; }
        public PageModel page { get; set; }
    }
}
