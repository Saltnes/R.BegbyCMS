using System;
using System.Web.UI;
using BusinessLayer;

namespace DataTableSample
{
    public partial class About : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Blayer bl = new Blayer();
                LabelParagraph2.Text = bl.Content2();
            }

        }
    }
}