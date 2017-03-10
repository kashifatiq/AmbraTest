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
        protected void Page_Load(object sender, EventArgs e)
        {

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
    }
}