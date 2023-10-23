﻿using CEI_PRoject;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CEIHaryana.Supervisor
{
	public partial class SupervisorLineTestReport : System.Web.UI.Page
	{
        CEI cei = new CEI();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GridViewBind();
            }
        }
        public void GridViewBind()
        {
            string LoginId = string.Empty;
            LoginId = Session["AdminID"].ToString();
            DataSet ds = new DataSet();
            ds = cei.GetSuppervisorLineTestReportData(LoginId);
            if (ds.Tables.Count > 0)
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
        }



        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Select")
            {
                Control ctrl = e.CommandSource as Control;
                GridViewRow row = ctrl.Parent.NamingContainer as GridViewRow;
                Label lblID = (Label)row.FindControl("lblID");
                string id = lblID.Text;
                Session["LineID"] = id;
                Label lblApproval = (Label)row.FindControl("lblApproval");
                Session["Approval"] = lblApproval.Text;
                if (e.CommandName == "Select")
                {
                    Response.Redirect("/TestReportModal/LineTestReportModal.aspx");

                }
            }
        }

        protected void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searhterm = txtSearch.Text.Trim();
            string LoginId = string.Empty;
            LoginId = Session["ContractorID"].ToString();

            DataSet ds = new DataSet();
            ds = cei.SearchingOnLine(searhterm, LoginId);
            if (ds.Tables.Count > 0)
            {
                GridView1.DataSource = ds;
                GridView1.DataBind();
            }
            else
            {
                string script = "alert(\"No Record Match\");";
                ScriptManager.RegisterStartupScript(this, GetType(), "Server Script", script, true);
            }
        }
    }
}