﻿<%@ Page Title="" Language="C#" MasterPageFile="~/SiteOwnerPages/SiteOwner.Master" AutoEventWireup="true" CodeBehind="Inspection.aspx.cs" Inherits="CEIHaryana.SiteOwnerPages.Inspection" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
<link rel="shortcut icon" type="image/png" href="/css2/style.min.css" />
    <link rel="stylesheet" href="/css2/style.css" />
    <link href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css" rel="stylesheet" id="bootstrap-css">
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/js/bootstrap.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>
    <link href="//maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css" rel="stylesheet" id="bootstrap-css">
    <script src="//maxcdn.bootstrapcdn.com/bootstrap/4.0.0/js/bootstrap.min.js"></script>
    <script src="//cdnjs.cloudflare.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>
    <link href="https://cdnjs.cloudflare.com/ajax/libs/select2/4.0.6-rc.0/css/select2.min.css" rel="stylesheet" />
    <script src="https://cdnjs.cloudflare.com/ajax/libs/select2/4.0.6-rc.0/js/select2.min.js"></script>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/2.1.1/jquery.min.js"></script>
    <script src="https://cdn.rawgit.com/harvesthq/chosen/gh-pages/chosen.jquery.min.js"></script>
    <link href="https://cdn.rawgit.com/harvesthq/chosen/gh-pages/chosen.min.css" rel="stylesheet" />
    <link href="https://cdnjs.cloudflare.com/ajax/libs/select2/4.0.6-rc.0/css/select2.min.css" rel="stylesheet" />
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.4.2/css/solid.min.css" integrity="sha512-P9pgMgcSNlLb4Z2WAB2sH5KBKGnBfyJnq+bhcfLCFusrRc4XdXrhfDluBl/usq75NF5gTDIMcwI1GaG5gju+Mw==" crossorigin="anonymous" referrerpolicy="no-referrer" />
    <script src="https://cdnjs.cloudflare.com/ajax/libs/select2/4.0.6-rc.0/js/select2.min.js"></script>
    <script defer src="https://use.fontawesome.com/releases/v5.15.4/js/all.js" integrity="sha384-rOA1PnstxnOBLzCLMcre8ybwbTmemjzdNlILg8O7z1lUkLXozs4DHonlDtnE7fpc" crossorigin="anonymous"></script>
    <script type="text/javascript">
        function isNumberKey(evt) {
            var charCode = (evt.which) ? evt.which : event.keyCode
            if (charCode > 31 && (charCode < 48 || charCode > 57)) {
                return false;
            }
            return true;
        }

        //Allow Only Aplhabet, Delete and Backspace

        function isAlpha(keyCode) {

            return ((keyCode >= 65 && keyCode <= 90) || keyCode == 8 || keyCode == 32 || keyCode == 190)

        }

        function alphabetKey(e) {
            var allow = ' ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz \b'
            var k;
            k = document.all ? parseInt(e.keyCode) : parseInt(e.which);
            return (allow.indexOf(String.fromCharCode(k)) != -1);
        }
    </script>
    <style>
        .submit {
            border: 1px solid #563d7c;
            border-radius: 5px;
            color: white;
            padding: 5px 10px 5px 10px;
            background: left 3px top 5px no-repeat #563d7c;
        }

            .submit:hover {
                border: 1px solid #563d7c;
                border-radius: 5px;
                color: white;
                padding: 5px 10px 5px 10px;
                background: left 3px top 5px no-repeat #26005f;
                box-shadow: rgba(0, 0, 0, 0.24) 0px 3px 8px;
            }

        .table-dark {
            text-align: center !important;
            background-color: #9292cc !important;
        }

        .col-4 {
            margin-bottom: 15px;
        }

        .form-control {
            box-shadow: rgba(0, 0, 0, 0.16) 0px 1px 4px;
            margin-left: 0px !important;
            height: 30px;
        }

        select.form-control {
            box-shadow: rgba(0, 0, 0, 0.16) 0px 1px 4px;
            margin-left: 0px !important;
            height: 30px;
        }

        label {
            font-size: 13px;
        }

        .form-control:focus {
            border: 2px solid #80bdff;
        }

        select.form-control:focus {
            border: 2px solid #80bdff;
        }

        .select2-container .select2-selection--single {
            height: 30px !important;
        }

        .select2-container--default .select2-selection--single {
            border: 1px solid #ccc !important;
            border-radius: 0px !important;
        }

        span.select2-selection.select2-selection--single {
            padding: 0px 0px 0px 5px;
            box-shadow: rgba(0, 0, 0, 0.16) 0px 1px 4px;
            margin-left: 0px !important;
            height: 30px;
            border-radius: 5px !important;
        }

            span.select2-selection.select2-selection--single:focus {
                border: 2px solid #80bdff;
            }

        .card .card-title {
            font-size: 1rem !important;
        }

        .btn-primary:hover {
            box-shadow: rgba(50, 50, 93, 0.25) 0px 30px 60px -12px inset, rgba(0, 0, 0, 0.3) 0px 18px 36px -18px inset;
        }

        button.btn.btn-primary.mr-2 {
            padding: 10px 25px 10px 25px;
            font-size: 18px;
        }

        select.form-control.select-form.select2 {
            height: 30px !important;
            padding: 2px 0px 5px 10px;
        }

        ul.chosen-choices {
            border-radius: 5px;
        }

        input#customFile {
            padding: 0px 0px 0px 0px;
        }

        input#ContentPlaceHolder1_txtName {
            font-size: 12.5px !important;
        }


        input#ContentPlaceHolder1_txtagency {
            font-size: 12.5px;
        }
    </style>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


       <div class="content-wrapper">
    <div class="card-body" style="box-shadow: rgba(0, 0, 0, 0.35) 0px 5px 15px; padding: 25px; margin-bottom: 25px; border-radius: 10px; margin-top: 10px;">
        <div class="row">
            <div class="col-4">
                <label>
                    Type of Inspection
                    <samp style="color: red">* </samp>
                </label>
                <asp:TextBox class="form-control" ID="txtPremises" ReadOnly="true" MaxLength="6" onkeydown="return preventEnterSubmit(event)" onkeyup="ValidatePincode();" onKeyPress="return isNumberKey(event);" autocomplete="off" TabIndex="7" runat="server" Style="margin-left: 18px"></asp:TextBox>


            </div>

            <div class="col-4">
                <label>
                    Type of Applicant<samp style="color: red"> * </samp>
                </label>
                <asp:TextBox class="form-control" ID="txtApplicantType" ReadOnly="true" MaxLength="6" onkeydown="return preventEnterSubmit(event)" onkeyup="ValidatePincode();" onKeyPress="return isNumberKey(event);" autocomplete="off" TabIndex="7" runat="server" Style="margin-left: 18px"></asp:TextBox>

            </div>
            <div class="col-4">
                <label>
                    Type of Installation<samp style="color: red"> * </samp>
                </label>
                <asp:TextBox class="form-control" ID="txtWorkType" ReadOnly="true" MaxLength="6" onkeydown="return preventEnterSubmit(event)" onkeyup="ValidatePincode();" onKeyPress="return isNumberKey(event);" autocomplete="off" TabIndex="7" runat="server" Style="margin-left: 18px"></asp:TextBox>

            </div>
            <div class="col-4" runat="server">
                <label for="Pin">Voltage Level</label>
                <asp:TextBox class="form-control" ID="txtVoltage" ReadOnly="true" MaxLength="6" onkeydown="return preventEnterSubmit(event)" onkeyup="ValidatePincode();" onKeyPress="return isNumberKey(event);" autocomplete="off" TabIndex="7" runat="server" Style="margin-left: 18px"></asp:TextBox>

            </div>
        </div>

        <div class="row">
            <div class="table-responsive pt-3" id="Uploads" runat="server" >
                <table class="table table-bordered table-striped">
                    <thead class="table-dark">
                        <tr>
                            <th>Name of Documents
                            </th>
                            <th>Upload Documents
                            </th>
                            <th>
                                Change Document
                            </th>
                        </tr>
                    </thead>
                    <tbody>
                        <div id="LineSubstationSupplier" runat="server" >
                            <tr id="Tr1" runat="server" visible="true">
                                <td>
                                    <div class="col-12">
                                        Request letter from concerned Officer<samp style="color: red"> * </samp>
                                    </div>
                                </td>
                                <td>
                                    <asp:LinkButton ID="lnkLetter" runat="server" AutoPostBack="true" OnClick="lnkLetter_Click" Text="Open Document" />

                                </td>
                                <td> 
                                    <asp:FileUpload runat="server" ID="fileUpload" />
                                </td>
                            </tr>
                            <tr id="Tr2" runat="server" visible="true">
                                <td>
                                    <div class="col-12">
                                        Manufacturing test report of equipment<samp style="color: red"> * </samp>
                                    </div>
                                </td>
                                <td>
                                    <div class="col-12">
                                        <asp:LinkButton ID="lnktest" runat="server" AutoPostBack="true" OnClick="lnktest_Click" Text="Open Document" />
                                    </div>
                                </td>
                                <td>
                                     <asp:FileUpload runat="server" ID="fileUpload1" />
                                </td>
                            </tr>
                        </div>
                        <div id="SupplierSub" runat="server" >
                            <tr id="Tr3" runat="server" visible="true">
                                <td>
                                    <div class="col-12">
                                        Single line diagram of Line<samp style="color: red"> * </samp>
                                    </div>
                                </td>
                                <td>
                                    <div class="col-12">
                                        <asp:LinkButton ID="lnkDiag" runat="server" AutoPostBack="true" OnClick="lnkDiag_Click" Text="Open Document" />
                                    </div>
                                </td>
                                 <td>
                                     <asp:FileUpload runat="server" ID="fileUpload2" />
                                </td>
                            </tr>
                        </div>
                        <div id="PersonalSub" runat="server" visible="false">
                            <tr id="Tr4" runat="server" visible="true">
                                <td>
                                    <div class="col-12">
                                        Copy of demand notice issued by UHDVN/ DHBVN<samp style="color: red"> * </samp>
                                    </div>
                                </td>
                                <td>
                                    <div class="col-12">
                                        <asp:LinkButton ID="lnkCopy" runat="server" AutoPostBack="true" OnClick="lnkCopy_Click" Text="Open Document" />
                                    </div>
                                </td>
                                 <td>
                                     <asp:FileUpload runat="server" ID="fileUpload3" />
                                </td>
                            </tr>
                            <tr id="Tr5" runat="server" visible="true">
                                <td>
                                    <div class="col-12">
                                        Invoice of transformer<samp style="color: red"> * </samp>
                                    </div>
                                </td>
                                <td>
                                    <div class="col-12">
                                        <asp:LinkButton ID="lnkInvoiceTransformer" runat="server" AutoPostBack="true" OnClick="lnkInvoiceTransformer_Click" Text="Open Document" />
                                    </div>
                                </td>
                                 <td>
                                     <asp:FileUpload runat="server" ID="fileUpload4" />
                                </td>
                            </tr>
                            <tr id="Tr6" runat="server" visible="true">
                                <td>
                                    <div class="col-12">
                                        Manufacturing test certificate of transformer<samp style="color: red"> * </samp>
                                    </div>
                                </td>
                                <td>
                                    <div class="col-12">
                                        <asp:LinkButton ID="lnkManufacturing" runat="server" AutoPostBack="true" OnClick="lnkManufacturing_Click" Text="Open Document" />
                                    </div>
                                </td>
                                 <td>
                                     <asp:FileUpload runat="server" ID="fileUpload5" />
                                </td>
                            </tr>
                            <tr id="Tr7" runat="server" visible="true">
                                <td>
                                    <div class="col-12">
                                        Single line diagram
                                                        <samp style="color: red">* </samp>
                                    </div>
                                </td>
                                <td>
                                    <div class="col-12">
                                        <asp:LinkButton ID="lnkSingleDiag" runat="server" AutoPostBack="true" OnClick="lnkSingleDiag_Click" Text="Open Document" />
                                    </div>
                                </td>
                                 <td>
                                     <asp:FileUpload runat="server" ID="fileUpload6" />
                                </td>
                            </tr>
                            <tr id="Tr8" runat="server" visible="true">
                                <td>
                                    <div class="col-12">
                                        Invoice of fire extinguisher system, apparatus installed at the site<samp style="color: red"> * </samp>
                                    </div>
                                </td>
                                <td>
                                    <div class="col-12">
                                        <asp:LinkButton ID="lnkInvoiceFire" runat="server" AutoPostBack="true" OnClick="lnkInvoiceFire_Click" Text="Open Document" />
                                    </div>
                                </td>
                                 <td>
                                     <asp:FileUpload runat="server" ID="fileUpload7" />
                                </td>
                            </tr>
                        </div>
                        <div id="PersonalGenerating" runat="server" visible="false">
                            <tr id="Tr9" runat="server" visible="true">
                                <td>
                                    <div class="col-12">
                                        Invoice of DG set<samp style="color: red"> * </samp>
                                    </div>
                                </td>
                                <td>
                                    <div class="col-12">
                                        <asp:LinkButton ID="lnkDGSetInvoice" runat="server" AutoPostBack="true" OnClick="lnkDocument_Click" Text="Open Document" />

                                    </div>
                                </td>
                                 <td>
                                     <asp:FileUpload runat="server" ID="fileUpload8" />
                                </td>
                            </tr>
                            <tr id="Tr10" runat="server" visible="true">
                                <td>
                                    <div class="col-12">
                                        Manufacturing test certificate of DG set
                                                        <samp style="color: red">* </samp>
                                    </div>
                                </td>
                                <td>
                                    <div class="col-12">
                                        <asp:LinkButton ID="lnkManufacturingCertificate" runat="server" AutoPostBack="true" OnClick="lnkDocument_Click" Text="Open Document" />

                                    </div>
                                </td>
                                 <td>
                                     <asp:FileUpload runat="server" ID="fileUpload9" />
                                </td>
                            </tr>
                            <tr id="Tr13" runat="server" visible="true">
                                <td>
                                    <div class="col-12">
                                        Invoice Of fire Extinguisher/apparatus installed at the site<samp style="color: red"> * </samp>
                                    </div>
                                </td>
                                <td>
                                    <div class="col-12">
                                        <asp:LinkButton ID="lnkInvoice" runat="server" AutoPostBack="true" OnClick="lnkDocument_Click" Text="Open Document" />
                                    </div>
                                </td>
                                 <td>
                                     <asp:FileUpload runat="server" ID="fileUpload10" />
                                </td>
                            </tr>
                            <tr id="Tr11" runat="server" visible="true">
                                <td>
                                    <div class="col-12">
                                        Structure stability report issued by authorized engineer<samp style="color: red"> * </samp>
                                    </div>
                                </td>
                                <td>
                                    <div class="col-12">
                                        <asp:LinkButton ID="lnkStructure" runat="server" AutoPostBack="true" OnClick="lnkDocument_Click" Text="Open Document" />
                                    </div>
                                </td>
                                 <td>
                                     <asp:FileUpload runat="server" ID="fileUpload11" />
                                </td>
                            </tr>
                        </div>

                        <tr id="LinePersonal" runat="server" visible="false">
                            <td>
                                <div class="col-12">
                                    Demand Notice<samp style="color: red"> * </samp>
                                </div>
                            </td>
                            <td>
                                <div class="col-12">
                                    <asp:LinkButton ID="lnkDocument" runat="server" AutoPostBack="true" onclick="lnkDocument_Click" Text="Open Document" />

                                </div>
                            </td>
                        </tr>
                    </tbody>
                </table>
            </div>
        </div>
        <div class="row">
            <div class="col-4">
                  <asp:TextBox class="form-control" Visible="false" ID="txtTestReportId" ReadOnly="true" autocomplete="off" TabIndex="7" runat="server" Style="margin-left: 18px"></asp:TextBox>

            </div>
            <div class="col-4" style="text-align: center">
              
                <asp:LinkButton ID="lnkRedirect" runat="server" AutoPostBack="true" onclick="lnkRedirect_Click" Text="View Test Report" />
            </div>
        </div>   
   
        <div class="row">
           
            <div class="col-4" id="ApprovalRequired" runat="server" visible="false">
                 <br />
                 <br />
                 <asp:DropDownList class="form-control  select-form select2" runat="server" AutoPostBack="true" ID="ddlReview" selectionmode="Multiple" Style="width: 100% !important;" OnSelectedIndexChanged="ddlReview_SelectedIndexChanged">
                                                <asp:ListItem Text="Select" Value="0"></asp:ListItem>
                                                <asp:ListItem Text="Accepted" Value="1"></asp:ListItem>
                                                <asp:ListItem Text="Rejected" Value="2"></asp:ListItem>
                                            </asp:DropDownList>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator57" ControlToValidate="ddlReview" runat="server" ForeColor="Red" InitialValue="0" ValidationGroup="Submit" ErrorMessage="Required"></asp:RequiredFieldValidator>
                                                     
            </div>
            <div class="col-4"></div>
            <div class="col-4" style="text-align: center" id="Rejection" runat="server" visible="false">
                 <label>
                                                Reason For Rejection<samp style="color: red"> * </samp>
                                            </label>
                 <asp:TextBox class="form-control" ID="txtRejected" TextMode="MultiLine" Rows="2" MaxLength="200"  autocomplete="off" TabIndex="7" runat="server" Style="margin-left: 18px"></asp:TextBox>
                   <asp:RequiredFieldValidator ID="RequiredFieldValidator60" ControlToValidate="txtRejected" runat="server" ForeColor="Red" ValidationGroup="Submit" ErrorMessage="Required"></asp:RequiredFieldValidator>
                                                          
                   </div>
        </div>
        <div class="row">
             <div class="col-4"></div>  
            <div class="col-4" style="text-align:center;">
                <asp:Button ID="btnSubmit" Text="Update" visible="false" runat="server" class="btn btn-primary mr-2" ValidationGroup="Submit" OnClick="btnSubmit_Click" />
            <asp:Button ID="btnBack" Text="Back" runat="server" Visible="false" class="btn btn-primary mr-2" OnClick="btnBack_Click" />
          
                </div>
            </div>
           
         
    </div>
         </div>

