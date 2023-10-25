﻿using System;
using System.Data;
using System.Data.SqlClient;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;
using CEI_PRoject;

namespace CEIHaryana.Contractor
{
    public partial class Contractor : System.Web.UI.MasterPage
    {
        CEI CEI = new CEI();
      string REID = string.Empty;
        protected void Page_Load(object sender, EventArgs e)
        {
            try

            {
                if (Convert.ToString(Session["ContractorID"]) != null || Convert.ToString(Session["ContractorID"]) != string.Empty)
                {

                    lblName.Text = Convert.ToString(Session["ContractorID"]);
                }
                else if (Session["ContractorID"] == null)
                {
                    HttpContext.Current.Response.Cache.SetCacheability(HttpCacheability.NoCache);
                    HttpContext.Current.Response.Cache.SetNoStore();
                    Response.Redirect("/Login.aspx");
                }
                else
                {

                    Session["ContractorID"] = "";
                    Response.Redirect("/Login.aspx");
                }
                GetContractorNotifications();
                //if(TextBoxPlaceholder.Controls.Count > 0)
                //{
                //    string alert = "alert('');";
                //    ScriptManager.RegisterStartupScript(this, this.GetType(), "erroralert", alert, true);
                //}
            }
            catch
            {
                Session["ContractorID"] = "";
                Response.Redirect("/Login.aspx");
            }
        }
        protected void btnLogout_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("/Login.aspx");
        }

        public void GetContractorNotifications()
        {
            REID = Session["ContractorID"].ToString();
            DataSet ds = new DataSet();
            ds = CEI.GetContractorNotifications(REID);
            TextBoxPlaceholder.Controls.Clear();

            int rowIndex = 0;

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                string dynamicData = row["IntimationId"].ToString();

                // Create a new TextBox control for each data item
                TextBox textBox = new TextBox
                {
                    ID = "TextBox_" + rowIndex, // Unique ID for each TextBox
                    CssClass = "form-control notification-box font-weight-light small-text mb-0 text-muted",
                    Text = "Supervisor Created Test Report for Intimation: " + dynamicData,
                    TextMode = TextBoxMode.MultiLine,
                    Rows = 2,
                   // WStyle = "font-size: 12px;"
                };

                // Add the TextBox to the placeholder
                TextBoxPlaceholder.Controls.Add(textBox);

                // Add a line break between TextBoxes
                TextBoxPlaceholder.Controls.Add(new LiteralControl("<br />"));

                rowIndex++;
            }

            // Add some hardcoded text
            //string hardcodedText = "Hardcoded Text: This is some additional text.";
            //TextBoxPlaceholder.Controls.Add(new LiteralControl(hardcodedText));
        }
    }
}