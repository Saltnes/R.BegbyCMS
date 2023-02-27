﻿using System;
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
                string content1Text = bl.Content1();
                LabelParagraph1.Text = content1Text;
                TextParagraph1Edit.Text = content1Text;
            }
        }


        protected void ButtonSave_OnClick(object sender, EventArgs e)
        {
            Blayer bl = new Blayer();
            bl.SaveWebContent1(TextParagraph1Edit.Text); // ADD TIMESTAMP WHEN SAVING IN DbLAYER 
        }
    }
}