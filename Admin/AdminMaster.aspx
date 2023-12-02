﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin_Master.Master" AutoEventWireup="true" CodeBehind="AdminMaster.aspx.cs" Inherits="CEIHaryana.Admin.AdminMaster" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
    <meta name="description" content="au theme template">
    <meta name="author" content="Hau Nguyen">   
    <meta name="keywords" content="CEI cei haryana">

    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <!-- Title Page-->
    <title>Dashboard</title>

    <!-- Fontfaces CSS-->
    <link href="/Dashboard_Css/css/font-face.css" rel="stylesheet" media="all">
    <link href="/Dashboard_Css/vendor/font-awesome-4.7/css/font-awesome.min.css" rel="stylesheet" media="all">
    <link href="/Dashboard_Css/vendor/font-awesome-5/css/fontawesome-all.min.css" rel="stylesheet" media="all">
    <link href="/Dashboard_Css/vendor/mdi-font/css/material-design-iconic-font.min.css" rel="stylesheet" media="all">
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/@fortawesome/fontawesome-free@6.4.2/css/fontawesome.min.css" integrity="sha384-BY+fdrpOd3gfeRvTSMT+VUZmA728cfF9Z2G42xpaRkUGu2i3DyzpTURDo5A6CaLK" crossorigin="anonymous">
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/bootstrap-icons/1.11.2/font/bootstrap-icons.min.css" integrity="sha512-D1liES3uvDpPrgk7vXR/hR/sukGn7EtDWEyvpdLsyalQYq6v6YUsTUJmku7B4rcuQ21rf0UTksw2i/2Pdjbd3g==" crossorigin="anonymous" referrerpolicy="no-referrer" />
    <!-- Bootstrap CSS-->
    <link href="/Dashboard_Css/vendor/bootstrap-4.1/bootstrap.min.css" rel="stylesheet" media="all">

    <!-- Vendor CSS-->
    <link href="/Dashboard_Css/vendor/animsition/animsition.min.css" rel="stylesheet" media="all">
    <link href="/Dashboard_Css/vendor/bootstrap-progressbar/bootstrap-progressbar-3.3.4.min.css" rel="stylesheet" media="all">
    <link href="/Dashboard_Css/vendor/wow/animate.css" rel="stylesheet" media="all">
    <link href="/Dashboard_Css/vendor/css-hamburgers/hamburgers.min.css" rel="stylesheet" media="all">
    <link href="/Dashboard_Css/vendor/slick/slick.css" rel="stylesheet" media="all">
    <link href="/Dashboard_Css/vendor/select2/select2.min.css" rel="stylesheet" media="all">
    <link href="/Dashboard_Css/vendor/perfect-scrollbar/perfect-scrollbar.css" rel="stylesheet" media="all">
    <!-- Example using CDN -->
    <script src="https://cdn.jsdelivr.net/npm/chart.js"></script>


    <!-- Main CSS-->
    <link href="/Dashboard_Css/css/theme.css" rel="stylesheet" media="all">
    <style type="text/css">
        .overview__inner {
            margin-top: -15px;
        }

        i.bi.bi-journal-medical {
            font-size: 40px;
        }

        i.bi.bi-folder-symlink-fill {
            font-size: 40px;
        }

        i.bi.bi-file-earmark-check {
            font-size: 40px;
        }

        i.bi.bi-file-earmark-plus {
            font-size: 40px;
        }

        canvas#doughutChart {
            height: 200px !important;
            width: 525px !important;
        }

        canvas#barChart {
            height: 200px !important;
        }

        .overview-box .text span {
            font-size: 15px !important;
            color: rgba(255, 255, 255, 0.6);
        }

        .col-lg-6 {
            max-width: 47% !important;
        }

        .content-wrapper {
            padding: 0px !important;
        }

        ::before {
            color: #ffffff !important;
        }

        h2 {
            font-size: 20px !important;
            font-weight: 700 !important;
        }

        .au-card.recent-report {
            padding: 15px !important;
        }

        .au-card.chart-percent-card {
            padding: 15px !important;
        }

        .percent-chart {
            padding-top: 10px !important;
        }

        .section__content--p30 {
            padding: 0px !important;
        }

        .container, .container-fluid, .container-sm, .container-md, .container-lg, .container-xl {
            padding-right: 2px !important;
            padding-left: 2px !important;
            margin-right: auto !important;
            margin-left: auto !important;
        }

        canvas#recent-rep-chart {
            height: 160px !important;
        }

        canvas#percent-chart {
            height: 190px !important;
        }

        .icon {
            margin-top: -8px;
        }

        input#ContentPlaceHolder1_txtFirmName {
            border: none;
            background: #2d51fe;
            color: white;
            font-size: 15px;
            padding: 0px;
            margin-top: -13%;
            margin-bottom: -15px;
        }

        input#ContentPlaceHolder1_TextBox1 {
            border: none;
            background: transparent;
            color: white;
            font-size: 15px;
            padding: 0px;
            margin-top: -13%;
            margin-bottom: -15px;
        }

        input#ContentPlaceHolder1_TextBox3 {
            border: none;
            background: transparent;
            color: white;
            font-size: 15px;
            padding: 0px;
            margin-top: -13%;
            margin-bottom: -15px;
        }

        input#ContentPlaceHolder1_TextBox4 {
            border: none;
            background: transparent;
            color: white;
            font-size: 15px;
            padding: 0px;
            margin-top: -13%;
            margin-bottom: -15px;
        }

        input#ContentPlaceHolder1_TextBox2 {
            border: none;
            background: transparent;
            color: white;
            font-size: 15px;
            padding: 0px;
            margin-top: -13%;
            margin-bottom: -15px;
        }

        input#ContentPlaceHolder1_TextBox5 {
            border: none;
            background: transparent;
            color: white;
            font-size: 15px;
            padding: 0px;
            margin-top: -13%;
            margin-bottom: -15px;
        }
        input#ContentPlaceHolder1_TextBox6 {
    border: none;
    background: transparent;
    color: white;
    font-size: 15px;
    padding: 0px;
    margin-top: -13%;
    margin-bottom: -15px;
}
        input#ContentPlaceHolder1_TextBox7 {
    border: none;
    background: transparent;
    color: white;
    font-size: 15px;
    padding: 0px;
    margin-top: -13%;
    margin-bottom: -15px;
}
        input#ContentPlaceHolder1_TextBox8 {
    border: none;
    background: transparent;
    color: white;
    font-size: 15px;
    padding: 0px;
    margin-top: -13%;
    margin-bottom: -15px;
}
        input#ContentPlaceHolder1_TextBox9 {
    border: none;
    background: transparent;
    color: white;
    font-size: 15px;
    padding: 0px;
    margin-top: -13%;
    margin-bottom: -15px;
}
        input#ContentPlaceHolder1_TextBox10 {
    border: none;
    background: transparent;
    color: white;
    font-size: 15px;
    padding: 0px;
    margin-top: -13%;
    margin-bottom: -15px;
}
        input#ContentPlaceHolder1_TextBox11 {
            border: none;
            background: transparent;
            color: white;
            font-size: 15px;
            padding: 0px;
            margin-top: -13%;
            margin-bottom: -15px;
        }  
         input#ContentPlaceHolder1_TextBox12 {
     border: none;
     background: transparent;
     color: white;
     font-size: 15px;
     padding: 0px;
     margin-top: -13%;
     margin-bottom: -15px;
 }  
        input#ContentPlaceHolder1_TextBox13 {
    border: none;
    background: transparent;
    color: white;
    font-size: 15px;
    padding: 0px;
    margin-top: -13%;
    margin-bottom: -15px;
}
        input#ContentPlaceHolder1_TextBox14 {
    border: none;
    background: transparent;
    color: white;
    font-size: 15px;
    padding: 0px;
    margin-top: -13%;
    margin-bottom: -15px;
}
        input#ContentPlaceHolder1_TextBox15 {
    border: none;
    background: transparent;
    color: white;
    font-size: 15px;
    padding: 0px;
    margin-top: -13%;
    margin-bottom: -15px;
}
        input#ContentPlaceHolder1_TextBox16 {
    border: none;
    background: transparent;
    color: white;
    font-size: 15px;
    padding: 0px;
    margin-top: -13%;
    margin-bottom: -15px;
}
        input#ContentPlaceHolder1_TextBox17 {
    border: none;
    background: transparent;
    color: white;
    font-size: 15px;
    padding: 0px;
    margin-top: -13%;
    margin-bottom: -15px;
}
        input#ContentPlaceHolder1_TextBox18 {
    border: none;
    background: transparent;
    color: white;
    font-size: 15px;
    padding: 0px;
    margin-top: -13%;
    margin-bottom: -15px;
}
        input#ContentPlaceHolder1_TextBox19 {
    border: none;
    background: transparent;
    color: white;
    font-size: 15px;
    padding: 0px;
    margin-top: -13%;
    margin-bottom: -15px;
}
        input#ContentPlaceHolder1_TextBox20 {
    border: none;
    background: transparent;
    color: white;
    font-size: 15px;
    padding: 0px;
    margin-top: -13%;
    margin-bottom: -15px;
}
        input#ContentPlaceHolder1_TextBox21 {
    border: none;
    background: transparent;
    color: white;
    font-size: 15px;
    padding: 0px;
    margin-top: -13%;
    margin-bottom: -15px;
}
        input#ContentPlaceHolder1_TextBox22 {
    border: none;
    background: transparent;
    color: white;
    font-size: 15px;
    padding: 0px;
    margin-top: -13%;
    margin-bottom: -15px;
}
        input#ContentPlaceHolder1_TextBox23 {
    border: none;
    background: transparent;
    color: white;
    font-size: 15px;
    padding: 0px;
    margin-top: -13%;
    margin-bottom: -15px;
}
        input#ContentPlaceHolder1_TextBox24 {
    border: none;
    background: transparent;
    color: white;
    font-size: 15px;
    padding: 0px;
    margin-top: -13%;
    margin-bottom: -15px;
}
        input#ContentPlaceHolder1_TextBox25 {
    border: none;
    background: transparent;
    color: white;
    font-size: 15px;
    padding: 0px;
    margin-top: -13%;
    margin-bottom: -15px;
}
        input#ContentPlaceHolder1_TextBox26 {
    border: none;
    background: transparent;
    color: white;
    font-size: 15px;
    padding: 0px;
    margin-top: -13%;
    margin-bottom: -15px;
}
        input#ContentPlaceHolder1_TextBox27 {
    border: none;
    background: transparent;
    color: white;
    font-size: 15px;
    padding: 0px;
    margin-top: -13%;
    margin-bottom: -15px;
}
        input#ContentPlaceHolder1_TextBox28 {
    border: none;
    background: transparent;
    color: white;
    font-size: 15px;
    padding: 0px;
    margin-top: -13%;
    margin-bottom: -15px;
}
        input#ContentPlaceHolder1_TextBox29 {
    border: none;
    background: transparent;
    color: white;
    font-size: 15px;
    padding: 0px;
    margin-top: -13%;
    margin-bottom: -15px;
}
        .au-card.au-card--bg-blue.au-card-top-countries.m-b-40 {
    height: 280px;
}
   
     div#officers_table {
    height: 250px;
    margin-top:-10px;
}
     ::-webkit-scrollbar {
    display: none;
}
     h2.title-1.m-b-25 {
    margin-bottom: 10px;
    margin-top: 10px;
}
     input#ContentPlaceHolder1_TotalRequestRecieved{
     border: none;
    background: transparent;
    color: white;
    font-size: 13px;
    padding: 0px;
    margin-top: -7%;
    margin-bottom: -15px;
    font-weight: 700;
     }
     input#ContentPlaceHolder1_Approved_rejected
     {
     border: none;
    background: transparent;
    color: white;
    font-size: 13px;
    padding: 0px;
    margin-top: -7%;
    margin-bottom: -15px;
    font-weight: 700;
     }
     input#ContentPlaceHolder1_In_process
     {
     border: none;
    background: transparent;
    color: white;
    font-size: 13px;
    padding: 0px;
    margin-top: -7%;
    margin-bottom: -15px;
    font-weight: 700;
     }
     input#ContentPlaceHolder1_Initiated
     {
     border: none;
    background: transparent;
    color: white;
    font-size: 13px;
    padding: 0px;
    margin-top: -7%;
    margin-bottom: -15px;
    font-weight: 700;
     }
     .title-2 {
    text-transform: capitalize;
    font-weight: 400;
    font-size: 20px;
    line-height: 1;

}
     input#ContentPlaceHolder1_TextBox30{
          border: none;
    background: transparent;
    color: white;
    font-size: 13px;
    padding: 0px;
    margin-top: -7%;
    margin-bottom: -15px;
    font-weight: 700;
     }
     canvas#myDoughnutChart {
    margin-top: -50px;
}
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="content-wrapper">
        <%--<div class="main-content">--%>
        <div class="section__content section__content--p30">
            <div class="container-fluid">
                <%--<div class="row">
                        <div class="col-md-12">
                            <div class="overview-wrap">
                                <h2 class="title-1">overview</h2>
                                <button class="au-btn au-btn-icon au-btn--blue">
                                    <i class="zmdi zmdi-plus"></i>add item</button>
                            </div>
                        </div>
                    </div>--%>
                <div class="card" style="background: #f9f9f9; margin: 5px; margin-top: 10px; margin-bottom: 10px; box-shadow: rgba(0, 0, 0, 0.24) 0px 3px 8px; padding: 2px 30px 5px 30px;">
                    <div class="row m-t-25">
                        <div class="col-sm-6 col-lg-3">
                            <div class="overview-item overview-item--c1">
                                <div class="overview__inner">
                                    <div class="overview-box clearfix">
                                        <div class="icon">
                                            <i class="bi bi-file-earmark-plus"></i>
                                        </div>
                                        <div class="text">
                                          <h2>
                                              <asp:TextBox class="form-control" ID="TotalRequestRecieved" runat="server" onkeydown="return preventEnterSubmit(event)" autocomplete="off"></asp:TextBox>

                                          </h2>

                                            <span>Total Requests Recieved</span>
                                        </div>
                                    </div>
                                    <%--<div class="overview-chart">
                                        <canvas id="widgetChart1"></canvas>
                                    </div>--%>
                                </div>
                            </div>
                        </div>
                        <div class="col-sm-6 col-lg-3">
                            <div class="overview-item overview-item--c2">
                                <div class="overview__inner">
                                    <div class="overview-box clearfix">
                                        <div class="icon">
                                            <i class="bi bi-file-earmark-check"></i>
                                        </div>
                                        <div class="text">
                                           <h2><asp:TextBox class="form-control" ID="TextBox30" runat="server" onkeydown="return preventEnterSubmit(event)" autocomplete="off"></asp:TextBox></h2>

                                            <span>Approved/Rejected</span>
                                        </div>
                                    </div>
                                    <%--<div class="overview-chart">
                                        <canvas id="widgetChart2"></canvas>
                                    </div>--%>
                                </div>
                            </div>
                        </div>
                        <div class="col-sm-6 col-lg-3">
                            <div class="overview-item overview-item--c3">
                                <div class="overview__inner">
                                    <div class="overview-box clearfix">
                                        <div class="icon">
                                            <i class="bi bi-journal-medical"></i>
                                        </div>
                                        <div class="text">
                                          <h2>
                                              <asp:TextBox class="form-control" ID="In_process" runat="server" onkeydown="return preventEnterSubmit(event)" 
                                                  autocomplete="off"></asp:TextBox></h2>

                                            <span>In Process</span>
                                        </div>
                                    </div>
                                    <%--<div class="overview-chart">
                                        <canvas id="widgetChart3"></canvas>
                                    </div>--%>
                                </div>
                            </div>
                        </div>
                        <div class="col-sm-6 col-lg-3">
                            <div class="overview-item overview-item--c4">
                                <div class="overview__inner">
                                    <div class="overview-box clearfix">
                                        <div class="icon">
                                            <i class="bi bi-folder-symlink-fill"></i>
                                        </div>
                                        <div class="text">
                                         <h2><asp:TextBox class="form-control" ID="Initiated" runat="server" onkeydown="return preventEnterSubmit(event)" autocomplete="off"></asp:TextBox></h2>
                                        
                                            <span>Initiated</span>
                                        </div>
                                    </div>
                                    <%--<div class="overview-chart">
                                        <canvas id="widgetChart4"></canvas>
                                    </div>--%>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="card" style="background: #f9f9f9; margin: 5px; box-shadow: rgba(0, 0, 0, 0.24) 0px 3px 8px; padding: 12px;">
                    <div class="row" style="margin-left: 20px;">

                        <div class="col-lg-6">
                            <div class="au-card m-b-30">
                                <div class="au-card-inner">
                                    <h3 class="title-2 m-b-40">Pending Status(division Wise)</h3>
                                    <canvas id="myChart" width="400" height="200"></canvas>
                                </div>
                            </div>
                        </div>
                        <div class="col-lg-6" style="margin-left: 30px !important;">
                            <div class="au-card m-b-30">
                                <div class="au-card-inner">
                                    <h3 class="title-2 m-b-40">Overall Applications Representation</h3>
                                 <canvas id="myDoughnutChart" width="400" height="322"></canvas>

                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="row" style="margin-top: -20px !important;">
                        <div class="col-lg-9">
                            <h2 class="title-1 m-b-25">Division Wise Report</h2>
                            <div class="card" style="box-shadow: 0px 2px 5px 0px rgba(0, 0, 0, 0.1);">
                            <div>
                                   <asp:GridView CssClass="table-responsive table table-hover table-striped" ID="GridView1" runat="server" Width="100%" AllowPaging="true" PageSize="20" OnPageIndexChanging="GridView1_PageIndexChanging"
                        AutoGenerateColumns="false" OnRowCommand="GridView1_RowCommand" BorderWidth="1px" BorderColor="#dbddff">
                        <PagerStyle CssClass="pagination-ys" />
                        <Columns>
                            <asp:TemplateField HeaderText="SNo">
                                <HeaderStyle Width="5%" CssClass="headercolor" />
                                <ItemStyle Width="5%" />
                                <ItemTemplate>
                                    <%#Container.DataItemIndex+1 %>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField>
                                <HeaderStyle Width="34%" CssClass="headercolor" />
                                <ItemStyle Width="34%" />
                                <HeaderTemplate>
                                   Division
                                </HeaderTemplate>
                                <ItemTemplate>
                                    <asp:LinkButton ID="LinkButton4" runat="server" CommandArgument=' <%#Eval("Division") %> ' CommandName="Select"><%#Eval("Division") %></asp:LinkButton>
                                </ItemTemplate>
                            </asp:TemplateField>
                                <asp:TemplateField HeaderText="Id" Visible="False">
                                    <ItemTemplate>
                                        <asp:Label ID="lblArea" runat="server" Text='<%#Eval("Area") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                            <asp:BoundField DataField="RecordCount" HeaderText="Total Requests Received till date">
                                <HeaderStyle HorizontalAlign="Left" Width="15%" CssClass="headercolor" />
                                <ItemStyle HorizontalAlign="Left" Width="15%" />
                            </asp:BoundField>
                                 <asp:BoundField DataField="Initiated" HeaderText="Initiated">
                                <HeaderStyle HorizontalAlign="center" Width="13%" CssClass="headercolor" />
                                <ItemStyle HorizontalAlign="center" Width="13%" />
                            </asp:BoundField>
                                 <asp:BoundField DataField="InProgress" HeaderText="In Progress">
                                <HeaderStyle HorizontalAlign="center" Width="13%" CssClass="headercolor" />
                                <ItemStyle HorizontalAlign="center" Width="13%" />
                            </asp:BoundField>
                            <asp:BoundField DataField="ActionTaken" HeaderText="Action Taken">
                                <HeaderStyle HorizontalAlign="center" Width="12%" CssClass="headercolor" />
                                <ItemStyle HorizontalAlign="center" Width="12%" />
                            </asp:BoundField>
                       
                        </Columns>
                        <FooterStyle BackColor="White" ForeColor="#000066" />
                        <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" HorizontalAlign="Center" />
                        <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Center" />
                        <RowStyle ForeColor="#000066" />
                        <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
                        <SortedAscendingCellStyle BackColor="#F1F1F1" />
                        <SortedAscendingHeaderStyle BackColor="#007DBB" />
                        <SortedDescendingCellStyle BackColor="#CAC9C9" />
                        <SortedDescendingHeaderStyle BackColor="#00547E" />
                    </asp:GridView>
                            </div>
                                </div>
                        </div>
                        <div class="col-lg-3">
                            <h2 class="title-1 m-b-25">Officers Pendency</h2>
                             <div class="au-card au-card--bg-blue au-card-top-countries m-b-40" style="box-shadow: 0px 2px 5px 0px rgba(0, 0, 0, 0.1);">
                             
                                <div class="au-card-inner">
                                    <div class="table-responsive" id="officers_table">
                                        <table class="table table-top-countries">
                                            <tbody>

                                                <tr>
                                                    <td>
                                                        <h4 style="font-weight: 800;">Officer Id</h4>
                                                    </td>
                                                    <td class="text-right">
                                                        <h4 style="font-weight: 800;">Count</h4>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:TextBox class="form-control" ID="txtFirmName" runat="server" onkeydown="return preventEnterSubmit(event)" autocomplete="off"></asp:TextBox></td>
                                                    <td class="text-right">
                                                        <asp:TextBox class="form-control" ID="TextBox6" runat="server" onkeydown="return preventEnterSubmit(event)" autocomplete="off"></asp:TextBox></td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:TextBox class="form-control" ID="TextBox1" runat="server" onkeydown="return preventEnterSubmit(event)" autocomplete="off"></asp:TextBox></td>
                                                    <td class="text-right">
                                                        <asp:TextBox class="form-control" ID="TextBox7" runat="server" onkeydown="return preventEnterSubmit(event)" autocomplete="off"></asp:TextBox></td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:TextBox class="form-control" ID="TextBox3" runat="server" onkeydown="return preventEnterSubmit(event)" autocomplete="off"></asp:TextBox></td>
                                                    <td class="text-right">
                                                        <asp:TextBox class="form-control" ID="TextBox8" runat="server" onkeydown="return preventEnterSubmit(event)" autocomplete="off"></asp:TextBox></td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:TextBox class="form-control" ID="TextBox4" runat="server" onkeydown="return preventEnterSubmit(event)" autocomplete="off"></asp:TextBox></td>
                                                    <td class="text-right">
                                                        <asp:TextBox class="form-control" ID="TextBox9" runat="server" onkeydown="return preventEnterSubmit(event)" autocomplete="off"></asp:TextBox></td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:TextBox class="form-control" ID="TextBox2" runat="server" onkeydown="return preventEnterSubmit(event)" autocomplete="off"></asp:TextBox></td>
                                                    <td class="text-right">
                                                        <asp:TextBox class="form-control" ID="TextBox10" runat="server" onkeydown="return preventEnterSubmit(event)" autocomplete="off"></asp:TextBox></td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:TextBox class="form-control" ID="TextBox5" runat="server" onkeydown="return preventEnterSubmit(event)" autocomplete="off"></asp:TextBox></td>
                                                    <td class="text-right">
                                                        <asp:TextBox class="form-control" ID="TextBox11" runat="server" onkeydown="return preventEnterSubmit(event)" autocomplete="off"></asp:TextBox></td>
                                                </tr>
                                                <tr>
    <td>
        <asp:TextBox class="form-control" ID="TextBox12" runat="server" onkeydown="return preventEnterSubmit(event)" autocomplete="off"></asp:TextBox></td>
    <td class="text-right">
        <asp:TextBox class="form-control" ID="TextBox13" runat="server" onkeydown="return preventEnterSubmit(event)" autocomplete="off"></asp:TextBox></td>
</tr>
                                                <tr>
    <td>
        <asp:TextBox class="form-control" ID="TextBox14" runat="server" onkeydown="return preventEnterSubmit(event)" autocomplete="off"></asp:TextBox></td>
    <td class="text-right">
        <asp:TextBox class="form-control" ID="TextBox15" runat="server" onkeydown="return preventEnterSubmit(event)" autocomplete="off"></asp:TextBox></td>
</tr>
                                                <tr>
    <td>
        <asp:TextBox class="form-control" ID="TextBox16" runat="server" onkeydown="return preventEnterSubmit(event)" autocomplete="off"></asp:TextBox></td>
    <td class="text-right">
        <asp:TextBox class="form-control" ID="TextBox17" runat="server" onkeydown="return preventEnterSubmit(event)" autocomplete="off"></asp:TextBox></td>
</tr>
                                                <tr>
    <td>
        <asp:TextBox class="form-control" ID="TextBox18" runat="server" onkeydown="return preventEnterSubmit(event)" autocomplete="off"></asp:TextBox></td>
    <td class="text-right">
        <asp:TextBox class="form-control" ID="TextBox19" runat="server" onkeydown="return preventEnterSubmit(event)" autocomplete="off"></asp:TextBox></td>
</tr>
                                                <tr>
    <td>
        <asp:TextBox class="form-control" ID="TextBox20" runat="server" onkeydown="return preventEnterSubmit(event)" autocomplete="off"></asp:TextBox></td>
    <td class="text-right">
        <asp:TextBox class="form-control" ID="TextBox21" runat="server" onkeydown="return preventEnterSubmit(event)" autocomplete="off"></asp:TextBox></td>
</tr>
                                                <tr>
    <td>
        <asp:TextBox class="form-control" ID="TextBox22" runat="server" onkeydown="return preventEnterSubmit(event)" autocomplete="off"></asp:TextBox></td>
    <td class="text-right">
        <asp:TextBox class="form-control" ID="TextBox23" runat="server" onkeydown="return preventEnterSubmit(event)" autocomplete="off"></asp:TextBox></td>
</tr>
                                                <tr>
    <td>
        <asp:TextBox class="form-control" ID="TextBox24" runat="server" onkeydown="return preventEnterSubmit(event)" autocomplete="off"></asp:TextBox></td>
    <td class="text-right">
        <asp:TextBox class="form-control" ID="TextBox25" runat="server" onkeydown="return preventEnterSubmit(event)" autocomplete="off"></asp:TextBox></td>
</tr>
                                                <tr>
    <td>
        <asp:TextBox class="form-control" ID="TextBox26" runat="server" onkeydown="return preventEnterSubmit(event)" autocomplete="off"></asp:TextBox></td>
    <td class="text-right">
        <asp:TextBox class="form-control" ID="TextBox27" runat="server" onkeydown="return preventEnterSubmit(event)" autocomplete="off"></asp:TextBox></td>
</tr>
                                                <tr>
    <td>
        <asp:TextBox class="form-control" ID="TextBox28" runat="server" onkeydown="return preventEnterSubmit(event)" autocomplete="off"></asp:TextBox></td>
    <td class="text-right">
        <asp:TextBox class="form-control" ID="TextBox29" runat="server" onkeydown="return preventEnterSubmit(event)" autocomplete="off"></asp:TextBox></td>
</tr>
                                            </tbody>
                                        </table>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <%-- </div>--%>
        </div>
    </div>
    <script src="/Dashboard_Css/vendor/jquery-3.2.1.min.js"></script>
    <!-- Bootstrap JS-->
    <script src="/Dashboard_Css/vendor/bootstrap-4.1/popper.min.js"></script>
    <script src="/Dashboard_Css/vendor/bootstrap-4.1/bootstrap.min.js"></script>
    <!-- Vendor JS       -->
    <script src="/Dashboard_Css/vendor/slick/slick.min.js">    </script>
    <script src="/Dashboard_Css/vendor/wow/wow.min.js"></script>
    <script src="/Dashboard_Css/vendor/animsition/animsition.min.js"></script>
    <script src="/Dashboard_Css/vendor/bootstrap-progressbar/bootstrap-progressbar.min.js">    </script>
    <script src="/Dashboard_Css/vendor/counter-up/jquery.waypoints.min.js"></script>
    <script src="/Dashboard_Css/vendor/counter-up/jquery.counterup.min.js">    </script>
    <script src="/Dashboard_Css/vendor/circle-progress/circle-progress.min.js"></script>
    <script src="/Dashboard_Css/vendor/perfect-scrollbar/perfect-scrollbar.js"></script>
    <script src="/Dashboard_Css/vendor/chartjs/Chart.bundle.min.js"></script>
    <script src="/Dashboard_Css/vendor/select2/select2.min.js">    </script>

    <!-- Main JS-->
    <script src="/Dashboard_Css/js/main.js"></script>
    
    
</asp:Content>
