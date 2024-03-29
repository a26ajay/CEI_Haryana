﻿using CEIHaryana.Contractor;
using iTextSharp.text.pdf.parser;
using Pipelines.Sockets.Unofficial.Arenas;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Net;
using System.Net.Mail;
using System.Net.Sockets;
using System.Web.UI.WebControls;
using System.Windows.Media.TextFormatting;
using static System.Net.WebRequestMethods;

namespace CEI_PRoject
{

    public class CEI
    {
        private int tCounter = 1;
        private int lCounter = 1;
        private SqlParameter outputParam;
        #region Bind DropDown Draw State
        public DataSet WorkIntimationGridData(string LicenceNo)
        {
            return DBTask.ExecuteDataset(ConfigurationManager.ConnectionStrings["DBConnection"].ToString(), "sp_WorkIntimationGridData", LicenceNo);
        }
        #endregion

        #region AdminLogin
        public int checkLogin(string UserName, string Password)
        {
            SqlConnection con = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            string sqlProc = "sp_Admin_Login";
            con.ConnectionString = ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            //AdvNo = (string)ViewState["AdvNo"];
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = sqlProc;
            cmd.Connection = con;
            cmd.Parameters.Add("@userid", SqlDbType.VarChar, 20).Value = UserName;
            cmd.Parameters.Add("@pwd", SqlDbType.VarChar, 20).Value = Password;
            cmd.Parameters.Add(new SqlParameter("@ret", SqlDbType.NVarChar, 50));
            cmd.Parameters["@ret"].Direction = ParameterDirection.ReturnValue;
            outputParam = new SqlParameter("@Status", SqlDbType.Int);
            outputParam.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(outputParam);
            cmd.ExecuteNonQuery();
            int k = Convert.ToInt32(cmd.Parameters["@ret"].Value);
            return k;
        }
        public string Status()
        {
            if (outputParam != null)
            {
                return outputParam.Value.ToString();
            }
            else
            {
                return null;
            }
        }
        #endregion
        #region Check ApplicationStatus
        public string checkApplicationStatus(string UserName)
        {
            SqlConnection con = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            string sqlProc = "sp_ApplicationStatus";

            con.ConnectionString = ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;

            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = sqlProc;
            cmd.Connection = con;
            cmd.Parameters.Add("@UserId", SqlDbType.VarChar, 50).Value = UserName;
           SqlParameter outputParam = new SqlParameter("@ApplicationStatus", SqlDbType.NVarChar, 50);
            outputParam.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(outputParam);
            cmd.ExecuteNonQuery();
            string applicationStatus = outputParam.Value.ToString();
            return applicationStatus;
        }

        #endregion
        #region UpdateInspection
        public void UpdateInspectionData(string Id_Update, string TestRportId, string Inspectiontype, string ApplicantType, string InstallationType,
              string VoltageLevel, string RequestLetterFromConcernedOfficer, string ManufacturingTestReportOfEqipment,
              string SingleLineDiagramOfLine, string DemandNoticeOfLine, string CopyOfNoticeIssuedByUHBVNorDHBVN,
              string InvoiceOfTransferOfPersonalSubstation, string ManufacturingTestCertificateOfTransformer,
              string SingleLineDiagramofTransformer, string InvoiceoffireExtinguisheratSite, string InvoiceOfDGSetOfGeneratingSet,
              string ManufacturingCerificateOfDGSet, string InvoiceOfExptinguisherOrApparatusAtsite,
              string StructureStabilityResolvedByAuthorizedEngineer, string Staff, string CreatedBy)
        {
            SqlCommand cmd = new SqlCommand("Sp_UpdateInspection");
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString);
            cmd.Connection = con;
            if (con.State == ConnectionState.Closed)
            {
                con.ConnectionString = ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;
                con.Open();
            }
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Id ", Id_Update);
            cmd.Parameters.AddWithValue("@TestRportId ", TestRportId);
            //  cmd.Parameters.AddWithValue("@IntimationId ", IntimationId);
            cmd.Parameters.AddWithValue("@Inspectiontype ", Inspectiontype);
            cmd.Parameters.AddWithValue("@ApplicantType ", ApplicantType);
            cmd.Parameters.AddWithValue("@InstallationType ", InstallationType);
            cmd.Parameters.AddWithValue("@VoltageLevel ", VoltageLevel);
            cmd.Parameters.AddWithValue("@RequestLetterFromConcernedOfficer ", RequestLetterFromConcernedOfficer);
            cmd.Parameters.AddWithValue("@ManufacturingTestReportOfEqipment ", ManufacturingTestReportOfEqipment);
            cmd.Parameters.AddWithValue("@SingleLineDiagramOfLine ", SingleLineDiagramOfLine);
            cmd.Parameters.AddWithValue("@DemandNoticeOfLine ", DemandNoticeOfLine);
            cmd.Parameters.AddWithValue("@CopyOfNoticeIssuedByUHBVNorDHBVN ", CopyOfNoticeIssuedByUHBVNorDHBVN);
            cmd.Parameters.AddWithValue("@InvoiceOfTransferOfPersonalSubstation ", InvoiceOfTransferOfPersonalSubstation);
            cmd.Parameters.AddWithValue("@ManufacturingTestCertificateOfTransformer ", ManufacturingTestCertificateOfTransformer);
            cmd.Parameters.AddWithValue("@SingleLineDiagramofTransformer ", SingleLineDiagramofTransformer);
            cmd.Parameters.AddWithValue("@InvoiceoffireExtinguisheratSite ", InvoiceoffireExtinguisheratSite);
            cmd.Parameters.AddWithValue("@InvoiceOfDGSetOfGeneratingSet ", InvoiceOfDGSetOfGeneratingSet);
            cmd.Parameters.AddWithValue("@ManufacturingCerificateOfDGSet ", ManufacturingCerificateOfDGSet);
            cmd.Parameters.AddWithValue("@InvoiceOfExptinguisherOrApparatusAtsite ", InvoiceOfExptinguisherOrApparatusAtsite);
            cmd.Parameters.AddWithValue("@StructureStabilityResolvedByAuthorizedEngineer ", StructureStabilityResolvedByAuthorizedEngineer);
            cmd.Parameters.AddWithValue("@Staff", Staff);
            // cmd.Parameters.AddWithValue("@Division", Division);              
            cmd.Parameters.AddWithValue("@CreatedBy ", CreatedBy);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        #endregion
        #region Insert Intimtion Data
        public void IntimationDataInsertion(string Id, string ContractorId, string ContractorType, string NameOfOwner, string NameOfAgency, string ContactNo, string Address, string District, string Pincode,
string PremisesType, string OtherPremises, string VoltageLevel, string PANNumber, string TypeOfInstallation1, string NumberOfInstallation1, string TypeOfInstallation2, string NumberOfInstallation2,
string TypeOfInstallation3, string NumberOfInstallation3, string TypeOfInstallation4, string NumberOfInstallation4, string TypeOfInstallation5, string NumberOfInstallation5,
string TypeOfInstallation6, string NumberOfInstallation6, string TypeOfInstallation7, string NumberOfInstallation7, string TypeOfInstallation8, string NumberOfInstallation8,
string Email, string WorkStartDate, string CompletionDate,
string AnyWorkIssued, string CopyOfWorkOrder, string CompletionDateasPerOrder, string ApplicantType, string CreatedBy)
        {
            SqlConnection con = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            string sqlProc = "sp_WorkIntimationRegistration";
            con.ConnectionString = ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            //AdvNo = (string)ViewState["AdvNo"];
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = sqlProc;
            cmd.Connection = con;
            cmd.Parameters.AddWithValue("@Id", Id);
            cmd.Parameters.AddWithValue("@ContractorId", ContractorId);
            cmd.Parameters.AddWithValue("@ContractorType", ContractorType);
            cmd.Parameters.AddWithValue("@NameOfOwner", NameOfOwner);
            cmd.Parameters.AddWithValue("@NameOfAgency", NameOfAgency);
            cmd.Parameters.AddWithValue("@ContactNo", ContactNo);
            cmd.Parameters.AddWithValue("@Address", Address);
            cmd.Parameters.AddWithValue("@District", District);
            cmd.Parameters.AddWithValue("@Pincode", Pincode);
            cmd.Parameters.AddWithValue("@PremisesType", PremisesType);
            cmd.Parameters.AddWithValue("@OtherPremises", OtherPremises);
            cmd.Parameters.AddWithValue("@VoltageLevel", VoltageLevel);
            cmd.Parameters.AddWithValue("@PANNumber", PANNumber);
            cmd.Parameters.AddWithValue("@TypeOfInstallation1", TypeOfInstallation1);
            cmd.Parameters.AddWithValue("@NumberOfInstallation1", NumberOfInstallation1);
            cmd.Parameters.AddWithValue("@TypeOfInstallation2", TypeOfInstallation2);
            cmd.Parameters.AddWithValue("@NumberOfInstallation2", NumberOfInstallation2);
            cmd.Parameters.AddWithValue("@TypeOfInstallation3", TypeOfInstallation3);
            cmd.Parameters.AddWithValue("@NumberOfInstallation3", NumberOfInstallation3);
            cmd.Parameters.AddWithValue("@TypeOfInstallation4", TypeOfInstallation4);
            cmd.Parameters.AddWithValue("@NumberOfInstallation4", NumberOfInstallation4);
            cmd.Parameters.AddWithValue("@TypeOfInstallation5", TypeOfInstallation5);
            cmd.Parameters.AddWithValue("@NumberOfInstallation5", NumberOfInstallation5);
            cmd.Parameters.AddWithValue("@TypeOfInstallation6", TypeOfInstallation6);
            cmd.Parameters.AddWithValue("@NumberOfInstallation6", NumberOfInstallation6);
            cmd.Parameters.AddWithValue("@TypeOfInstallation7", TypeOfInstallation7);
            cmd.Parameters.AddWithValue("@NumberOfInstallation7", NumberOfInstallation7);
            cmd.Parameters.AddWithValue("@TypeOfInstallation8", TypeOfInstallation8);
            cmd.Parameters.AddWithValue("@NumberOfInstallation8", NumberOfInstallation8);
            cmd.Parameters.AddWithValue("@Email", Email);
            cmd.Parameters.AddWithValue("@WorkStartDate", WorkStartDate);
            cmd.Parameters.AddWithValue("@CompletionDate", CompletionDate);
            cmd.Parameters.AddWithValue("@AnyWorkIssued", AnyWorkIssued);
            cmd.Parameters.AddWithValue("@CopyOfWorkOrder", CopyOfWorkOrder);
            cmd.Parameters.AddWithValue("@CompletionDateasPerOrder", CompletionDateasPerOrder);
            cmd.Parameters.AddWithValue("@ApplicantType", ApplicantType);
            cmd.Parameters.AddWithValue("@CreatedBy", CreatedBy);
            outputParam = new SqlParameter("@RegistrationID", SqlDbType.NVarChar, 50);
            outputParam.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(outputParam);
            cmd.ExecuteNonQuery();

        }
        public string projectId()
        {
            if (outputParam != null)
            {
                return outputParam.Value.ToString();
            }
            else
            {
                return null;
            }
        }
        public void AddInstallations(string IntimationId, string Typeofinstallation, int Noofinstallation)
        {
            SqlCommand cmd = new SqlCommand("sp_InstallationsCount");
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString);
            cmd.Connection = con;
            if (con.State == ConnectionState.Closed)
            {
                con.ConnectionString = ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;
                con.Open();
            }

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IntimationId ", IntimationId);
            cmd.Parameters.AddWithValue("@Typeofinstallation", Typeofinstallation);
            cmd.Parameters.AddWithValue("@Noofinstallation", Noofinstallation);
            cmd.ExecuteNonQuery();
            con.Close();

        }

        public void UpdateInstallations(string Id,string IntimationId)
        {
            SqlCommand cmd = new SqlCommand("sp_CheckTestReportHistory");
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString);
            cmd.Connection = con;
            if (con.State == ConnectionState.Closed)
            {
                con.ConnectionString = ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;
                con.Open();
            }

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Id ", Id);
            cmd.Parameters.AddWithValue("@IntimationId", IntimationId);
            cmd.ExecuteNonQuery();
            con.Close();

        }
        public DataSet InsertSiteOwnerData(string SiteOwnerUserId)
        {
            return DBTask.ExecuteDataset(ConfigurationManager.ConnectionStrings["DBConnection"].ToString(), "sp_InsertSiteOwnerLogin", SiteOwnerUserId);
        }

        #endregion
        #region Insert Supervisor Data
        public void InserSupervisorData(string REID, string Name, string Age, string FatherName, string Address, string District, string State, string PinCode, string PhoneNo,
      string Qualification, string Email, string CertificateOld, string CertificateNew, string DateofIntialissue, string DateofExpiry,
      string DateofRenewal, string votagelevel, string voltageWithEffect, string AnyContractor, string AttachedContractorld,
    string CreatedBy, string UserId, string IPAddress)
        {

            SqlCommand cmd = new SqlCommand("sp_SetWiremanandSuperwiserDetails");
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString);
            cmd.Connection = con;
            if (con.State == ConnectionState.Closed)
            {
                con.ConnectionString = ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;
                con.Open();
            }
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@REID", REID);
            cmd.Parameters.AddWithValue("@Name", Name);
            cmd.Parameters.AddWithValue("@Age", Age);
            cmd.Parameters.AddWithValue("@FatherName", FatherName);
            cmd.Parameters.AddWithValue("@Address", Address);
            cmd.Parameters.AddWithValue("@District", District);
            cmd.Parameters.AddWithValue("@State", State);
            cmd.Parameters.AddWithValue("@PinCode", PinCode);
            cmd.Parameters.AddWithValue("@PhoneNo", PhoneNo);
            cmd.Parameters.AddWithValue("@Qualification", Qualification);
            cmd.Parameters.AddWithValue("@Email", Email);
            cmd.Parameters.AddWithValue("@CertificateOld", CertificateOld);
            cmd.Parameters.AddWithValue("@CertificateNew", CertificateNew);
            cmd.Parameters.AddWithValue("@DateofIntialissue", DateofIntialissue);
            cmd.Parameters.AddWithValue("@DateofExpiry", DateofExpiry);
            cmd.Parameters.AddWithValue("@DateofRenewal", DateofRenewal);
            cmd.Parameters.AddWithValue("@votagelevel", votagelevel);
            cmd.Parameters.AddWithValue("@voltageWithEffect", voltageWithEffect);
            cmd.Parameters.AddWithValue("@AnyContractor", AnyContractor);
            cmd.Parameters.AddWithValue("@AttachedContractorld", AttachedContractorld);
            cmd.Parameters.AddWithValue("@Category", "Supervisor");
            cmd.Parameters.AddWithValue("@Createdby", CreatedBy);
            cmd.Parameters.AddWithValue("@UserId", UserId);

            cmd.Parameters.AddWithValue("@IPAddress", IPAddress);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        #endregion
        #region Insert Wireman Data
        public void InserWireManData(string REID, string Name, string Age, string FatherName, string Address, string District, string State, string PinCode, string PhoneNo,
      string Qualification, string Email, string CertificateOld, string CertificateNew, string DateofIntialissue, string DateofExpiry,
      string DateofRenewal, string AnyContractor, string AttachedContractorld,
    string CreatedBy, string UserId, string IPAddress)
        {

            SqlCommand cmd = new SqlCommand("sp_SetWiremanandSuperwiserDetails");
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString);
            cmd.Connection = con;
            if (con.State == ConnectionState.Closed)
            {
                con.ConnectionString = ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;
                con.Open();
            }
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@REID", REID);
            cmd.Parameters.AddWithValue("@Name", Name);
            cmd.Parameters.AddWithValue("@Age", Age);
            cmd.Parameters.AddWithValue("@FatherName", FatherName);
            cmd.Parameters.AddWithValue("@Address", Address);
            cmd.Parameters.AddWithValue("@District", District);
            cmd.Parameters.AddWithValue("@State", State);
            cmd.Parameters.AddWithValue("@PinCode", PinCode);
            cmd.Parameters.AddWithValue("@PhoneNo", PhoneNo);
            cmd.Parameters.AddWithValue("@Qualification", Qualification);
            cmd.Parameters.AddWithValue("@Email", Email);
            cmd.Parameters.AddWithValue("@CertificateOld", CertificateOld);
            cmd.Parameters.AddWithValue("@CertificateNew", CertificateNew);
            cmd.Parameters.AddWithValue("@DateofIntialissue", DateofIntialissue);
            cmd.Parameters.AddWithValue("@DateofExpiry", DateofExpiry);
            cmd.Parameters.AddWithValue("@DateofRenewal", DateofRenewal);
            cmd.Parameters.AddWithValue("@AnyContractor", AnyContractor);
            cmd.Parameters.AddWithValue("@AttachedContractorld", AttachedContractorld);
            cmd.Parameters.AddWithValue("@Category", "Wireman");
            cmd.Parameters.AddWithValue("@Createdby", CreatedBy);
            cmd.Parameters.AddWithValue("@UserId", UserId);

            cmd.Parameters.AddWithValue("@IPAddress", IPAddress);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        #endregion
        #region Insert Contractor Data
        public void InsertContractorData(string ContractorID, string UserId, string Name, string FatherName, string FirmName, string GSTNumber, string RegisteredOffice,
      string State, string Districtoffirm, string PinCode, string BranchOffice, string BranchState, string BranchDistrictoffirm,
      string BranchPinCode, string PhoneNo, string Email, string DateofIntialissue, string DateofRenewal, string DateofExpiry,
      string votagelevel, string voltageWithEffect, string LicenceOld, string LicenceNew, string IPAddress, string Createdby)
        {

            SqlCommand cmd = new SqlCommand("sp_setContractorRegistrationDetails");
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString);
            cmd.Connection = con;
            if (con.State == ConnectionState.Closed)
            {
                con.ConnectionString = ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;
                con.Open();
            }
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ContractorID", ContractorID);
            cmd.Parameters.AddWithValue("@UserId", UserId);
            cmd.Parameters.AddWithValue("@Name", Name);
            cmd.Parameters.AddWithValue("@FatherName", FatherName);
            cmd.Parameters.AddWithValue("@FirmName", FirmName);
            cmd.Parameters.AddWithValue("@GSTNumber", GSTNumber);
            cmd.Parameters.AddWithValue("@RegisteredOffice", RegisteredOffice);
            cmd.Parameters.AddWithValue("@State", State);
            cmd.Parameters.AddWithValue("@Districtoffirm", Districtoffirm);
            cmd.Parameters.AddWithValue("@PinCode", PinCode);
            cmd.Parameters.AddWithValue("@BranchOffice", BranchOffice);
            cmd.Parameters.AddWithValue("@BranchState", BranchState);
            cmd.Parameters.AddWithValue("@BranchDistrictoffirm", BranchDistrictoffirm);
            cmd.Parameters.AddWithValue("@BranchPinCode", BranchPinCode);
            cmd.Parameters.AddWithValue("@PhoneNo", PhoneNo);
            cmd.Parameters.AddWithValue("@Email", Email);
            cmd.Parameters.AddWithValue("@DateofIntialissue", DateofIntialissue);
            cmd.Parameters.AddWithValue("@DateofRenewal", DateofRenewal);
            cmd.Parameters.AddWithValue("@DateofExpiry", DateofExpiry);
            cmd.Parameters.AddWithValue("@votagelevel", votagelevel);
            cmd.Parameters.AddWithValue("@voltageWithEffect", voltageWithEffect);
            cmd.Parameters.AddWithValue("@LicenceOld", LicenceOld);
            cmd.Parameters.AddWithValue("@LicenceNew", LicenceNew);
            cmd.Parameters.AddWithValue("@IPAddress", IPAddress);
            cmd.Parameters.AddWithValue("@Createdby", Createdby);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        #endregion
        #region Update Line Data
        public void UpdateLineData(string ID,string Count, string RejectOrApprovedFronContractor, string ReasonForRejection)
        {
            SqlCommand cmd = new SqlCommand("sp_ContractorTestReortApproval");
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString);
            cmd.Connection = con;
            if (con.State == ConnectionState.Closed)
            {
                con.ConnectionString = ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;
                con.Open();
            }

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Id", ID);
            cmd.Parameters.AddWithValue("@Count", Count);
            cmd.Parameters.AddWithValue("@RejectOrApprovedFronContractor", RejectOrApprovedFronContractor);
            cmd.Parameters.AddWithValue("@ReasonForRejection", ReasonForRejection);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        #endregion
        #region Insert Line Data
        public void InsertLineData(string IdUpdate, string Count, string LineId, string IntimationId, string LineVoltage, string OtherVoltageType, string OtherVoltage, string LineLength, string LineType, string NoOfCircuit,
            string Conductortype, string NumberofPoleTower, string ConductorSize, string GroundWireSize, string NmbrofRailwayCrossing,
            string NmbrofRoadCrossing, string NmbrofRiverCanalCrossing, string NmbrofPowerLineCrossing, string NmbrofEarthing, string EarthingType1,
            string Valueinohms1, string EarthingType2, string Valueinohms2, string EarthingType3, string Valueinohms3, string EarthingType4, string Valueinohms4, string EarthingType5, string Valueinohms5, string
EarthingType6, string Valueinohms6, string EarthingType7, string Valueinohms7, string EarthingType8, string Valueinohms8, string EarthingType9, string Valueinohms9, string EarthingType10, string
Valueinohms10, string EarthingType11, string Valueinohms11, string EarthingType12, string Valueinohms12, string EarthingType13, string Valueinohms13, string EarthingType14, string Valueinohms14, string
EarthingType15, string Valueinohms15, string NoofPoleTowerForOverheadCable, string CableSize, string RailwayCrossingNoForOC, string RoadCrossingNoForOC,
            string RiverCanalCrossingNoForOC, string PowerLineCrossingNoForOc, string RedPhaseEarthWire, string YellowPhaseEarth,
            string BluePhaseEarthWire, string RedPhaseYellowPhase, string RedPhaseBluePhase, string BluePhaseYellowPhase, string PhasewireNeutralwire,
            string PhasewireEarth, string NeutralwireEarth, string TypeofCable, string OtherCable, string SizeofCable, string Cablelaidin,
            string RedPhaseEarthWirefor440orAbove, string YellowPhaseEarthWire440orAbove, string BluePhaseEarthWire440orAbove,
            string RedPhaseYellowPhase440orAbove, string RedPhaseBluePhase440orAbove, string BluePhaseYellowPhase440orAbove,
            string PhasewireNeutralwire220OrAbove, string PhasewireEarth220OrAbove, string NeutralwireEarth220OrAbove, string CreatedBy
)
        {
            SqlCommand cmd = new SqlCommand("sp_InserLineData");
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString);
            cmd.Connection = con;
            if (con.State == ConnectionState.Closed)
            {
                con.ConnectionString = ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;
                con.Open();
            }

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IdUpdate", IdUpdate);
            cmd.Parameters.AddWithValue("@Count", Count);
            cmd.Parameters.AddWithValue("@Id", LineId);
            cmd.Parameters.AddWithValue("@IntimationId", IntimationId);
            cmd.Parameters.AddWithValue("@LineVoltage", LineVoltage);
            cmd.Parameters.AddWithValue("@LineLength", LineLength);
            cmd.Parameters.AddWithValue("@OtherVoltageType", OtherVoltageType);
            cmd.Parameters.AddWithValue("@OtherVoltage", OtherVoltage);
            cmd.Parameters.AddWithValue("@LineType", LineType);
            cmd.Parameters.AddWithValue("@NoOfCircuit", NoOfCircuit);
            cmd.Parameters.AddWithValue("@Conductortype", Conductortype);
            cmd.Parameters.AddWithValue("@NumberofPoleTower", NumberofPoleTower);
            cmd.Parameters.AddWithValue("@ConductorSize", ConductorSize);
            cmd.Parameters.AddWithValue("@GroundWireSize", GroundWireSize);
            cmd.Parameters.AddWithValue("@NmbrofRailwayCrossing", NmbrofRailwayCrossing);
            cmd.Parameters.AddWithValue("@NmbrofRoadCrossing", NmbrofRoadCrossing);
            cmd.Parameters.AddWithValue("@NmbrofRiverCanalCrossing", NmbrofRiverCanalCrossing);
            cmd.Parameters.AddWithValue("@NmbrofPowerLineCrossing", NmbrofPowerLineCrossing);
            cmd.Parameters.AddWithValue("@NmbrofEarthing", NmbrofEarthing);
            cmd.Parameters.AddWithValue("@EarthingType1", EarthingType1);
            cmd.Parameters.AddWithValue("@Valueinohms1", Valueinohms1);
            cmd.Parameters.AddWithValue("@EarthingType2", EarthingType2);
            cmd.Parameters.AddWithValue("@Valueinohms2", Valueinohms2);
            cmd.Parameters.AddWithValue("@EarthingType3", EarthingType3);
            cmd.Parameters.AddWithValue("@Valueinohms3", Valueinohms3);
            cmd.Parameters.AddWithValue("@EarthingType4", EarthingType4);
            cmd.Parameters.AddWithValue("@Valueinohms4", Valueinohms4);
            cmd.Parameters.AddWithValue("@EarthingType5", EarthingType5);
            cmd.Parameters.AddWithValue("@Valueinohms5", Valueinohms5);
            cmd.Parameters.AddWithValue("@EarthingType6", EarthingType6);
            cmd.Parameters.AddWithValue("@Valueinohms6", Valueinohms6);
            cmd.Parameters.AddWithValue("@EarthingType7", EarthingType7);
            cmd.Parameters.AddWithValue("@Valueinohms7", Valueinohms7);
            cmd.Parameters.AddWithValue("@EarthingType8", EarthingType8);
            cmd.Parameters.AddWithValue("@Valueinohms8", Valueinohms8);
            cmd.Parameters.AddWithValue("@EarthingType9", EarthingType9);
            cmd.Parameters.AddWithValue("@Valueinohms9", Valueinohms9);
            cmd.Parameters.AddWithValue("@EarthingType10", EarthingType10);
            cmd.Parameters.AddWithValue("@Valueinohms10", Valueinohms10);
            cmd.Parameters.AddWithValue("@EarthingType11", EarthingType11);
            cmd.Parameters.AddWithValue("@Valueinohms11", Valueinohms11);
            cmd.Parameters.AddWithValue("@EarthingType12", EarthingType12);
            cmd.Parameters.AddWithValue("@Valueinohms12", Valueinohms12);
            cmd.Parameters.AddWithValue("@EarthingType13", EarthingType13);
            cmd.Parameters.AddWithValue("@Valueinohms13", Valueinohms13);
            cmd.Parameters.AddWithValue("@EarthingType14", EarthingType14);
            cmd.Parameters.AddWithValue("@Valueinohms14", Valueinohms15);
            cmd.Parameters.AddWithValue("@EarthingType15", EarthingType15);
            cmd.Parameters.AddWithValue("@Valueinohms15", Valueinohms15);
            cmd.Parameters.AddWithValue("@NoofPoleTowerForOverheadCable", NoofPoleTowerForOverheadCable);
            cmd.Parameters.AddWithValue("@CableSize", CableSize);
            cmd.Parameters.AddWithValue("@RailwayCrossingNoForOC", RailwayCrossingNoForOC);
            cmd.Parameters.AddWithValue("@RoadCrossingNoForOC", RoadCrossingNoForOC);
            cmd.Parameters.AddWithValue("@RiverCanalCrossingNoForOC", RiverCanalCrossingNoForOC);
            cmd.Parameters.AddWithValue("@PowerLineCrossingNoForOc", PowerLineCrossingNoForOc);
            cmd.Parameters.AddWithValue("@RedPhaseEarthWire", RedPhaseEarthWire);
            cmd.Parameters.AddWithValue("@YellowPhaseEarth", YellowPhaseEarth);
            cmd.Parameters.AddWithValue("@BluePhaseEarthWire", BluePhaseEarthWire);
            cmd.Parameters.AddWithValue("@RedPhaseYellowPhase", RedPhaseYellowPhase);
            cmd.Parameters.AddWithValue("@RedPhaseBluePhase", RedPhaseBluePhase);
            cmd.Parameters.AddWithValue("@BluePhaseYellowPhase", BluePhaseYellowPhase);
            cmd.Parameters.AddWithValue("@PhasewireNeutralwire", PhasewireNeutralwire);
            cmd.Parameters.AddWithValue("@PhasewireEarth", PhasewireEarth);
            cmd.Parameters.AddWithValue("@NeutralwireEarth", NeutralwireEarth);
            cmd.Parameters.AddWithValue("@TypeofCable", TypeofCable);
            cmd.Parameters.AddWithValue("@OtherCable", OtherCable);
            cmd.Parameters.AddWithValue("@SizeofCable", SizeofCable);
            cmd.Parameters.AddWithValue("@Cablelaidin", Cablelaidin);
            cmd.Parameters.AddWithValue("@RedPhaseEarthWirefor440orAbove", RedPhaseEarthWirefor440orAbove);
            cmd.Parameters.AddWithValue("@YellowPhaseEarthWire440orAbove", YellowPhaseEarthWire440orAbove);
            cmd.Parameters.AddWithValue("@BluePhaseEarthWire440orAbove", BluePhaseEarthWire440orAbove);
            cmd.Parameters.AddWithValue("@RedPhaseYellowPhase440orAbove", RedPhaseYellowPhase440orAbove);
            cmd.Parameters.AddWithValue("@RedPhaseBluePhase440orAbove", RedPhaseBluePhase440orAbove);
            cmd.Parameters.AddWithValue("@BluePhaseYellowPhase440orAbove", BluePhaseYellowPhase440orAbove);
            cmd.Parameters.AddWithValue("@PhasewireNeutralwire220OrAbove", PhasewireNeutralwire220OrAbove);
            cmd.Parameters.AddWithValue("@PhasewireEarth220OrAbove", PhasewireEarth220OrAbove);
            cmd.Parameters.AddWithValue("@NeutralwireEarth220OrAbove", NeutralwireEarth220OrAbove);
            cmd.Parameters.AddWithValue("@CreatedBy", CreatedBy);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        #endregion
        #region Insert Substation Data
        public void InsertSubstationData(string IdUpdate, string Count, string Id, string TestReportId, string IntimationId, string TransformerSerialNumber, string TransformerCapacityType, string TransformerCapacity, string TranformerType,
            string PrimaryVoltage, string SecondoryVoltage, string OilCapacity, string BreakDownVoltageofOil, string HtInsulationHVEarth,
            string LtInsulationLVEarth, string LowestvaluebetweenHTLTSide, string LightningArrestorLocation, string OtherLALocation,
            string TypeofHTPrimarySideSwitch, string NumberOfEarthing, string EarthingType1, string Valueinohms1,
            string UsedFor1, string OtherEarthing1, string EarthingType2, string Valueinohms2, string UsedFor2, string OtherEarthing2, string EarthingType3, string Valueinohms3, string UsedFor3, string OtherEarthing3,
            string EarthingType4, string Valueinohms4, string UsedFor4, string OtherEarthing4, string EarthingType5, string Valueinohms5, string UsedFor5, string OtherEarthing5,
            string EarthingType6, string Valueinohms6, string UsedFor6, string OtherEarthing6, string EarthingType7, string Valueinohms7, string UsedFor7, string OtherEarthing7,
            string EarthingType8, string Valueinohms8, string UsedFor8, string OtherEarthing8, string EarthingType9, string Valueinohms9, string UsedFor9, string OtherEarthing9,
            string EarthingType10, string Valueinohms10, string UsedFor10, string OtherEarthing10, string EarthingType11, string Valueinohms11, string UsedFor11, string OtherEarthing11,
            string EarthingType12, string Valueinohms12, string UsedFor12, string OtherEarthing12, string EarthingType13, string Valueinohms13, string UsedFor13, string OtherEarthing13,
            string EarthingType14, string Valueinohms14, string UsedFor14, string OtherEarthing14, string EarthingType15, string Valueinohms15, string UsedFor15, string OtherEarthing15,
            string EarthingType16, string Valueinohms16, string UsedFor16, string OtherEarthing16, string EarthingType17, string Valueinohms17, string UsedFor17, string OtherEarthing17,
            string EarthingType18, string Valueinohms18, string UsedFor18, string OtherEarthing18, string EarthingType19, string Valueinohms19, string UsedFor19, string OtherEarthing19,
            string EarthingType20, string Valueinohms20, string UsedFor20, string OtherEarthing20, string LoadBreakingCapacityOfBreakerInKA, string TypeOfLTProtection,
            string CapacityOfIndividualFuseInAMPS, string CapacityOfLTBreakerInAMPS, string LoadBreakingCapacityOfBreakerInAMPS, string SeaLevelOfTransformerInMeters, string CreatedBy)
        {
            SqlCommand cmd = new SqlCommand("sp_InsertSubstationTransformerData");
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString);
            cmd.Connection = con;
            if (con.State == ConnectionState.Closed)
            {
                con.ConnectionString = ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;
                con.Open();
            }

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IdUpdate", IdUpdate);
            cmd.Parameters.AddWithValue("@Count", Count);
            cmd.Parameters.AddWithValue("@Id", Id);
            cmd.Parameters.AddWithValue("@TestReportId", TestReportId);
            cmd.Parameters.AddWithValue("@IntimationId", IntimationId);
            cmd.Parameters.AddWithValue("@TransformerSerialNumber", TransformerSerialNumber);
            cmd.Parameters.AddWithValue("@TransformerCapacityType", TransformerCapacityType);
            cmd.Parameters.AddWithValue("@TransformerCapacity", TransformerCapacity);
            cmd.Parameters.AddWithValue("@TranformerType", TranformerType);
            cmd.Parameters.AddWithValue("@PrimaryVoltage", PrimaryVoltage);
            cmd.Parameters.AddWithValue("@SecondoryVoltage", SecondoryVoltage);
            cmd.Parameters.AddWithValue("@OilCapacity", OilCapacity);
            cmd.Parameters.AddWithValue("@BreakDownVoltageofOil", BreakDownVoltageofOil);
            cmd.Parameters.AddWithValue("@HtInsulationHVEarth", HtInsulationHVEarth);
            cmd.Parameters.AddWithValue("@LtInsulationLVEarth", LtInsulationLVEarth);
            cmd.Parameters.AddWithValue("@LowestvaluebetweenHTLTSide", LowestvaluebetweenHTLTSide);
            cmd.Parameters.AddWithValue("@LightningArrestorLocation", LightningArrestorLocation);
            cmd.Parameters.AddWithValue("@OtherLALocation", OtherLALocation);
            cmd.Parameters.AddWithValue("@TypeofHTPrimarySideSwitch", TypeofHTPrimarySideSwitch);
            cmd.Parameters.AddWithValue("@NumberOfEarthing", NumberOfEarthing);
            cmd.Parameters.AddWithValue("@EarthingType1", EarthingType1);
            cmd.Parameters.AddWithValue("@Valueinohms1", Valueinohms1);
            cmd.Parameters.AddWithValue("@UsedFor1", UsedFor1);
            cmd.Parameters.AddWithValue("@OtherEarthing1", OtherEarthing1);
            cmd.Parameters.AddWithValue("@EarthingType2", EarthingType2);
            cmd.Parameters.AddWithValue("@Valueinohms2", Valueinohms2);
            cmd.Parameters.AddWithValue("@UsedFor2", UsedFor2);
            cmd.Parameters.AddWithValue("@OtherEarthing2", OtherEarthing2);
            cmd.Parameters.AddWithValue("@EarthingType3", EarthingType3);
            cmd.Parameters.AddWithValue("@Valueinohms3", Valueinohms3);
            cmd.Parameters.AddWithValue("@UsedFor3", UsedFor3);
            cmd.Parameters.AddWithValue("@OtherEarthing3", OtherEarthing3);
            cmd.Parameters.AddWithValue("@EarthingType4", EarthingType4);
            cmd.Parameters.AddWithValue("@Valueinohms4", Valueinohms4);
            cmd.Parameters.AddWithValue("@UsedFor4", UsedFor4);
            cmd.Parameters.AddWithValue("@OtherEarthing4", OtherEarthing4);
            cmd.Parameters.AddWithValue("@EarthingType5", EarthingType5);
            cmd.Parameters.AddWithValue("@Valueinohms5", Valueinohms5);
            cmd.Parameters.AddWithValue("@UsedFor5", UsedFor5);
            cmd.Parameters.AddWithValue("@OtherEarthing5", OtherEarthing5);
            cmd.Parameters.AddWithValue("@EarthingType6", EarthingType6);
            cmd.Parameters.AddWithValue("@Valueinohms6", Valueinohms6);
            cmd.Parameters.AddWithValue("@UsedFor6", UsedFor6);
            cmd.Parameters.AddWithValue("@OtherEarthing6", OtherEarthing6);
            cmd.Parameters.AddWithValue("@EarthingType7", EarthingType7);
            cmd.Parameters.AddWithValue("@Valueinohms7", Valueinohms7);
            cmd.Parameters.AddWithValue("@UsedFor7", UsedFor7);
            cmd.Parameters.AddWithValue("@OtherEarthing7", OtherEarthing7);
            cmd.Parameters.AddWithValue("@EarthingType8", EarthingType8);
            cmd.Parameters.AddWithValue("@Valueinohms8", Valueinohms8);
            cmd.Parameters.AddWithValue("@UsedFor8", UsedFor8);
            cmd.Parameters.AddWithValue("@OtherEarthing8", OtherEarthing8);
            cmd.Parameters.AddWithValue("@EarthingType9", EarthingType9);
            cmd.Parameters.AddWithValue("@Valueinohms9", Valueinohms9);
            cmd.Parameters.AddWithValue("@UsedFor9", UsedFor9);
            cmd.Parameters.AddWithValue("@OtherEarthing9", OtherEarthing9);
            cmd.Parameters.AddWithValue("@EarthingType10", EarthingType10);
            cmd.Parameters.AddWithValue("@Valueinohms10", Valueinohms10);
            cmd.Parameters.AddWithValue("@UsedFor10", UsedFor10);
            cmd.Parameters.AddWithValue("@OtherEarthing10", OtherEarthing10);
            cmd.Parameters.AddWithValue("@EarthingType11", EarthingType11);
            cmd.Parameters.AddWithValue("@Valueinohms11", Valueinohms11);
            cmd.Parameters.AddWithValue("@UsedFor11", UsedFor11);
            cmd.Parameters.AddWithValue("@OtherEarthing11", OtherEarthing11);
            cmd.Parameters.AddWithValue("@EarthingType12", EarthingType12);
            cmd.Parameters.AddWithValue("@Valueinohms12", Valueinohms12);
            cmd.Parameters.AddWithValue("@UsedFor12", UsedFor12);
            cmd.Parameters.AddWithValue("@OtherEarthing12", OtherEarthing12);
            cmd.Parameters.AddWithValue("@EarthingType13", EarthingType13);
            cmd.Parameters.AddWithValue("@Valueinohms13", Valueinohms13);
            cmd.Parameters.AddWithValue("@UsedFor13", UsedFor13);
            cmd.Parameters.AddWithValue("@OtherEarthing13", OtherEarthing13);
            cmd.Parameters.AddWithValue("@EarthingType14", EarthingType14);
            cmd.Parameters.AddWithValue("@Valueinohms14", Valueinohms14);
            cmd.Parameters.AddWithValue("@UsedFor14", UsedFor14);
            cmd.Parameters.AddWithValue("@OtherEarthing14", OtherEarthing14);
            cmd.Parameters.AddWithValue("@EarthingType15", EarthingType15);
            cmd.Parameters.AddWithValue("@Valueinohms15", Valueinohms15);
            cmd.Parameters.AddWithValue("@UsedFor15", UsedFor15);
            cmd.Parameters.AddWithValue("@OtherEarthing15", OtherEarthing15);
            cmd.Parameters.AddWithValue("@EarthingType16", EarthingType16);
            cmd.Parameters.AddWithValue("@Valueinohms16", Valueinohms16);
            cmd.Parameters.AddWithValue("@UsedFor16", UsedFor16);
            cmd.Parameters.AddWithValue("@OtherEarthing16", OtherEarthing16);
            cmd.Parameters.AddWithValue("@EarthingType17", EarthingType17);
            cmd.Parameters.AddWithValue("@Valueinohms17", Valueinohms17);
            cmd.Parameters.AddWithValue("@UsedFor17", UsedFor17);
            cmd.Parameters.AddWithValue("@OtherEarthing17", OtherEarthing17);
            cmd.Parameters.AddWithValue("@EarthingType18", EarthingType18);
            cmd.Parameters.AddWithValue("@Valueinohms18", Valueinohms18);
            cmd.Parameters.AddWithValue("@UsedFor18", UsedFor18);
            cmd.Parameters.AddWithValue("@OtherEarthing18", OtherEarthing18);
            cmd.Parameters.AddWithValue("@EarthingType19", EarthingType19);
            cmd.Parameters.AddWithValue("@Valueinohms19", Valueinohms19);
            cmd.Parameters.AddWithValue("@UsedFor19", UsedFor19);
            cmd.Parameters.AddWithValue("@OtherEarthing19", OtherEarthing19);
            cmd.Parameters.AddWithValue("@EarthingType20", EarthingType20);
            cmd.Parameters.AddWithValue("@Valueinohms20", Valueinohms20);
            cmd.Parameters.AddWithValue("@UsedFor20", UsedFor20);
            cmd.Parameters.AddWithValue("@OtherEarthing20", OtherEarthing20);
            cmd.Parameters.AddWithValue("@LoadBreakingCapacityOfBreakerInKA", LoadBreakingCapacityOfBreakerInKA);
            cmd.Parameters.AddWithValue("@TypeOfLTProtection", TypeOfLTProtection);
            cmd.Parameters.AddWithValue("@CapacityOfIndividualFuseInAMPS", CapacityOfIndividualFuseInAMPS);
            cmd.Parameters.AddWithValue("@CapacityOfLTBreakerInAMPS", CapacityOfLTBreakerInAMPS);
            cmd.Parameters.AddWithValue("@LoadBreakingCapacityOfBreakerInAMPS", LoadBreakingCapacityOfBreakerInAMPS);
            cmd.Parameters.AddWithValue("@SeaLevelOfTransformerInMeters", SeaLevelOfTransformerInMeters);
            cmd.Parameters.AddWithValue("@CreatedBy", CreatedBy);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public string GenerateUniqueSubstation()
        {
            SqlCommand cmd = new SqlCommand("sp_GenerateSubstationId");
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString);
            cmd.Connection = con;
            if (con.State == ConnectionState.Closed)
            {
                con.ConnectionString = ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;
                con.Open();
            }

            cmd.CommandType = CommandType.StoredProcedure;
            outputParam = new SqlParameter("@RegistrationID", SqlDbType.NVarChar, 50);
            outputParam.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(outputParam);
            cmd.ExecuteNonQuery();

            if (outputParam != null)
            {
                return outputParam.Value.ToString();
            }
            else
            {
                return null;
            }
        }
        #endregion


        #region Update Substation Data
        public void UpdateSubstationData(string ID,string Count, string RejectOrApprovedFronContractor, string ReasonForRejection)
        {
            SqlCommand cmd = new SqlCommand("sp_SubstationTestReportApproval");
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString);
            cmd.Connection = con;
            if (con.State == ConnectionState.Closed)
            {
                con.ConnectionString = ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;
                con.Open();
            }

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Id", ID);
            cmd.Parameters.AddWithValue("@Count", Count);
            cmd.Parameters.AddWithValue("@RejectOrApprovedFronContractor", RejectOrApprovedFronContractor);
            cmd.Parameters.AddWithValue("@ReasonForRejection", ReasonForRejection);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        #endregion
        #region Update GeneratingSet Data
        public void UpdateGeneratingSetData(string ID,string Count, string RejectOrApprovedFronContractor, string ReasonForRejection)
        {
            SqlCommand cmd = new SqlCommand("sp_GeneratingTestReportApproval");
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString);
            cmd.Connection = con;
            if (con.State == ConnectionState.Closed)
            {
                con.ConnectionString = ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;
                con.Open();
            }

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Id", ID);
            cmd.Parameters.AddWithValue("@Count", Count);
            cmd.Parameters.AddWithValue("@RejectOrApprovedFronContractor", RejectOrApprovedFronContractor);
            cmd.Parameters.AddWithValue("@ReasonForRejection", ReasonForRejection);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        #endregion

        #region Update Inspection Data
        public void UpdateInspectionData(string ID)
        {
            SqlCommand cmd = new SqlCommand("sp_UpdateStatus");
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString);
            cmd.Connection = con;
            if (con.State == ConnectionState.Closed)
            {
                con.ConnectionString = ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;
                con.Open();
            }

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Id", ID);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        #endregion
        #region Insert GeneratingSet Data
        public void InsertGeneratingSetData(string IdUpdate, string Count, string Id, string IntimationId, string GeneratingSetCapacityType, string GeneratingSetCapacity, string SerialNumbrOfAcGenerator, string GeneratingSetType, string GeneratorVoltageLevel, string CurrenntCapacityOfBreaker,
string BreakingCapacityofBreaker, string TypeOfPlant, string CapacityOfPlantType, string CapacityOfPlant, string HighestVoltageLevelOfDCString, string LowestInsulationBetweenDCWireToEarth,
string NoOfPowerPCV, string LTACBreakerCapacity, string ACCablesLowestInsulation, string NumberOfEarthing, string EarthingType1, string EarthingValue1, string UsedFor1, string OtherEarthing1, string EarthingType2,
string EarthingValue2, string UsedFor2, string OtherEarthing2, string EarthingType3, string EarthingValue3, string UsedFor3, string OtherEarthing3, string EarthingType4, string EarthingValue4, string UsedFor4, string OtherEarthing4, string EarthingType5, string EarthingValue5,
string UsedFor5, string OtherEarthing5, string EarthingType6, string EarthingValue6, string UsedFor6, string OtherEarthing6, string EarthingType7, string EarthingValue7, string UsedFor7, string OtherEarthing7, string EarthingType8, string EarthingValue8,
string UsedFor8, string OtherEarthing8, string EarthingType9, string EarthingValue9, string UsedFor9, string OtherEarthing9, string EarthingType10, string EarthingValue10, string UsedFor10, string OtherEarthing10, string EarthingType11, string EarthingValue11,
string UsedFor11, string OtherEarthing11, string EarthingType12, string EarthingValue12, string UsedFor12, string OtherEarthing12, string EarthingType13, string EarthingValue13, string UsedFor13, string OtherEarthing13, string EarthingType14,
string EarthingValue14, string UsedFor14, string OtherEarthing14, string EarthingType15, string EarthingValue15, string UsedFor15, string OtherEarthing15, string CreatedBy)
        {
            SqlCommand cmd = new SqlCommand("sp_InsertGeneratingSetData");
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString);
            cmd.Connection = con;
            if (con.State == ConnectionState.Closed)
            {
                con.ConnectionString = ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;
                con.Open();
            }

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IdUpdate", IdUpdate);
            cmd.Parameters.AddWithValue("@Count", Count);
            cmd.Parameters.AddWithValue("@Id", Id);
            cmd.Parameters.AddWithValue("@IntimationId", IntimationId);
            cmd.Parameters.AddWithValue("@GeneratingSetCapacityType", GeneratingSetCapacityType);
            cmd.Parameters.AddWithValue("@GeneratingSetCapacity", GeneratingSetCapacity);
            cmd.Parameters.AddWithValue("@SerialNumbrOfAcGenerator", SerialNumbrOfAcGenerator);
            cmd.Parameters.AddWithValue("@GeneratingSetType", GeneratingSetType);
            cmd.Parameters.AddWithValue("@GeneratorVoltageLevel", GeneratorVoltageLevel);
            cmd.Parameters.AddWithValue("@CurrenntCapacityOfBreaker", CurrenntCapacityOfBreaker);
            cmd.Parameters.AddWithValue("@BreakingCapacityofBreaker", BreakingCapacityofBreaker);
            cmd.Parameters.AddWithValue("@TypeOfPlant", TypeOfPlant);
            cmd.Parameters.AddWithValue("@CapacityOfPlantType", CapacityOfPlantType);
            cmd.Parameters.AddWithValue("@CapacityOfPlant", CapacityOfPlant);
            cmd.Parameters.AddWithValue("@HighestVoltageLevelOfDCString", HighestVoltageLevelOfDCString);
            cmd.Parameters.AddWithValue("@LowestInsulationBetweenDCWireToEarth", LowestInsulationBetweenDCWireToEarth);
            cmd.Parameters.AddWithValue("@NoOfPowerPCV", NoOfPowerPCV);
            cmd.Parameters.AddWithValue("@LTACBreakerCapacity", LTACBreakerCapacity);
            cmd.Parameters.AddWithValue("@ACCablesLowestInsulation", ACCablesLowestInsulation);
            cmd.Parameters.AddWithValue("@NumberOfEarthing", NumberOfEarthing);
            cmd.Parameters.AddWithValue("@EarthingType1", EarthingType1);
            cmd.Parameters.AddWithValue("@EarthingValue1", EarthingValue1);
            cmd.Parameters.AddWithValue("@UsedFor1", UsedFor1);
            cmd.Parameters.AddWithValue("@OtherEarthing1", OtherEarthing1);

            cmd.Parameters.AddWithValue("@EarthingType2", EarthingType2);
            cmd.Parameters.AddWithValue("@EarthingValue2", EarthingValue2);
            cmd.Parameters.AddWithValue("@UsedFor2", UsedFor2);
            cmd.Parameters.AddWithValue("@OtherEarthing2", OtherEarthing2);

            cmd.Parameters.AddWithValue("@EarthingType3", EarthingType3);
            cmd.Parameters.AddWithValue("@EarthingValue3", EarthingValue3);
            cmd.Parameters.AddWithValue("@UsedFor3", UsedFor3);
            cmd.Parameters.AddWithValue("@OtherEarthing3", OtherEarthing3);

            cmd.Parameters.AddWithValue("@EarthingType4", EarthingType4);
            cmd.Parameters.AddWithValue("@EarthingValue4", EarthingValue4);
            cmd.Parameters.AddWithValue("@UsedFor4", UsedFor4);
            cmd.Parameters.AddWithValue("@OtherEarthing4", OtherEarthing4);

            cmd.Parameters.AddWithValue("@EarthingType5", EarthingType5);
            cmd.Parameters.AddWithValue("@EarthingValue5", EarthingValue5);
            cmd.Parameters.AddWithValue("@UsedFor5", UsedFor5);
            cmd.Parameters.AddWithValue("@OtherEarthing5", OtherEarthing5);

            cmd.Parameters.AddWithValue("@EarthingType6", EarthingType6);
            cmd.Parameters.AddWithValue("@EarthingValue6", EarthingValue6);
            cmd.Parameters.AddWithValue("@UsedFor6", UsedFor6);
            cmd.Parameters.AddWithValue("@OtherEarthing6", OtherEarthing6);

            cmd.Parameters.AddWithValue("@EarthingType7", EarthingType7);
            cmd.Parameters.AddWithValue("@EarthingValue7", EarthingValue7);
            cmd.Parameters.AddWithValue("@UsedFor7", UsedFor7);
            cmd.Parameters.AddWithValue("@OtherEarthing7", OtherEarthing7);

            cmd.Parameters.AddWithValue("@EarthingType8", EarthingType8);
            cmd.Parameters.AddWithValue("@EarthingValue8", EarthingValue8);
            cmd.Parameters.AddWithValue("@UsedFor8", UsedFor8);
            cmd.Parameters.AddWithValue("@OtherEarthing8", OtherEarthing8);

            cmd.Parameters.AddWithValue("@EarthingType9", EarthingType9);
            cmd.Parameters.AddWithValue("@EarthingValue9", EarthingValue9);
            cmd.Parameters.AddWithValue("@UsedFor9", UsedFor9);
            cmd.Parameters.AddWithValue("@OtherEarthing9", OtherEarthing9);

            cmd.Parameters.AddWithValue("@EarthingType10", EarthingType10);
            cmd.Parameters.AddWithValue("@EarthingValue10", EarthingValue10);
            cmd.Parameters.AddWithValue("@UsedFor10", UsedFor10);
            cmd.Parameters.AddWithValue("@OtherEarthing10", OtherEarthing10);

            cmd.Parameters.AddWithValue("@EarthingType11", EarthingType11);
            cmd.Parameters.AddWithValue("@EarthingValue11", EarthingValue11);
            cmd.Parameters.AddWithValue("@UsedFor11", UsedFor11);
            cmd.Parameters.AddWithValue("@OtherEarthing11", OtherEarthing11);

            cmd.Parameters.AddWithValue("@EarthingType12", EarthingType12);
            cmd.Parameters.AddWithValue("@EarthingValue12", EarthingValue12);
            cmd.Parameters.AddWithValue("@UsedFor12", UsedFor12);
            cmd.Parameters.AddWithValue("@OtherEarthing12", OtherEarthing12);

            cmd.Parameters.AddWithValue("@EarthingType13", EarthingType13);
            cmd.Parameters.AddWithValue("@EarthingValue13", EarthingValue13);
            cmd.Parameters.AddWithValue("@UsedFor13", UsedFor13);
            cmd.Parameters.AddWithValue("@OtherEarthing13", OtherEarthing13);

            cmd.Parameters.AddWithValue("@EarthingType14", EarthingType14);
            cmd.Parameters.AddWithValue("@EarthingValue14", EarthingValue14);
            cmd.Parameters.AddWithValue("@UsedFor14", UsedFor14);
            cmd.Parameters.AddWithValue("@OtherEarthing14", OtherEarthing14);

            cmd.Parameters.AddWithValue("@EarthingType15", EarthingType15);
            cmd.Parameters.AddWithValue("@EarthingValue15", EarthingValue15);
            cmd.Parameters.AddWithValue("@UsedFor15", UsedFor15);
            cmd.Parameters.AddWithValue("@OtherEarthing15", OtherEarthing15);

            cmd.Parameters.AddWithValue("@CreatedBy", CreatedBy);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public string GenerateUniqueGeneratingSetId()
        {
            SqlCommand cmd = new SqlCommand("sp_GeneratingSetId");
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString);
            cmd.Connection = con;
            if (con.State == ConnectionState.Closed)
            {
                con.ConnectionString = ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;
                con.Open();
            }

            cmd.CommandType = CommandType.StoredProcedure;
            outputParam = new SqlParameter("@RegistrationID", SqlDbType.NVarChar, 50);
            outputParam.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(outputParam);
            cmd.ExecuteNonQuery();

            if (outputParam != null)
            {
                return outputParam.Value.ToString();
            }
            else
            {
                return null;
            }
        }
        #endregion
        #region Insert Phase Data
        public void InsertPhaseData(string Id, string InstallationType, string VoltageLevel, string CapacityMainSwitchAndBreaker, string NumberOfEarthing,
            string EarthingType1, string EarthingValue1, string UsedFor1, string EarthingType2, string EarthingValue2, string UsedFor2,
            string EarthingType3, string EarthingValue3, string UsedFor3, string EarthingType4, string EarthingValue4, string UsedFor4,
            string EarthingType5, string EarthingValue5, string UsedFor5, string EarthingType6, string EarthingValue6, string UsedFor6, string EarthingType7,
            string EarthingValue7, string UsedFor7, string EarthingType8, string EarthingValue8, string UsedFor8, string EarthingType9, string EarthingValue9,
            string UsedFor9, string EarthingType10, string EarthingValue10, string UsedFor10, string EarthingType11, string EarthingValue11, string UsedFor11,
            string EarthingType12, string EarthingValue12, string UsedFor12, string EarthingType13, string EarthingValue13, string UsedFor13, string EarthingType14,
            string EarthingValue14, string UsedFor14, string EarthingType15, string EarthingValue15, string UsedFor15, string MinimumIRValueBWwires,
            string NoOfRCCB, string RatingOfRCCB, string CurrentCarryingCpacity, string NoOfCircuit, string NoOfMotors)
        {
            SqlCommand cmd = new SqlCommand("sp_SingleOrThreePhase");
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString);
            cmd.Connection = con;
            if (con.State == ConnectionState.Closed)
            {
                con.ConnectionString = ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;
                con.Open();
            }

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Id", Id);
            cmd.Parameters.AddWithValue("@InstallationType", InstallationType);
            cmd.Parameters.AddWithValue("@VoltageLevel", VoltageLevel);
            cmd.Parameters.AddWithValue("@CapacityMainSwitchAndBreaker", CapacityMainSwitchAndBreaker);
            cmd.Parameters.AddWithValue("@NumberOfEarthing", NumberOfEarthing);
            cmd.Parameters.AddWithValue("@EarthingType1", EarthingType1);
            cmd.Parameters.AddWithValue("@EarthingValue1", EarthingValue1);
            cmd.Parameters.AddWithValue("@UsedFor1", UsedFor1);
            cmd.Parameters.AddWithValue("@EarthingType2", EarthingType2);
            cmd.Parameters.AddWithValue("@EarthingValue2", EarthingValue2);
            cmd.Parameters.AddWithValue("@UsedFor2", UsedFor2);
            cmd.Parameters.AddWithValue("@EarthingType3", EarthingType3);
            cmd.Parameters.AddWithValue("@EarthingValue3", EarthingValue3);
            cmd.Parameters.AddWithValue("@UsedFor3", UsedFor3);
            cmd.Parameters.AddWithValue("@EarthingType4", EarthingType4);
            cmd.Parameters.AddWithValue("@EarthingValue4", EarthingValue4);
            cmd.Parameters.AddWithValue("@UsedFor4", UsedFor4);
            cmd.Parameters.AddWithValue("@EarthingType5", EarthingType5);
            cmd.Parameters.AddWithValue("@EarthingValue5", EarthingValue5);
            cmd.Parameters.AddWithValue("@UsedFor5", UsedFor5);
            cmd.Parameters.AddWithValue("@EarthingType6", EarthingType6);
            cmd.Parameters.AddWithValue("@EarthingValue6", EarthingValue6);
            cmd.Parameters.AddWithValue("@UsedFor6", UsedFor6);
            cmd.Parameters.AddWithValue("@EarthingType7", EarthingType7);
            cmd.Parameters.AddWithValue("@EarthingValue7", EarthingValue7);
            cmd.Parameters.AddWithValue("@UsedFor7", UsedFor7);
            cmd.Parameters.AddWithValue("@EarthingType8", EarthingType8);
            cmd.Parameters.AddWithValue("@EarthingValue8", EarthingValue8);
            cmd.Parameters.AddWithValue("@UsedFor8", UsedFor8);
            cmd.Parameters.AddWithValue("@EarthingType9", EarthingType9);
            cmd.Parameters.AddWithValue("@EarthingValue9", EarthingValue9);
            cmd.Parameters.AddWithValue("@UsedFor9", UsedFor9);
            cmd.Parameters.AddWithValue("@EarthingType10", EarthingType10);
            cmd.Parameters.AddWithValue("@EarthingValue10", EarthingValue10);
            cmd.Parameters.AddWithValue("@UsedFor10", UsedFor10);
            cmd.Parameters.AddWithValue("@EarthingType11", EarthingType11);
            cmd.Parameters.AddWithValue("@EarthingValue11", EarthingValue11);
            cmd.Parameters.AddWithValue("@UsedFor11", UsedFor11);
            cmd.Parameters.AddWithValue("@EarthingType12", EarthingType12);
            cmd.Parameters.AddWithValue("@EarthingValue12", EarthingValue12);
            cmd.Parameters.AddWithValue("@UsedFor12", UsedFor12);
            cmd.Parameters.AddWithValue("@EarthingType13", EarthingType13);
            cmd.Parameters.AddWithValue("@EarthingValue13", EarthingValue13);
            cmd.Parameters.AddWithValue("@UsedFor13", UsedFor13);
            cmd.Parameters.AddWithValue("@EarthingType14", EarthingType14);
            cmd.Parameters.AddWithValue("@EarthingValue14", EarthingValue14);
            cmd.Parameters.AddWithValue("@UsedFor14", UsedFor14);
            cmd.Parameters.AddWithValue("@EarthingType15", EarthingType15);
            cmd.Parameters.AddWithValue("@EarthingValue15", EarthingValue15);
            cmd.Parameters.AddWithValue("@UsedFor15", UsedFor15);
            cmd.Parameters.AddWithValue("@MinimumIRValueBWwires", MinimumIRValueBWwires);
            cmd.Parameters.AddWithValue("@NoOfRCCB", NoOfRCCB);
            cmd.Parameters.AddWithValue("@RatingOfRCCB", RatingOfRCCB);
            cmd.Parameters.AddWithValue("@CurrentCarryingCpacity", CurrentCarryingCpacity);
            cmd.Parameters.AddWithValue("@NoOfCircuit", NoOfCircuit);
            cmd.Parameters.AddWithValue("@NoOfMotors", NoOfMotors);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        #endregion 
        #region Insert Test Report Data
        public void InsertTestReportData(string IntimationId, string InstallationFor, string NameOfOwner, string NameOfAgency, string ContactNo,
            string AddressOfSite, string TypeOfPremises, string VoltageLevel, string WorkStartDate, string WorkCompletionDate, string SanctionLoad,
            string InstallationType1, string TypeOfInstallation1, string InstallationType2, string TypeOfInstallation2, string
InstallationType3, string TypeOfInstallation3, string InstallationType4, string TypeOfInstallation4, string InstallationType5,
            string TypeOfInstallation5, string InstallationType6, string TypeOfInstallation6, string InstallationType7,
            string TypeOfInstallation7, string InstallationType8, string TypeOfInstallation8)
        {
            SqlCommand cmd = new SqlCommand("sp_TestReport");
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString);
            cmd.Connection = con;
            if (con.State == ConnectionState.Closed)
            {
                con.ConnectionString = ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;
                con.Open();
            }

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IntimationId", IntimationId);
            cmd.Parameters.AddWithValue("@InstallationFor", InstallationFor);
            cmd.Parameters.AddWithValue("@NameOfOwner", NameOfOwner);
            cmd.Parameters.AddWithValue("@NameOfAgency", NameOfAgency);
            cmd.Parameters.AddWithValue("@ContactNo", ContactNo);
            cmd.Parameters.AddWithValue("@AddressOfSite", AddressOfSite);
            cmd.Parameters.AddWithValue("@TypeOfPremises", TypeOfPremises);
            cmd.Parameters.AddWithValue("@VoltageLevel", VoltageLevel);
            cmd.Parameters.AddWithValue("@WorkStartDate", WorkStartDate);
            cmd.Parameters.AddWithValue("@WorkCompletionDate", WorkCompletionDate);
            cmd.Parameters.AddWithValue("@SanctionLoad", SanctionLoad);
            cmd.Parameters.AddWithValue("@InstallationType1", InstallationType1);
            cmd.Parameters.AddWithValue("@TypeOfInstallation1", TypeOfInstallation1);
            cmd.Parameters.AddWithValue("@InstallationType2", InstallationType2);
            cmd.Parameters.AddWithValue("@TypeOfInstallation2", TypeOfInstallation2);
            cmd.Parameters.AddWithValue("@InstallationType3", InstallationType3);
            cmd.Parameters.AddWithValue("@TypeOfInstallation3", TypeOfInstallation3);
            cmd.Parameters.AddWithValue("@InstallationType4", InstallationType4);
            cmd.Parameters.AddWithValue("@TypeOfInstallation4", TypeOfInstallation4);
            cmd.Parameters.AddWithValue("@InstallationType5", InstallationType5);
            cmd.Parameters.AddWithValue("@TypeOfInstallation5", TypeOfInstallation5);
            cmd.Parameters.AddWithValue("@InstallationType6", InstallationType6);
            cmd.Parameters.AddWithValue("@TypeOfInstallation6", TypeOfInstallation6);
            cmd.Parameters.AddWithValue("@InstallationType7", InstallationType7);
            cmd.Parameters.AddWithValue("@TypeOfInstallation7", TypeOfInstallation7);
            cmd.Parameters.AddWithValue("@InstallationType8", InstallationType8);
            cmd.Parameters.AddWithValue("@TypeOfInstallation8", TypeOfInstallation8);
            outputParam = new SqlParameter("@RegistrationID", SqlDbType.NVarChar, 50);
            outputParam.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(outputParam);
            cmd.ExecuteNonQuery();

        }
        public string TestReportId()
        {
            if (outputParam != null)
            {
                return outputParam.Value.ToString();
            }
            else
            {
                return null;
            }
        }
        #endregion
        #region Insert Lift Data
        public void InsertLiftData(string Id, string VoltageAndSystemOfSupply, string MVInstallation, string SerailNumber1, string Equipment1,
            string Voltage1, string FedFromDistribution1, string SerailNumber2, string Equipment2, string Voltage2, string FedFromDistribution2,
            string SerailNumber3, string Equipment3, string Voltage3, string FedFromDistribution3, string SerailNumber4, string Equipment4,
            string Voltage4, string FedFromDistribution4, string SerailNumber5, string Equipment5, string Voltage5,
            string FedFromDistribution5, string InsulationResistanceForInstallation,
            string RedYellowPhase, string RedBluePhase, string BlueYellowPhase, string RedPhaseEarthWire, string YellowPhaseEarthWire,
            string BluePhaseEarthWire, string NumberOfEarthing, string EarthingType1, string EarthingValue1, string EarthingType2,
            string EarthingValue2, string EarthingType3, string EarthingValue3, string EarthingType4,
            string EarthingValue4, string EarthingType5, string EarthingValue5, string EarthingType6, string EarthingValue6,
            string EarthingType7, string EarthingValue7, string EarthingType8, string EarthingValue8, string EarthingType9,
            string EarthingValue9, string EarthingType10, string EarthingValue10, string EarthingType11, string EarthingValue11,
            string EarthingType12, string EarthingValue12, string EarthingType13, string EarthingValue13, string EarthingType14,
            string EarthingValue14, string EarthingType15, string EarthingValue15)
        {
            SqlCommand cmd = new SqlCommand("sp_InsertLift");
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString);
            cmd.Connection = con;
            if (con.State == ConnectionState.Closed)
            {
                con.ConnectionString = ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;
                con.Open();
            }
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Id ", Id);
            cmd.Parameters.AddWithValue("@VoltageAndSystemOfSu ", VoltageAndSystemOfSupply);
            cmd.Parameters.AddWithValue("@MVInstallation ", MVInstallation);
            cmd.Parameters.AddWithValue("@SerailNumber1 ", SerailNumber1);
            cmd.Parameters.AddWithValue("@Equipment1 ", Equipment1);
            cmd.Parameters.AddWithValue("@Voltage1 ", Voltage1);
            cmd.Parameters.AddWithValue("@FedFromDistribution1 ", FedFromDistribution1);
            cmd.Parameters.AddWithValue("@SerailNumber2", SerailNumber2);
            cmd.Parameters.AddWithValue("@Equipment2", Equipment1);
            cmd.Parameters.AddWithValue("@Voltage2", Voltage2);
            cmd.Parameters.AddWithValue("@FedFromDistribution2", FedFromDistribution2);
            cmd.Parameters.AddWithValue("@SerailNumber3", SerailNumber3);
            cmd.Parameters.AddWithValue("@Equipment3", Equipment3);
            cmd.Parameters.AddWithValue("@Voltage3", Voltage3);
            cmd.Parameters.AddWithValue("@FedFromDistribution3", FedFromDistribution3);
            cmd.Parameters.AddWithValue("@SerailNumber4", SerailNumber4);
            cmd.Parameters.AddWithValue("@Equipment4", Equipment4);
            cmd.Parameters.AddWithValue("@Voltage4", Voltage4);
            cmd.Parameters.AddWithValue("@FedFromDistribution4", FedFromDistribution4);
            cmd.Parameters.AddWithValue("@SerailNumber5", SerailNumber5);
            cmd.Parameters.AddWithValue("@Equipment5", Equipment5);
            cmd.Parameters.AddWithValue("@Voltage5", Voltage5);
            cmd.Parameters.AddWithValue("@FedFromDistribution5", FedFromDistribution5);
            cmd.Parameters.AddWithValue("@InsulationResistanceForInstallation", InsulationResistanceForInstallation);
            cmd.Parameters.AddWithValue("@RedYellowPhase", RedYellowPhase);
            cmd.Parameters.AddWithValue("@RedBluePhase", RedBluePhase);
            cmd.Parameters.AddWithValue("@BlueYellowPhase", BlueYellowPhase);
            cmd.Parameters.AddWithValue("@RedPhaseEarthWire", RedPhaseEarthWire);
            cmd.Parameters.AddWithValue("@YellowPhaseEarthWire", YellowPhaseEarthWire);
            cmd.Parameters.AddWithValue("@BluePhaseEarthWire", BluePhaseEarthWire);
            cmd.Parameters.AddWithValue("@NumberOfEarthing", NumberOfEarthing);
            cmd.Parameters.AddWithValue("@EarthingType1", EarthingType1);
            cmd.Parameters.AddWithValue("@EarthingValue1", EarthingValue1);
            cmd.Parameters.AddWithValue("@EarthingType2", EarthingType2);
            cmd.Parameters.AddWithValue("@EarthingValue2", EarthingValue2);
            cmd.Parameters.AddWithValue("@EarthingType3", EarthingType3);
            cmd.Parameters.AddWithValue("@EarthingValue3", EarthingValue3);
            cmd.Parameters.AddWithValue("@EarthingType4", EarthingType4);
            cmd.Parameters.AddWithValue("@EarthingValue4", EarthingValue4);
            cmd.Parameters.AddWithValue("@EarthingType5", EarthingType5);
            cmd.Parameters.AddWithValue("@EarthingValue5", EarthingValue5);
            cmd.Parameters.AddWithValue("@EarthingType6", EarthingType6);
            cmd.Parameters.AddWithValue("@EarthingValue6", EarthingValue6);
            cmd.Parameters.AddWithValue("@EarthingType7", EarthingType7);
            cmd.Parameters.AddWithValue("@EarthingValue7", EarthingValue7);
            cmd.Parameters.AddWithValue("@EarthingType8", EarthingType8);
            cmd.Parameters.AddWithValue("@EarthingValue8", EarthingValue8);
            cmd.Parameters.AddWithValue("@EarthingType9", EarthingType9);
            cmd.Parameters.AddWithValue("@EarthingValue9", EarthingValue9);
            cmd.Parameters.AddWithValue("@EarthingType10", EarthingType10);
            cmd.Parameters.AddWithValue("@EarthingValue10", EarthingValue10);
            cmd.Parameters.AddWithValue("@EarthingType11", EarthingType11);
            cmd.Parameters.AddWithValue("@EarthingValue11", EarthingValue11);
            cmd.Parameters.AddWithValue("@EarthingType12", EarthingType12);
            cmd.Parameters.AddWithValue("@EarthingValue12", EarthingValue12);
            cmd.Parameters.AddWithValue("@EarthingType13", EarthingType13);
            cmd.Parameters.AddWithValue("@EarthingValue13", EarthingValue13);
            cmd.Parameters.AddWithValue("@EarthingType14", EarthingType14);
            cmd.Parameters.AddWithValue("@EarthingValue14", EarthingValue14);
            cmd.Parameters.AddWithValue("@EarthingType15", EarthingType15);
            cmd.Parameters.AddWithValue("@EarthingValue15", EarthingValue15);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        #endregion
        #region Insert Inspection Data
        public void InsertInspectionData(string ContactNo, string TestRportId, string IntimationId, string Inspectiontype, string ApplicantType, string InstallationType,
      string VoltageLevel, string LineLength,  string TestReportCount, string RequestLetterFromConcernedOfficer, string ManufacturingTestReportOfEqipment,
      string SingleLineDiagramOfLine, string DemandNoticeOfLine, string CopyOfNoticeIssuedByUHBVNorDHBVN,
      string InvoiceOfTransferOfPersonalSubstation, string ManufacturingTestCertificateOfTransformer,
      string SingleLineDiagramofTransformer, string InvoiceoffireExtinguisheratSite, string InvoiceOfDGSetOfGeneratingSet,
      string ManufacturingCerificateOfDGSet, string InvoiceOfExptinguisherOrApparatusAtsite,
      string StructureStabilityResolvedByAuthorizedEngineer, string Staff, string District, string Division, string RequestDetails, string DateOfSubmission, string CreatedBy)
        {
            SqlCommand cmd = new SqlCommand("sp_InsertInspectionData");
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString);
            cmd.Connection = con;
            if (con.State == ConnectionState.Closed)
            {
                con.ConnectionString = ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;
                con.Open();
            }
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ContactNo ", ContactNo);
            cmd.Parameters.AddWithValue("@TestRportId ", TestRportId);
            cmd.Parameters.AddWithValue("@IntimationId ", IntimationId);
            cmd.Parameters.AddWithValue("@Inspectiontype ", Inspectiontype);
            cmd.Parameters.AddWithValue("@ApplicantType ", ApplicantType);
            cmd.Parameters.AddWithValue("@InstallationType ", InstallationType);
            cmd.Parameters.AddWithValue("@VoltageLevel ", VoltageLevel);
            cmd.Parameters.AddWithValue("@LineLength ", LineLength);
            cmd.Parameters.AddWithValue("@TestReportCount ", TestReportCount);
            cmd.Parameters.AddWithValue("@RequestLetterFromConcernedOfficer ", RequestLetterFromConcernedOfficer);
            cmd.Parameters.AddWithValue("@ManufacturingTestReportOfEqipment ", ManufacturingTestReportOfEqipment);
            cmd.Parameters.AddWithValue("@SingleLineDiagramOfLine ", SingleLineDiagramOfLine);
            cmd.Parameters.AddWithValue("@DemandNoticeOfLine ", DemandNoticeOfLine);
            cmd.Parameters.AddWithValue("@CopyOfNoticeIssuedByUHBVNorDHBVN ", CopyOfNoticeIssuedByUHBVNorDHBVN);
            cmd.Parameters.AddWithValue("@InvoiceOfTransferOfPersonalSubstation ", InvoiceOfTransferOfPersonalSubstation);
            cmd.Parameters.AddWithValue("@ManufacturingTestCertificateOfTransformer ", ManufacturingTestCertificateOfTransformer);
            cmd.Parameters.AddWithValue("@SingleLineDiagramofTransformer ", SingleLineDiagramofTransformer);
            cmd.Parameters.AddWithValue("@InvoiceoffireExtinguisheratSite ", InvoiceoffireExtinguisheratSite);
            cmd.Parameters.AddWithValue("@InvoiceOfDGSetOfGeneratingSet ", InvoiceOfDGSetOfGeneratingSet);
            cmd.Parameters.AddWithValue("@ManufacturingCerificateOfDGSet ", ManufacturingCerificateOfDGSet);
            cmd.Parameters.AddWithValue("@InvoiceOfExptinguisherOrApparatusAtsite ", InvoiceOfExptinguisherOrApparatusAtsite);
            cmd.Parameters.AddWithValue("@StructureStabilityResolvedByAuthorizedEngineer ", StructureStabilityResolvedByAuthorizedEngineer);
            cmd.Parameters.AddWithValue("@Staff ", Staff);
            cmd.Parameters.AddWithValue("@District ", District);
            cmd.Parameters.AddWithValue("@Division ", Division);
            cmd.Parameters.AddWithValue("@RequestDetails ", RequestDetails);
            cmd.Parameters.AddWithValue("@DateOfSubmission ", DateOfSubmission);
            cmd.Parameters.AddWithValue("@CreatedBy ", CreatedBy);
            outputParam = new SqlParameter("@GeneratedId", SqlDbType.NVarChar, 50);
            outputParam.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(outputParam);
            cmd.ExecuteNonQuery();
            //int generatedId = Convert.ToInt32(outputParam.Value);

            //con.Close();
        }
        public string InspectionId()
        {
            if (outputParam != null)
            {
                return outputParam.Value.ToString();
            }
            else
            {
                return null;
            }
        }
        #endregion
        #region Update Work Intimation Contractor Data
        public void updateWorkIntimation(string Id)
        {
            SqlCommand cmd = new SqlCommand("sp_ContractorDataUpdate");
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString);
            cmd.Connection = con;
            if (con.State == ConnectionState.Closed)
            {
                con.ConnectionString = ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;
                con.Open();
            }
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Id ", Id);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        #endregion
        #region Update Inspection Data
        public void updateInspection(string ID, string AcceptedOrRejected, string ReasonForRejection, string AdditonalNotes)
        {
            SqlCommand cmd = new SqlCommand("sp_InspectionReview");
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString);
            cmd.Connection = con;
            if (con.State == ConnectionState.Closed)
            {
                con.ConnectionString = ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;
                con.Open();
            }
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ID ", ID);
            cmd.Parameters.AddWithValue("@AcceptedOrRejected ", AcceptedOrRejected);
            cmd.Parameters.AddWithValue("@ReasonForRejection ", ReasonForRejection);
            cmd.Parameters.AddWithValue("@AdditionalNotes", AdditonalNotes);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        #endregion  
        #region Update Inspection PendingPayment Data
        public void updateInspectionPending(string ID, string TransactionId, string TransctionDate, string ChallanAttachment)
        {
            SqlCommand cmd = new SqlCommand("sp_UpdateInspectionPaymentHistory");
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString);
            cmd.Connection = con;
            if (con.State == ConnectionState.Closed)
            {
                con.ConnectionString = ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;
                con.Open();
            }
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ID ", ID);
            cmd.Parameters.AddWithValue("@TransactionId ", TransactionId);
            cmd.Parameters.AddWithValue("@TransctionDate ", TransctionDate);
            cmd.Parameters.AddWithValue("@ChallanAttachment", ChallanAttachment);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        #endregion
        public string GenerateUniqueID()
        {
            SqlCommand cmd = new SqlCommand("sp_generateLineId");
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString);
            cmd.Connection = con;
            if (con.State == ConnectionState.Closed)
            {
                con.ConnectionString = ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;
                con.Open();
            }

            cmd.CommandType = CommandType.StoredProcedure;
            outputParam = new SqlParameter("@RegistrationID", SqlDbType.NVarChar, 50);
            outputParam.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(outputParam);
            cmd.ExecuteNonQuery();

            if (outputParam != null)
            {
                return outputParam.Value.ToString();
            }
            else
            {
                return null;
            }
        }

        #region Bind DropDown Draw State
        public DataSet GetddlDrawState()
        {
            return DBTask.ExecuteDataset(ConfigurationManager.ConnectionStrings["DBConnection"].ToString(), "sp_getStateForDropdown");
        }
        #endregion

        #region Bind DropDown Draw Earthing
        public DataSet GetddlEarthing()
        {
            return DBTask.ExecuteDataset(ConfigurationManager.ConnectionStrings["DBConnection"].ToString(), "sp_Earthing");
        }
        #endregion

        #region Bind DropDown Draw State
        public DataSet GetddlDrawDistrict(string State)
        {
            return DBTask.ExecuteDataset(ConfigurationManager.ConnectionStrings["DBConnection"].ToString(), "sp_getDistrictForDropdownState", State);
        }
        #endregion 
        #region Get Contractor Data
        public DataSet GetContractorData(string REID)
        {
            return DBTask.ExecuteDataset(ConfigurationManager.ConnectionStrings["DBConnection"].ToString(), "sp_updateContractorData", REID);
        }
        #endregion
        #region Get Supervisor Data
        public DataSet GetSupervisorData(string REID)
        {
            return DBTask.ExecuteDataset(ConfigurationManager.ConnectionStrings["DBConnection"].ToString(), "sp_GetSuperwiserDetails", REID);
        }
        #endregion
        public string ValidateOTP(string mobilenumber)
        {
            //string mobilenumber = Session["Contact"].ToString();
            Random random = new Random();
            int otpInt = random.Next(100000, 999999);

            string otp = otpInt.ToString("D6");
            //Session["OTP"] = otp;

            HttpWebRequest myReq = (HttpWebRequest)WebRequest.Create("http://smpanelv.yieldplus.in/api/mt/SendSMS?APIKey=546t3yI5n06VJogf7Keaiw&senderid=SDEI&channel=Trans&DCS=0&flashsms=0&number=" + mobilenumber + "&text=Dear Customer " + otp + " is the OTP for your request send to CEI Department, HRY. OTPs are SECRET. DO NOT share OTP with anyone --SAFEDOT&route=2&peid=1101407410000040566");
            HttpWebResponse myResp = (HttpWebResponse)myReq.GetResponse();
            System.IO.StreamReader respStreamReader = new System.IO.StreamReader(myResp.GetResponseStream());
            string responseString = respStreamReader.ReadToEnd();

            respStreamReader.Close();
            myResp.Close();
            return otp;
        }   
        public string ValidateOTPthroughEmail(string Email)
        {
            //string mobilenumber = Session["Contact"].ToString();
            Random random = new Random();
            int otpInt = random.Next(100000, 999999);

            string otp = otpInt.ToString("D6");
            //Session["OTP"] = otp;

            MailMessage mailMessage = new MailMessage();
            mailMessage.From = new MailAddress("haryanacei@gmail.com");
            mailMessage.To.Add(Email); mailMessage.Subject = "Your Site Owner ID and Password";
            string body = $"Dear Customer,\n\n" + otp + " is the OTP for your request send to CEI Department, HRY.OTPs are SECRET.DO NOT share OTP with anyone.Thank you for choosing our services. If you have any questions or need further assistance, please feel free to contact our support team.\n\n Best regards,\n\n[CEI Haryana]";
            mailMessage.Body = body;

            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com");
            smtpClient.Port = 587;
            smtpClient.Credentials = new NetworkCredential("haryanacei@gmail.com", "httnrdifrwgfnzrv");
            smtpClient.EnableSsl = true;

            smtpClient.Send(mailMessage);
            return otp;
        } 
        public void NewCredentialsthroughEmail(string Email)
        {
            MailMessage mailMessage = new MailMessage();
            mailMessage.From = new MailAddress("haryanacei@gmail.com");
            mailMessage.To.Add(Email); 
            mailMessage.Subject = "Credentials";
            string body = $"Dear Customer,\n\nWe are pleased to inform you that your account has been successfully created. Your user ID is the first 4 characters of your name combined with your date of birth.\n\nThank you for choosing our services. If you have any questions or need further assistance, please feel free to contact our support team.\n\nBest regards,\n[CEI Haryana]";
            mailMessage.Body = body;
            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com");
            smtpClient.Port = 587;
            smtpClient.Credentials = new NetworkCredential("haryanacei@gmail.com", "httnrdifrwgfnzrv");
            smtpClient.EnableSsl = true;

            smtpClient.Send(mailMessage);
        }
       
        public void SiteOwnerCredentials(string Email , string pan)
        {
            
            MailMessage mailMessage = new MailMessage();
            mailMessage.From = new MailAddress("haryanacei@gmail.com");
            mailMessage.To.Add(Email); mailMessage.Subject = "Your Site Owner ID and Password";
            string body = $"Dear Customer,\n\nWe are pleased to inform you that your account has been successfully created. Your user id is {pan} and Password is 123456 Visit Website http://ceiharyana.com/ \n\nThank you for choosing our services. If you have any questions or need further assistance, please feel free to contact our support team.\n\nBest regards,\n[CEI Haryana]"; ;
            mailMessage.Body = body;
            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com");
            smtpClient.Port = 587;
            smtpClient.Credentials = new NetworkCredential("haryanacei@gmail.com", "httnrdifrwgfnzrv");
            smtpClient.EnableSsl = true;

            smtpClient.Send(mailMessage);
        }


        public DataTable InspectionHistoryForAdminData()
        {
            return DBTask.ExecuteDataTable(ConfigurationManager.ConnectionStrings["DBConnection"].ToString(), "sp_InspectionHistoryForAdmin");
        }
        #region Get WorkIntimationDataForAdmin Data
        public DataSet GetWorkIntimationDataForAdmin(string REID)
        {
            return DBTask.ExecuteDataset(ConfigurationManager.ConnectionStrings["DBConnection"].ToString(), "sp_WorkIntimationData", REID);
        }
        #endregion
        public DataSet GetddlEarthingSubstation()
        {
            return DBTask.ExecuteDataset(ConfigurationManager.ConnectionStrings["DBConnection"].ToString(), "sp_EarthingSubstation");
        }
        public DataSet GetddlPrimaryVotlage()
        {
            return DBTask.ExecuteDataset(ConfigurationManager.ConnectionStrings["DBConnection"].ToString(), "sp_PrimaryVoltage");
        }
        public DataSet GetddlPremises()
        {
            return DBTask.ExecuteDataset(ConfigurationManager.ConnectionStrings["DBConnection"].ToString(), "sp_Premises");
        }
        public DataSet GetContractorContact(string UserId)
        {
            return DBTask.ExecuteDataset(ConfigurationManager.ConnectionStrings["DBConnection"].ToString(), "sp_GetContractorContactNo", UserId);
        }
        public DataSet GetddlTestReportVoltage()
        {
            return DBTask.ExecuteDataset(ConfigurationManager.ConnectionStrings["DBConnection"].ToString(), "sp_TestReprortVoltage");
        }
        public DataSet GetddlAssignedWorkForSupervisor()
        {
            return DBTask.ExecuteDataset(ConfigurationManager.ConnectionStrings["DBConnection"].ToString(), "Sp_WorkDetail");
        }
        public DataSet GetContractorNotifications(string ID)
        {
            return DBTask.ExecuteDataset(ConfigurationManager.ConnectionStrings["DBConnection"].ToString(), "sp_ContractorNotificationData", ID);
        }
        public DataSet GetddlInstallationType()
        {
            return DBTask.ExecuteDataset(ConfigurationManager.ConnectionStrings["DBConnection"].ToString(), "sp_InstallatioType");
        }
        public DataSet GetSuppervisorLineTestReportData(string LineID)
        {
            return DBTask.ExecuteDataset(ConfigurationManager.ConnectionStrings["DBConnection"].ToString(), "sp_GetLineDataBySupervisor", LineID);
        }
        public DataSet GetSubstationDataBySupervisor(string SubstationId)
        {
            return DBTask.ExecuteDataset(ConfigurationManager.ConnectionStrings["DBConnection"].ToString(), "sp_GetSubstationDataBySupervisor", SubstationId);
        }
        public DataSet GetGeneraterSetData(string GeneratingId)
        {
            return DBTask.ExecuteDataset(ConfigurationManager.ConnectionStrings["DBConnection"].ToString(), "sp_GetGeneraterSetDataBySupervisor", GeneratingId);
        }
        public DataSet GetddlDistrict()
        {
            return DBTask.ExecuteDataset(ConfigurationManager.ConnectionStrings["DBConnection"].ToString(), "sp_AreaCovered");
        }
        public DataSet GetddlDrawDistrictddl()
        {
            return DBTask.ExecuteDataset(ConfigurationManager.ConnectionStrings["DBConnection"].ToString(), "sp_getDistrictForDropdown");
        }
        public DataSet GetddlDrawContractor()
        {
            return DBTask.ExecuteDataset(ConfigurationManager.ConnectionStrings["DBConnection"].ToString(), "sp_getContractorForDropdown");
        }
        public DataSet GetQualification()
        {
            return DBTask.ExecuteDataset(ConfigurationManager.ConnectionStrings["DBConnection"].ToString(), "GetQualificatiohn");
        }

        public DataSet GetddlVoltageLevel()
        {
            return DBTask.ExecuteDataset(ConfigurationManager.ConnectionStrings["DBConnection"].ToString(), "sp_GetVoltageLevel");
        }

        public DataSet GetContractorData()
        {
            return DBTask.ExecuteDataset(ConfigurationManager.ConnectionStrings["DBConnection"].ToString(), "GetContractorDetails");
        }


        public DataTable GetContractorDataforgrid(string loginType, string ID)
        {
            return DBTask.ExecuteDataTable(ConfigurationManager.ConnectionStrings["DBConnection"].ToString(), "sp_GetContractorData", loginType, ID);
        }

        public DataTable GetWiremanorSuperwiserData(string category, string loginType, string ID)
        {
            return DBTask.ExecuteDataTable(ConfigurationManager.ConnectionStrings["DBConnection"].ToString(), "sp_GetWiremanorSuperwiserData", category, loginType, ID);
        }
        public DataTable WorkIntimationData(string LoginID)
        {
            return DBTask.ExecuteDataTable(ConfigurationManager.ConnectionStrings["DBConnection"].ToString(), "sp_WorkIntimationProjects", LoginID);
        }
        public DataSet LineDataWithId(int ID)
        {
            return DBTask.ExecuteDataset(ConfigurationManager.ConnectionStrings["DBConnection"].ToString(), "sp_GetLineDataWithId", ID);
        }
        public DataSet LineTestReportData(string LineID)
        {
            return DBTask.ExecuteDataset(ConfigurationManager.ConnectionStrings["DBConnection"].ToString(), "sp_GetLineData", LineID);
        }
        public DataSet SubstationTestReportData(string Id)
        {
            return DBTask.ExecuteDataset(ConfigurationManager.ConnectionStrings["DBConnection"].ToString(), "sp_SubstationDataWithId", Id);
        }
        public DataSet StaffLogin(string Id)
        {
            return DBTask.ExecuteDataset(ConfigurationManager.ConnectionStrings["DBConnection"].ToString(), "sp_StaffLogin", Id);
        } 
        public DataSet ActionTaken(string Id)
        {
            return DBTask.ExecuteDataset(ConfigurationManager.ConnectionStrings["DBConnection"].ToString(), "sp_InspectionActionTakenData", Id);
        }
        public DataSet InspectionData(string Id)
        {
            return DBTask.ExecuteDataset(ConfigurationManager.ConnectionStrings["DBConnection"].ToString(), "sp_GetInspectionData", Id);
        }
        public DataTable SiteOwnerLineData(string PanId)
        {
            return DBTask.ExecuteDataTable(ConfigurationManager.ConnectionStrings["DBConnection"].ToString(), "sp_GetSiteOwnerLineReportData", PanId);
        }
        public DataSet TransformerTestReportData(string SubStationId)
        {
            return DBTask.ExecuteDataset(ConfigurationManager.ConnectionStrings["DBConnection"].ToString(), "sp_GetSubstationHistory", SubStationId);
        }
        public DataTable TestReportSubstationData(string SubStationId)
        {
            return DBTask.ExecuteDataTable(ConfigurationManager.ConnectionStrings["DBConnection"].ToString(), "sp_GetSiteOwnerTransformerReportData", SubStationId);
        }
        public DataTable TestReportGeneratingData(string PanId)
        {
            return DBTask.ExecuteDataTable(ConfigurationManager.ConnectionStrings["DBConnection"].ToString(), "sp_GetSiteOwnerGeneratingReportData", PanId);
        }
        public DataTable SiteOwnerInspectionData(string SiteOwnerId)
        {
            return DBTask.ExecuteDataTable(ConfigurationManager.ConnectionStrings["DBConnection"].ToString(), "sp_SiteOwnerInspectionHistory", SiteOwnerId);
        }
        public DataSet GeneratingTestReportData(string GeneratingSetId)
        {
            return DBTask.ExecuteDataset(ConfigurationManager.ConnectionStrings["DBConnection"].ToString(), "sp_GetGenratingSetHistory", GeneratingSetId);
        }
        public DataSet GeneratingTestReportDataWithId(string Id)
        {
            return DBTask.ExecuteDataset(ConfigurationManager.ConnectionStrings["DBConnection"].ToString(), "sp_GeneratingDataWithId", Id);
        }
        public DataTable GetStaffAssignedToContractor(string ID)
        {
            return DBTask.ExecuteDataTable(ConfigurationManager.ConnectionStrings["DBConnection"].ToString(), "sp_GetStaffAssignedtoContractor", ID);
        }
        public DataSet GetddlVoltageForLine(string voltage)
        {
            return DBTask.ExecuteDataset(ConfigurationManager.ConnectionStrings["DBConnection"].ToString(), "sp_LineVoltage", voltage);
        }
        public DataTable WorkIntimationDataforAdmin()
        {
            return DBTask.ExecuteDataTable(ConfigurationManager.ConnectionStrings["DBConnection"].ToString(), "sp_WorkIntimationProjectsforAdmin");
        }
        public DataTable WorkIntimationDataforSupervisor(string Id)
        {
            return DBTask.ExecuteDataTable(ConfigurationManager.ConnectionStrings["DBConnection"].ToString(), "sp_GetIntimationsForSupervisor", Id);
        }
        public int SetDataInStaffAssined(string REID, string projectId, string AssignBy)
        {
            return DBTask.ExecuteNonQuery(ConfigurationManager.ConnectionStrings["DBConnection"].ToString(), "sp_setDataInStaffAssined", REID, projectId, AssignBy);
        }
        public int updateUserRegistration(int registrationId)
        {
            return DBTask.ExecuteNonQuery(ConfigurationManager.ConnectionStrings["DBConnection"].ToString(), "Sp_updateUserRegistration", registrationId);
        }

        public int UserDocuments(string UserId, string flpPhotourl8, string flpPhotourl, string flpPhotourl1, string flpPhotourl2, string flpPhotourl3, string flpPhotourl4, string flpPhotourl5, string flpPhotourl9, string flpPhotourl6, string flpPhotourl7)
        {
            return DBTask.ExecuteNonQuery(ConfigurationManager.ConnectionStrings["DBConnection"].ToString(), "sp_UserDocuments", UserId, flpPhotourl8, flpPhotourl, flpPhotourl1, flpPhotourl2, flpPhotourl3, flpPhotourl4, flpPhotourl5, flpPhotourl9, flpPhotourl6, flpPhotourl7);
        }
        public DataTable RegistrationDetails()
        {
            return DBTask.ExecuteDataTable(ConfigurationManager.ConnectionStrings["DBConnection"].ToString(), "sp_GetRegistrationDataSupervisor");
        }
        public DataTable WirmenRegistrationDetails()
        {
            return DBTask.ExecuteDataTable(ConfigurationManager.ConnectionStrings["DBConnection"].ToString(), "sp_GetRegistrationDataWiremen");
        }
        public static int DropRegistrationData(int registrationId)
        {
            return DBTask.ExecuteNonQuery(ConfigurationManager.ConnectionStrings["DBConnection"].ToString(), "sp_DropUserRegistration", registrationId);
        }

        public DataSet checkGSTexist(string GSTnumber)
        {
            return DBTask.ExecuteDataset(ConfigurationManager.ConnectionStrings["DBConnection"].ToString(), "sp_checkGST", GSTnumber);
        }

        public DataSet checkLicenceexist(string LicenceNew, string LicenceOld)
        {
            return DBTask.ExecuteDataset(ConfigurationManager.ConnectionStrings["DBConnection"].ToString(), "sp_checkLicence", LicenceNew, LicenceOld);
        }
        public DataSet checkCertificateexist(string CertificateOld, string CertificateNew)
        {
            return DBTask.ExecuteDataset(ConfigurationManager.ConnectionStrings["DBConnection"].ToString(), "sp_CheckCertificate", CertificateOld, CertificateNew);
        }

        public DataSet SearchingOnGeneraterSet(string searchterm, string LoginId)
        {
            return DBTask.ExecuteDataset(ConfigurationManager.ConnectionStrings["DBConnection"].ToString(), "Sp_SearchingGeneraterSet", searchterm, LoginId);
        }

        public DataSet SearchingOnSubstation(string searchterm, string LoginId)
        {
            return DBTask.ExecuteDataset(ConfigurationManager.ConnectionStrings["DBConnection"].ToString(), "sp_SearchingSubstation", searchterm, LoginId);
        }
        public DataSet SearchingOnLine(string searchterm, string LoginId)
        {
            return DBTask.ExecuteDataset(ConfigurationManager.ConnectionStrings["DBConnection"].ToString(), "Sp_SearchingLineData", searchterm, LoginId);
        }

        public DataSet SearchingOnIntimation(string searchterm, string LoginId)
        {
            return DBTask.ExecuteDataset(ConfigurationManager.ConnectionStrings["DBConnection"].ToString(), "Sp_SearchingIntimationData", searchterm, LoginId);
        }
        public DataSet GetSuperVisorContact(string UserId)
        {
            return DBTask.ExecuteDataset(ConfigurationManager.ConnectionStrings["DBConnection"].ToString(), "sp_GetSupervisorData", UserId);
        }
        public DataSet GetTestReportHistoryForUpdate(string Type, string TestReportId)
        {
            return DBTask.ExecuteDataset(ConfigurationManager.ConnectionStrings["DBConnection"].ToString(), "sp_SearchingTestReportHistory", Type, TestReportId);
        }
        public DataSet GetTestReportDataForUpdate(string Type, string Id)
        {
            return DBTask.ExecuteDataset(ConfigurationManager.ConnectionStrings["DBConnection"].ToString(), "sp_SearchingOnTestHistoryData", Type, Id);
        }
        public DataTable LineDataForAdmin()
        {
            return DBTask.ExecuteDataTable(ConfigurationManager.ConnectionStrings["DBConnection"].ToString(), "sp_Linedataforadmin");
        }
        public DataTable SubstationDataForAdmin()
        {
            return DBTask.ExecuteDataTable(ConfigurationManager.ConnectionStrings["DBConnection"].ToString(), "sp_Substationdataforadmin");
        }
        public DataTable GeneratingDataForAdmin()
        {
            return DBTask.ExecuteDataTable(ConfigurationManager.ConnectionStrings["DBConnection"].ToString(), "sp_Generatingdataforadmin");
        }
        public DataSet GetddlSecondaryVotlage()
        {
            return DBTask.ExecuteDataset(ConfigurationManager.ConnectionStrings["DBConnection"].ToString(), "sp_SecondryVoltage");
        }
        public DataSet GetSiteOwnerNotifications(string ID)
        {
            return DBTask.ExecuteDataset(ConfigurationManager.ConnectionStrings["DBConnection"].ToString(), "sp_SiteOwnerNotifiction", ID);
        }
        public DataSet GetPaymentInformation(string Id, string IntimationId)
        {
            return DBTask.ExecuteDataset(ConfigurationManager.ConnectionStrings["DBConnection"].ToString(), "sp_paymentCalculation", Id, IntimationId);
        }
        public string GetTotalPaymentInformation(string Id, string IntimationId)
        {
            SqlCommand cmd = new SqlCommand("sp_TotalPayment");
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString);
            cmd.Connection = con;
            if (con.State == ConnectionState.Closed)
            {
                con.ConnectionString = ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;
                con.Open();
            }

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ID", Id);
            cmd.Parameters.AddWithValue("@IntimationId", IntimationId);
            outputParam = new SqlParameter("@TotalPayment", SqlDbType.NVarChar, 50);
            outputParam.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(outputParam);
            cmd.ExecuteNonQuery();
            if (outputParam != null)
            {
                return outputParam.Value.ToString();
            }
            else
            {
                return null;
            }
        }

        public DataTable SiteOwnerPeroidicInspectionData(string SiteOwnerId)
        {
            return DBTask.ExecuteDataTable(ConfigurationManager.ConnectionStrings["DBConnection"].ToString(), "Sp_GetSiteOwnerPeriodicInspection", SiteOwnerId);
        }

        public DataSet GetSupervisorNotifications()
        {
            return DBTask.ExecuteDataset(ConfigurationManager.ConnectionStrings["DBConnection"].ToString(), "sp_SupervisorNotificationData");
        }

        public DataSet GetSuppervisorTestReportHistory(string LoginId)
        {
            return DBTask.ExecuteDataset(ConfigurationManager.ConnectionStrings["DBConnection"].ToString(), "sp_TestReportInstallationsHistory", LoginId);
        }
        public DataTable TestReportDataForAdmin()
        {
            return DBTask.ExecuteDataTable(ConfigurationManager.ConnectionStrings["DBConnection"].ToString(), "sp_TestReportHistoryAdmin");
        }
        public DataSet TestReportContractorHistory(string LoginId)
        {
            return DBTask.ExecuteDataset(ConfigurationManager.ConnectionStrings["DBConnection"].ToString(), "sp_TestReportContractorHistory", LoginId);
        }
        public DataSet AllInspectionHistory()
        {
            return DBTask.ExecuteDataset(ConfigurationManager.ConnectionStrings["DBConnection"].ToString(), "sp_AllRequestsForAdmin");
        }
        #region Update TestReport Data
        public void UpdateTestReportData(string ID, string RejectOrApprovedFronContractor, string ReasonForRejection)
        {
            SqlCommand cmd = new SqlCommand("sp_UpdateTestReports");
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString);
            cmd.Connection = con;
            if (con.State == ConnectionState.Closed)
            {
                con.ConnectionString = ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;
                con.Open();
            }

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Id", ID);
            cmd.Parameters.AddWithValue("@RejectOrApprovedFronContractor", RejectOrApprovedFronContractor);
            cmd.Parameters.AddWithValue("@ReasonForRejection", ReasonForRejection);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        #endregion

        public DataTable RequestPendingDivision(string Division)
        {
            return DBTask.ExecuteDataTable(ConfigurationManager.ConnectionStrings["DBConnection"].ToString(), "GetRecordsAccordingToDays", Division);
        }

        public DataTable RequestPendingDaysData(string dated, string Division, string District)
        {
            return DBTask.ExecuteDataTable(ConfigurationManager.ConnectionStrings["DBConnection"].ToString(), "Sp_ShowRequestPendingDaysData", dated, Division, District);
        }
        public DataSet DasboardCalculations()
        {
            return DBTask.ExecuteDataset(ConfigurationManager.ConnectionStrings["DBConnection"].ToString(), "sp_DashboardCalculations");
        }
        public DataSet DasboardPieChartCalculations()
        {
            return DBTask.ExecuteDataset(ConfigurationManager.ConnectionStrings["DBConnection"].ToString(), "sp_BindDashboardPiechart");
        }
        public DataSet StaffPendingRecordsCount()
        {
            return DBTask.ExecuteDataset(ConfigurationManager.ConnectionStrings["DBConnection"].ToString(), "sp_StaffPendingRecordsCount");
        }

        public DataSet DdlToAssign()
        {
            return DBTask.ExecuteDataset(ConfigurationManager.ConnectionStrings["DBConnection"].ToString(), "sp_ToAssign");
        }
        #region Update Inspection Data For Action
        public void UpdateInspectionDataOnAction(string ID, string AcceptedOrRejected, string ReasonForRejection, string AssignTo, string AdditionalNotes)
        {
            SqlCommand cmd = new SqlCommand("sp_UpdateAction");
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString);
            cmd.Connection = con;
            if (con.State == ConnectionState.Closed)
            {
                con.ConnectionString = ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;
                con.Open();
            }

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Id", ID);
            cmd.Parameters.AddWithValue("@AcceptedOrRejected", AcceptedOrRejected);

            cmd.Parameters.AddWithValue("@ReasonForRejection", ReasonForRejection);
            cmd.Parameters.AddWithValue("@Staff", AssignTo);
            cmd.Parameters.AddWithValue("@AdditionalNotes", AdditionalNotes);

            cmd.ExecuteNonQuery();
            con.Close();
        }
        #endregion

        public DataSet DivisionsDistrictHistory(string loginid)
        {
            return DBTask.ExecuteDataset(ConfigurationManager.ConnectionStrings["DBConnection"].ToString(), "sp_DivisionDistrictsHistory", loginid);
        }
        public DataSet GetRecordsDivisionistrict(string loginid)
        {
            return DBTask.ExecuteDataset(ConfigurationManager.ConnectionStrings["DBConnection"].ToString(), "sp_GetRecordsDivisionistrict", loginid);
        }

        public DataSet StaffPendingDivisionWise(string loginId)
        {
            return DBTask.ExecuteDataset(ConfigurationManager.ConnectionStrings["DBConnection"].ToString(), "sp_StaffDivisionWise", loginId);
        }
        public DataTable ShowPendingDivisionDaysData(string dated, string Division, string District)
        {
            return DBTask.ExecuteDataTable(ConfigurationManager.ConnectionStrings["DBConnection"].ToString(), "Sp_ShowPendingDivisionDaysData", dated, Division, District);
        }

        public DataSet DivisionInspectionHistory(string LoginId)
        {
            return DBTask.ExecuteDataset(ConfigurationManager.ConnectionStrings["DBConnection"].ToString(), "sp_DivisionRequestHistory", LoginId);
        }
        public DataTable SiteOwnerPendingPayment(string SiteOwnerId)
        {
            return DBTask.ExecuteDataTable(ConfigurationManager.ConnectionStrings["DBConnection"].ToString(), "sp_PendingInspectionPaymentData", SiteOwnerId);
        }
        public DataSet RecordsDivisionDistrict(string loginid)
        {
            return DBTask.ExecuteDataset(ConfigurationManager.ConnectionStrings["DBConnection"].ToString(), "sp_BindDivisionBarGraph", loginid);
        }
        public DataSet GetStaffDetailsDropDown(string Division)
        {
            return DBTask.ExecuteDataset(ConfigurationManager.ConnectionStrings["DBConnection"].ToString(), "sp_GetStaffDetails", Division);
        }
        public DataSet GetDdlDivisionData()
        {
            return DBTask.ExecuteDataset(ConfigurationManager.ConnectionStrings["DBConnection"].ToString(), "sp_GetDivision");
        }
        #region Bind DropDown To Bind District by Division
        public DataSet GetddldistrictfromDivision(string Area)
        {
            return DBTask.ExecuteDataset(ConfigurationManager.ConnectionStrings["DBConnection"].ToString(), "sp_getDistrictForDropdownDivision", Area);
        }
        #endregion

        public DataSet ConsolidateSearchData(string SubmittedDate, string EndDate, string Division, string District, string Status, string Inspectiontype,
    string PendingWith, string OwnerApplication, string GSTNumber, string Assignto)
        {
            try
            {
                DataSet ds = new DataSet();
                SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnection"].ToString());
                SqlCommand cmd = new SqlCommand("sp_ConsolidatedSearch", connection);
                cmd.CommandType = CommandType.StoredProcedure;

                // Add parameters with named parameters
                cmd.Parameters.AddWithValue("@SubmittedDate", SubmittedDate);
                cmd.Parameters.AddWithValue("@EndDate", EndDate);
                cmd.Parameters.AddWithValue("@Division", Division);
                cmd.Parameters.AddWithValue("@District", District);
                cmd.Parameters.AddWithValue("@Status", Status);
                cmd.Parameters.AddWithValue("@Inspectiontype", Inspectiontype);
                cmd.Parameters.AddWithValue("@PendingWith", PendingWith);
                cmd.Parameters.AddWithValue("@OwnerApplication", OwnerApplication);
                cmd.Parameters.AddWithValue("@GSTNumber", GSTNumber);
                cmd.Parameters.AddWithValue("@AssignTo", Assignto);

                connection.Open();

                // Use a SqlDataAdapter to fill the DataSet
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    adapter.Fill(ds);
                }
                return ds;

            }
            catch (Exception ex)
            {
                return null;
            }

        }

        public DataTable GetInstllationsforSupervisor(string IntimationId)
        {
            return DBTask.ExecuteDataTable(ConfigurationManager.ConnectionStrings["DBConnection"].ToString(), "sp_GetInstallation", IntimationId);

        }
        public DataTable WorkIntimationHistoryforSupervisor(string Id)
        {
            return DBTask.ExecuteDataTable(ConfigurationManager.ConnectionStrings["DBConnection"].ToString(), "sp_GetIntimationHistoryForSupervisor", Id);
        }
        public DataTable GetInstllationHistorySupervisor(string IntimationId)
        {
            return DBTask.ExecuteDataTable(ConfigurationManager.ConnectionStrings["DBConnection"].ToString(), "sp_GetInstallationHistory", IntimationId);

        }

        public DataSet GetDetailsByPanNumberId(string PANNumber)
        {
            return DBTask.ExecuteDataset(ConfigurationManager.ConnectionStrings["DBConnection"].ToString(), "sp_GetDetailsByPanNumberId", PANNumber);
        }
        #region Insert New user data Data
        public void InserNewUserData(string ApplicationFor, string Name, string Age, string CalculatedAge, string FatherName,
            string gender, string aadhar, string Address, string District, string State, string PinCode, string PhoneNo, string Email,
            string Category, string CreatedBy, string UserId,
            string CommunicationAddress, string CommState, string CommDistrict, string CommPin, string Password, string IPAddress)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("sp_NewUserRegistration");
                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString);
                cmd.Connection = con;
                if (con.State == ConnectionState.Closed)
                {
                    con.ConnectionString = ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;
                    con.Open();
                }
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@ApplicationFor", ApplicationFor);
                cmd.Parameters.AddWithValue("@Name", Name);
                //cmd.Parameters.AddWithValue("@ApplicationStatus", ApplicationStatus);
                cmd.Parameters.AddWithValue("@Age", Age);
                cmd.Parameters.AddWithValue("@CalculatedAge", CalculatedAge);
                cmd.Parameters.AddWithValue("@FatherName", FatherName);
                cmd.Parameters.AddWithValue("@Gender", gender);
                cmd.Parameters.AddWithValue("@Aadhar", aadhar);
                cmd.Parameters.AddWithValue("@Address", Address);
                cmd.Parameters.AddWithValue("@District", District);
                cmd.Parameters.AddWithValue("@State", State);
                cmd.Parameters.AddWithValue("@PinCode", PinCode);
                cmd.Parameters.AddWithValue("@PhoneNo", PhoneNo);
                cmd.Parameters.AddWithValue("@Email", Email);
                cmd.Parameters.AddWithValue("@Category", Category);
                cmd.Parameters.AddWithValue("@Createdby", CreatedBy);
                cmd.Parameters.AddWithValue("@UserId", UserId);
                cmd.Parameters.AddWithValue("@CommunicationAddress", CommunicationAddress);
                cmd.Parameters.AddWithValue("@CommState", CommState);
                cmd.Parameters.AddWithValue("@CommDistrict", CommDistrict);
                cmd.Parameters.AddWithValue("@CommPin", CommPin);
                cmd.Parameters.AddWithValue("@Password", Password);
                cmd.Parameters.AddWithValue("@IPAddres", IPAddress);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
            }
        }
        #endregion

        public DataSet GetddlSecondaryVotlage(string Volts)
        {
            return DBTask.ExecuteDataset(ConfigurationManager.ConnectionStrings["DBConnection"].ToString(), "sp_SecondryVoltage", Volts);
        }
        public DataSet GetddlPrimaryVotlage(string Volts)
        {
            return DBTask.ExecuteDataset(ConfigurationManager.ConnectionStrings["DBConnection"].ToString(), "sp_PrimaryVoltage", Volts);
        } 
        public DataSet TestReportData(string PANNumber)
        {
            return DBTask.ExecuteDataset(ConfigurationManager.ConnectionStrings["DBConnection"].ToString(), "sp_GetIntimationsForSiteOwner", PANNumber);
        }
        public DataSet SiteOwnerInstallations(string IntimationId)
        {
            return DBTask.ExecuteDataset(ConfigurationManager.ConnectionStrings["DBConnection"].ToString(), "sp_GetInstallationForSiteOwner", IntimationId);
        } 
        public DataSet GetData(string Inspectiontype,string IntimationId, string Count)
        {
            return DBTask.ExecuteDataset(ConfigurationManager.ConnectionStrings["DBConnection"].ToString(), "sp_GetDataForInspection", Inspectiontype, IntimationId, Count);
        }
        public DataSet ActionTestReport(string LoginId)
        {
            return DBTask.ExecuteDataset(ConfigurationManager.ConnectionStrings["DBConnection"].ToString(), "sp_ActiontakenTestReport", LoginId);
        }

        public void InsertnewUseQualification(string UserId, string UniversityName10th, string PassingYear10th, string MarksObtained10th, string MarksMax10th, string Percentage10th,
              string Name12ITIDiploma, string UniversityName12thorITI, string PassingYear12thorITI, string MarksObtained12thorITI, string MarksMax12thorITI, string Percentage12thorITI,
              string NameofDiplomaDegree, string UniversityNameDiplomaorDegree, string PassingYearDiplomaorDegree, string MarksObtainedDiplomaorDegree, string MarksMaxDiplomaorDegree, string PercentageDiplomaorDegree,
              string NameofDegree, string UniversityNamePG, string PassingYearPG, string MarksObtainedPG, string MarksMaxPG, string PercentagePG,
              string NameofMasters, string MastersUniversityName, string MastersPassingYear, string MasterMarksObtained, string MastersMarksMax, string MatersPercentage,
              string IsCertificateofCompetency, string CertificateofCompetency1, string PermitNo1, string IssuingAuthority1, string IssueDate1, string ExpiryDate,
              string EmployedPermanent, string PermanentEmployerName, string PostDescription, string FromDate, string ToDate,
              string Experience, string TraningUnder, string ExperienceEmployerName, string ExperiencePostDescription, string ExperienceFromDate, string ExperienceToDate,
              string Experience1, string TraningUnder1, string ExperienceEmployerName1, string ExperiencePostDescription1, string ExperienceFromDate1, string ExperienceToDate1,
              string Experience2, string TraningUnder2, string ExperienceEmployerName2, string ExperiencePostDescription2, string ExperienceFromDate2, string ExperienceToDate2,
              string Experience3, string TraningUnder3, string ExperienceEmployerName3, string ExperiencePostDescription3, string ExperienceFromDate3, string ExperienceToDate3,
              string Experience4, string TraningUnder4, string ExperienceEmployerName4, string ExperiencePostDescription4, string ExperienceFromDate4, string ExperienceToDate4,
              string TotalExperience, string RetiredEngineer
              )
        {
            SqlCommand cmd = new SqlCommand("sp_InsertUserQualification");
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString);
            cmd.Connection = con;
            if (con.State == ConnectionState.Closed)
            {
                con.ConnectionString = ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;
                con.Open();
            }
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@UserId", UserId);
            cmd.Parameters.AddWithValue("@UniversityName10th", UniversityName10th);
            cmd.Parameters.AddWithValue("@PassingYear10th", PassingYear10th);
            cmd.Parameters.AddWithValue("@MarksObtained10th", MarksObtained10th);
            cmd.Parameters.AddWithValue("@MarksMax10th", MarksMax10th);
            cmd.Parameters.AddWithValue("@Percentage10th", Percentage10th);

            cmd.Parameters.AddWithValue("@Name12ITIDiploma", Name12ITIDiploma);
            cmd.Parameters.AddWithValue("@UniversityName12thorITI", UniversityName12thorITI);
            cmd.Parameters.AddWithValue("@PassingYear12thorITI", PassingYear12thorITI);
            cmd.Parameters.AddWithValue("@MarksObtained12thorITI", MarksObtained12thorITI);
            cmd.Parameters.AddWithValue("@MarksMax12thorITI", MarksMax12thorITI);
            cmd.Parameters.AddWithValue("@Percentage12thorITI", Percentage12thorITI);

            cmd.Parameters.AddWithValue("@NameofDiplomaDegree", NameofDiplomaDegree);
            cmd.Parameters.AddWithValue("@UniversityNameDiplomaorDegree", UniversityNameDiplomaorDegree);
            cmd.Parameters.AddWithValue("@PassingYearDiplomaorDegree", PassingYearDiplomaorDegree);
            cmd.Parameters.AddWithValue("@MarksObtainedDiplomaorDegree", MarksObtainedDiplomaorDegree);
            cmd.Parameters.AddWithValue("@MarksMaxDiplomaorDegree", MarksMaxDiplomaorDegree);
            cmd.Parameters.AddWithValue("@PercentageDiplomaorDegree", PercentageDiplomaorDegree);

            cmd.Parameters.AddWithValue("@NameofDegree", NameofDegree);
            cmd.Parameters.AddWithValue("@UniversityNamePG", UniversityNamePG);
            cmd.Parameters.AddWithValue("@PassingYearPG", PassingYearPG);
            cmd.Parameters.AddWithValue("@MarksObtainedPG", MarksObtainedPG);
            cmd.Parameters.AddWithValue("@MarksMaxPG", MarksMaxPG);
            cmd.Parameters.AddWithValue("@PercentagePG", PercentagePG);

            cmd.Parameters.AddWithValue("@NameofMasters", NameofMasters);
            cmd.Parameters.AddWithValue("@MastersUniversityName", MastersUniversityName);
            cmd.Parameters.AddWithValue("@MastersPassingYear", MastersPassingYear);
            cmd.Parameters.AddWithValue("@MasterMarksObtained", MasterMarksObtained);
            cmd.Parameters.AddWithValue("@MastersMarksMax", MastersMarksMax);
            cmd.Parameters.AddWithValue("@MastersPercentage", MatersPercentage);

            cmd.Parameters.AddWithValue("@IsCertificateofCompetency", IsCertificateofCompetency);
            cmd.Parameters.AddWithValue("@CertificateofCompetency1", CertificateofCompetency1);
            cmd.Parameters.AddWithValue("@PermitNo1", PermitNo1);
            cmd.Parameters.AddWithValue("@IssuingAuthority1", IssuingAuthority1);
            cmd.Parameters.AddWithValue("@IssueDate1", IssueDate1);
            cmd.Parameters.AddWithValue("@ExpiryDate1", ExpiryDate);
            //cmd.Parameters.AddWithValue("@CertificateofCompetency2", CertificateofCompetency2);
            //cmd.Parameters.AddWithValue("@PermitNo2", PermitNo2);
            //cmd.Parameters.AddWithValue("@IssuingAuthority2", IssuingAuthority2);
            //cmd.Parameters.AddWithValue("@IssueDate2", IssueDate2);
            cmd.Parameters.AddWithValue("@EmployedPermanent", EmployedPermanent);
            cmd.Parameters.AddWithValue("@EmployerName", PermanentEmployerName);
            cmd.Parameters.AddWithValue("@PostDescription", PostDescription);
            cmd.Parameters.AddWithValue("@FromDate", FromDate);
            cmd.Parameters.AddWithValue("@ToDate", ToDate);

            cmd.Parameters.AddWithValue("@ExperiencedIn", Experience);
            cmd.Parameters.AddWithValue("@TrainingUnder", TraningUnder);
            cmd.Parameters.AddWithValue("@ExperienceEmployerName", ExperienceEmployerName);
            cmd.Parameters.AddWithValue("@ExperiencePostDescription", ExperiencePostDescription);
            cmd.Parameters.AddWithValue("@ExperienceFromDate", ExperienceFromDate);
            cmd.Parameters.AddWithValue("@ExperienceToDate", ExperienceToDate);

            cmd.Parameters.AddWithValue("@ExperiencedIn1", Experience1);
            cmd.Parameters.AddWithValue("@TrainingUnder1", TraningUnder1);
            cmd.Parameters.AddWithValue("@ExperienceEmployerName1", ExperienceEmployerName1);
            cmd.Parameters.AddWithValue("@ExperiencePostDescription1", ExperiencePostDescription1);
            cmd.Parameters.AddWithValue("@ExperienceFromDate1", ExperienceFromDate1);
            cmd.Parameters.AddWithValue("@ExperienceToDate1", ExperienceToDate1);

            cmd.Parameters.AddWithValue("@ExperiencedIn2", Experience2);
            cmd.Parameters.AddWithValue("@TrainingUnder2", TraningUnder2);
            cmd.Parameters.AddWithValue("@ExperienceEmployerName2", ExperienceEmployerName2);
            cmd.Parameters.AddWithValue("@ExperiencePostDescription2", ExperienceEmployerName2);
            cmd.Parameters.AddWithValue("@ExperienceFromDate2 ", ExperienceFromDate2);
            cmd.Parameters.AddWithValue("@ExperienceToDate2 ", ExperienceToDate2);

            cmd.Parameters.AddWithValue("@ExperiencedIn3", Experience3);
            cmd.Parameters.AddWithValue("@TrainingUnder3", TraningUnder3);
            cmd.Parameters.AddWithValue("@ExperienceEmployerName3", ExperienceEmployerName3);
            cmd.Parameters.AddWithValue("@ExperiencePostDescription3", ExperiencePostDescription3);
            cmd.Parameters.AddWithValue("@ExperienceFromDate3 ", ExperienceFromDate3);
            cmd.Parameters.AddWithValue("@ExperienceToDate3 ", ExperienceToDate3);

            cmd.Parameters.AddWithValue("@ExperiencedIn4", Experience4);
            cmd.Parameters.AddWithValue("@TrainingUnder4", TraningUnder4);
            cmd.Parameters.AddWithValue("@ExperienceEmployerName4", ExperienceEmployerName4);
            cmd.Parameters.AddWithValue("@ExperiencePostDescription4", ExperiencePostDescription4);
            cmd.Parameters.AddWithValue("@ExperienceFromDate4 ", ExperienceFromDate4);
            cmd.Parameters.AddWithValue("@ExperienceToDate4 ", ExperienceToDate4);

            cmd.Parameters.AddWithValue("@TotalExperience ", TotalExperience);
            cmd.Parameters.AddWithValue("@RetiredEngineer", RetiredEngineer);
            //cmd.Parameters.AddWithValue("@ExperienceEmployerName1", txtEmployer.Text);
            //cmd.Parameters.AddWithValue("@ExperiencePostDescription1", txtDescript.Text);
            //cmd.Parameters.AddWithValue("@ExperienceFromDate1", txtFrm1.Text);
            //cmd.Parameters.AddWithValue("@ExperienceToDate1", txtToDate.Text);
            //cmd.Parameters.AddWithValue("@RetiredEmployerName", RetiredEmployerName);
            //cmd.Parameters.AddWithValue("@RetiredPostDescription", RetiredPostDescription);
            //cmd.Parameters.AddWithValue("@RetiredFromDate", RetiredFromDate);
            //cmd.Parameters.AddWithValue("@RetiredToDate", RetiredToDate);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        #region Contractor Application Form Data
        public void ContractorApplicationData(string GSTNumber, string StyleOfCompany, string CompanyRegisterdOffice, string CompanyPartnerOrDirector,
             string CompanyPenalities,string LibraryAvailable, string AgentName, string ManufacturingFirmOrProductionUnit, string ContractorLicencePreviouslyGranted,
            string NameOfIssuingAuthority, string DateOfBirth, string DateOfLicenseExpiring,string ContractorLicencePreviouslyGrantedWithSameName,
            string LicenseNoIfYes,string DateoFIssue,  string TypeOfEmployee1, string LicenseNo1,
            string IssueDate1, string ValidityDate1, string Qualification1, string TypeOfEmployee2, string LicenseNo2, string IssueDate2,
            string ValidityDate2, string Qualification2, string CreatedBy)
        {
            SqlCommand cmd = new SqlCommand("sp_SetContractorApplicationFormData");
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString);
            cmd.Connection = con;
            if (con.State == ConnectionState.Closed)
            {
                con.ConnectionString = ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;
                con.Open();
            }

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@GSTNumber", GSTNumber);
            cmd.Parameters.AddWithValue("StyleOfCompany", StyleOfCompany);
            cmd.Parameters.AddWithValue("@CompanyRegisterdOffice", CompanyRegisterdOffice);
            cmd.Parameters.AddWithValue("@CompanyPartnerOrDirector", CompanyPartnerOrDirector);
            cmd.Parameters.AddWithValue("@CompanyPenalities", CompanyPenalities);
            cmd.Parameters.AddWithValue("@LibraryAvailable", LibraryAvailable);
            cmd.Parameters.AddWithValue("@AgentName", AgentName);
            cmd.Parameters.AddWithValue("@ManufacturingFirmOrProductionUnit", ManufacturingFirmOrProductionUnit);
            cmd.Parameters.AddWithValue("@ContractorLicencePreviouslyGranted", ContractorLicencePreviouslyGranted);
            cmd.Parameters.AddWithValue("@NameOfIssuingAuthority", NameOfIssuingAuthority);
            cmd.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            cmd.Parameters.AddWithValue("@DateOfLicenseExpiring", DateOfLicenseExpiring);
            cmd.Parameters.AddWithValue("@ContractorLicencePreviouslyGrantedWithSameName", ContractorLicencePreviouslyGrantedWithSameName);
            cmd.Parameters.AddWithValue("@LicenseNoIfYes", LicenseNoIfYes);
            cmd.Parameters.AddWithValue("@DateoFIssue", DateoFIssue);
            cmd.Parameters.AddWithValue("@TypeOfEmployee1", TypeOfEmployee1);
            cmd.Parameters.AddWithValue("@LicenseNo1", LicenseNo1);
            cmd.Parameters.AddWithValue("@IssueDate1", IssueDate1);
            cmd.Parameters.AddWithValue("@ValidityDate1", ValidityDate1);
            cmd.Parameters.AddWithValue("@Qualification1", Qualification1);
            cmd.Parameters.AddWithValue("@TypeOfEmployee2", TypeOfEmployee2);
            cmd.Parameters.AddWithValue("@LicenseNo2", LicenseNo2);
            cmd.Parameters.AddWithValue("@IssueDate2", IssueDate2);
            cmd.Parameters.AddWithValue("@ValidityDate2", ValidityDate2);
            cmd.Parameters.AddWithValue("@Qualification2", Qualification2);
            cmd.Parameters.AddWithValue("@CreatedBy", CreatedBy);
            cmd.ExecuteNonQuery();
            con.Close();

        }
        public void ContractorPartners(string TypeOfAuthority,string Name,string Address,string State,string District,string Pincode,string CreatedBy)
        {
            SqlCommand cmd = new SqlCommand("sp_ContractorPartners");
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString);
            cmd.Connection = con;
            if (con.State == ConnectionState.Closed)
            {
                con.ConnectionString = ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;
                con.Open();
            }

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@TypeOfAuthority", TypeOfAuthority);
                cmd.Parameters.AddWithValue("@Name", Name);
                cmd.Parameters.AddWithValue("@Address", Address);
                cmd.Parameters.AddWithValue("@State", State);
                cmd.Parameters.AddWithValue("@District", District);
                cmd.Parameters.AddWithValue("@Pincode", Pincode);
                cmd.Parameters.AddWithValue("@CreatedBy", CreatedBy);

                cmd.ExecuteNonQuery();
                  con.Close();

        }

        #endregion

        #region Insert ApplicationLift And Esculator
        public void InsertListAndEscalators(string UserId, string ApplicantType, string ApplicantName, string ApplicantContact, string ApplicantOfficeAdd,
            string ApplicantState, string ApplicantDistt, string ApplicantPincode, string AgentName, string AgentContect, string AgentAddres, string AgentState,
            string AgentDistt, string AgentPincode, string OwnerName, string OwnerAddres, string OwnerState, string OwnerDistrict, string OwnerPincode,
            string ErectionDate, string TypeOfLift, string MakersName, string MakersLocalAgent, string MakersAddress, string ContractSpeedLift, string ContractLoadLift,
            string LiftCapcityMaxNoOfPerson, string TotalWeightLiftCar, string WeightCounterWeight, string NoOfSuspensionRoops, string Description, string Weight,
            string Size, string PitDepth, string TravelAndNoOfFloors, string ConstructionDetailsOverheadArrangement//, string CopyOfAnnualInsurancePolicy, string CopyOfChallanTreasury,
                                                                                                                   // string AnnualMaintenanceContract, string SaftyCertificate, string FormA, string FormB, string FormC
            )
        {
            SqlCommand cmd = new SqlCommand("Sp_InsertLiftEscalators");
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString);
            cmd.Connection = con;
            if (con.State == ConnectionState.Closed)
            {
                con.ConnectionString = ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;
                con.Open();
            }

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@UserId ", UserId);
            cmd.Parameters.AddWithValue("@ApplicantType", ApplicantType);
            cmd.Parameters.AddWithValue("@ApplicantNames", ApplicantName);
            cmd.Parameters.AddWithValue("@ApplicantContactNo", ApplicantContact);
            cmd.Parameters.AddWithValue("@ApplicantOfficeAddress", ApplicantOfficeAdd);
            cmd.Parameters.AddWithValue("@ApplicantState", ApplicantState);
            cmd.Parameters.AddWithValue("@ApplicantDistrict", ApplicantDistt);
            cmd.Parameters.AddWithValue("@ApplicantPinCode", ApplicantPincode);
            cmd.Parameters.AddWithValue("@AgentName", AgentName);
            cmd.Parameters.AddWithValue("@AgentContactNo", AgentContect);
            cmd.Parameters.AddWithValue("@AgentAddress", AgentAddres);
            cmd.Parameters.AddWithValue("@AgentState", AgentState);
            cmd.Parameters.AddWithValue("@AgentDistrict", AgentDistt);
            cmd.Parameters.AddWithValue("@AgentPincode", AgentPincode);
            cmd.Parameters.AddWithValue("@OwnerName", OwnerName);
            cmd.Parameters.AddWithValue("@OwnerAddress", OwnerAddres);
            cmd.Parameters.AddWithValue("@OwnerState", OwnerState);
            cmd.Parameters.AddWithValue("@OwnerDistrict", OwnerDistrict);
            cmd.Parameters.AddWithValue("@OwnerPincode", OwnerPincode);
            cmd.Parameters.AddWithValue("@ErectionDate", ErectionDate);
            cmd.Parameters.AddWithValue("@TypeOfLift", TypeOfLift);
            cmd.Parameters.AddWithValue("@MakersName", MakersName);
            cmd.Parameters.AddWithValue("@MakersLocalAgent", MakersLocalAgent);
            cmd.Parameters.AddWithValue("@MakersAddress", MakersAddress);
            cmd.Parameters.AddWithValue("@ContractSpeedLift", ContractSpeedLift);
            cmd.Parameters.AddWithValue("@ContractLoadLift", ContractLoadLift);
            cmd.Parameters.AddWithValue("@LiftCapcityMaxNoOfPerson", LiftCapcityMaxNoOfPerson);
            cmd.Parameters.AddWithValue("@TotalWeightLiftCar", TotalWeightLiftCar);
            cmd.Parameters.AddWithValue("@WeightCounterWeight", WeightCounterWeight);
            cmd.Parameters.AddWithValue("@NoOfSuspensionRoops", NoOfSuspensionRoops);
            cmd.Parameters.AddWithValue("@Description", Description);
            cmd.Parameters.AddWithValue("@Weight", Weight);
            cmd.Parameters.AddWithValue("@Size", Size);
            cmd.Parameters.AddWithValue("@PitDepth", PitDepth);
            cmd.Parameters.AddWithValue("@TravelAndNoOfFloors", TravelAndNoOfFloors);
            cmd.Parameters.AddWithValue("@ConstructionDetailsOverheadArrangement", ConstructionDetailsOverheadArrangement);
            //cmd.Parameters.AddWithValue("@CopyOfAnnualInsurancePolicy ", CopyOfAnnualInsurancePolicy);
            //cmd.Parameters.AddWithValue("@CopyOfChallanTreasury", CopyOfChallanTreasury);
            //cmd.Parameters.AddWithValue("@AnnualMaintenanceContract", AnnualMaintenanceContract);
            //cmd.Parameters.AddWithValue("@SaftyCertificate", SaftyCertificate);
            //cmd.Parameters.AddWithValue("@FormA", FormA);
            //cmd.Parameters.AddWithValue("@FormB	", FormB);
            //cmd.Parameters.AddWithValue("@FormC	 ", FormC);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        #endregion


        public DataTable GetPartnersDirectorDate(string CreatedBy)
        {
            return DBTask.ExecuteDataTable(ConfigurationManager.ConnectionStrings["DBConnection"].ToString(), "sp_PartnersDirectorData", CreatedBy);
        }

        public int DocumentsForContactor(string Last3YearsITRAndBalanceSheet, string PanCard, string AdhaarNo, string AgeCertificate, string CalbrationFromNABLOrTestingLaboratoryofequipment, string CopyOfAnnexure3And5, string StatusOfCompanyProof, string MajorWorkesCarried, string DetailsofWorkPermited, string ElibraryasperANNEXURE2, string PreviouslyGrantedLicense, string CreatedBy)
        {
            return DBTask.ExecuteNonQuery(ConfigurationManager.ConnectionStrings["DBConnection"].ToString(), "sp_ContractorDocuments", Last3YearsITRAndBalanceSheet, PanCard, AdhaarNo,AgeCertificate, CalbrationFromNABLOrTestingLaboratoryofequipment, CopyOfAnnexure3And5, StatusOfCompanyProof, MajorWorkesCarried, DetailsofWorkPermited, ElibraryasperANNEXURE2, PreviouslyGrantedLicense, CreatedBy);
        }
        #region InsertApplicationLift And Esculator Document
        //public void LiftEsculatorDocument(string REID, string flpPhotourl, string flpPhotourl1, string flpPhotourl2, string flpPhotourl3,
        //    string flpPhotourl4, string flpPhotourl5, string flpPhotourl6)
        //{
        //    SqlCommand cmd = new SqlCommand("Sp_LiftEsculatorDocument");
        //    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString);
        //    cmd.Connection = con;
        //    if (con.State == ConnectionState.Closed)
        //    {
        //        con.ConnectionString = ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;
        //        con.Open();
        //    }
        //    cmd.Parameters.AddWithValue("@UserId", REID);
        //    cmd.Parameters.AddWithValue("@CopyOfAnnualInsurancePolicy", flpPhotourl);
        //    cmd.Parameters.AddWithValue("@CopyOfChallanTreasury", flpPhotourl1);
        //    cmd.Parameters.AddWithValue("@AnnualMaintenanceContract", flpPhotourl2);
        //    cmd.Parameters.AddWithValue("@SaftyCertificate", flpPhotourl3);
        //    cmd.Parameters.AddWithValue("@FormA", flpPhotourl4);
        //    cmd.Parameters.AddWithValue("@FormB", flpPhotourl5);
        //    cmd.Parameters.AddWithValue("@FormC", flpPhotourl6);
        //    cmd.ExecuteNonQuery();
        //    con.Close();

        //}


        #endregion

        public DataSet GetQualificationHistory(string id)
        {
            return DBTask.ExecuteDataset(ConfigurationManager.ConnectionStrings["DBConnection"].ToString(), "sp_GetUserQualification", id);

        }
        public int LiftEsculatorDocument(string flpPhotourl, string flpPhotourl1, string flpPhotourl2, string flpPhotourl3, string flpPhotourl4, string flpPhotourl5, string flpPhotourl6, string REID)
        {
            return DBTask.ExecuteNonQuery(ConfigurationManager.ConnectionStrings["DBConnection"].ToString(), "Sp_LiftEsculatorDocuments", flpPhotourl, flpPhotourl1, flpPhotourl2, flpPhotourl3, flpPhotourl4, flpPhotourl5, flpPhotourl6, REID);
        }

        public DataTable ContractorBasicInformation(string UserId)
        {
            return DBTask.ExecuteDataTable(ConfigurationManager.ConnectionStrings["DBConnection"].ToString(), "sp_GetContractorBasicInformation", UserId);

        }
        public DataSet QualificationData(string LoginId)
        {
            return DBTask.ExecuteDataset(ConfigurationManager.ConnectionStrings["DBConnection"].ToString(), "Sp_GetRegistrationForm", LoginId);

        }
        public DataSet GetReportsHistory(string Type,string IntimationId, string Count)
        {
            return DBTask.ExecuteDataset(ConfigurationManager.ConnectionStrings["DBConnection"].ToString(), "sp_GetTestReportId", Type, IntimationId, Count);

        }
        public DataSet GetTestReportHistoryFromSupervisor()
        {
            return DBTask.ExecuteDataset(ConfigurationManager.ConnectionStrings["DBConnection"].ToString(), "sp_TestReportInstallationsHistoryFromSupervisor");
        }

    }
}
    
