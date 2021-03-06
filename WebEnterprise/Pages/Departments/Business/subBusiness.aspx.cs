﻿using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebEnterprise.Pages.Departments.Business
{
    public partial class subBusiness : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.User.Identity.IsAuthenticated)
            {
                string strCurrentUserId = User.Identity.GetUserId();
                Response.Redirect("/Account/Login", true);

            }

            //check for a postback
            if (!Page.IsPostBack)
            {
                //bind the gridview data
                businessPostGridView.DataSource = businessDataSource;
                businessPostGridView.DataBind();
            }

        }

        protected void businessPostGridView_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            //check if the row is the header row
            if (e.Row.RowType == DataControlRowType.Header)
            {
                //add the thead and tbody section programatically
                e.Row.TableSection = TableRowSection.TableHeader;
            }
        }

        protected void businessPostGridView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}