using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AmraLibrary;
namespace AmbraTestApp
{
    public partial class testCalls : System.Web.UI.Page
    {
        AmbraApiCalls apiCalls = new AmbraApiCalls();
        string _UserName = "kashif.atiq@tenpearls.com";
        string _Password = "qazwsx123";
        string _account_id = "76e0106d-4068-4cb8-964e-9dd0bd4f411b";
        protected void Page_Load(object sender, EventArgs e)
        {
            
            Dictionary<string, string> postedData = new Dictionary<string, string>();
            string ss = "";
            foreach(string str in Request.Form.Keys)
            {
                ss = ss +","+ str;
                postedData.Add(str, Request.Form[str]);
            }
            string json = Helpers.ConvertObjectToJsonString(postedData);
           
        }

        protected void btnCreateSession_Click(object sender, EventArgs e)
        {
            apiCalls.CreateSession(_UserName, _Password);
        }

        protected void btnGetStudyList_Click(object sender, EventArgs e)
        {
            apiCalls.GetStudyList(_UserName, _Password);
        }

        protected void btnGeStudy_Click(object sender, EventArgs e)
        {
            apiCalls.GetSingleStudy(_UserName, _Password);
        }

        protected void btnGetWebhook_Click(object sender, EventArgs e)
        {
            apiCalls.GetWebHookList(_UserName, _Password, _account_id);
        }

        protected void btnCreateWebHook_Click(object sender, EventArgs e)
        {
            apiCalls.CreateWebHook(_UserName, _Password, _account_id, "test", "https://df5f9ea8.ngrok.io/");
        }

        protected void btnTestDateTime_Click(object sender, EventArgs e)
        {
            string patientBirthDate = "19410901";
            patientBirthDate = patientBirthDate.Substring(0, 4) + "-" + patientBirthDate.Substring(4, 2) + "-" + patientBirthDate.Substring(6, 2);
            DateTime d = Convert.ToDateTime(patientBirthDate);
        }
    }
}