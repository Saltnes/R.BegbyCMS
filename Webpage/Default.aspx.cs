using System;
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
    }
}