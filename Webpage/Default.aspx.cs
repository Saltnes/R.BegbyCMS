using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;

namespace DataTableSample
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Blayer bl = new Blayer();
                LabelParagraph1.Text = bl.Content1();
            }
        }


        protected void ButtonSave_OnClick(object sender, EventArgs e)
        {
            Blayer bl = new Blayer();
            bl.SaveWebContent1(TextParagraph1Edit.Text);
        }
    }
}