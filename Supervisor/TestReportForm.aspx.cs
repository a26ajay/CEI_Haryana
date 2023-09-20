﻿using CEI_PRoject;
using System;
using System.Data;
using System.Web.UI.WebControls;

namespace CEIHaryana.Supervisor
{
    public partial class TestReportForm : System.Web.UI.Page
    {
        CEI CEI = new CEI();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                BindListBoxInstallationType();
            }

            }
        private void BindListBoxInstallationType()
        {
            DataSet dsWorkDetail = new DataSet();
            dsWorkDetail = CEI.GetddlInstallationType();
            ddlWorkDetail.DataSource = dsWorkDetail;
            ddlWorkDetail.DataTextField = "InstallationType";
            ddlWorkDetail.DataValueField = "Id";
            ddlWorkDetail.DataBind();
            ddlWorkDetail.Items.Insert(0, new ListItem("Select", "0"));
            dsWorkDetail.Clear();
        }
        protected void ddlWorkDetail_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Value = ddlWorkDetail.SelectedItem.ToString();
            if (ddlWorkDetail.SelectedValue != "0")
            {
                Installation.Visible = true;
                installationType1.Visible = true;
                if (string.IsNullOrEmpty(txtinstallationType1.Text))
                {
                    txtinstallationType1.Text = Value;
                }

                else if (txtinstallationType1.Text != string.Empty && string.IsNullOrEmpty(txtinstallationType2.Text))
                {
                    installationType2.Visible = true;
                    txtinstallationType2.Text = Value;
                }
                else if (string.IsNullOrEmpty(txtinstallationType3.Text))
                {
                    installationType3.Visible = true;
                    txtinstallationType3.Text = Value;
                }
                else if (string.IsNullOrEmpty(txtinstallationType4.Text))
                {
                    installationType4.Visible = true;
                    txtinstallationType4.Text = Value;
                }
                else if (string.IsNullOrEmpty(txtinstallationType5.Text))
                {
                    installationType5.Visible = true;
                    txtinstallationType5.Text = Value;
                }
                else if (string.IsNullOrEmpty(txtinstallationType6.Text))
                {

                    installationType6.Visible = true;
                    txtinstallationType6.Text = Value;
                }
                else if (string.IsNullOrEmpty(txtinstallationType7.Text))
                {
                    installationType7.Visible = true;
                    txtinstallationType7.Text = Value;
                }
                else if (string.IsNullOrEmpty(txtinstallationType8.Text))
                {
                    installationType8.Visible = true;
                    txtinstallationType8.Text = Value;
                }
                if (ddlWorkDetail.SelectedValue != "0")
                {

                    try
                    {
                        string selectedValue = ddlWorkDetail.SelectedValue;
                        ListItem itemToRemove = ddlWorkDetail.Items.FindByValue(selectedValue);
                        if (itemToRemove != null)
                        {
                            ddlWorkDetail.Items.Remove(itemToRemove);
                        }
                    }
                    catch (Exception)
                    { }
                    ddlWorkDetail.SelectedValue = "0";

                }
            }
        }
        protected void btnDelete1_Click(object sender, EventArgs e)
        {
            installationType1.Visible = false;
            txtinstallationType1.Text = string.Empty;
            txtinstallationNo1.Text = string.Empty;
        }

        protected void btnDelete2_Click(object sender, EventArgs e)
        {
            installationType2.Visible = false;
            txtinstallationType2.Text = string.Empty;
            txtinstallationNo2.Text = string.Empty;
        }

        protected void btnDelete3_Click(object sender, EventArgs e)
        {
            installationType3.Visible = false;
            txtinstallationType3.Text = string.Empty;
            txtinstallationNo3.Text = string.Empty;
        }

        protected void btnDelete4_Click(object sender, EventArgs e)
        {
            installationType4.Visible = false;
            txtinstallationType4.Text = string.Empty;
            txtinstallationNo4.Text = string.Empty;
        }

        protected void btnDelete5_Click(object sender, EventArgs e)
        {
            installationType5.Visible = false;
            txtinstallationType5.Text = string.Empty;
            txtinstallationNo5.Text = string.Empty;
        }

        protected void btnDelete6_Click(object sender, EventArgs e)
        {
            installationType4.Visible = false;
            txtinstallationType4.Text = string.Empty;
            txtinstallationNo4.Text = string.Empty;
        }

        protected void btnDelete7_Click(object sender, EventArgs e)
        {
            installationType7.Visible = false;
            txtinstallationType7.Text = string.Empty;
            txtinstallationNo7.Text = string.Empty;
        }

        protected void btnDelete8_Click(object sender, EventArgs e)
        {
            installationType8.Visible = false;
            txtinstallationType8.Text = string.Empty;
            txtinstallationNo8.Text = string.Empty;
        }

        protected void btnNext_Click(object sender, EventArgs e)
        {
            try
            {

                Session["installationType1"] = txtinstallationType1.Text;
                Session["installationNo1"] = txtinstallationNo1.Text;

                Session["installationType2"] = txtinstallationType2.Text;
                Session["installationNo2"] = txtinstallationNo2.Text;

                Session["installationType3"] = txtinstallationType3.Text;
                Session["installationNo3"] = txtinstallationNo3.Text;

                Session["installationType4"] = txtinstallationType4.Text;
                Session["installationNo4"] = txtinstallationNo4.Text;

                Session["installationType5"] = txtinstallationType5.Text;
                Session["installationNo5"] = txtinstallationNo5.Text;

                Session["installationType6"] = txtinstallationType6.Text;
                Session["installationNo6"] = txtinstallationNo6.Text;

                Session["installationType7"] = txtinstallationType7.Text;
                Session["installationNo7"] = txtinstallationNo7.Text;

                Session["installationType8"] = txtinstallationType8.Text;
                Session["installationNo8"] = txtinstallationNo8.Text;
                Response.Redirect("TestReportForm1.aspx");
            }
            catch
            {

            }
        }
    }
}