﻿using CEI_PRoject;
using OfficeOpenXml.Drawing.Slicer.Style;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using System.Runtime.ConstrainedExecution;


namespace CEIHaryana.UserPages
{
    public partial class ContractorApplicationForm : System.Web.UI.Page
    {
        CEI CEI = new CEI();
        string LoginID = string.Empty;
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!IsPostBack)
                {
                    if (Session["ContractorID"] != null)
                    {
                        ContractorInformation();
                        ddlLoadBindState();
                        if (Session["PartnerDirector"] != null)
                        {
                            PartnersModalDirectorData();
                        }
                        else
                        {

                        }
                    }
                    else
                    {

                    }
                }
            }
            catch
            {
                Response.Redirect("/Login.aspx");
            }

        }
        private void ContractorInformation()
        {
            try
            {

                LoginID = Session["ContractorID"].ToString();
                DataTable ds = new DataTable();
                ds = CEI.ContractorBasicInformation(LoginID);
                if (ds.Rows.Count > 0)
                {
                    txtContractorName.Text = ds.Rows[0]["Name"].ToString();
                    txtFatherName.Text = ds.Rows[0]["FatherName"].ToString();
                    txtBirthDate.Text = ds.Rows[0]["DOB"].ToString();
                    txtAppliedFor.Text = ds.Rows[0]["ApplicationFor"].ToString();
                }
                else
                {

                }

            }
            catch { }
        }
        private void ddlLoadBindState()
        {
            try
            {
                DataSet dsState = new DataSet();
                dsState = CEI.GetddlDrawState();
                ddlState.DataSource = dsState;
                ddlState.DataTextField = "StateName";
                ddlState.DataValueField = "StateID";
                ddlState.DataBind();
                ddlState.Items.Insert(0, new ListItem("Select", "0"));
                dsState.Clear();
            }
            catch (Exception)
            {
            }
        }

        protected void ddlState_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ddlLoadBindDistrict(ddlState.SelectedItem.ToString());
                ScriptManager.RegisterStartupScript(this, this.GetType(), "showModal", "$('#myModal').modal('show');", true);
            }
            catch { }

        }
        protected void ddlPenalities_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (ddlPenalities.SelectedValue != "0")
                {
                    string selectedValue = ddlPenalities.SelectedValue;

                    if (!string.IsNullOrEmpty(txtPenalities.Text))
                    {
                        // If the TextBox is not empty, append a comma and space
                        txtPenalities.Text += ", ";
                    }

                    txtPenalities.Text += ddlPenalities.SelectedItem.ToString();

                    ListItem itemToRemove = ddlPenalities.Items.FindByValue(selectedValue);
                    if (itemToRemove != null)
                    {
                        ddlPenalities.Items.Remove(itemToRemove);
                    }

                    ddlPenalities.SelectedValue = "0";
                }
            }
            catch (Exception ex)
            {
                // Handle the exception, e.g., log or display an error message.
            }
        }

        private void ddlLoadBindDistrict(string state)
        {
            try
            {
                DataSet dsDistrict = new DataSet();
                dsDistrict = CEI.GetddlDrawDistrict(state);
                ddlDistrict.DataSource = dsDistrict;
                ddlDistrict.DataTextField = "District";
                ddlDistrict.DataValueField = "District";
                ddlDistrict.DataBind();
                ddlDistrict.Items.Insert(0, new ListItem("Select", "0"));
                dsDistrict.Clear();
            }
            catch (Exception)
            {
                //msg.Text = ex.Message;
            }
        }
        protected void DdlPartnerOrDirector_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Check if the selected value is "YES"
            if (DdlPartnerOrDirector.SelectedValue == "1")
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "showModal", "$('#myModal').modal('show');", true);
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "hideModal", "$('#myModal').modal('hide');", true);

            }
        }
        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            try
            {
            }
            catch { }
        }
        protected void BtnSubmit_Click(object sender, EventArgs e)
        {

            try
            {
                LoginID = Session["ContractorID"].ToString();
                DataTable ds = new DataTable();
                ds = CEI.GetPartnersDirectorDate(LoginID);
                if (DdlPartnerOrDirector.SelectedValue == "1" && ds.Rows.Count < 0)
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "showalert", "PartnerDirectorAlert();", true);
                }
                else
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "CallValidateForm", "validateForm();", true);

                    string validationResult = Page.ClientScript.GetWebResourceUrl(this.GetType(), "window.validationResult");

                    bool isValidBoolean;
                    if (!bool.TryParse(validationResult, out isValidBoolean))
                    {

                        string Createdby = Session["ContractorID"].ToString();
                        string selectedValues = txtPenalities.Text.Trim();
                        CEI.ContractorApplicationData(txtGstNumber.Text, ddlCompanyStyle.SelectedItem.ToString(), ddlOffice.SelectedItem.ToString(),
                            DdlPartnerOrDirector.SelectedItem.ToString(), ddlPenalities.SelectedItem.ToString(), ddlAnnexureOrNot.SelectedItem.ToString(),
                            txtAgentName.Text, ddlUnitOrNot.SelectedItem.ToString(), ddlLicenseGranted.SelectedItem.ToString(), txtIssusuingName.Text,
                            txtDOB.Text, txtLicenseExpiry.Text, ddlSameNameLicense.SelectedItem.ToString(), txtLicenseNo.Text, txtLicenseIssue.Text, ddlEmployer1.SelectedItem.ToString(), txtLicense1.Text, txtIssueDate1.Text, txtValidity1.Text,
                            txtQualification1.Text, ddlEmployer2.SelectedItem.ToString(), txtLicense2.Text, txtIssueDate2.Text, txtValidity2.Text,
                            txtQualification2.Text, Createdby);
                    }

                }
                //CEI.ContractorPartners()
                ScriptManager.RegisterStartupScript(this, this.GetType(), "showalert", "alert('Application Submitted Successfully !!!')", true);


                Response.Redirect("/UserPages/DocumentsForContractor.aspx", false);
            }
            catch { }
        }

        private void PartnersModalDirectorData()
        {

            LoginID = Session["ContractorID"].ToString();
            DataTable ds = new DataTable();
            ds = CEI.GetPartnersDirectorDate(LoginID);
            if (ds.Rows.Count > 0)
            {
                GridView1.DataSource = ds;
                GridView1.DataBind();
                GridView2.DataSource = ds;
                GridView2.DataBind();
            }
            else
            {

            }
            ds.Dispose();
        }
        protected void btnModalSubmit_Click(object sender, EventArgs e)
        {

            try
            {
                string Createdby = Session["ContractorID"].ToString();

                CEI.ContractorPartners(ddlAuthority.SelectedItem.ToString(), txtName.Text.Trim(), txtAddress.Text.Trim(), ddlState.SelectedItem.ToString(),
                    ddlDistrict.SelectedItem.ToString(), txtPinCode.Text.Trim(), Createdby);
                ScriptManager.RegisterStartupScript(this, this.GetType(), "showModal", "$('#myModal').modal('show');", true);
                PartnersModalDirectorData();
                Session["PartnerDirector"] = "Added";
                DdlPartnerOrDirector.SelectedValue = "0";

            }
            catch { }
        }

        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (DropDownList2.SelectedValue == "1") // "Yes" selected
                {
                    DdlPenelity.Visible = true;
                    ShowPenelity.Visible = true;
                }
                else
                {
                    DdlPenelity.Visible = false;
                    ShowPenelity.Visible = false;
                }

            }
            catch { }
        }

        protected void ddlLicenseGranted_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (ddlLicenseGranted.SelectedValue == "1") // "Yes" selected
                {
                    divIssueAuthority.Visible = true;
                    divDOB.Visible = true;
                    divLicenseExpiry.Visible = true;
                    divLicensePreviouslyGranted.Visible = true;
                }
                else
                {
                    divIssueAuthority.Visible = false;
                    divDOB.Visible = false;
                    divLicenseExpiry.Visible = false;
                    divLicensePreviouslyGranted.Visible = false;
                }

            }
            catch { }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (ddlSameNameLicense.SelectedValue == "1") // "Yes" selected
                {
                    divLicenseNo.Visible = true;
                    divDOIssue.Visible = true;
                }
                else
                {
                    divLicenseNo.Visible = false;
                    divDOIssue.Visible = false;
                }

            }
            catch 
            { 

            }
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Cookies["ContractorID"].Expires = DateTime.Now.AddDays(-1);
            Response.Redirect("/Login.aspx");
        }
    }
}