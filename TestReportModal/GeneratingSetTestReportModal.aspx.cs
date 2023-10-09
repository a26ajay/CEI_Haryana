﻿using CEI_PRoject;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CEIHaryana.TestReportModal
{
    public partial class GeneratingSetTestReportModal : System.Web.UI.Page
    {
        CEI CEI = new CEI();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                if (Session["ContractorID"] != null)
                {
                    GetDetailswithId();
                }
            }
        }

        public void GetDetailswithId()
        {
            try
            {
                ID = Session["GeneratingSetId"].ToString();
                DataSet ds = new DataSet();
                ds = CEI.SubstationTestReportData(ID);
                txtCapacityType.Text = ds.Tables[0].Rows[0]["GeneratingSetCapacityType"].ToString();
                txtCapacity.Text = ds.Tables[0].Rows[0]["GeneratingSetCapacity"].ToString();
                txtSerialNoOfGenerator.Text = ds.Tables[0].Rows[0]["SerialNumbrOfAcGenerator"].ToString();
                txtGeneratingSetType.Text = ds.Tables[0].Rows[0]["GeneratingSetType"].ToString();
                if (txtGeneratingSetType.Text.Trim() == "Solar Panel")
                {
                    SolarPanelGeneratingSet.Visible = true;
                }
                else
                {
                    SolarPanelGeneratingSet.Visible = false;
                }
                txtGeneratorVoltage.Text = ds.Tables[0].Rows[0]["GeneratorVoltageLevel"].ToString();
                txtCurrentCapacity.Text = ds.Tables[0].Rows[0]["CurrenntCapacityOfBreaker"].ToString();
                txtBreakingCapacity.Text = ds.Tables[0].Rows[0]["BreakingCapacityofBreaker"].ToString();
                txtPlantType.Text = ds.Tables[0].Rows[0]["TypeOfPlant"].ToString();
                txtPlantCapacityType.Text = ds.Tables[0].Rows[0]["CapacityOfPlantType"].ToString();
                txtPlantCapacity.Text = ds.Tables[0].Rows[0]["CapacityOfPlant"].ToString();
                txtDCString.Text = ds.Tables[0].Rows[0]["HighestVoltageLevelOfDCString"].ToString();
                txtLowestInsulation.Text = ds.Tables[0].Rows[0]["LowestInsulationBetweenDCWireToEarth"].ToString();
                txtPCVOrSolar.Text = ds.Tables[0].Rows[0]["NoOfPowerPCV"].ToString();
                txtLTACCapacity.Text = ds.Tables[0].Rows[0]["LTACBreakerCapacity"].ToString();
                txtLowestInsulationAC.Text = ds.Tables[0].Rows[0]["ACCablesLowestInsulation"].ToString();
                txtEarthing.Text = ds.Tables[0].Rows[0]["NumberOfEarthing"].ToString();
                GeneratingEarthing.Visible = true;
                if (txtEarthing.Text.Trim() == "4")
                {
                    Limit.Visible = false;
                    GeneratingEarthing4.Visible = true;
                }
                else if (txtEarthing.Text.Trim() == "5")
                {
                    Limit.Visible = false;
                    GeneratingEarthing4.Visible = true;
                    GeneratingEarthing5.Visible = true;
                }
                else if (txtEarthing.Text.Trim() == "6")
                {
                    Limit.Visible = false;
                    GeneratingEarthing4.Visible = true;
                    GeneratingEarthing5.Visible = true;
                    GeneratingEarthing6.Visible = true;
                }
                else if (txtEarthing.Text.Trim() == "7")
                {
                    Limit.Visible = false;
                    GeneratingEarthing4.Visible = true;
                    GeneratingEarthing5.Visible = true;
                    GeneratingEarthing6.Visible = true;
                    GeneratingEarthing7.Visible = true;
                }
                else if (txtEarthing.Text.Trim() == "8")
                {
                    Limit.Visible = false;
                    GeneratingEarthing4.Visible = true;
                    GeneratingEarthing5.Visible = true;
                    GeneratingEarthing6.Visible = true;
                    GeneratingEarthing7.Visible = true;
                    GeneratingEarthing8.Visible = true;
                }
                else if (txtEarthing.Text.Trim() == "9")
                {
                    Limit.Visible = false;
                    GeneratingEarthing4.Visible = true;
                    GeneratingEarthing5.Visible = true;
                    GeneratingEarthing6.Visible = true;
                    GeneratingEarthing7.Visible = true;
                    GeneratingEarthing8.Visible = true;
                    GeneratingEarthing9.Visible = true;
                }
                else if (txtEarthing.Text.Trim() == "10")
                {
                    Limit.Visible = false;
                    GeneratingEarthing4.Visible = true;
                    GeneratingEarthing5.Visible = true;
                    GeneratingEarthing6.Visible = true;
                    GeneratingEarthing7.Visible = true;
                    GeneratingEarthing8.Visible = true;
                    GeneratingEarthing9.Visible = true;
                    GeneratingEarthing10.Visible = true;
                }
                else if (txtEarthing.Text.Trim() == "11")
                {
                    Limit.Visible = false;
                    GeneratingEarthing4.Visible = true;
                    GeneratingEarthing5.Visible = true;
                    GeneratingEarthing6.Visible = true;
                    GeneratingEarthing7.Visible = true;
                    GeneratingEarthing8.Visible = true;
                    GeneratingEarthing9.Visible = true;
                    GeneratingEarthing10.Visible = true;
                    GeneratingEarthing11.Visible = true;
                }
                else if (txtEarthing.Text.Trim() == "12")
                {
                    Limit.Visible = false;
                    GeneratingEarthing4.Visible = true;
                    GeneratingEarthing5.Visible = true;
                    GeneratingEarthing6.Visible = true;
                    GeneratingEarthing7.Visible = true;
                    GeneratingEarthing8.Visible = true;
                    GeneratingEarthing9.Visible = true;
                    GeneratingEarthing10.Visible = true;
                    GeneratingEarthing11.Visible = true;
                    GeneratingEarthing12.Visible = true;
                }
                else if (txtEarthing.Text.Trim() == "13")
                {
                    Limit.Visible = false;
                    GeneratingEarthing4.Visible = true;
                    GeneratingEarthing5.Visible = true;
                    GeneratingEarthing6.Visible = true;
                    GeneratingEarthing7.Visible = true;
                    GeneratingEarthing8.Visible = true;
                    GeneratingEarthing9.Visible = true;
                    GeneratingEarthing10.Visible = true;
                    GeneratingEarthing11.Visible = true;
                    GeneratingEarthing12.Visible = true;
                    GeneratingEarthing13.Visible = true;
                }
                else if (txtEarthing.Text.Trim() == "14")
                {
                    Limit.Visible = false;
                    GeneratingEarthing4.Visible = true;
                    GeneratingEarthing5.Visible = true;
                    GeneratingEarthing6.Visible = true;
                    GeneratingEarthing7.Visible = true;
                    GeneratingEarthing8.Visible = true;
                    GeneratingEarthing9.Visible = true;
                    GeneratingEarthing10.Visible = true;
                    GeneratingEarthing11.Visible = true;
                    GeneratingEarthing12.Visible = true;
                    GeneratingEarthing13.Visible = true;
                    GeneratingEarthing14.Visible = true;
                }
                else if (txtEarthing.Text.Trim() == "15")
                {
                    Limit.Visible = false;
                    GeneratingEarthing4.Visible = true;
                    GeneratingEarthing5.Visible = true;
                    GeneratingEarthing6.Visible = true;
                    GeneratingEarthing7.Visible = true;
                    GeneratingEarthing8.Visible = true;
                    GeneratingEarthing9.Visible = true;
                    GeneratingEarthing10.Visible = true;
                    GeneratingEarthing11.Visible = true;
                    GeneratingEarthing12.Visible = true;
                    GeneratingEarthing13.Visible = true;
                    GeneratingEarthing14.Visible = true;
                    GeneratingEarthing15.Visible = true;
                }

                else
                {
                    GeneratingEarthing4.Visible = false;
                    GeneratingEarthing5.Visible = false;
                    GeneratingEarthing6.Visible = false;
                    GeneratingEarthing7.Visible = false;
                    GeneratingEarthing8.Visible = false;
                    GeneratingEarthing9.Visible = false;
                    GeneratingEarthing10.Visible = false;
                    GeneratingEarthing11.Visible = false;
                    GeneratingEarthing12.Visible = false;
                    GeneratingEarthing13.Visible = false;
                    GeneratingEarthing14.Visible = false;
                    GeneratingEarthing15.Visible = false;
                    Limit.Visible = false;
                    txtEarthingType1.Text = ds.Tables[0].Rows[0]["EarthingType1"].ToString();
                    txtGeneratingEarthing1.Text = ds.Tables[0].Rows[0]["EarthingValue1"].ToString();
                    txtEarthingUsed1.Text = ds.Tables[0].Rows[0]["UsedFor1"].ToString();
                    txtEarthingType2.Text = ds.Tables[0].Rows[0]["EarthingType2"].ToString();
                    txtGeneratingEarthing2.Text = ds.Tables[0].Rows[0]["EarthingValue2"].ToString();
                    txtEarthingUsed2.Text = ds.Tables[0].Rows[0]["UsedFor2"].ToString();
                    txtEarthingType3.Text = ds.Tables[0].Rows[0]["EarthingType3"].ToString();
                    txtGeneratingEarthing3.Text = ds.Tables[0].Rows[0]["EarthingValue3"].ToString();
                    txtEarthingUsed3.Text = ds.Tables[0].Rows[0]["UsedFor3"].ToString();
                    txtEarthingType4.Text = ds.Tables[0].Rows[0]["EarthingType4"].ToString();
                    txtGeneratingEarthing4.Text = ds.Tables[0].Rows[0]["EarthingValue4"].ToString();
                    txtEarthingUsed4.Text = ds.Tables[0].Rows[0]["UsedFor4"].ToString();
                    txtEarthingType5.Text = ds.Tables[0].Rows[0]["EarthingType5"].ToString();
                    txtGeneratingEarthing5.Text = ds.Tables[0].Rows[0]["EarthingValue5"].ToString();
                    txtEarthingUsed5.Text = ds.Tables[0].Rows[0]["UsedFor5"].ToString();
                    txtEarthingType6.Text = ds.Tables[0].Rows[0]["EarthingType6"].ToString();
                    txtGeneratingEarthing6.Text = ds.Tables[0].Rows[0]["EarthingValue6"].ToString();
                    txtEarthingUsed6.Text = ds.Tables[0].Rows[0]["UsedFor6"].ToString();
                    txtEarthingType7.Text = ds.Tables[0].Rows[0]["EarthingType7"].ToString();
                    txtGeneratingEarthing7.Text = ds.Tables[0].Rows[0]["EarthingValue7"].ToString();
                    txtEarthingUsed7.Text = ds.Tables[0].Rows[0]["UsedFor7"].ToString();
                    txtEarthingType8.Text = ds.Tables[0].Rows[0]["EarthingType8"].ToString();
                    txtGeneratingEarthing8.Text = ds.Tables[0].Rows[0]["EarthingValue8"].ToString();
                    txtEarthingUsed8.Text = ds.Tables[0].Rows[0]["UsedFor8"].ToString();
                    txtEarthingType9.Text = ds.Tables[0].Rows[0]["EarthingType9"].ToString();
                    txtGeneratingEarthing9.Text = ds.Tables[0].Rows[0]["EarthingValue9"].ToString();
                    txtEarthingUsed9.Text = ds.Tables[0].Rows[0]["UsedFor9"].ToString();
                    txtEarthingType10.Text = ds.Tables[0].Rows[0]["EarthingType10"].ToString();
                    txtGeneratingEarthing10.Text = ds.Tables[0].Rows[0]["EarthingValue10"].ToString();
                    txtEarthingUsed10.Text = ds.Tables[0].Rows[0]["UsedFor10"].ToString();
                    txtEarthingType11.Text = ds.Tables[0].Rows[0]["EarthingType11"].ToString();
                    txtGeneratingEarthing11.Text = ds.Tables[0].Rows[0]["EarthingValue11"].ToString();
                    txtEarthingUsed11.Text = ds.Tables[0].Rows[0]["UsedFor11"].ToString();
                    txtEarthingType12.Text = ds.Tables[0].Rows[0]["EarthingType12"].ToString();
                    txtGeneratingEarthing12.Text = ds.Tables[0].Rows[0]["EarthingValue12"].ToString();
                    txtEarthingUsed12.Text = ds.Tables[0].Rows[0]["UsedFor12"].ToString();
                    txtEarthingType13.Text = ds.Tables[0].Rows[0]["EarthingType13"].ToString();
                    txtGeneratingEarthing13.Text = ds.Tables[0].Rows[0]["EarthingValue13"].ToString();
                    txtEarthingUsed13.Text = ds.Tables[0].Rows[0]["UsedFor13"].ToString();
                    txtEarthingType14.Text = ds.Tables[0].Rows[0]["EarthingType14"].ToString();
                    txtGeneratingEarthing14.Text = ds.Tables[0].Rows[0]["EarthingValue14"].ToString();
                    txtEarthingUsed14.Text = ds.Tables[0].Rows[0]["UsedFor14"].ToString();
                    txtEarthingType15.Text = ds.Tables[0].Rows[0]["EarthingType15"].ToString();
                    txtGeneratingEarthing15.Text = ds.Tables[0].Rows[0]["EarthingValue15"].ToString();
                    txtEarthingUsed15.Text = ds.Tables[0].Rows[0]["UsedFor15"].ToString();
                }
            }
            catch
            {

            }
        }
        protected void BtnSubmit_Click(object sender, EventArgs e)
        {
            string id = Session["GeneratingSetId"].ToString();
            CEI.UpdateGeneratingSetData(id, ddlType.SelectedItem.ToString(), txtRejection.Text);
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

    }
}