﻿<%@ Page Title="" Language="C#" MasterPageFile="~/SiteOwnerPages/SiteOwner.Master" AutoEventWireup="true" CodeBehind="TestReportData.aspx.cs" Inherits="CEIHaryana.SiteOwnerPages.TestReportData" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
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
                  <div class="col-sm-6 col-md-6"></div>                 
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
                       <asp:GridView class="table-responsive" ID="GridView1" runat="server" Width="100%"
                            AutoGenerateColumns="false" OnRowCommand="GridView1_RowCommand" AllowPaging="true"
                           PageSize="20" OnPageIndexChanging="GridView1_PageIndexChanging">
                            <Columns>
                                <asp:TemplateField HeaderText="Id" Visible="False">
                                    <ItemTemplate>
                                        <asp:Label ID="lblID" runat="server" Text='<%#Eval("ID") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField> 
                                <asp:TemplateField HeaderText="Id" Visible="False">
                                    <ItemTemplate>
                                        <asp:Label ID="lblIntimationId" runat="server" Text='<%#Eval("IntimationId") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                 <asp:TemplateField HeaderText="Id" Visible="False">
                                    <ItemTemplate>
                                        <asp:Label ID="lblInspectionType" runat="server" Text='<%#Eval("Premises") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Id" Visible="False">
                                    <ItemTemplate>
                                        <asp:Label ID="lblApplicantType" runat="server" Text='<%#Eval("ApplicantType") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Id" Visible="False">
                                    <ItemTemplate>
                                        <asp:Label ID="lblVoltage" runat="server" Text='<%#Eval("Voltage") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Id" Visible="False">
                                    <ItemTemplate>
                                        <asp:Label ID="lblDistrict" runat="server" Text='<%#Eval("DistrictId") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField>
                                    <HeaderStyle Width="10%" />
                                    <ItemStyle Width="10%" />
                                    <HeaderTemplate>
                                        TestReportId
                                    </HeaderTemplate>
                                    <ItemTemplate>
                                        <asp:LinkButton ID="LinkButton4" runat="server" CommandArgument=' <%#Eval("LineID") %> ' CommandName="Select"><%#Eval("LineId") %></asp:LinkButton>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:BoundField DataField="LineVoltage" HeaderText="LineVoltage">
                                    <HeaderStyle HorizontalAlign="Left" Width="15%" />
                                    <ItemStyle HorizontalAlign="Left" Width="15%" />
                                </asp:BoundField>
                                <asp:BoundField DataField="LineLength" HeaderText="LineLength">
                                    <HeaderStyle HorizontalAlign="center" Width="12%" />
                                    <ItemStyle HorizontalAlign="center" Width="12%" />
                                </asp:BoundField>
                                <asp:BoundField DataField="LineType" HeaderText="LineType">
                                    <HeaderStyle HorizontalAlign="center" Width="15%" />
                                    <ItemStyle HorizontalAlign="center" Width="15%" />
                                </asp:BoundField>
                                <asp:BoundField DataField="NmbrofEarthing" HeaderText="Number Of Earthing">
                                    <HeaderStyle HorizontalAlign="center" Width="15%" />
                                    <ItemStyle HorizontalAlign="center" Width="15%" />
                                </asp:BoundField>

                         <%--       <asp:BoundField DataField="CompletionDate1" HeaderText="Completion Date">
                                    <HeaderStyle HorizontalAlign="center" Width="13%" />
                                    <ItemStyle HorizontalAlign="center" Width="13%" />
                                </asp:BoundField>--%>

                                <asp:TemplateField>
                                    <HeaderStyle Width="10%" />
                                    <ItemStyle Width="10%" />
                                    <ItemTemplate>
                                      </ItemTemplate>
                                </asp:TemplateField>
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

  </div>
  <footer class="footer">
  </footer>
  <script>
      new DataTable('#example');
  </script>
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
