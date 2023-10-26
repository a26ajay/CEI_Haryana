﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin_Master.Master" AutoEventWireup="true" CodeBehind="Projects.aspx.cs" Inherits="CEIHaryana.Admin.Projects" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
       <link rel="shortcut icon" type="image/png" href="/css2/style.min.css" />
    <link rel="stylesheet" href="/css2/style.css" />
    <link href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css" rel="stylesheet" id="bootstrap-css">
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/js/bootstrap.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>
    <link href="https://cdnjs.cloudflare.com/ajax/libs/select2/4.0.6-rc.0/css/select2.min.css" rel="stylesheet" />
    <script src="https://cdnjs.cloudflare.com/ajax/libs/select2/4.0.6-rc.0/js/select2.min.js"></script>
    <link href="https://cdnjs.cloudflare.com/ajax/libs/twitter-bootstrap/4.5.2/css/bootstrap.css" rel="stylesheet" />
    <link href="https://cdn.datatables.net/1.13.5/css/dataTables.bootstrap4.min.css" rel="stylesheet" />

    <script src="https://code.jquery.com/jquery-3.7.0.js"></script>
    <script src="https://cdn.datatables.net/1.13.5/js/jquery.dataTables.min.js"></script>
    <script src="https://cdn.datatables.net/1.13.5/js/dataTables.bootstrap4.min.js"></script>
    <script src="https://kit.fontawesome.com/57676f1d80.js" crossorigin="anonymous"></script>
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <style type="text/css">
        .pagination-ys {
    /*display: inline-block;*/
    padding-left: 0;
    margin: 20px 0;
    border-radius: 4px;
}
 
.pagination-ys table > tbody > tr > td {
    display: contents;
}
 
.pagination-ys table > tbody > tr > td > a,
.pagination-ys table > tbody > tr > td > span {
    position: relative;
    float: left;
    padding: 8px 12px;
    line-height: 1.42857143;
    text-decoration: none;
    color: #dd4814;
    background-color: #ffffff;
    border: 1px solid #dddddd;
    margin-left: -1px;
}
 
.pagination-ys table > tbody > tr > td > span {
    position: relative;
    float: left;
    padding: 8px 12px;
    line-height: 1.42857143;
    text-decoration: none;    
    margin-left: -1px;
    z-index: 2;
    color: #aea79f;
    background-color: #f5f5f5;
    border-color: #dddddd;
    cursor: default;
}
 
.pagination-ys table > tbody > tr > td:first-child > a,
.pagination-ys table > tbody > tr > td:first-child > span {
    margin-left: 0;
    border-bottom-left-radius: 4px;
    border-top-left-radius: 4px;
}
 
.pagination-ys table > tbody > tr > td:last-child > a,
.pagination-ys table > tbody > tr > td:last-child > span {
    border-bottom-right-radius: 4px;
    border-top-right-radius: 4px;
}
 
.pagination-ys table > tbody > tr > td > a:hover,
.pagination-ys table > tbody > tr > td > span:hover,
.pagination-ys table > tbody > tr > td > a:focus,
.pagination-ys table > tbody > tr > td > span:focus {
    color: #97310e;
    background-color: #eeeeee;
    border-color: #dddddd;
}
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="content-wrapper">
        <div class="card" style="box-shadow: rgba(149, 157, 165, 0.2) 0px 8px 24px; border-radius: 5px !important">
            <div class="card-body">
                <div class="row ">
                    <div class="col-sm-4 col-md-4">
                        <h6 class="card-title fw-semibold mb-4">
                            <asp:Label ID="lblData" runat="server"></asp:Label></h6>
                    </div>
                  <%--  <div class="col-sm-6 col-md-6"></div>
                    <div class="col-sm-2 col-md-2">
                        <asp:Button ID="btnAddnew" runat="server" class="btn btn-primary" Style="margin-left: 10px;" Text="Add New" OnClick="btnAddnew_Click" />
                    </div>--%>
                </div>
                <div class="card-body" style="box-shadow: rgba(0, 0, 0, 0.35) 0px 5px 15px; padding: 25px; margin-bottom: 25px; border-radius: 10px; margin-top: 10px;">
                    <div class="row" style="margin-bottom: -30px;">
                        <div class="col-4">
                            <div class="form-group row">
                                <label for="search" class="col-sm-3 col-form-label" style="margin-top: -6px;">Search:</label>
                                <div class="col-sm-9" style="margin-left: -35px;">
                                    <asp:TextBox ID="txtSearch" runat="server" PlaceHolder="Auto Search" class="form-control" onkeydown="return SearchOnEnter(event);" Font-Size="12px" onkeyup="Search_Gridview(this)"></asp:TextBox><br />
                                </div>
                            </div>
                        </div>
                    </div>
                    <table class="table table-responsive">
                    <asp:GridView class="table-responsive table table-striped tale-hover" ID="GridView1" runat="server" Width="100%" OnPageIndexChanging="GridView1_PageIndexChanging"
                        AutoGenerateColumns="false" OnRowCommand="GridView1_RowCommand" AllowPaging="true" PageSize="10"> 
                        <PagerStyle CssClass="pagination-ys" />
                        <Columns>
                            <asp:TemplateField HeaderText="Id" Visible="False">
                                <ItemTemplate>
                                    <asp:Label ID="lblID" runat="server" Text='<%#Eval("Id") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>

                         <%--   <asp:BoundField DataField="SNo" HeaderText="SNo">
                                <HeaderStyle HorizontalAlign="center" Width="5%" />
                                <ItemStyle HorizontalAlign="center" Width="5%" />
                            </asp:BoundField>--%>
                            <asp:TemplateField>
                                    <HeaderStyle Width="10%" />
                                    <ItemStyle Width="10%" />
                                       <HeaderTemplate>
               IntimationId
         </HeaderTemplate>
                                    <ItemTemplate>
                                      <%--  <a href="#ex1" rel="modal:open">Open Modal</a>--%>
                                    <%--     <asp:LinkButton runat="server" ID="LinkButton4" OnClientClick="return openPopup();" Text="View Details"  CommandName="Select" CommandArgument='<%#Eval("Id") %>' />--%>
 <asp:LinkButton ID="LinkButton4" runat ="server" CommandArgument=' <%#Eval("Id") %> ' CommandName ="Select" ><%#Eval("Id") %></asp:LinkButton> 
                                    </ItemTemplate>
                                </asp:TemplateField>
                            <asp:BoundField DataField="Name" HeaderText="Name">
                                <HeaderStyle HorizontalAlign="Left" Width="15%"/>
                                <ItemStyle HorizontalAlign="Left" Width="15%"/>
                                 </asp:BoundField>
                             <asp:BoundField DataField="ContactNo" HeaderText="Contact No">
                                <HeaderStyle HorizontalAlign="center" Width="12%"/>
                                <ItemStyle HorizontalAlign="center" Width="12%"/>
                            </asp:BoundField>
                        <%--     <asp:BoundField DataField="WorkDetails" HeaderText="WorkDetails">
                                <HeaderStyle HorizontalAlign="center" Width="20%"/>
                                <ItemStyle HorizontalAlign="center" Width="20%"/>
                            </asp:BoundField>--%>
                              <asp:BoundField DataField="VoltageLevel" HeaderText="Voltage Level">
                                <HeaderStyle HorizontalAlign="center" Width="12%"/>
                                <ItemStyle HorizontalAlign="center" Width="12%"/>
                            </asp:BoundField>
                            <asp:BoundField DataField="CreatedDate1" HeaderText="Request Date">
                                <HeaderStyle HorizontalAlign="center" Width="12%"/>
                                <ItemStyle HorizontalAlign="center" Width="12%"/>
                            </asp:BoundField>
                             <asp:BoundField DataField="CompletionDate1" HeaderText="Completion Date">
                                <HeaderStyle HorizontalAlign="center" Width="13%"/>
                                <ItemStyle HorizontalAlign="center" Width="13%"/>
                            </asp:BoundField>

                           <%-- <asp:TemplateField>
                                <HeaderStyle Width="10%"/>
                                <ItemStyle Width="10%"/>
                                <ItemTemplate>
                                    <asp:LinkButton runat="server" ID="LinkButton4" Style="padding: 0px 5px 0px 5px; font-size: 18px; border-radius: 3px;"
                                        Text="<i class='fa fa-edit' style='color:white !important;'></i>" CssClass='greenButton btn-primary' CommandName="Select" CommandArgument="<%# Container.DataItemIndex %>" />
                                      </ItemTemplate>
                            </asp:TemplateField>--%>
                        </Columns>
                        <FooterStyle BackColor="White" ForeColor="#000066"/>
                        <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" HorizontalAlign="Center"/>
                        <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Center" />
                        <RowStyle ForeColor="#000066" />
                        <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
                        <SortedAscendingCellStyle BackColor="#F1F1F1" />
                        <SortedAscendingHeaderStyle BackColor="#007DBB" />
                        <SortedDescendingCellStyle BackColor="#CAC9C9" />
                        <SortedDescendingHeaderStyle BackColor="#00547E" />
                    </asp:GridView>
                </table>
                        </div>
            </div>
        </div>
    </div>
     <script type="text/javascript">
           function Search_Gridview(strKey) {
               var strData = strKey.value.toLowerCase().split(" ");
               var tblData = document.getElementById("<%=GridView1.ClientID %>");
               var rowData;
               for (var i = 1; i < tblData.rows.length; i++) {
                   rowData = tblData.rows[i].innerHTML;
                   var styleDisplay = 'none';
                   for (var j = 0; j < strData.length; j++) {
                       if (rowData.toLowerCase().indexOf(strData[j]) >= 0)
                           styleDisplay = '';
                       else {
                           styleDisplay = 'none';
                           break;
                       }
                   }
                   tblData.rows[i].style.display = styleDisplay;
               }

           }
           function SearchOnEnter(event) {
               if (event.keyCode === 13) {
                   event.preventDefault(); // Prevent default form submission
                   Search_Gridview(document.getElementById('txtSearch'));
               }
           }
     </script>
</asp:Content>
