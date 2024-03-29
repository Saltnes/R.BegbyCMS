﻿using System;
using System.Web.UI;
using BusinessLayer;

namespace DataTableSample
{
    public partial class Edit : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Blayer bl = new Blayer();
                string content1Text = bl.Content1();
                LabelParagraph1.Text = content1Text;
                TextParagraph1Edit.Text = content1Text;
                
                string content2Text = bl.Content2();
                LabelParagraph2.Text = content2Text;
                TextParagraph2Edit.Text = content2Text;
            }
        }
        
        
        protected void ButtonSave_OnClick(object sender, EventArgs e)
        {
            Blayer bl = new Blayer();
            bl.SaveWebContent1(TextParagraph1Edit.Text); 
        }

        protected void ButtonSave2_OnClick(object sender, EventArgs e)
        {
            Blayer bl = new Blayer();
            bl.SaveWebContent2(TextParagraph2Edit.Text);
        }
        
        protected void ButtonUpload_Click(object sender, EventArgs e)
        {
            string imagesPath = Server.MapPath("~/images");
            FileUpload1.SaveAs(imagesPath + "\\" + FileUpload1.FileName);
        }

        
    }
}

