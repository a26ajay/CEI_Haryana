﻿using CEI_PRoject;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using static System.Net.WebRequestMethods;

namespace CEIHaryana.TestReportModal
{
    public partial class SubstationTransformerTestReportModal : System.Web.UI.Page
    {
        CEI CEI = new CEI();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                if (Session["ContractorID"] != null)
                {
                    ID = Session["SubStationID"].ToString();
                    GetDetailswithId();
                    if (Convert.ToString(Session["Approval"]) == "Pending")
                    {
                        Contractor.Visible = true;
                        Contractor3.Visible = true;
                    }
                    else
                    {
                        Contractor.Visible = true;
                        Contractor2.Visible = true;
                    }
                }
                else if (Session["AdminID"] != null)
                {
                    ID = Session["SubStationID"].ToString();
                    GetDetailswithId();
                    SiteOwner.Visible = true;
                    IntimationData.Visible = true;
                }
                else if (Session["InspectionTestReportId"] != null)
                {
                    ID = Session["InspectionTestReportId"].ToString();
                    GetDetailswithId();
                    SiteOwner.Visible = true;
                    IntimationData.Visible = true;
                    btnNext.Text = "Back";
                }
                else if (Session["SupervisorID"] != null)

                {
                    ID = Session["SubStationID"].ToString();
                    GetDetailswithId();
                    Supervisor.Visible = true;
                    IntimationData.Visible = true;
                }
            }
        }
        public void GetDetailswithId()
        {
            try
            {
                DataSet ds = new DataSet();
                ds = CEI.SubstationTestReportData(ID);

                string value1 = Convert.ToString(Session["Approval"]);
                if (value1.Trim() == "Accept")
                {
                    ddlType.Attributes.Add("Readonly", "true");
                    ddlType.SelectedIndex = ddlType.Items.IndexOf(ddlType.Items.FindByText(value1));
                }
                else if (value1.Trim() == "Reject")
                {
                    ddlType.Attributes.Add("Readonly", "true");
                    ddlType.SelectedIndex = ddlType.Items.IndexOf(ddlType.Items.FindByText(value1));
                    Rejection.Visible = true;
                    txtRejection.Attributes.Add("Readonly", "true");
                }

                string dp_Id = ds.Tables[0].Rows[0]["ContractorType"].ToString();
                txtInstallation.Text = dp_Id;
                if (dp_Id == "Firm/Organization/Company/Department")
                {
                    agency.Visible = true;
                    individual.Visible = false;
                }
                else
                {
                    individual.Visible = true;
                    agency.Visible = false;
                }

                txtName.Text = ds.Tables[0].Rows[0]["NameOfOwner"].ToString();
                txtagency.Text = ds.Tables[0].Rows[0]["NameOfAgency"].ToString();
                txtPhone.Text = ds.Tables[0].Rows[0]["ContactNo"].ToString();
                txtAddress.Text = ds.Tables[0].Rows[0]["Address"].ToString();
                string dp_Id1 = ds.Tables[0].Rows[0]["PremisesType"].ToString();
                TxtPremises.Text = dp_Id1;
                string dp_Id2 = ds.Tables[0].Rows[0]["OtherPremises"].ToString();
                string dp_Id3 = ds.Tables[0].Rows[0]["VoltageLevel"].ToString().Trim();
                txtVoltagelevel.Text = dp_Id3;
                string dp_Id4 = ds.Tables[0].Rows[0]["WorkStartDate"].ToString();
                txtStartDate.Text = DateTime.Parse(dp_Id4).ToString("yyyy-MM-dd");
                string dp_Id5 = ds.Tables[0].Rows[0]["CompletionDate"].ToString();
                txtCompletitionDate.Text = DateTime.Parse(dp_Id4).ToString("yyyy-MM-dd");
                txtTransformerSerialNumber.Text = ds.Tables[0].Rows[0]["TransformerSerialNumber"].ToString();
                txtTransformerCapacityType.Text = ds.Tables[0].Rows[0]["TransformerCapacityType"].ToString();
                txtTransformerType.Text = ds.Tables[0].Rows[0]["TranformerType"].ToString();
                if (txtTransformerType.Text.Trim() == "Oil")
                {
                    InCaseOfOil.Visible = true;
                    Capacity.Visible = true;
                    BDV.Visible = true;
                }
                else
                {
                    InCaseOfOil.Visible = true;
                    Capacity.Visible = false;
                    BDV.Visible = false;
                }
                if (txtTransformerCapacity.Text == "KVA")
                {
                    if (int.TryParse(txtTransformerCapacity.Text, out int value))
                    {
                        if (value >= 1000)
                        {
                            TypeOfHTBreaker.Visible = true;
                            ddlBreaker.Visible = true;
                            txtHTType.Visible = false;
                        }
                        else
                        {
                            ddlBreaker.Visible = false;
                            txtHTType.Visible = true;
                            TypeOfHTBreaker.Visible = false;
                        }
                    }
                }
                if (txtHTType.Text == "Breaker")
                {
                    TypeOfHTBreaker.Visible = true;
                }
                txtTransformerCapacity.Text = ds.Tables[0].Rows[0]["TransformerCapacity"].ToString();
                txtTransformerType.Text = ds.Tables[0].Rows[0]["TranformerType"].ToString();
                txtPrimaryVoltage.Text = ds.Tables[0].Rows[0]["PrimaryVoltage"].ToString();
                txtSecondryVoltage.Text = ds.Tables[0].Rows[0]["SecondoryVoltage"].ToString();
                txtOilCapacity.Text = ds.Tables[0].Rows[0]["OilCapacity"].ToString();
                txtOilBDV.Text = ds.Tables[0].Rows[0]["BreakDownVoltageofOil"].ToString();
                txtHTsideInsulation.Text = ds.Tables[0].Rows[0]["HtInsulationHVEarth"].ToString();
                txtLTSideInsulation.Text = ds.Tables[0].Rows[0]["LtInsulationLVEarth"].ToString();
                txtLowestValue.Text = ds.Tables[0].Rows[0]["LowestvaluebetweenHTLTSide"].ToString();
                txtLightningArrestor.Text = ds.Tables[0].Rows[0]["LightningArrestorLocation"].ToString();
                txtHTType.Text = ds.Tables[0].Rows[0]["TypeofHTPrimarySideSwitch"].ToString();
                txtEarthing.Text = ds.Tables[0].Rows[0]["NumberOfEarthing"].ToString();
                SubstationEarthingDiv.Visible = true;
                if (txtEarthing.Text.Trim() == "4")
                {
                    EarthingSubstation4.Visible = true;
                }
                else if (txtEarthing.Text.Trim() == "5")
                {
                    EarthingSubstation4.Visible = true;
                    EathingSubstation5.Visible = true;
                }
                else if (txtEarthing.Text.Trim() == "6")
                {
                    EarthingSubstation4.Visible = true;
                    EathingSubstation5.Visible = true;
                    EathingSubstation6.Visible = true;
                }
                else if (txtEarthing.Text.Trim() == "7")
                {
                    EarthingSubstation4.Visible = true;
                    EathingSubstation5.Visible = true;
                    EathingSubstation6.Visible = true;
                    EathingSubstation7.Visible = true;
                }
                else if (txtEarthing.Text.Trim() == "8")
                {
                    EarthingSubstation4.Visible = true;
                    EathingSubstation5.Visible = true;
                    EathingSubstation6.Visible = true;
                    EathingSubstation7.Visible = true;
                    EathingSubstation8.Visible = true;
                }
                else if (txtEarthing.Text.Trim() == "9")
                {
                    EarthingSubstation4.Visible = true;
                    EathingSubstation5.Visible = true;
                    EathingSubstation6.Visible = true;
                    EathingSubstation7.Visible = true;
                    EathingSubstation8.Visible = true;
                    EathingSubstation9.Visible = true;
                }
                else if (txtEarthing.Text.Trim() == "10")
                {
                    EarthingSubstation4.Visible = true;
                    EathingSubstation5.Visible = true;
                    EathingSubstation6.Visible = true;
                    EathingSubstation7.Visible = true;
                    EathingSubstation8.Visible = true;
                    EathingSubstation9.Visible = true;
                    EathingSubstation10.Visible = true;
                }
                else if (txtEarthing.Text.Trim() == "11")
                {
                    EarthingSubstation4.Visible = true;
                    EathingSubstation5.Visible = true;
                    EathingSubstation6.Visible = true;
                    EathingSubstation7.Visible = true;
                    EathingSubstation8.Visible = true;
                    EathingSubstation9.Visible = true;
                    EathingSubstation10.Visible = true;
                    EathingSubstation11.Visible = true;
                }
                else if (txtEarthing.Text.Trim() == "12")
                {
                    EarthingSubstation4.Visible = true;
                    EathingSubstation5.Visible = true;
                    EathingSubstation6.Visible = true;
                    EathingSubstation7.Visible = true;
                    EathingSubstation8.Visible = true;
                    EathingSubstation9.Visible = true;
                    EathingSubstation10.Visible = true;
                    EathingSubstation11.Visible = true;
                    EathingSubstation12.Visible = true;
                }
                else if (txtEarthing.Text.Trim() == "13")
                {
                    EarthingSubstation4.Visible = true;
                    EathingSubstation5.Visible = true;
                    EathingSubstation6.Visible = true;
                    EathingSubstation7.Visible = true;
                    EathingSubstation8.Visible = true;
                    EathingSubstation9.Visible = true;
                    EathingSubstation10.Visible = true;
                    EathingSubstation11.Visible = true;
                    EathingSubstation12.Visible = true;
                    EathingSubstation13.Visible = true;
                }
                else if (txtEarthing.Text.Trim() == "14")
                {
                    EarthingSubstation4.Visible = true;
                    EathingSubstation5.Visible = true;
                    EathingSubstation6.Visible = true;
                    EathingSubstation7.Visible = true;
                    EathingSubstation8.Visible = true;
                    EathingSubstation9.Visible = true;
                    EathingSubstation10.Visible = true;
                    EathingSubstation11.Visible = true;
                    EathingSubstation12.Visible = true;
                    EathingSubstation13.Visible = true;
                    EathingSubstation14.Visible = true;
                }
                else if (txtEarthing.Text.Trim() == "15")
                {
                    EarthingSubstation4.Visible = true;
                    EathingSubstation5.Visible = true;
                    EathingSubstation6.Visible = true;
                    EathingSubstation7.Visible = true;
                    EathingSubstation8.Visible = true;
                    EathingSubstation9.Visible = true;
                    EathingSubstation10.Visible = true;
                    EathingSubstation11.Visible = true;
                    EathingSubstation12.Visible = true;
                    EathingSubstation13.Visible = true;
                    EathingSubstation14.Visible = true;
                    EathingSubstation15.Visible = true;
                }
                else if (txtEarthing.Text.Trim() == "16")
                {
                    EarthingSubstation4.Visible = true;
                    EathingSubstation5.Visible = true;
                    EathingSubstation6.Visible = true;
                    EathingSubstation7.Visible = true;
                    EathingSubstation8.Visible = true;
                    EathingSubstation9.Visible = true;
                    EathingSubstation10.Visible = true;
                    EathingSubstation11.Visible = true;
                    EathingSubstation12.Visible = true;
                    EathingSubstation13.Visible = true;
                    EathingSubstation14.Visible = true;
                    EathingSubstation15.Visible = true;
                    EathingSubstation16.Visible = true;
                }
                else if (txtEarthing.Text.Trim() == "17")
                {
                    EarthingSubstation4.Visible = true;
                    EathingSubstation5.Visible = true;
                    EathingSubstation6.Visible = true;
                    EathingSubstation7.Visible = true;
                    EathingSubstation8.Visible = true;
                    EathingSubstation9.Visible = true;
                    EathingSubstation10.Visible = true;
                    EathingSubstation11.Visible = true;
                    EathingSubstation12.Visible = true;
                    EathingSubstation13.Visible = true;
                    EathingSubstation14.Visible = true;
                    EathingSubstation15.Visible = true;
                    EathingSubstation16.Visible = true;
                    EathingSubstation17.Visible = true;
                }
                else if (txtEarthing.Text.Trim() == "18")
                {
                    EarthingSubstation4.Visible = true;
                    EathingSubstation5.Visible = true;
                    EathingSubstation6.Visible = true;
                    EathingSubstation7.Visible = true;
                    EathingSubstation8.Visible = true;
                    EathingSubstation9.Visible = true;
                    EathingSubstation10.Visible = true;
                    EathingSubstation11.Visible = true;
                    EathingSubstation12.Visible = true;
                    EathingSubstation13.Visible = true;
                    EathingSubstation14.Visible = true;
                    EathingSubstation15.Visible = true;
                    EathingSubstation16.Visible = true;
                    EathingSubstation17.Visible = true;
                    EathingSubstation18.Visible = true;
                }
                else if (txtEarthing.Text.Trim() == "19")
                {
                    EarthingSubstation4.Visible = true;
                    EathingSubstation5.Visible = true;
                    EathingSubstation6.Visible = true;
                    EathingSubstation7.Visible = true;
                    EathingSubstation8.Visible = true;
                    EathingSubstation9.Visible = true;
                    EathingSubstation10.Visible = true;
                    EathingSubstation11.Visible = true;
                    EathingSubstation12.Visible = true;
                    EathingSubstation13.Visible = true;
                    EathingSubstation14.Visible = true;
                    EathingSubstation15.Visible = true;
                    EathingSubstation16.Visible = true;
                    EathingSubstation17.Visible = true;
                    EathingSubstation18.Visible = true;
                    EathingSubstation19.Visible = true;
                }
                else if (txtEarthing.Text.Trim() == "20")
                {
                    EarthingSubstation4.Visible = true;
                    EathingSubstation5.Visible = true;
                    EathingSubstation6.Visible = true;
                    EathingSubstation7.Visible = true;
                    EathingSubstation8.Visible = true;
                    EathingSubstation9.Visible = true;
                    EathingSubstation10.Visible = true;
                    EathingSubstation11.Visible = true;
                    EathingSubstation12.Visible = true;
                    EathingSubstation13.Visible = true;
                    EathingSubstation14.Visible = true;
                    EathingSubstation15.Visible = true;
                    EathingSubstation16.Visible = true;
                    EathingSubstation17.Visible = true;
                    EathingSubstation18.Visible = true;
                    EathingSubstation19.Visible = true;
                    EathingSubstation20.Visible = true;
                }
                else
                {
                    EarthingSubstation4.Visible = false;
                    EathingSubstation5.Visible = false;
                    EathingSubstation6.Visible = false;
                    EathingSubstation7.Visible = false;
                    EathingSubstation8.Visible = false;
                    EathingSubstation9.Visible = false;
                    EathingSubstation10.Visible = false;
                    EathingSubstation11.Visible = false;
                    EathingSubstation12.Visible = false;
                    EathingSubstation13.Visible = false;
                    EathingSubstation14.Visible = false;
                    EathingSubstation15.Visible = false;
                    EathingSubstation16.Visible = false;
                    EathingSubstation17.Visible = false;
                    EathingSubstation18.Visible = false;
                    EathingSubstation19.Visible = false;
                    EathingSubstation20.Visible = false;
                }
                txtEarthingType1.Text = ds.Tables[0].Rows[0]["EarthingType1"].ToString();
                txtSubstationEarthing1.Text = ds.Tables[0].Rows[0]["Valueinohms1"].ToString();
                txtUsedFor1.Text = ds.Tables[0].Rows[0]["UsedFor1"].ToString();
                txtEarthingType2.Text = ds.Tables[0].Rows[0]["EarthingType2"].ToString();
                txtSubstationEarthing2.Text = ds.Tables[0].Rows[0]["Valueinohms2"].ToString();
                txtUsedFor2.Text = ds.Tables[0].Rows[0]["UsedFor2"].ToString();
                txtEarthingType3.Text = ds.Tables[0].Rows[0]["EarthingType3"].ToString();
                txtSubstationEarthing3.Text = ds.Tables[0].Rows[0]["Valueinohms3"].ToString();
                txtUsedFor3.Text = ds.Tables[0].Rows[0]["UsedFor3"].ToString();
                txtEarthingType4.Text = ds.Tables[0].Rows[0]["EarthingType4"].ToString();
                txtSubstationEarthing4.Text = ds.Tables[0].Rows[0]["Valueinohms4"].ToString();
                txtUsedFor4.Text = ds.Tables[0].Rows[0]["UsedFor4"].ToString();
                txtEarthingType5.Text = ds.Tables[0].Rows[0]["EarthingType5"].ToString();
                txtSubstationEarthing5.Text = ds.Tables[0].Rows[0]["Valueinohms5"].ToString();
                txtUsedFor5.Text = ds.Tables[0].Rows[0]["UsedFor5"].ToString();
                txtEarthingType6.Text = ds.Tables[0].Rows[0]["EarthingType6"].ToString();
                txtSubstationEarthing6.Text = ds.Tables[0].Rows[0]["Valueinohms6"].ToString();
                txtUsedFor6.Text = ds.Tables[0].Rows[0]["UsedFor6"].ToString();
                txtEarthingType7.Text = ds.Tables[0].Rows[0]["EarthingType7"].ToString();
                txtSubstationEarthing7.Text = ds.Tables[0].Rows[0]["Valueinohms7"].ToString();
                txtUsedFor7.Text = ds.Tables[0].Rows[0]["UsedFor7"].ToString();
                txtEarthingType8.Text = ds.Tables[0].Rows[0]["EarthingType8"].ToString();
                txtSubstationEarthing8.Text = ds.Tables[0].Rows[0]["Valueinohms8"].ToString();
                txtUsedFor8.Text = ds.Tables[0].Rows[0]["UsedFor8"].ToString();
                txtEarthingType9.Text = ds.Tables[0].Rows[0]["EarthingType9"].ToString();
                txtSubstationEarthing9.Text = ds.Tables[0].Rows[0]["Valueinohms9"].ToString();
                txtUsedFor9.Text = ds.Tables[0].Rows[0]["UsedFor9"].ToString();
                txtEarthingType10.Text = ds.Tables[0].Rows[0]["EarthingType10"].ToString();
                txtSubstationEarthing10.Text = ds.Tables[0].Rows[0]["Valueinohms10"].ToString();
                txtUsedFor10.Text = ds.Tables[0].Rows[0]["UsedFor10"].ToString();
                txtEarthingType11.Text = ds.Tables[0].Rows[0]["EarthingType11"].ToString();
                txtSubstationEarthing11.Text = ds.Tables[0].Rows[0]["Valueinohms11"].ToString();
                txtUsedFor11.Text = ds.Tables[0].Rows[0]["UsedFor11"].ToString();
                txtEarthingType12.Text = ds.Tables[0].Rows[0]["EarthingType12"].ToString();
                txtSubstationEarthing12.Text = ds.Tables[0].Rows[0]["Valueinohms12"].ToString();
                txtUsedFor12.Text = ds.Tables[0].Rows[0]["UsedFor12"].ToString();
                txtEarthingType13.Text = ds.Tables[0].Rows[0]["EarthingType13"].ToString();
                txtSubstationEarthing13.Text = ds.Tables[0].Rows[0]["Valueinohms13"].ToString();
                txtUsedFor13.Text = ds.Tables[0].Rows[0]["UsedFor13"].ToString();
                txtEarthingType14.Text = ds.Tables[0].Rows[0]["EarthingType14"].ToString();
                txtSubstationEarthing14.Text = ds.Tables[0].Rows[0]["Valueinohms14"].ToString();
                txtUsedFor14.Text = ds.Tables[0].Rows[0]["UsedFor14"].ToString();
                txtEarthingType15.Text = ds.Tables[0].Rows[0]["EarthingType15"].ToString();
                txtSubstationEarthing15.Text = ds.Tables[0].Rows[0]["Valueinohms15"].ToString();
                txtUsedFor15.Text = ds.Tables[0].Rows[0]["UsedFor15"].ToString();

                txtBreakerCapacity.Text = ds.Tables[0].Rows[0]["LoadBreakingCapacityOfBreakerInKA"].ToString();
                txtLTProtection.Text = ds.Tables[0].Rows[0]["TypeOfLTProtection"].ToString();
                txtIndividualCapacity.Text = ds.Tables[0].Rows[0]["CapacityOfIndividualFuseInAMPS"].ToString();
                txtLTBreakerCapacity.Text = ds.Tables[0].Rows[0]["LoadBreakingCapacityOfBreakerInAMPS"].ToString();
                txtLoadBreakingCapacity.Text = ds.Tables[0].Rows[0]["RiverCanalCrossingNoForOC"].ToString();
                txtSealLevelPlinth.Text = ds.Tables[0].Rows[0]["SeaLevelOfTransformerInMeters"].ToString();
                txtRejection.Text = ds.Tables[0].Rows[0]["ReasonForRejection"].ToString();
                Session["Contact"] = ds.Tables[0].Rows[0]["ContractorContactNo"].ToString();
            }
            catch
            {

            }
        }
        protected void ddlType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlType.SelectedValue == "2")
            {
                Rejection.Visible = true;
            }
            else
            {
                Rejection.Visible = false;
            }
        }

        protected void BtnSubmit_Click(object sender, EventArgs e)
        {
            string id = Session["SubStationID"].ToString();
            CEI.UpdateSubstationData(id, ddlType.SelectedItem.ToString(), txtRejection.Text);
            Response.Redirect("/Contractor/SubstationTransformer.aspx");
        }
        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Supervisor/SupervisorSubstationTestReport.aspx");
        }
        protected void btnNext_Click(object sender, EventArgs e)
        {
            if (btnNext.Text.Trim() == "Back")
            {
                Response.Redirect("/Officers/Inspection.aspx", false);
            }
            else
            {
                Response.Redirect("/SiteOwnerPages/CreateInspectionReport.aspx", false);
            }
        }
        protected void BtnVerify_Click(object sender, EventArgs e)
        {
            if (btnVerify.Text == "SendOTP")
            {
                OTP.Visible = true;
                string mobilenumber = Session["Contact"].ToString();
                Session["OTP"] = CEI.ValidateOTP(mobilenumber);
                btnVerify.Text = "Verify";
            }
            else
            {
                if (Session["OTP"].ToString() == txtOtp.Text)
                {
                    Contractor2.Visible = true;
                    Contractor3.Visible = false;
                }
            }
        }
    }
}