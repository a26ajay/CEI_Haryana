﻿<%@ Page Language="C#" AutoEventWireup="true"  MasterPageFile="~/UserPages/Registration.Master" EnableEventValidation="false" CodeBehind="Qualification.aspx.cs" Inherits="CEIHaryana.UserPages.Qualification" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <title></title>
    <meta content="" name="keywords" />
    <!-- Favicons -->
    <link href="assetsnew/img/favicon.png" rel="icon" />
    <link href="assetsnew/img/apple-touch-icon.png" rel="apple-touch-icon" />
    <!-- Google Fonts -->
    <link
        href="https://fonts.googleapis.com/css?family=Open+Sans:300,300i,400,400i,600,600i,700,700i|Roboto:300,300i,400,400i,500,500i,600,600i,700,700i|Poppins:300,300i,400,400i,500,500i,600,600i,700,700i"
        rel="stylesheet" />
    <!-- Vendor CSS Files -->
    
    <!-- Template Main CSS File -->
    <link href="/assetsnew/css/style.css" rel="stylesheet" />
    <link href="/assetsnew/css/style2.css" rel="stylesheet" />
    <link rel="stylesheet" href="/vendors/feather/feather.css" />
    <link rel="stylesheet" href="/vendors/ti-icons/css/themify-icons.css" />
    <link rel="stylesheet" href="/vendors/css/vendor.bundle.base.css" />
    <!-- endinject -->
    <!-- Plugin css for this page -->
  
    <!-- End plugin css for this page -->
    <!-- inject:css -->
    <link rel="stylesheet" href="/css/vertical-layout-light/style.css" />
    <!-- endinject -->
    <link rel="shortcut icon" href="/images/favicon.png" />
    <script>
        function off() {
            document.getElementById("hidethis").style.display = 'none';
        }
        function on() {
            document.getElementById("hidethis").style.display = '';
        }
    </script>
    <style>
     
        img {
    margin-bottom: 20px !important;
    margin-top: 10px;
}
        img#ProfilePhoto {
            height: 100px;
            width: 100px;
            box-shadow: rgba(99, 99, 99, 0.2) 0px 2px 8px 0
        }

        input.form-control.file-upload-info {
            height: 1px;
        }

        input#exampleInputUsername1 {
            height: 1px;
            width: 50%;
            box-shadow: rgba(99, 99, 99, 0.2) 0px 2px 8px 0px;
        }

            input#exampleInputUsername1:hover {
                height: 1px;
                width: 90%;
                box-shadow: rgba(0, 0, 0, 0.24) 0px 3px 8px;
            }

            input#exampleInputUsername1:focus {
                height: 1px;
                width: 90%;
                box-shadow: rgba(0, 0, 0, 0.24) 0px 3px 8px;
                background: #f3f3f3;
            }

        input#exampleInputEmail1 {
            height: 1px;
            width: 90%;
            box-shadow: rgba(99, 99, 99, 0.2) 0px 2px 8px 0px;
        }

            input#exampleInputEmail1:hover {
                height: 1px;
                width: 90%;
                box-shadow: rgba(0, 0, 0, 0.24) 0px 3px 8px;
            }

            input#exampleInputEmail1:focus {
                height: 1px;
                width: 90%;
                box-shadow: rgba(0, 0, 0, 0.24) 0px 3px 8px;
                background: #f3f3f3;
            }

        select#exampleFormControlSelect3 {
            height: 1px;
            width: 90%;
            box-shadow: rgba(99, 99, 99, 0.2) 0px 2px 8px 0px;
        }

            select#exampleFormControlSelect3:hover {
                height: 1px;
                width: 90%;
                box-shadow: rgba(0, 0, 0, 0.24) 0px 3px 8px;
            }

            select#exampleFormControlSelect3:focus {
                height: 1px;
                width: 90%;
                box-shadow: rgba(0, 0, 0, 0.24) 0px 3px 8px;
                background: #f3f3f3;
            }

        input.form-control {
            height: 1px;
            width: 100% !important;
            box-shadow: rgba(99, 99, 99, 0.2) 0px 2px 8px 0px;
            padding: 0px 0px 0px 0px;
            height: 25px !important;
            text-align: center;
        }

            input.form-control:hover {
                height: 1px;
                width: 90%;
                box-shadow: rgba(0, 0, 0, 0.24) 0px 3px 8px;
            }

            input.form-control:focus {
                height: 1px;
                width: 90%;
                box-shadow: rgba(99, 99, 99, 0.2) 0px 2px 8px 0px;
                background: #f3f3f3;
            }

        input.form-control {
            height: 1px;
            width: 90%;
            box-shadow: rgba(99, 99, 99, 0.2) 0px 2px 8px 0px;
        }

            input.form-control:hover {
                height: 1px;
                width: 90%;
                box-shadow: rgba(0, 0, 0, 0.24) 0px 3px 8px;
            }

            input.form-control:focus {
                height: 1px;
                width: 90%;
                box-shadow: rgba(99, 99, 99, 0.2) 0px 2px 8px 0px;
                background: #f3f3f3;
            }

        .table td, .jsgrid .jsgrid-table td {
            font-size: 1px;
            padding: 10px 15px 10px 15px;
        }

        select#ddlQualification {
            height: 25px;
            width: 100%;
            font-size: 13px;
            text-align: center;
            border: 1px solid #ced4da;
            border-radius: 5px;
            box-shadow: rgba(99, 99, 99, 0.2) 0px 2px 8px 0px;
        }

            select#ddlQualification:hover {
                height: 25px;
                width: 100%;
                font-size: 13px;
                text-align: center;
                border: 1px solid #ced4da;
                border-radius: 5px;
                box-shadow: rgba(0, 0, 0, 0.24) 0px 3px 8px;
            }

        select#DropDownList1 {
            height: 25px;
            width: 100%;
            font-size: 13px;
            text-align: center;
            border: 1px solid #ced4da;
            border-radius: 5px;
            box-shadow: rgba(99, 99, 99, 0.2) 0px 2px 8px 0px;
        }

            select#DropDownList1:hover {
                height: 25px;
                width: 100%;
                font-size: 13px;
                text-align: center;
                border: 1px solid #ced4da;
                border-radius: 5px;
                box-shadow: rgba(0, 0, 0, 0.24) 0px 3px 8px;
            }

             select#DropDownList2 {
     height: 25px;
     width: 100%;
     font-size: 13px;
     text-align: center;
     border: 1px solid #ced4da;
     border-radius: 5px;
     box-shadow: rgba(99, 99, 99, 0.2) 0px 2px 8px 0px;
 }

     select#DropDownList2:hover {
         height: 25px;
         width: 100%;
         font-size: 13px;
         text-align: center;
         border: 1px solid #ced4da;
         border-radius: 5px;
         box-shadow: rgba(0, 0, 0, 0.24) 0px 3px 8px;
     }

     
             select#DropDownList3 {
     height: 30px;
     width: 100%;
     font-size: 13px;
     text-align: center;
     border: 1px solid #ced4da;
     border-radius: 5px;
     box-shadow: rgba(99, 99, 99, 0.2) 0px 2px 8px 0px;
 }

     select#DropDownList3:hover {
         height: 30px;
         width: 100%;
         font-size: 13px;
         text-align: center;
         border: 1px solid #ced4da;
         border-radius: 5px;
         box-shadow: rgba(0, 0, 0, 0.24) 0px 3px 8px;
     }
             select#DropDownList4 {
     height: 30px;
     width: 100%;
     font-size: 13px;
     text-align: center;
     border: 1px solid #ced4da;
     border-radius: 5px;
     box-shadow: rgba(99, 99, 99, 0.2) 0px 2px 8px 0px;
 }

     select#DropDownList4:hover {
         height: 30px;
         width: 100%;
         font-size: 13px;
         text-align: center;
         border: 1px solid #ced4da;
         border-radius: 5px;
         box-shadow: rgba(0, 0, 0, 0.24) 0px 3px 8px;
     }





        select#ddlQualification1 {
            height: 25px;
            width: 100%;
            font-size: 13px;
            text-align: center;
            border: 1px solid #ced4da;
            border-radius: 5px;
            box-shadow: rgba(99, 99, 99, 0.2) 0px 2px 8px 0px;
        }

            select#ddlQualification1:hover {
                height: 25px;
                width: 100%;
                font-size: 13px;
                text-align: center;
                border: 1px solid #ced4da;
                border-radius: 5px;
                box-shadow: rgba(0, 0, 0, 0.24) 0px 3px 8px;
            }

        select#ddlQualification2 {
            height: 25px;
            width: 100%;
            font-size: 13px;
            text-align: center;
            border: 1px solid #ced4da;
            border-radius: 5px;
            box-shadow: rgba(99, 99, 99, 0.2) 0px 2px 8px 0px;
        }

            select#ddlQualification2:hover {
                height: 25px;
                width: 100%;
                font-size: 13px;
                text-align: center;
                border: 1px solid #ced4da;
                border-radius: 5px;
                box-shadow: rgba(0, 0, 0, 0.24) 0px 3px 8px;
            }
            .navbar .dropdown ul a:hover, .navbar .dropdown ul .active:hover, .navbar .dropdown ul li:hover>a {
    color: #106eea;
    width: 79%;
}
            .card .card-body {
    padding: 1.25rem 2.25rem;
}
    </style>

    </asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
        <asp:ScriptManager ID="ScriptManager2" runat="server"></asp:ScriptManager>
        <div>
            <!-- ======= Top Bar ======= -->
            
            <!-- ======= Header ======= -->
            
            <!-- End Header -->
            <main id="main">
                <section id="about" class="about section-bg">
                    <div class="container" data-aos="fade-up">
                        <div class="row">
                            <div class="col-md-12">
                                <p style="text-align: center; font-weight: 700; margin-top: -40px; margin-bottom: 10px;">
                                    (Please read the instructions carefully as given in Instruction
                            Page before filling the form)
                                </p>
                                <img src="/Assets/capsules/qualification.png" alt="NO IMAGE FOUND" style="width: 90%; margin-left: 5%;" />
                               
                                 <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                    <ContentTemplate>
                                <div class="card"
                                    style="box-shadow: rgba(0, 0, 0, 0.35) 0px 5px 15px; border-radius: 10px !important;">
                                    <div class="card-body">
                                        <div class="row">
                                            <div class="col-md-12">
                                                <h4 class="card-title">Qualification DETAIL</h4>
                                            </div>
                                        </div>
                                        <div class="row">
                                            <div class="table-responsive">
                                                <table class="table table-bordered">
                                                    <thead>
                                                        <tr style="text-align: center;">

                                                            <th scope="col" style="width: 20% !important;">Exam Name</th>
                                                            <th scope="col">Board/University Name</th>
                                                            <th scope="col" style="width: 0% !important;">Passing Year</th>
                                                            <th scope="col" style="width: 0% !important;">Obtained Marks&nbsp;/&nbsp;Max Marks
                                                        <%--<div class="row">
                                                            <div class="col-md-6">
                                                                <p>Obtained Marks</p>
                                                            </div>
                                                            <div class="col-md-6">
                                                                <p>Max Marks</p>
                                                            </div>
                                                        </div>--%>
                                                            </th>
                                                            <th scope="col" style="width: 10% !important;">% </th>
                                                        </tr>
                                                    </thead>
                                                    <tbody>
                                                        <tr>
                                                            <td style="text-align: center; font-size: 15px !important;">10th
                                                            </td>
                                                            <td>
                                                                <asp:TextBox class="form-control" ID="txtUniversity" runat="server" autocomplete="off"> </asp:TextBox>
                                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtUniversity"
                                                                    ErrorMessage="Please Add Your 10th Board Name" ValidationGroup="Submit" ForeColor="Red">Please Add Your 10th Board Name</asp:RequiredFieldValidator>


                                                            </td>
                                                            <td>

                                                                <asp:TextBox class="form-control" ID="txtPassingyear" type="date" runat="server" min='0000-01-01' max='9999-01-01' autocomplete="off"> </asp:TextBox>
                                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtPassingyear"
                                                                    ErrorMessage="Please Add Your 10th Passing Year" ValidationGroup="Submit" ForeColor="Red">Please Add Your 10th Passing Year</asp:RequiredFieldValidator>

                                                            </td>
                                                            <td>
                                                                <div class="row">
                                                                    <div class="col-md-6">
                                                                        <asp:TextBox class="form-control" ID="txtmarksObtained" autocomplete="off" runat="server"> </asp:TextBox>
                                                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtmarksObtained"
                                                                            ErrorMessage="Please Add Your Marks Obtained in 10th" ValidationGroup="Submit" ForeColor="Red">Please Add Your Marks Obtained in 10th</asp:RequiredFieldValidator>

                                                                    </div>
                                                                    <div class="col-md-6">
                                                                        <asp:TextBox class="form-control" ID="txtmarksmax" autocomplete="off" runat="server"> </asp:TextBox>
                                                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtmarksmax"
                                                                            ErrorMessage="Please Add Max Marks in 10th" ValidationGroup="Submit" ForeColor="Red">Please Add Max Marks in 10th</asp:RequiredFieldValidator>


                                                                    </div>
                                                                </div>

                                                            </td>
                                                            <td>
                                                                <asp:TextBox class="form-control" ID="txtprcntg" autocomplete="off" runat="server"> </asp:TextBox>
                                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtprcntg"
                                                                    ErrorMessage="Please Add Your Percentage in 10th" ValidationGroup="Submit" ForeColor="Red">Please Add Your Percentage in 10th</asp:RequiredFieldValidator>

                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                                                                <ContentTemplate>
                                                                    <td style="text-align: center;">
                                                                        <asp:DropDownList class="  select-form select2" ID="ddlQualification" runat="server" TabIndex="16" AutoPostBack="true">
                                                                            <asp:ListItem Text="Select" Value="0"></asp:ListItem>
                                                                            <asp:ListItem Text="ITI(Certificate in Wireman,Linemen)" Value="1"></asp:ListItem>
                                                                            <asp:ListItem Text="ITI(Certificate in Electrician)" Value="2"></asp:ListItem>
                                                                            <asp:ListItem Text="Diploma in  Wireman,Linemen" Value="3"></asp:ListItem>
                                                                            <asp:ListItem Text="Diploma in Electrician" Value="4"></asp:ListItem>
                                                                            <asp:ListItem Text="Diploma in Electrical Engineering" Value="5"></asp:ListItem>
                                                                            <asp:ListItem Text="Diploma in Electronics Engineering" Value="6"></asp:ListItem>
                                                                        </asp:DropDownList>
                                                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator6" Text="*Please Select Qualification*" ErrorMessage="*Please Select Qualification*" ControlToValidate="ddlQualification" runat="server" InitialValue="0" Display="Dynamic" ValidationGroup="Submit" ForeColor="Red" />

                                                                    </td>
                                                                </ContentTemplate>
                                                            </asp:UpdatePanel>
                                                            <td>
                                                                <asp:TextBox class="form-control" autocomplete="off" ID="txtUniversity1" runat="server"> </asp:TextBox>
                                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="txtUniversity1"
                                                                    ErrorMessage="Please Add Board/University Name" ValidationGroup="Submit" ForeColor="Red">Please Add Board/University Name</asp:RequiredFieldValidator>

                                                            </td>
                                                            <td>
                                                                <asp:TextBox class="form-control" autocomplete="off" type="date" min='0000-01-01' max='9999-01-01' ID="txtPassingyear1" runat="server"> </asp:TextBox>
                                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="txtPassingyear1"
                                                                    ErrorMessage="Please Add Passing Year" ValidationGroup="Submit" ForeColor="Red">Please Add Passing Year</asp:RequiredFieldValidator>

                                                            </td>
                                                            <td>
                                                                <div class="row">

                                                                    <div class="col-md-6">
                                                                        <asp:TextBox class="form-control" autocomplete="off" ID="txtmarksObtained1" runat="server"> </asp:TextBox>
                                                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ControlToValidate="txtmarksObtained1"
                                                                            ErrorMessage="Please Add Your Marks Obtained" ValidationGroup="Submit" ForeColor="Red">Please Add Your Marks Obtained </asp:RequiredFieldValidator>

                                                                    </div>
                                                                    <div class="col-md-6">
                                                                        <asp:TextBox class="form-control" autocomplete="off" ID="txtmarksmax1" runat="server"> </asp:TextBox>
                                                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" ControlToValidate="txtmarksmax1"
                                                                            ErrorMessage="Please Add Max Marks" ValidationGroup="Submit" ForeColor="Red">Please Add Max Marks </asp:RequiredFieldValidator>

                                                                    </div>
                                                                </div>
                                                            </td>
                                                            <td>
                                                                <asp:TextBox class="form-control" autocomplete="off" ID="txtprcntg1" runat="server"> </asp:TextBox>
                                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator11" runat="server" ControlToValidate="txtprcntg1"
                                                                    ErrorMessage="Please Add Your Percentage" ValidationGroup="Submit" ForeColor="Red">Please Add Your Percentage </asp:RequiredFieldValidator>

                                                            </td>
                                                        </tr>
                                                        <tr>

                                                            <td style="text-align: center;">
                                                                <asp:DropDownList class="select-form select2" ID="ddlQualification1" runat="server" TabIndex="16" AutoPostBack="true">
                                                                    <asp:ListItem Text="Select Diploma" Value="0"></asp:ListItem>
                                                                    <asp:ListItem Text="Diploma in Electrical Engineering" Value="1"></asp:ListItem>
                                                                    <asp:ListItem Text="Diploma in Electronics Engineering" Value="2"></asp:ListItem>

                                                                </asp:DropDownList>
                                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator36" InitialValue="0" runat="server" ControlToValidate="ddlQualification1"
                                                                    ErrorMessage="Please Select Diploma" ValidationGroup="Submit" ForeColor="Red">Please Select Diploma </asp:RequiredFieldValidator>
                                                            </td>
                                                            <td>
                                                                <asp:TextBox class="form-control" ID="txtUniversity2" autocomplete="off" runat="server"> </asp:TextBox>
                                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator37" runat="server" ControlToValidate="txtUniversity2"
                                                                    ErrorMessage="Please Enter University" ValidationGroup="Submit" ForeColor="Red">Please Enter University </asp:RequiredFieldValidator>
                                                            </td>
                                                            <td>
                                                                <asp:TextBox class="form-control" type="date" autocomplete="off" min='0000-01-01' max='9999-01-01' ID="txtPassingyear2" runat="server"> </asp:TextBox>
                                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator38" runat="server" ControlToValidate="txtPassingyear2"
                                                                    ErrorMessage="Please Enter Your Name" ValidationGroup="Submit" ForeColor="Red">Please Enter Passing Year </asp:RequiredFieldValidator>
                                                            </td>
                                                            <td>
                                                                <div class="row">
                                                                    <div class="col-md-6">
                                                                        <asp:TextBox class="form-control" autocomplete="off" ID="txtmarksObtained2" runat="server"> </asp:TextBox>
                                                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator39" runat="server" ControlToValidate="txtmarksObtained2"
                                                                    ErrorMessage="Please Enter Obtained Marks" ValidationGroup="Submit" ForeColor="Red">Please Enter Obtained Marks </asp:RequiredFieldValidator>
                                                                    </div>
                                                                    <div class="col-md-6">
                                                                        <asp:TextBox class="form-control" autocomplete="off" ID="txtmarksmax2" runat="server"> </asp:TextBox>
                                                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator40" runat="server" ControlToValidate="txtmarksmax2"
                                                                    ErrorMessage="Please Enter Max Marks" ValidationGroup="Submit" ForeColor="Red">Please Enter Max Marks</asp:RequiredFieldValidator>
                                                                    </div>
                                                                </div>
                                                            </td>
                                                            <td>
                                                                <asp:TextBox class="form-control" autocomplete="off" ID="txtprcntg2" runat="server"> </asp:TextBox>
                                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator41" runat="server" ControlToValidate="txtprcntg2"
                                                                    ErrorMessage="Please Add Your Percentage" ValidationGroup="Submit" ForeColor="Red">Please Add Your Percentage </asp:RequiredFieldValidator>
                                                            </td>
                                                        </tr>
                                                        <tr id="DdlDegree" runat="server" >

                                                            <td style="text-align: center;">
                                                                <asp:DropDownList class="select-form select2" ID="ddlQualification2" runat="server" TabIndex="16" AutoPostBack="true">
                                                                    <asp:ListItem Text="Select Degree" Value="0"></asp:ListItem>
                                                                    <asp:ListItem Text="Degree in Electrical Engineering" Value="1"></asp:ListItem>
                                                                    <asp:ListItem Text="Degree in Electronics Engineering" Value="2"></asp:ListItem>
                                                                </asp:DropDownList>
                                                                <asp:RequiredFieldValidator ID="requiredfeildvalid" runat="server" ControlToValidate="ddlQualification2" InitialValue="0" ForeColor="Red" ValidationGroup="Submit" ErrorMessage="Please Select Degree">Please Select Degree</asp:RequiredFieldValidator>
                                                            </td>
                                                            <td>
                                                                <asp:TextBox class="form-control" autocomplete="off" ID="txtUniversity3" runat="server"> </asp:TextBox>
                                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator31" runat="server" ControlToValidate="txtUniversity3" ForeColor="Red" ValidationGroup="Submit" ErrorMessage="Please Enter University">Please Enter University</asp:RequiredFieldValidator>
                                                          
                                                                </td>
                                                            <td>
                                                                <asp:TextBox class="form-control" autocomplete="off" type="date" min='0000-01-01' max='9999-01-01' ID="txtPassingyear3" runat="server"> </asp:TextBox>
                                                          <asp:RequiredFieldValidator ID="RequiredFieldValidator32" runat="server" ControlToValidate="txtPassingyear3" ForeColor="Red" ValidationGroup="Submit" ErrorMessage="Please Enter Passing Year">Please Enter Passing Year</asp:RequiredFieldValidator>
                                                                </td>
                                                            <td>
                                                                <div class="row">
                                                                    <div class="col-md-6">
                                                                        <asp:TextBox class="form-control" autocomplete="off" ID="txtmarksObtained3" runat="server"> </asp:TextBox>
                                                               <asp:RequiredFieldValidator ID="RequiredFieldValidator33" runat="server" ControlToValidate="txtmarksObtained3" ForeColor="Red" ValidationGroup="Submit" ErrorMessage="Please Enter Obtained Marks">Please Enter Obtained Marks</asp:RequiredFieldValidator>
                                                                        </div>
                                                                    <div class="col-md-6">
                                                                        <asp:TextBox class="form-control" autocomplete="off" ID="txtmarksmax3" runat="server"> </asp:TextBox>
                                                                  <asp:RequiredFieldValidator ID="RequiredFieldValidator34" runat="server" ControlToValidate="txtmarksmax3" ForeColor="Red" ValidationGroup="Submit" ErrorMessage="Please Enter Max Marks">Please Enter Max Marks</asp:RequiredFieldValidator>
                                                                        </div>
                                                                </div>
                                                            </td>
                                                            <td>
                                                                <asp:TextBox class="form-control" autocomplete="off" ID="txtprcntg3" runat="server"> </asp:TextBox>
                                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator30" runat="server" ControlToValidate="txtprcntg3" ForeColor="Red" ValidationGroup="Submit" ErrorMessage="Please Enter Percentage">Please Enter Percentage</asp:RequiredFieldValidator>

                                                            </td>
                                                        </tr>
                                                        <tr id="DdlMasters" visible="false" runat="server">

                                                            <td style="text-align: center;">
                                                                <asp:DropDownList class="select-form select2" ID="ddlQualification3" runat="server" TabIndex="16" AutoPostBack="true">
                                                                    <asp:ListItem Text="Select Masters" Value="0"></asp:ListItem>
                                                                    <asp:ListItem Text="Masters in Electrical Engineering" Value="1"></asp:ListItem>
                                                                    <asp:ListItem Text="Masters in Electronics Engineering" Value="2"></asp:ListItem>

                                                                </asp:DropDownList>
                                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator24" runat="server" ControlToValidate="ddlQualification3" ForeColor="Red" ValidationGroup="Submit" ErrorMessage="Please Select Master Degree">Please Select Master Degree</asp:RequiredFieldValidator>
                                                            </td>
                                                            <td>
                                                                <asp:TextBox class="form-control" autocomplete="off" ID="txtUniversity4" runat="server"> </asp:TextBox>
 <asp:RequiredFieldValidator ID="RequiredFieldValidator25" runat="server" ControlToValidate="txtUniversity4" ForeColor="Red" ValidationGroup="Submit" ErrorMessage="Please Enter University"></asp:RequiredFieldValidator>
                                                            </td>
                                                            <td>
                                                                <asp:TextBox class="form-control"  autocomplete="off" type="date" min='0000-01-01' max='9999-01-01' ID="txtPassingyear4" runat="server"> </asp:TextBox>
                                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator26" runat="server" ControlToValidate="txtPassingyear4" ForeColor="Red" ValidationGroup="Submit" ErrorMessage="Please Enter Passing Year">Please Enter Passing Year</asp:RequiredFieldValidator>
                                                            </td>
                                                            <td>
                                                                <div class="row">
                                                                    <div class="col-md-6">
                                                                        <asp:TextBox class="form-control" autocomplete="off" ID="txtmarksObtained4" runat="server"> </asp:TextBox>
 <asp:RequiredFieldValidator ID="RequiredFieldValidator27" runat="server" ControlToValidate="txtmarksObtained4" ForeColor="Red" ValidationGroup="Submit" ErrorMessage="Please Enter Obtained Marks">Please Enter Obtained Marks</asp:RequiredFieldValidator>
                                                                    </div>
                                                                    <div class="col-md-6">
                                                                        <asp:TextBox class="form-control" autocomplete="off" ID="txtmarksmax4" runat="server"> </asp:TextBox>
                                                                         <asp:RequiredFieldValidator ID="RequiredFieldValidator28" runat="server" ControlToValidate="txtmarksmax4" ForeColor="Red" ValidationGroup="Submit" ErrorMessage="Please Enter Max Marks">Please Enter Max Marks</asp:RequiredFieldValidator>
                                                                    </div>
                                                                </div>
                                                            </td>
                                                            <td>
                                                                <asp:TextBox class="form-control" autocomplete="off" ID="txtprcntg4" runat="server"> </asp:TextBox>
                                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator29" runat="server" ControlToValidate="txtprcntg4" ForeColor="Red" ValidationGroup="Submit" ErrorMessage="Please Enter Percentage">Please Enter Percentage</asp:RequiredFieldValidator>
                                                            </td>
                                                        </tr>
                                                        <tr>

                                                            <td colspan="5" style="font-size: 12px;">
                                                                <asp:Button ID="BtnAddMoreQualification" runat="server" Text="Add More" class="btn btn-primary"
                                                                    Style="padding: 10px 20px 10px 20px; border-radius: 5px;" OnClick="BtnAddMoreQualification_Click" ></asp:Button>
                                                            </td>                                                            
                                                        </tr>
                                                    </tbody>
                                                </table>

                                            </div>
                                        </div>
                                        <hr />
                                        <div class="row" style="margin-top: 15px;">
                                            <div class="col-md-10">
                                                <h4 class="card-title" style="font-size: 15px;">Whether you are holder of
                                            certificate of competency/Wireman Permit issued by any state licincing
                                            board/chief electrical inspector.</h4>
                                            </div>
                                            <div class="col-md-2">
                                                <asp:RadioButtonList ID="RadioButtonList2" AutoPostBack="true" runat="server" RepeatDirection="Horizontal" OnSelectedIndexChanged="RadioButtonList2_SelectedIndexChanged">
                                                    <asp:ListItem Text="Yes" Value="0" Selected="True"></asp:ListItem>
                                                    <asp:ListItem Text="No" Value="1"></asp:ListItem>
                                                </asp:RadioButtonList>
                                                 <asp:RequiredFieldValidator ID="RequiredFieldValidator35" runat="server" InitialValue="" ControlToValidate="RadioButtonList2" ForeColor="Red" ValidationGroup="Submit" Display="Dynamic" ErrorMessage="Please Choose Yes Or No">Please Choose Yes Or No</asp:RequiredFieldValidator>
                                            </div>
                                        </div>
                                        <div class="row" id="competency" runat="server" visible="false">
                                            <div class="table-responsive" runat="server"  >
                                                <table class="table table-bordered">
                                                    <thead>
                                                        <tr style="text-align: center;">
                                                            <th scope="col">Sno.</th>
                                                            <th scope="col">&nbsp; &nbsp; &nbsp; &nbsp; Category &nbsp;
                                                        &nbsp;&nbsp; &nbsp; </th>
                                                            <th scope="col">Permit No.</th>
                                                            <th scope="col">Issuing Authority</th>
                                                            <th scope="col">Issue Date</th>
                                                            <th scope="col">Expiry Date</th>
                                                        </tr>
                                                    </thead>
                                                    <tbody>
                                                        <tr>
                                                            <td style="text-align: center; font-size: 13px;">1
                                                            </td>
                                                            <td>
                                                                <asp:TextBox class="form-control" autocomplete="off" ID="txtCategory" runat="server"> </asp:TextBox>
                                                         <asp:RequiredFieldValidator ID="RequiredFieldValidator42" runat="server" InitialValue="" ControlToValidate="txtCategory" ForeColor="Red" ValidationGroup="Submit"  ErrorMessage="Please Enter Category">Please Enter Category</asp:RequiredFieldValidator>
                                                                </td>
                                                            <td>
                                                                <asp:TextBox class="form-control" autocomplete="off" ID="txtPermitNo" runat="server"> </asp:TextBox>
                                                          <asp:RequiredFieldValidator ID="RequiredFieldValidator43" runat="server" InitialValue="" ControlToValidate="txtPermitNo" ForeColor="Red" ValidationGroup="Submit"  ErrorMessage="Please Enter Permit No.">Please Enter Permit No.</asp:RequiredFieldValidator>
                                                                </td>
                                                            <td>
                                                                <asp:TextBox class="form-control" autocomplete="off" ID="txtIssuingAuthority" runat="server"> </asp:TextBox>
                                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator44" runat="server" InitialValue="" ControlToValidate="txtIssuingAuthority" ForeColor="Red" ValidationGroup="Submit"  ErrorMessage="Please Enter IssuingAuthority">Please Enter IssuingAuthority</asp:RequiredFieldValidator>
                                                                </td>
                                                            <td>
                                                                <asp:TextBox class="form-control" type="date" min='0000-01-01' max='9999-01-01' autocomplete="off" ID="txtIssuingDate" runat="server"> </asp:TextBox>
                                                          <asp:RequiredFieldValidator ID="RequiredFieldValidator45" runat="server" InitialValue="" ControlToValidate="txtIssuingDate" ForeColor="Red" ValidationGroup="Submit"  ErrorMessage="Please Select Issuing Date">Please Select Issuing Date</asp:RequiredFieldValidator>
                                                                </td>
                                                            <td>
                                                                <asp:TextBox class="form-control" type="date" min='0000-01-01' max='9999-01-01' autocomplete="off" ID="txtExpiryDate" runat="server"> </asp:TextBox>
                                                       <asp:RequiredFieldValidator ID="RequiredFieldValidator46" runat="server" InitialValue="" ControlToValidate="txtExpiryDate" ForeColor="Red" ValidationGroup="Submit"  ErrorMessage="Please Select Expiry Date">Please Select Expiry Date</asp:RequiredFieldValidator>
                                                                </td>
                                                        </tr>
                                                    </tbody>
                                                </table>
                                            </div>
                                        </div>
                                        <hr />
                                        <div class="row" style="margin-top: 15px;">
                                            <div class="col-md-5">
                                                <h4 class="card-title" style="font-size: 15px;">Are you Employed on Permanent
                                            Basis.</h4>
                                            </div>
                                            <div class="col-md-2">
                                                <asp:RadioButtonList ID="RadioButtonList3" runat="server" AutoPostBack="true" RepeatDirection="Horizontal" OnSelectedIndexChanged="RadioButtonList3_SelectedIndexChanged">
                                                    <asp:ListItem Text="Yes" Value="0" Selected="True"></asp:ListItem>
                                                    <asp:ListItem Text="No" Value="1"></asp:ListItem>
                                                </asp:RadioButtonList>
                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator47" runat="server" InitialValue="" ControlToValidate="RadioButtonList3" ForeColor="Red" ValidationGroup="Submit" Display="Dynamic" ErrorMessage="Please Choose Yes Or No">Please Choose Yes Or No</asp:RequiredFieldValidator>
                                            </div>
                                        </div>
                                        <div class="row" id="PermanentEmployee" runat="server">
                                            <div class="table-responsive">
                                                <table class="table table-bordered">
                                                    <thead>
                                                        <tr style="text-align: center;">
                                                            <th scope="col">Sno.</th>
                                                            <th scope="col">&nbsp; &nbsp; &nbsp; &nbsp; Name of Employer &nbsp;
                                                        &nbsp;&nbsp; &nbsp; </th>
                                                            <th scope="col">Post Description</th>
                                                            <th scope="col">From</th>
                                                            <th scope="col">To</th>
                                                        </tr>
                                                    </thead>
                                                    <tbody>
                                                        <tr>
                                                            <td style="text-align: center; font-size: 13px;">1
                                                            </td>
                                                            <td>
                                                                <asp:TextBox class="form-control" autocomplete="off" ID="txtPermanentEmployerName" runat="server"> </asp:TextBox>
                                                          <asp:RequiredFieldValidator ID="RequiredFieldValidator48" runat="server" ControlToValidate="txtPermanentEmployerName" ForeColor="Red" ValidationGroup="Submit"  ErrorMessage="Please Enter Employer Name">Please Enter Employer Name</asp:RequiredFieldValidator>
                                                                </td>
                                                            <td>
                                                                <asp:TextBox class="form-control" autocomplete="off" ID="txtPermanentDescription" runat="server"> </asp:TextBox>
                                                          <asp:RequiredFieldValidator ID="RequiredFieldValidator49" runat="server" ControlToValidate="txtPermanentDescription" ForeColor="Red" ValidationGroup="Submit"  ErrorMessage="Please Enter Employer Name">Please Enter Employer Name</asp:RequiredFieldValidator>
                                                                </td>
                                                            <td>
                                                                <asp:TextBox class="form-control" autocomplete="off" type="date" min='0000-01-01' max='9999-01-01' ID="txtPermanentFrom" runat="server"> </asp:TextBox>
                                                          <asp:RequiredFieldValidator ID="RequiredFieldValidator50" runat="server" ControlToValidate="txtPermanentFrom" ForeColor="Red" ValidationGroup="Submit"  ErrorMessage="Please Enter From Date">Please Enter From Date</asp:RequiredFieldValidator>
                                                                </td>
                                                            <td>
                                                                <asp:TextBox class="form-control" autocomplete="off" type="date" min='0000-01-01' max='9999-01-01' ID="txtPermanentTo" runat="server"> </asp:TextBox>
                                                      <asp:RequiredFieldValidator ID="RequiredFieldValidator51" runat="server" ControlToValidate="txtPermanentTo" ForeColor="Red" ValidationGroup="Submit"  ErrorMessage="Please Enter TO Date">Please Enter TO Date</asp:RequiredFieldValidator>
                                                                </td>
                                                        </tr>
                                                    </tbody>
                                                </table>
                                            </div>
                                        </div>
                                        <hr />
                                        <%-- <a href="ContractorApplicationForm.aspx">ContractorApplicationForm.aspx</a>--%>
                                        <div class="row" style="margin-top: 15px;">
                                            <div class="col-md-5">
                                                <h4 class="card-title" style="font-size: 15px;">Detail of Experience.</h4>
                                            </div>
                                        </div>
                                        <div class="row">
                                            <div class="table-responsive">
                                                <table class="table table-bordered">
                                                    <thead>
                                                        <tr style="text-align: center;">
                                                            <%--  <th scope="col">Sno.</th>--%>
                                                            <th scope="col">&nbsp; &nbsp; &nbsp; &nbsp; Experienced in &nbsp;
                                                        &nbsp;&nbsp; &nbsp; </th>
                                                            <th scope="col">&nbsp; &nbsp; &nbsp; &nbsp; Training Under &nbsp;
&nbsp;&nbsp; &nbsp; </th>
                                                            <th scope="col">&nbsp; &nbsp; &nbsp; &nbsp; Name of Employer &nbsp;
&nbsp;&nbsp; &nbsp; </th>
                                                            <th scope="col">Post Description</th>
                                                            <th scope="col">From</th>
                                                            <th scope="col">To</th>
                                                        </tr>
                                                    </thead>
                                                    <tbody>
                                                        <tr>
                                                            <%--  <td style="text-align: center; font-size: 13px;">1
                                                            </td>--%>
                                                            <td>
                                                                <asp:DropDownList class="select-form select2" ID="ddlExperiene" runat="server" TabIndex="16" AutoPostBack="true">
                                                                    <asp:ListItem Text="Select" Value="0"></asp:ListItem>
                                                                    <asp:ListItem Text="Erection" Value="1"></asp:ListItem>
                                                                    <asp:ListItem Text="Operation" Value="2"></asp:ListItem>
                                                                    <asp:ListItem Text="Maintenance of Electrical Installation" Value="3"></asp:ListItem>

                                                                </asp:DropDownList>
                                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator52" runat="server" ControlToValidate="ddlExperiene" InitialValue="0" ForeColor="Red" ValidationGroup="Submit" Display="Dynamic"  ErrorMessage="Please Select ExperienceIn"></asp:RequiredFieldValidator>
                                                            </td>
                                                            <td>
                                                                <asp:DropDownList class="select-form select2" ID="ddlTraningUnder" runat="server" TabIndex="16" AutoPostBack="true">
                                                                    <asp:ListItem Text="Select" Value="0"></asp:ListItem>
                                                                    <asp:ListItem Text="A class licensed electrical contractor" Value="0"></asp:ListItem>
                                                                    <asp:ListItem Text="Central government" Value="1"></asp:ListItem>
                                                                    <asp:ListItem Text="State government" Value="2"></asp:ListItem>
                                                                    <asp:ListItem Text="Semigovernment department/organisation" Value="2"></asp:ListItem>
                                                                </asp:DropDownList>
                                                               <%-- <asp:RequiredFieldValidator ID="RequiredFieldValidator53" runat="server" ControlToValidate="DropDownList1" InitialValue="0" ForeColor="Red" 
                                                                    ValidationGroup="Submit" Display="Dynamic"  ErrorMessage="Please Select Traning Under"></asp:RequiredFieldValidator>--%>
                                                            </td>
                                                            <td>
                                                                <asp:TextBox class="form-control" autocomplete="off" ID="txtExperienceEmployer" runat="server"> </asp:TextBox>
                                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator12" runat="server" ControlToValidate="txtExperienceEmployer"
                                                                    ErrorMessage="Please Add Employer Name" ValidationGroup="Submit" ForeColor="Red">Please Add Employer Name</asp:RequiredFieldValidator>
                                                            </td>
                                                            <td>
                                                                <asp:TextBox class="form-control" autocomplete="off" ID="txtPostDescription" runat="server"> </asp:TextBox>
                                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator13" runat="server" ControlToValidate="txtPostDescription"
                                                                    ErrorMessage="Please Add Post Description" ValidationGroup="Submit" ForeColor="Red">Please Add Post Description</asp:RequiredFieldValidator>
                                                            </td>
                                                            <td>
                                                                <asp:TextBox class="form-control" autocomplete="off" type="date" min='0000-01-01' max='9999-01-01' ID="txtExperienceFrom" runat="server"> </asp:TextBox>
                                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator14" runat="server" ControlToValidate="txtExperienceFrom"
                                                                    ErrorMessage="Please Add From Date" ValidationGroup="Submit" ForeColor="Red">Please Add From Date</asp:RequiredFieldValidator>
                                                            </td>
                                                            <td>
                                                                <asp:TextBox class="form-control" autocomplete="off" type="date" AutoPostBack="true" min='0000-01-01' max='9999-01-01' ID="txtExperienceTo"  OnTextChanged="txtTo1_TextChanged"  runat="server"> </asp:TextBox>
                                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator15" runat="server" ControlToValidate="txtExperienceTo"
                                                                    ErrorMessage="Please Add To Date" ValidationGroup="Submit" ForeColor="Red">Please Add To Date</asp:RequiredFieldValidator>
                                                            </td>
                                                        </tr>
                                                        <tr id="Experience1" runat="server" visible="false">
                                                            <%--  <td style="text-align: center; font-size: 13px;">1
    </td>--%>
                                                            <td>
                                                                <asp:DropDownList class="select-form select2" ID="ddlExperience1" runat="server" TabIndex="16" AutoPostBack="true">
                                                                    <asp:ListItem Text="Select" Value="0"></asp:ListItem>
                                                                    <asp:ListItem Text="Erection" Value="1"></asp:ListItem>
                                                                    <asp:ListItem Text="Operation" Value="2"></asp:ListItem>
                                                                    <asp:ListItem Text="Maintenance of Electrical Installation" Value="3"></asp:ListItem>

                                                                </asp:DropDownList>
                                                                 <asp:RequiredFieldValidator ID="RequiredFieldValidator54" runat="server" ControlToValidate="ddlExperience1" InitialValue="0" ForeColor="Red" 
                                                                    ValidationGroup="Submit" Display="Dynamic"  ErrorMessage="Please Select Experience1">Please Select Experience1</asp:RequiredFieldValidator>
                                                            </td>
                                                            <td>
                                                                <asp:DropDownList class="select-form select2" ID="ddlTrainingUnder1" runat="server" TabIndex="16" AutoPostBack="true">
                                                                    <asp:ListItem Text="Select" Value="0"></asp:ListItem>
                                                                    <asp:ListItem Text=" A class licensed electricalcontractor" Value="0"></asp:ListItem>
                                                                    <asp:ListItem Text="Central government" Value="1"></asp:ListItem>
                                                                    <asp:ListItem Text="State government" Value="2"></asp:ListItem>
                                                                    <asp:ListItem Text="Semigovernment department/organisation" Value="2"></asp:ListItem>
                                                                </asp:DropDownList>
<%-- <asp:RequiredFieldValidator ID="RequiredFieldValidator55" runat="server" ControlToValidate="ddlTrainingUnder" InitialValue="0" ForeColor="Red" 
                                                                    ValidationGroup="Submit" Display="Dynamic"  ErrorMessage="Please Select Traning Under "></asp:RequiredFieldValidator>--%>

                                                            </td>
                                                            <td>
                                                                <asp:TextBox class="form-control" autocomplete="off" ID="txtExperienceEmployer1" runat="server"> </asp:TextBox>
                                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator16" runat="server" ControlToValidate="txtExperienceEmployer1"
                                                                    ErrorMessage="Please Add Name" ValidationGroup="Submit" ForeColor="Red">Please Add Name</asp:RequiredFieldValidator>
                                                            </td>
                                                            <td>
                                                                <asp:TextBox class="form-control" autocomplete="off" ID="txtPostDescription1" runat="server"> </asp:TextBox>
                                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator17" runat="server" ControlToValidate="txtPostDescription1"
                                                                    ErrorMessage="Please Add Post Description" ValidationGroup="Submit" ForeColor="Red">Please Add Post Description</asp:RequiredFieldValidator>
                                                            </td>
                                                            <td>
                                                                <asp:TextBox class="form-control" autocomplete="off" type="date" min='0000-01-01' max='9999-01-01' ID="txtExperienceFrom1" runat="server"> </asp:TextBox>
                                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator18" runat="server" ControlToValidate="txtExperienceFrom1"
                                                                    ErrorMessage="Please Add From Date" ValidationGroup="Submit" ForeColor="Red">Please Add From Date</asp:RequiredFieldValidator>
                                                            </td>
                                                            <td>
                                                                <asp:TextBox class="form-control" AutoPostBack="true" autocomplete="off" type="date" min='0000-01-01' max='9999-01-01' ID="txtExperienceTo1" OnTextChanged="txtTo1_TextChanged" runat="server"> </asp:TextBox>
                                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator19" runat="server" ControlToValidate="txtExperienceTo1"
                                                                    ErrorMessage="Please Add To Date" ValidationGroup="Submit" ForeColor="Red">Please Add To Date</asp:RequiredFieldValidator>
                                                            </td>
                                                        </tr>
                                                        <tr id="Experience2" runat="server" visible="false">
                                                            <%--  <td style="text-align: center; font-size: 13px;">1
    </td>--%>
                                                            <td>
                                                                <asp:DropDownList class="select-form select2" ID="ddlExperience2" runat="server" TabIndex="16" AutoPostBack="true">
                                                                    <asp:ListItem Text="Select" Value="0"></asp:ListItem>
                                                                    <asp:ListItem Text="Erection" Value="1"></asp:ListItem>
                                                                    <asp:ListItem Text="Operation" Value="2"></asp:ListItem>
                                                                    <asp:ListItem Text="Maintenance of Electrical Installation" Value="3"></asp:ListItem>

                                                                </asp:DropDownList>
                                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator56" runat="server" ControlToValidate="ddlExperience2" InitialValue="0" ForeColor="Red" 
                                                                    ValidationGroup="Submit" Display="Dynamic"  ErrorMessage="Please Select Experience2">Please Select Experience2</asp:RequiredFieldValidator>
                                                            </td>
                                                            <td>
                                                                <asp:DropDownList class="select-form select2" ID="ddlTrainingUnder2" runat="server" TabIndex="16" AutoPostBack="true">
                                                                    <asp:ListItem Text="Select" Value="0"></asp:ListItem>
                                                                    <asp:ListItem Text="A classlicensed electricalcontractor" Value="0"></asp:ListItem>
                                                                    <asp:ListItem Text="Centralgovernment" Value="1"></asp:ListItem>
                                                                    <asp:ListItem Text="Stategovernment" Value="2"></asp:ListItem>
                                                                    <asp:ListItem Text="Semigovernment department/organisation" Value="2"></asp:ListItem>
                                                                </asp:DropDownList>
                                                               <%-- <asp:RequiredFieldValidator ID="RequiredFieldValidator57" runat="server" ControlToValidate="ddlTrainingUnder2" InitialValue="0" ForeColor="Red" 
                                                                    ValidationGroup="Submit" Display="Dynamic"  ErrorMessage="Please Select Traning Under "></asp:RequiredFieldValidator>--%>
                                                            </td>
                                                            <td>
                                                                <asp:TextBox class="form-control" autocomplete="off" ID="txtExperienceEmployer2" runat="server"> </asp:TextBox>
                                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator20" runat="server" ControlToValidate="txtExperienceEmployer2"
                                                                    ErrorMessage="Please Enter Your Name" ValidationGroup="Submit" ForeColor="Red">Please Add Name</asp:RequiredFieldValidator>
                                                            </td>
                                                            <td>
                                                                <asp:TextBox class="form-control" autocomplete="off" ID="txtPostDescription2" runat="server"> </asp:TextBox>
                                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator21" runat="server" ControlToValidate="txtPostDescription2"
                                                                    ErrorMessage="Please Add Post Description" ValidationGroup="Submit" ForeColor="Red">Please Add Post Description</asp:RequiredFieldValidator>
                                                            </td>
                                                            <td>
                                                                <asp:TextBox class="form-control" autocomplete="off" type="date" min='0000-01-01' max='9999-01-01' ID="txtExperienceFrom2" runat="server"> </asp:TextBox>
                                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator22" runat="server" ControlToValidate="txtExperienceFrom2"
                                                                    ErrorMessage="Please Add From Date" ValidationGroup="Submit" ForeColor="Red">Please Add From Date</asp:RequiredFieldValidator>
                                                            </td>
                                                            <td>
                                                                <asp:TextBox class="form-control" autocomplete="off" type="date" AutoPostBack="true" OnTextChanged="txtTo1_TextChanged" min='0000-01-01' max='9999-01-01' ID="txtExperienceTo2" runat="server"> </asp:TextBox>
                                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator23" runat="server" ControlToValidate="txtExperienceTo2"
                                                                    ErrorMessage="Please Add To Date" ValidationGroup="Submit" ForeColor="Red">Please Add To Date</asp:RequiredFieldValidator>
                                                            </td>
                                                        </tr>
                                                        <tr id="Experience3" runat="server" visible="false">
                                                            <%--  <td style="text-align: center; font-size: 13px;">1
    </td>--%>
                                                            <td>
                                                                <asp:DropDownList class="select-form select2" ID="ddlExperience3" runat="server" TabIndex="16" AutoPostBack="true">
                                                                    <asp:ListItem Text="Select" Value="0"></asp:ListItem>
                                                                    <asp:ListItem Text="Erection" Value="1"></asp:ListItem>
                                                                    <asp:ListItem Text="Operation" Value="2"></asp:ListItem>
                                                                    <asp:ListItem Text="Maintenance of Electrical Installation" Value="3"></asp:ListItem>

                                                                </asp:DropDownList>
                                                                 <asp:RequiredFieldValidator ID="RequiredFieldValidator58" runat="server" ControlToValidate="ddlExperience3" InitialValue="0" ForeColor="Red" 
                                                                    ValidationGroup="Submit" Display="Dynamic"  ErrorMessage="Please Select Experience3 "></asp:RequiredFieldValidator>
                                                            </td>
                                                            <td>
                                                                <asp:DropDownList class="select-form select2" ID="ddlTrainingUnder3" runat="server" TabIndex="16" AutoPostBack="true">
                                                                    <asp:ListItem Text="Select" Value="0"></asp:ListItem>
                                                                    <asp:ListItem Text=" A classlicensed electricalcontractor" Value="0"></asp:ListItem>
                                                                    <asp:ListItem Text="Centralgovernment" Value="1"></asp:ListItem>
                                                                    <asp:ListItem Text="Stategovernment" Value="2"></asp:ListItem>
                                                                    <asp:ListItem Text="Semigovernment department/organisation" Value="2"></asp:ListItem>
                                                                </asp:DropDownList>
                                                                 <%-- <asp:RequiredFieldValidator ID="RequiredFieldValidator59" runat="server" ControlToValidate="ddlTrainingUnder3" InitialValue="0" ForeColor="Red" 
                                                                    ValidationGroup="Submit" Display="Dynamic"  ErrorMessage="Please Select Traning Under3 "></asp:RequiredFieldValidator>--%>
                                                            </td>
                                                            <td>
                                                                <asp:TextBox class="form-control" autocomplete="off" ID="txtExperienceEmployer3" runat="server"> </asp:TextBox>
                                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator163" runat="server" ControlToValidate="txtExperienceEmployer3"
                                                                    ErrorMessage="Please Add Name" ValidationGroup="Submit" ForeColor="Red">Please Add Name</asp:RequiredFieldValidator>
                                                            </td>
                                                            <td>
                                                                <asp:TextBox class="form-control" autocomplete="off" ID="txtPostDescription3" runat="server"> </asp:TextBox>
                                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator173" runat="server" ControlToValidate="txtPostDescription3"
                                                                    ErrorMessage="Please Add Post Description" ValidationGroup="Submit" ForeColor="Red">Please Add Post Description</asp:RequiredFieldValidator>
                                                            </td>
                                                            <td>
                                                                <asp:TextBox class="form-control" autocomplete="off" type="date" min='0000-01-01' max='9999-01-01' ID="txtExperienceFrom3" runat="server"> </asp:TextBox>
                                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator183" runat="server" ControlToValidate="txtExperienceFrom3"
                                                                    ErrorMessage="Please Add From Date" ValidationGroup="Submit" ForeColor="Red">Please Add From Date</asp:RequiredFieldValidator>
                                                            </td>
                                                            <td>
                                                                <asp:TextBox class="form-control" AutoPostBack="true" autocomplete="off" type="date" min='0000-01-01' max='9999-01-01' ID="txtExperienceTo3" OnTextChanged="txtTo1_TextChanged" runat="server"> </asp:TextBox>
                                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator193" runat="server" ControlToValidate="txtExperienceTo3"
                                                                    ErrorMessage="Please Add To Date" ValidationGroup="Submit" ForeColor="Red">Please Add To Date</asp:RequiredFieldValidator>
                                                            </td>
                                                        </tr>
                                                        <tr id="Experience4" runat="server" visible="false">
                                                            <%--  <td style="text-align: center; font-size: 13px;">1
    </td>--%>
                                                            <td>
                                                                <asp:DropDownList class="select-form select2" ID="ddlExperience4" runat="server" TabIndex="16" AutoPostBack="true">
                                                                    <asp:ListItem Text="Select" Value="0"></asp:ListItem>
                                                                    <asp:ListItem Text="Erection" Value="1"></asp:ListItem>
                                                                    <asp:ListItem Text="Operation" Value="2"></asp:ListItem>
                                                                    <asp:ListItem Text="Maintenance of Electrical Installation" Value="3"></asp:ListItem>

                                                                </asp:DropDownList>
                                                                 <asp:RequiredFieldValidator ID="RequiredFieldValidator60" runat="server" ControlToValidate="ddlExperience4" InitialValue="0" ForeColor="Red" 
                                                                    ValidationGroup="Submit" Display="Dynamic"  ErrorMessage="Please Select Experience4 "></asp:RequiredFieldValidator>
                                                            </td>
                                                            <td>
                                                                <asp:DropDownList class="select-form select2" ID="ddlTrainingUnder4" runat="server" TabIndex="16" AutoPostBack="true">
                                                                    <asp:ListItem Text="Select" Value="0"></asp:ListItem>
                                                                    <asp:ListItem Text="A classlicensed electricalcontractor" Value="1"></asp:ListItem>
                                                                    <asp:ListItem Text="Centralgovernment" Value="2"></asp:ListItem>
                                                                    <asp:ListItem Text="Stategovernment" Value="3"></asp:ListItem>
                                                                    <asp:ListItem Text="Semigovernment department/organisation" Value="4"></asp:ListItem>
                                                                </asp:DropDownList>
                                                                   <%-- <asp:RequiredFieldValidator ID="RequiredFieldValidator61" runat="server" ControlToValidate="ddlTrainingUnder4" InitialValue="0" ForeColor="Red" 
                                                                    ValidationGroup="Submit" Display="Dynamic"  ErrorMessage="Please Select Traning Under4 "></asp:RequiredFieldValidator>--%>
                                                            </td>
                                                            <td>
                                                                <asp:TextBox class="form-control" autocomplete="off" ID="txtExperienceEmployer4" runat="server"> </asp:TextBox>
                                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator204" runat="server" ControlToValidate="txtExperienceEmployer4"
                                                                    ErrorMessage="Please Add Name" ValidationGroup="Submit" ForeColor="Red">Please Add Name</asp:RequiredFieldValidator>
                                                            </td>
                                                            <td>
                                                                <asp:TextBox class="form-control" autocomplete="off" ID="txtPostDescription4" runat="server"> </asp:TextBox>
                                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator241" runat="server" ControlToValidate="txtPostDescription4"
                                                                    ErrorMessage="Please Add Post Description" ValidationGroup="Submit" ForeColor="Red">Please Add Post Description</asp:RequiredFieldValidator>
                                                            </td>
                                                            <td>
                                                                <asp:TextBox class="form-control" autocomplete="off" type="date" min='0000-01-01' max='9999-01-01' ID="txtExperienceFrom4" runat="server"> </asp:TextBox>
                                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator224" runat="server" ControlToValidate="txtExperienceFrom4"
                                                                    ErrorMessage="Please Add Experience Date" ValidationGroup="Submit" ForeColor="Red">Please Add Experience Date</asp:RequiredFieldValidator>
                                                            </td>
                                                            <td>
                                                                <asp:TextBox class="form-control" autocomplete="off" type="date" AutoPostBack="true" OnTextChanged="txtTo1_TextChanged" min='0000-01-01' max='9999-01-01' ID="txtExperienceTo4" runat="server"> </asp:TextBox>
                                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator234" runat="server" ControlToValidate="txtExperienceTo4"
                                                                    ErrorMessage="Please Add Experience ToDate" ValidationGroup="Submit" ForeColor="Red">Please Add Experience ToDate</asp:RequiredFieldValidator>
                                                            </td>
                                                        </tr>

                                                        <tr>

                                                            <td colspan="4" style="font-size: 12px;">
                                                                <asp:Button ID="btnAddMore" runat="server" Text="Add More" class="btn btn-primary"
                                                                    Style="padding: 10px 20px 10px 20px; border-radius: 5px;" OnClick="btnAddMore_Click"></asp:Button>
                                                            </td>
                                                            <td colspan="2" style="font-size: 12px;">
                                                                <p style="font-size: 12px;">Total Experience:</p>
                                                                <asp:TextBox class="form-control" ReadOnly="true" autocomplete="off" ID="txtTotalExperience" runat="server"> </asp:TextBox>                                                                
                                                            </td>
                                                        </tr>
                                                    </tbody>
                                                </table>
                                            </div>
                                        </div>
                                        <hr />
                                        <div class="row" style="margin-top: 15px;">
                                            <div class="col-md-5">
                                                <h4 class="card-title" style="font-size: 15px;">Are you a Retired Engineer.</h4>
                                            </div>
                                            <div class="col-md-2">
                                                <asp:RadioButtonList ID="RadioButtonList1" runat="server" AutoPostBack="true" RepeatDirection="Horizontal" OnSelectedIndexChanged="RadioButtonList1_SelectedIndexChanged">
                                                    <asp:ListItem Text="Yes" Value="0" Selected="True"></asp:ListItem>
                                                    <asp:ListItem Text="No" Value="1"></asp:ListItem>
                                                </asp:RadioButtonList>
                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator62" runat="server" ControlToValidate="RadioButtonList1" InitialValue="" ForeColor="Red" 
                                                 ValidationGroup="Submit" Display="Dynamic"  ErrorMessage="Please Choose Yes Or No ">Please choose yes or no</asp:RequiredFieldValidator>
                                            </div>
                                        </div>
                                        <div class="row">
                                            <div class="table-responsive" id="RetiredEmployee" visible="false" runat="server">
                                                <table class="table table-bordered">
                                                    <thead>
                                                        <tr style="text-align: center;">
                                                            <th scope="col">Sno.</th>
                                                            <th scope="col">&nbsp; &nbsp; &nbsp; &nbsp; Name of Employer &nbsp;
                                                        &nbsp;&nbsp; &nbsp; </th>
                                                            <th scope="col">Post Description</th>
                                                            <th scope="col">From</th>
                                                            <th scope="col">To</th>
                                                        </tr>
                                                    </thead>
                                                    <tbody>
                                                        <tr>
                                                            <td style="text-align: center; font-size: 13px;">1
                                                            </td>
                                                            <td>
                                                                <asp:TextBox class="form-control" autocomplete="off" ID="txtEmployerName2" runat="server"> </asp:TextBox>
                                                      <asp:RequiredFieldValidator ID="RequiredFieldValidator63" runat="server" ControlToValidate="txtEmployerName2"
                                                                    ErrorMessage="Please Enter Your Name" ValidationGroup="Submit" ForeColor="Red">Please Add Employer Name </asp:RequiredFieldValidator>
                                                                </td>
                                                            <td>
                                                      
                                                                <asp:TextBox class="form-control" autocomplete="off" ID="txtDescription2" runat="server"> </asp:TextBox>
                                                       <asp:RequiredFieldValidator ID="RequiredFieldValidator64" runat="server" ControlToValidate="txtDescription2"
                                                                    ErrorMessage="Please Enter Your Name" ValidationGroup="Submit" ForeColor="Red">Please Add Description</asp:RequiredFieldValidator>
                                                                </td>
                                                            <td>
                                                                <asp:TextBox class="form-control" autocomplete="off" type="date" min='0000-01-01' max='9999-01-01' ID="txtFrom2" runat="server"> </asp:TextBox>
                                                          <asp:RequiredFieldValidator ID="RequiredFieldValidator65" runat="server" ControlToValidate="txtFrom2"
                                                                    ErrorMessage="Please Enter Your Name" ValidationGroup="Submit" ForeColor="Red">Please Add From Date</asp:RequiredFieldValidator>
                                                                </td>
                                                            <td>
                                                                <asp:TextBox class="form-control" autocomplete="off" type="date" min='0000-01-01' max='9999-01-01' ID="txtTo2" runat="server"> </asp:TextBox>
                                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator66" runat="server" ControlToValidate="txtTo2"
                                                                    ErrorMessage="Please Enter Your " ValidationGroup="Submit" ForeColor="Red">Please Add To Date</asp:RequiredFieldValidator>
                                                                </td>
                                                        </tr>
                                                    </tbody>
                                                </table>
                                            </div>
                                        </div>
                                        <div class="row" style="margin-top: 15px;">
                                            <div class="col-md-6">
                                                <asp:Button ID="btnBack" runat="server" Text="Back" class="btn btn-primary" Style="padding: 10px 20px 10px 20px; border-radius: 5px;"
                                                    OnClick="btnBack_Click"></asp:Button>
                                            </div>
                                            <div class="col-md-6" style="text-align: end;">
                                                <asp:Button ID="btnNext" runat="server" Text="Next" class="btn btn-primary" Style="padding: 10px 20px 10px 20px; border-radius: 5px;"
                                                    OnClick="btnNext_Click" ValidationGroup="Submit" ></asp:Button>

                                            </div>
                                        </div>
                                        <div class="col-4">
                                            <asp:HiddenField ID="hdnId" runat="server" />
                                        </div>
                                    </div>
                                </div>
                                <div class="col-md-1"></div>
                        </ContentTemplate>
                                     </asp:UpdatePanel>
                            </div>
                        </div>
                    </div>
                </section>
                <!-- End About Section -->
            </main>
            <!-- End #main -->
            <!-- ======= Footer ======= -->
            <footer id="footer" style="background: #d1e6ff;">
                <%--<div class="container py-4">
            <div class="copyright">
                &copy; Copyright
                <strong>
                    <span>BizLand</span>
                </strong>
                . All Rights Reserved
            </div>
            <div class="credits">
                <!-- All the links in the footer should remain intact. -->
                <!-- You can delete the links only if you purchased the pro version. -->
                <!-- Licensing information: https://bootstrapmade.com/license/ -->
                <!-- Purchase the pro version with working PHP/AJAX contact form: https://bootstrapmade.com/bizland-bootstrap-business-template/ -->
                Designed by
                <a href="https://bootstrapmade.com/">BootstrapMade</a>
            </div>
        </div>--%>
            </footer>
            <!-- End Footer -->
            <div id="preloader"></div>
            <a href="#" class="back-to-top d-flex align-items-center justify-content-center">
                <i class="bi bi-arrow-up-short"></i>
            </a>
            <script src="/assetsnew/vendor/purecounter/purecounter_vanilla.js"></script>
            <script src="/assetsnew/vendor/aos/aos.js"></script>
            <script src="/assetsnew/vendor/bootstrap/js/bootstrap.bundle.min.js"></script>
            <script src="/assetsnew/vendor/glightbox/js/glightbox.min.js"></script>
            <script src="/assetsnew/vendor/isotope-layout/isotope.pkgd.min.js"></script>
            <script src="/assetsnew/vendor/swiper/swiper-bundle.min.js"></script>
            <script src="/assetsnew/vendor/waypoints/noframework.waypoints.js"></script>
            <script src="/assetsnew/vendor/php-email-form/validate.js"></script>
            <!-- Template Main JS File -->
            <script src="/assetsnew/js/main.js"></script>
            <script src="/vendors/js/vendor.bundle.base.js"></script>
            <!-- endinject -->
            <!-- Plugin js for this page -->
            <script src="/vendors/typeahead.js/typeahead.bundle.min.js"></script>
            <script src="/vendors/select2/select2.min.js"></script>
            <!-- End plugin js for this page -->
            <!-- inject:js -->
            <script src="/js2/off-canvas.js"></script>
            <script src="/js2/hoverable-collapse.js"></script>
            <script src="/js2/template.js"></script>
            <script src="/js2/settings.js"></script>
            <script src="/js2/todolist.js"></script>
            <!-- endinject -->
            <!-- Custom js for this page-->
            <script src="/js2/file-upload.js"></script>
            <script src="/js2/typeahead.js"></script>
            <script src="/js2/select2.js"></script>
            <script type="text/javascript">
                function validateForm() {
                    var isValid = true;

                    var txtUniversity = document.getElementById('txtUniversity');
                    var txtPassingyear = document.getElementById('txtPassingyear');
                    var txtmarksObtained = document.getElementById('txtmarksObtained');
                    var txtmarksmax = document.getElementById('txtmarksmax');
                    var txtprcntg = document.getElementById('txtprcntg');
                    var txtUniversity1 = document.getElementById('txtUniversity1');
                    var txtPassingyear1 = document.getElementById('txtPassingyear1');
                    var txtmarksObtained1 = document.getElementById('txtmarksObtained1');
                    var txtmarksmax1 = document.getElementById('txtmarksmax1');
                    var txtprcntg1 = document.getElementById('txtprcntg1');
                    // Validate txtUniversity
                    if (txtUniversity.value.trim() === '') {
                        isValid = false;
                        txtUniversity.style.border = '1px solid red';
                    } else {
                        txtUniversity.style.border = '';
                    }


                    if (txtPassingyear.value.trim() === '') {
                        isValid = false;
                        txtPassingyear.style.border = '1px solid red';
                    } else {
                        txtPassingyear.style.border = '';
                    }


                    if (txtmarksObtained.value.trim() === '') {
                        isValid = false;
                        txtmarksObtained.style.border = '1px solid red';
                    } else {
                        txtmarksObtained.style.border = '';
                    }

                    if (txtmarksmax.value.trim() === '') {
                        isValid = false;
                        txtmarksmax.style.border = '1px solid red';
                    } else {
                        txtmarksmax.style.border = '';
                    }

                    if (txtprcntg.value.trim() === '') {
                        isValid = false;
                        txtprcntg.style.border = '1px solid red';
                    } else {
                        txtprcntg.style.border = '';
                    }

                    if (txtUniversity1.value.trim() === '') {
                        isValid = false;
                        txtUniversity1.style.border = '1px solid red';
                    } else {
                        txtUniversity1.style.border = '';
                    }

                    if (txtPassingyear1.value.trim() === '') {
                        isValid = false;
                        txtPassingyear1.style.border = '1px solid red';
                    } else {
                        txtPassingyear1.style.border = '';
                    }

                    if (txtmarksObtained1.value.trim() === '') {
                        isValid = false;
                        txtmarksObtained1.style.border = '1px solid red';
                    } else {
                        txtmarksObtained1.style.border = '';
                    }

                    if (txtmarksmax1.value.trim() === '') {
                        isValid = false;
                        txtmarksmax1.style.border = '1px solid red';
                    } else {
                        txtmarksmax1.style.border = '';
                    }

                    if (txtprcntg1.value.trim() === '') {
                        isValid = false;
                        txtprcntg1.style.border = '1px solid red';
                    } else {
                        txtprcntg1.style.border = '';
                    }

                    if (!isValid) {
                        alert('Please fill in all the required fields.');
                    }

                    return isValid;
                }
            </script>
        </div>

        <script src="https://code.jquery.com/jquery-2.1.3.min.js"></script>
      <script src="http://maxcdn.bootstrapcdn.com/bootstrap/3.3.1/js/bootstrap.min.js"></script>
    </asp:Content>
