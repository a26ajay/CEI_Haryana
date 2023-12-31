﻿using CEI_PRoject;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CEIHaryana.SiteOwnerPages
{
    public partial class PendingPayment : System.Web.UI.Page
    {
        CEI CEI = new CEI();
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!Page.IsPostBack)
                {
                    BindGrid();
                }
            }
            catch
            {
            }

        }

        public void BindGrid()
        {
            string LoginID = string.Empty;
            LoginID = Session["SiteOwnerId"].ToString();
            DataTable ds = new DataTable();
            ds = CEI.SiteOwnerPendingPayment(LoginID);
            if (ds.Rows.Count > 0)
            {
                GridView1.DataSource = ds;
                GridView1.DataBind();
            }
            else
            {
                GridView1.DataSource = null;
                GridView1.DataBind();
                string script = "alert(\"No Record Found\");";
                ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
            }
            ds.Dispose();
        }
        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            Control ctrl = e.CommandSource as Control;
            GridViewRow row = ctrl.Parent.NamingContainer as GridViewRow;
            Label lblID = (Label)row.FindControl("lblID");
            Session["PendingPaymentId"] = lblID.Text;
            Label lblIntimationId = (Label)row.FindControl("lblIntimationId");
            Session["PendingIntimations"] = lblIntimationId.Text;
            Label lblType = (Label)row.FindControl("lblType");
            Session["Data1"] = lblType.Text;
            Label lblVoltageLevel = (Label)row.FindControl("lblVoltageLevel");
            Session["Data2"] = lblVoltageLevel.Text;
            if (e.CommandName == "Select")

            {
                Response.Redirect("/SiteOwnerPages/PaymentPage.aspx");

            }
        }
    }
}