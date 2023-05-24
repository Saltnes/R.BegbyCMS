using System;
using DBLayer;


namespace DataTableSample
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        { 
            var dbl = new DbLayer();
            LabelNumElever.Text = dbl.GetNumOfElever().ToString();
            
            GridViewElever.DataSource = dbl.GetAllElev();
            GridViewElever.DataBind();
        }
        

        protected void ButtonSearchByFornavn_OnClick(object sender, EventArgs e)
        {
            var dbl = new DbLayer();
            var searchValue = TextBoxSearchByFornavn.Text;

            GridViewByFornavn.DataSource = dbl.GetInfoFromFornavn(searchValue);
            GridViewByFornavn.DataBind();
        }
        
    }
}