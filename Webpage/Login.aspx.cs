using System;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DataTableSample
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
        protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
        {
            if (Login1.Password == "DorLomin")
            {
                e.Authenticated = true;
                Login1.Visible = false;
            }
        }
    }
}