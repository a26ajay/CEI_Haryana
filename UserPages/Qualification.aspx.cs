﻿using CEI_PRoject;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CEIHaryana.UserPages
{
    public partial class Qualification : System.Web.UI.Page
    {
        string InsertedCategory = "";
        string REID = string.Empty;
        bool showAlert = false;
        CEI CEI = new CEI();
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                if (Session["InsertedCategory"] != null && !string.IsNullOrEmpty(Session["InsertedCategory"].ToString()))
                {
                    string InsertedCategory = "";
                    InsertedCategory = Session["InsertedCategory"].ToString();
                    if (InsertedCategory == "Wireman")
                    {
                        ddlQualification2.Attributes.Add("disabled", "disabled");
                    }
                    else
                    {
                        ddlQualification2.Attributes.Remove("disabled");
                    }

                }
                if (Session["Back"] != null && !string.IsNullOrEmpty(Session["Back"].ToString()))
                {
                    GetUserQualification();
                }
                else if (Session["Back"] == null)
                {


                }


            }

        }

        protected void GetUserQualification()
        {
            if (Session["WiremanId"] != null)
            {
                REID = Session["WiremanId"].ToString();
            }
            else
            {
                REID = Session["SupervisorID"].ToString();
            }
            //hdnId.Value = REID;

            SqlCommand cmd = new SqlCommand("sp_GetUserQualification");
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", REID);
            cmd.Connection = con;
            using (SqlDataAdapter adp = new SqlDataAdapter(cmd))
            {
                DataSet ds = new DataSet();
                adp.Fill(ds);
                txtUniversity.Text = ds.Tables[0].Rows[0]["UniversityName10th"].ToString();
                string dp_Id3 = ds.Tables[0].Rows[0]["PassingYear10th"].ToString();
                txtPassingyear.Text = DateTime.Parse(dp_Id3).ToString("yyyy-MM-dd");
                txtmarksObtained.Text = ds.Tables[0].Rows[0]["MarksObtained10th"].ToString();
                txtmarksmax.Text = ds.Tables[0].Rows[0]["MarksMax10th"].ToString();
                txtprcntg.Text = ds.Tables[0].Rows[0]["Percentage10th"].ToString();
                string dp_Id = ds.Tables[0].Rows[0]["Name12ITIDiploma"].ToString();
                string dp_Id1 = ds.Tables[0].Rows[0]["NameofDiplomaDegree"].ToString();
                txtUniversity1.Text = ds.Tables[0].Rows[0]["UniversityName12thorITI"].ToString();
                string dp_Id4 = ds.Tables[0].Rows[0]["PassingYear12thorITI"].ToString();
                txtPassingyear1.Text = DateTime.Parse(dp_Id4).ToString("yyyy-MM-dd");
                txtmarksObtained1.Text = ds.Tables[0].Rows[0]["MarksObtained12thorITI"].ToString();
                txtmarksmax1.Text = ds.Tables[0].Rows[0]["MarksMax12thorITI"].ToString();
                txtprcntg1.Text = ds.Tables[0].Rows[0]["Percentage12thorITI"].ToString();
                txtUniversity2.Text = ds.Tables[0].Rows[0]["UniversityNameDiplomaorDegree"].ToString();
                string dp_Id5 = ds.Tables[0].Rows[0]["PassingYearDiplomaorDegree"].ToString();
                txtPassingyear2.Text = DateTime.Parse(dp_Id5).ToString("yyyy-MM-dd");
                txtmarksObtained2.Text = ds.Tables[0].Rows[0]["MarksObtainedDiplomaorDegree"].ToString();
                txtmarksmax2.Text = ds.Tables[0].Rows[0]["MarksMaxDiplomaorDegree"].ToString();
                txtprcntg2.Text = ds.Tables[0].Rows[0]["PercentageDiplomaorDegree"].ToString();
                string dp_Id2 = ds.Tables[0].Rows[0]["NameofDegree"].ToString();
                txtUniversity3.Text = ds.Tables[0].Rows[0]["UniversityNamePG"].ToString();
                string dp_Id6 = ds.Tables[0].Rows[0]["PassingYearPG"].ToString();
                txtPassingyear3.Text = DateTime.Parse(dp_Id6).ToString("yyyy-MM-dd");
                txtmarksObtained3.Text = ds.Tables[0].Rows[0]["MarksObtainedPG"].ToString();
                txtmarksmax3.Text = ds.Tables[0].Rows[0]["MarksMaxPG"].ToString();
                txtprcntg3.Text = ds.Tables[0].Rows[0]["PercentagePG"].ToString();
                txtCategory.Text = ds.Tables[0].Rows[0]["CertificateofCompetency1"].ToString();
                txtPermitNo.Text = ds.Tables[0].Rows[0]["PermitNo1"].ToString();
                txtIssuingAuthority.Text = ds.Tables[0].Rows[0]["IssuingAuthority1"].ToString();
                string dp_Id7 = ds.Tables[0].Rows[0]["IssueDate1"].ToString();
                txtIssuingDate.Text = DateTime.Parse(dp_Id7).ToString("yyyy-MM-dd");
                //txtCategory1.Text = ds.Tables[0].Rows[0]["CertificateofCompetency2"].ToString();
                //txtPermitNo1.Text = ds.Tables[0].Rows[0]["PermitNo2"].ToString();
                //txtIssuingAuthority1.Text = ds.Tables[0].Rows[0]["IssuingAuthority2"].ToString();
                //string dp_Id8 = ds.Tables[0].Rows[0]["IssueDate2"].ToString();
                //txtIssuingDate1.Text = DateTime.Parse(dp_Id8).ToString("yyyy-MM-dd");
                txtEmployerName.Text = ds.Tables[0].Rows[0]["EmployerName"].ToString();
                txtDescription.Text = ds.Tables[0].Rows[0]["PostDescription"].ToString();
                string dp_Id9 = ds.Tables[0].Rows[0]["FromDate"].ToString();
                txtFrom.Text = DateTime.Parse(dp_Id9).ToString("yyyy-MM-dd");
                string dp_Id10 = ds.Tables[0].Rows[0]["ToDate"].ToString();
                txtTo.Text = DateTime.Parse(dp_Id10).ToString("yyyy-MM-dd");
                txtEmployerName1.Text = ds.Tables[0].Rows[0]["ExperienceEmployerName"].ToString();
                txtDescription1.Text = ds.Tables[0].Rows[0]["ExperiencePostDescription"].ToString();
                string dp_Id11 = ds.Tables[0].Rows[0]["ExperienceFromDate"].ToString();
                txtFrom1.Text = DateTime.Parse(dp_Id11).ToString("yyyy-MM-dd");
                string dp_Id12 = ds.Tables[0].Rows[0]["ExperienceToDate"].ToString();
                txtTo1.Text = DateTime.Parse(dp_Id12).ToString("yyyy-MM-dd");
                //txtEmployer.Text = ds.Tables[0].Rows[0]["ExperienceEmployerName1"].ToString();
                //txtDescript.Text = ds.Tables[0].Rows[0]["ExperiencePostDescription1"].ToString();
                //string dp_Id15 = ds.Tables[0].Rows[0]["ExperienceFromDate1"].ToString();
                //txtFrm1.Text = DateTime.Parse(dp_Id15).ToString("yyyy-MM-dd");
                //string dp_Id16 = ds.Tables[0].Rows[0]["ExperienceToDate1"].ToString();
                //txtToDate.Text = DateTime.Parse(dp_Id16).ToString("yyyy-MM-dd");
                txtEmployerName2.Text = ds.Tables[0].Rows[0]["RetiredEmployerName"].ToString();
                txtDescription2.Text = ds.Tables[0].Rows[0]["RetiredPostDescription"].ToString();
                string dp_Id13 = ds.Tables[0].Rows[0]["RetiredFromDate"].ToString();
                txtFrom2.Text = DateTime.Parse(dp_Id13).ToString("yyyy-MM-dd");
                string dp_Id14 = ds.Tables[0].Rows[0]["RetiredToDate"].ToString();
                txtTo2.Text = DateTime.Parse(dp_Id14).ToString("yyyy-MM-dd");
                // txtDOB.Text = DateTime.Parse(dp_Id2).ToString("yyyy-MM-dd");

                ddlQualification.SelectedIndex = ddlQualification.Items.IndexOf(ddlQualification.Items.FindByText(dp_Id));
                ddlQualification1.SelectedIndex = ddlQualification1.Items.IndexOf(ddlQualification1.Items.FindByText(dp_Id1));
                ddlQualification2.SelectedIndex = ddlQualification2.Items.IndexOf(ddlQualification2.Items.FindByText(dp_Id2));
            }
        }
        protected void QualificationValidations()
        {


            InsertedCategory = Session["InsertedCategory"].ToString();


            if (InsertedCategory == "Supervisor")
            {
                if (ddlQualification.SelectedValue == "1" || ddlQualification.SelectedValue == "2")
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "alertScript", "alert('You are not eligible for filling this form because your qualification does not match our criteria!!!');", true);
                    showAlert = true;
                }

            }
            if (ddlQualification.SelectedValue == "0" && ddlQualification1.SelectedValue == "0")
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "alertScript", "alert('You are not eligible for filling this form because your qualification does not match our criteria!!!');", true);
                showAlert = true;

            }
            if (!showAlert)
            {
                CheckExperience();
            }
        }


        protected void btnBack_Click(object sender, EventArgs e)
        {
            //Session["RegistrationID"].ToString();
            Response.Redirect("/Login.aspx");
        }
        protected void CheckExperience()
        {
            try
            {


                DateTime fromDate = DateTime.Parse(txtFrom1.Text);
                DateTime toDate = DateTime.Parse(txtTo1.Text);

                TimeSpan oneYear = TimeSpan.FromDays(365);
                string InsertedCategory = "";
                InsertedCategory = Session["InsertedCategory"].ToString();
                if (InsertedCategory == "Wireman")
                {
                    if (ddlQualification.SelectedValue == "3" || ddlQualification.SelectedValue == "4")
                    {
                        if ((toDate - fromDate) < oneYear)
                        {
                            ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('You are not eligible for filling this form because You need at least 1 years of experience ');", true);
                            showAlert = true;
                        }
                    }
                    else if (ddlQualification.SelectedValue == "1" || ddlQualification.SelectedValue == "2")
                    {
                        if ((toDate - fromDate) < (TimeSpan.FromDays(3 * 365)))
                        {
                            ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('You are not eligible for filling this form because You need at least 3 year of experience');", true);
                            showAlert = true;
                        }
                    }
                }
                else if (InsertedCategory == "Supervisor")
                {
                    if (ddlQualification2.SelectedValue != "0")
                    {
                        if ((toDate - fromDate) < oneYear)
                        {
                            ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('You are not eligible for filling this form because You need at least 1 years of experience');", true);
                            showAlert = true;
                        }
                    }
                    else if (ddlQualification.SelectedValue == "3" || ddlQualification.SelectedValue == "4")
                    {
                        if ((toDate - fromDate) < (TimeSpan.FromDays(5 * 365)))
                        {
                            ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('You are not eligible for filling this form because You need at least 5 year of experience ');", true);
                            showAlert = true;
                        }
                    }
                }
            }
            catch (Exception ex) { }
        }

        protected void validations()
        {
            try
            {
                if (ddlQualification1.SelectedValue != "0")
                {
                    if (txtUniversity2.Text == "")
                    {
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Please add your Board/University Name');", true);
                        showAlert = true;
                    }
                    else if (txtPassingyear2.Text == "")
                    {
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Please add your Passing Year');", true);
                        showAlert = true;
                    }
                    else if (txtmarksObtained2.Text == "" || txtmarksmax2.Text == "" || txtprcntg2.Text == "")
                    {
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Please add your Marks');", true);
                        showAlert = true;
                    }
                }
                else if (ddlQualification2.SelectedValue != "0")
                {
                    if (txtUniversity3.Text == "")
                    {
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Please add your Board/University Name');", true);
                        showAlert = true;
                    }
                    else if (txtPassingyear3.Text == "")
                    {
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Please add your Passing Year');", true);
                        showAlert = true;
                    }
                    else if (txtmarksObtained3.Text == "" || txtmarksmax3.Text == "" || txtprcntg3.Text == "")
                    {
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Please add your Marks');", true);
                        showAlert = true;
                    }
                }
                else
                {
                    showAlert = false;
                }
            }
            catch { }
        }
        protected void btnNext_Click(object sender, EventArgs e)
        {
            if (Session["WiremanId"] != null)
            {
                REID = Session["WiremanId"].ToString();
            }
            else
            {
                REID = Session["SupervisorID"].ToString();
            }
            //hdnId.Value = REID;
            QualificationValidations();
            CheckExperience();
            validations();

            if (!showAlert)
            {

                CEI.InsertnewUseQualification(REID, txtUniversity.Text, txtPassingyear.Text, txtmarksObtained.Text, txtmarksmax.Text, txtprcntg.Text,ddlQualification.SelectedItem.ToString(),
                    txtUniversity1.Text, txtPassingyear1.Text, txtmarksObtained1.Text, txtmarksmax1.Text, txtprcntg1.Text, ddlQualification1.SelectedItem.ToString(),
                   txtUniversity2.Text, txtPassingyear2.Text, txtmarksObtained2.Text, txtmarksmax2.Text, txtprcntg2.Text, ddlQualification2.SelectedItem.ToString(),
                  txtUniversity3.Text, txtPassingyear3.Text, txtmarksObtained3.Text, txtmarksmax3.Text, txtprcntg3.Text, ddlQualification3.SelectedItem.ToString(),
                  txtUniversity4.Text, txtPassingyear4.Text, txtmarksObtained4.Text, txtmarksmax4.Text, txtprcntg4.Text, RadioButtonList2.SelectedItem.ToString(),
                 txtCategory.Text, txtPermitNo.Text,txtIssuingAuthority.Text, txtIssuingDate.Text, RadioButtonList3.SelectedItem.ToString(),txtEmployerName.Text,txtDescription.Text,txtFrom.Text,txtTo.Text, txtEmployerName1.Text,
                 txtDescription1.Text, txtFrom1.Text, txtTo1.Text, RadioButtonList1.SelectedItem.ToString(), txtEmployerName2.Text,
                 txtDescription2.Text, txtFrom2.Text, txtTo2.Text);

                Session["Back"] = txtUniversity.Text;
                ScriptManager.RegisterStartupScript(this, this.GetType(), "showalert", "alert('Qualification Added Successfully !!!')", true);
                showAlert = true;
                Response.Redirect("Documents.aspx");
            }
        }



        protected void RadioButtonList2_SelectedIndexChanged(object sender, EventArgs e)
        {
            QualificationValidations();
            if (RadioButtonList2.SelectedValue == "0")
            {
                competency.Visible = true;
            }
            else
            {
                competency.Visible = false;
            }
        }

        protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (RadioButtonList1.SelectedValue == "0")
            {
                RetiredEmployee.Visible = true;
            }
            else
            {
                RetiredEmployee.Visible = false;
            }
        }
        protected void txtTo1_TextChanged(object sender, EventArgs e)
        {

            // Check the condition to determine if txtExperienceFrom and txtExperienceTo are visible
            bool isExperienceVisible = true;  

            TextBox[] fromArray = isExperienceVisible ? new TextBox[] { txtExperienceFrom, txtFrom1, txtExperienceFrom2, txtExperienceFrom3, txtExperienceFrom4 } : new TextBox[] { txtFrom1 };
            TextBox[] toArray = isExperienceVisible ? new TextBox[] { txtExperienceTo, txtTo1, txtExperienceTo2, txtExperienceTo3, txtExperienceTo4 } : new TextBox[] { txtTo1 };

            int totalYears = 0, totalMonths = 0, totalDays = 0;

            for (int i = 0; i < fromArray.Length; i++)
            {
                // Check if the TextBox controls are visible
                if (fromArray[i].Visible && toArray[i].Visible)
                {
                    DateTime fromDate, toDate;

                    // Use a try-catch block to handle parsing errors
                    try
                    {
                        // Parse the 'From' and 'To' values
                        if (DateTime.TryParse(fromArray[i].Text, out fromDate) && DateTime.TryParse(toArray[i].Text, out toDate))
                        {
                            // Calculate the difference in years, months, and days
                            TimeSpan difference = toDate - fromDate;
                            totalYears += difference.Days / 365;
                            totalMonths += (difference.Days % 365) / 30;
                            totalDays += difference.Days % 30;
                        }
                    }
                    catch (Exception ex)
                    {
                        // Handle parsing errors (e.g., invalid date format)
                        // You can log the error or take appropriate action based on your needs
                    }
                }
            }

            // Display the calculated values in another TextBox
            txtTotalExperience.Text = $"{totalYears} years, {totalMonths} months, {totalDays} days";
        }
            protected void RadioButtonList3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RadioButtonList3.SelectedValue == "1")
            {
                PermanentEmployee.Visible = false;

            }
            else
            {
                PermanentEmployee.Visible = true;
            }

        }

        protected void btnAddMore_Click(object sender, EventArgs e)
        {
            if (Experience3.Visible == true)
            {
                Experience1.Visible = true;
                Experience2.Visible = true;
                Experience3.Visible = true;
                Experience4.Visible = true;
            }
            else if (Experience2.Visible == true)
            {
                Experience1.Visible = true;
                Experience2.Visible = true;
                Experience3.Visible = true;
            }
            else if(Experience1.Visible == true)
            {
                Experience1.Visible = true;
                Experience2.Visible = true;
            } 
             
            else if (Experience1.Visible == false)
            {
                Experience1.Visible = true;
                Experience2.Visible = false;
            }
            else
            {
                Experience1.Visible = false;
                Experience2.Visible = false;
            }
        }
    }
}