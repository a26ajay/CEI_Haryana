﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Supervisor/Supervisor.Master" AutoEventWireup="true" CodeBehind="TestReportForm.aspx.cs" Inherits="CEIHaryana.Supervisor.TestReportForm" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="https://www.w3schools.com/w3css/4/w3.css">
    <style type="text/css">
        .w3-bar.w3-black {
            background-color: #263247 !important;
            border-top-right-radius: 15px;
    border-top-left-radius: 15px;
    padding: 7px 0px 7px 10px;
        }
        input#ContentPlaceHolder1_btnLondon {
    MARGIN-RIGHT: 10PX;
    border-radius:15px;
}
        input#ContentPlaceHolder1_btnParis {
    MARGIN-RIGHT: 10PX;
    border-radius:15px;
}
        input#ContentPlaceHolder1_btnTokyo {
    MARGIN-RIGHT: 10PX;
    border-radius:15px;
}
        input#ContentPlaceHolder1_btnTokyo1 {
    MARGIN-RIGHT: 10PX;
    border-radius:15px;
}
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="content-wrapper">
        <div class="card" style="box-shadow: rgba(149, 157, 165, 0.2) 0px 8px 24px; border-radius: 5px !important">
            <div class="card-body">
                <div class="row" style="margin-bottom: 30px;">
                    <div class="col-md-4"></div>
                    <div class="col-sm-4" style="text-align: center; box-shadow: rgba(0, 0, 0, 0.35) 0px 5px 15px; padding-top: 8px; padding-bottom: 8px; border-radius: 10px;">
                        <h6 class="card-title fw-semibold mb-4" style="font-weight: 700; margin-bottom: 0px !important;">TEST REPORT</h6>
                    </div>
                    <br />
                    <div class="col-md-4"></div>
                </div>
                <div class="card"  style=" box-shadow: rgba(0, 0, 0, 0.35) 0px 5px 15px;margin-bottom:20px;padding: 15px 0px 0px 20px;">
    <div class="row" style="margin-bottom: 20px;">
        <div class="col-4">
            <label>
                Installation Type
            <samp style="color: red">* </samp>
            </label>
            <asp:DropDownList class="form-control  select-form select2" TabIndex="6" runat="server" AutoPostBack="true" ID="ddlLineVoltage" selectionmode="Multiple" Style="width: 100% !important;height:30px;">
            </asp:DropDownList>
        </div>
    </div>
    </div>
                <div class="card" style=" box-shadow: rgba(0, 0, 0, 0.35) 0px 5px 15px;">
                
                    <div class="w3-bar w3-black">
                        <asp:Button ID="btnLondon" Text="LINE" runat="server" class="w3-bar-item  btn-primary" OnClick="btnLondon_Click" />
                        <asp:Button class="w3-bar-item  btn-primary" ID="btnParis" Text="TRANSFORMER" runat="server" OnClick="btnParis_Click" />
                        <asp:Button class="w3-bar-item  btn-primary" ID="btnTokyo" Text="GENERATING SET" runat="server" OnClick="btnTokyo_Click" />
                        <asp:Button class="w3-bar-item  btn-primary" ID="btnTokyo1" Text="SINGLE/THREE-PHASE" runat="server" OnClick="btnTokyo_Click" />
                    </div>
                    <div id="London" class="w3-container city" visible="false" runat="server">
                                        <div id="IfInstallationIsLine" runat="server">
                   
                   
                    <div class="card-body" style="padding: 25px; margin-bottom: 25px; border-radius: 10px; margin-top: 10px;">
                        <div>
                            <div class="row">
                                <div class="col-4">
                                    <label>
                                        Voltage of Line<samp style="color: red"> * </samp>
                                    </label>
                                    <asp:DropDownList class="form-control  select-form select2" TabIndex="6" runat="server" AutoPostBack="true" ID="DropDownList1" selectionmode="Multiple" Style="width: 100% !important;">
                                    </asp:DropDownList>
                                </div>
                                <div class="col-4" id="OtherVoltage" runat="server" visible="false">
                                    <label for="Voltage">
                                        Other Voltage 
                        <samp style="color: red">* </samp>
                                    </label>
                                    <asp:TextBox class="form-control" AutoPostBack="true" ID="TxtOthervoltage" MaxLength="10" onkeydown="return preventEnterSubmit(event)" placeholder="" autocomplete="off" TabIndex="2" runat="server" Style="margin-left: 18px"></asp:TextBox>

                                </div>
                                <div class="col-4" id="Div1" runat="server">
                                    <label for="Name">
                                        Length of Line (in KM)
                        <samp style="color: red">* </samp>
                                    </label>
                                    <asp:TextBox class="form-control" ID="txtLineLength" onkeydown="return preventEnterSubmit(event)" onkeypress="return isNumberKey(event);" MaxLength="3" placeholder="" autocomplete="off" TabIndex="2" runat="server" Style="margin-left: 18px"></asp:TextBox>

                                </div>
                                <div class="col-4">
                                    <label>
                                        Line Type
                        <samp style="color: red">* </samp>
                                    </label>
                                    <asp:DropDownList class="form-control  select-form select2" TabIndex="6" runat="server" AutoPostBack="true" ID="ddlLineType" selectionmode="Multiple" Style="width: 100% !important">
                                        <asp:ListItem Text="Select" Value=""></asp:ListItem>
                                        <asp:ListItem Text="Overhead" Value="1"></asp:ListItem>
                                        <asp:ListItem Text="Underground" Value="2"></asp:ListItem>
                                    </asp:DropDownList>
                                </div>
                            </div>
                        </div>
                        <div id="LineTypeOverhead" runat="server" visible="true">
                            <div class="row">
                                <div class="col-4">
                                    <label>
                                        No of Circuit
     <samp style="color: red">* </samp>
                                    </label>
                                    <asp:DropDownList class="form-control  select-form select2" TabIndex="6" runat="server" AutoPostBack="true" ID="ddlNmbrOfCircuit" selectionmode="Multiple" Style="width: 100% !important">
                                        <asp:ListItem Text="Select" Value=""></asp:ListItem>
                                        <asp:ListItem Text="Single" Value="1"></asp:ListItem>
                                        <asp:ListItem Text="Double" Value="2"></asp:ListItem>
                                    </asp:DropDownList>
                                </div>
                                <div class="col-4">
                                    <label>
                                        Conductor Type
     <samp style="color: red">* </samp>
                                    </label>
                                    <asp:DropDownList class="form-control  select-form select2" TabIndex="6" runat="server" AutoPostBack="true" ID="ddlConductorType" Style="width: 100% !important">

                                        <asp:ListItem Text="Select" Value=""></asp:ListItem>
                                        <asp:ListItem Text="Bare" Value="1"></asp:ListItem>
                                        <asp:ListItem Text="Cable" Value="2"></asp:ListItem>
                                    </asp:DropDownList>
                                </div>
                            </div>
                        </div>
                        <div id="OverheadBare" visible="true" runat="server">
                            <div class="row">
                                <div class="col-4">
                                    <label>
                                        Number of Pole/Tower<samp style="color: red"> * </samp>
                                    </label>
                                    <asp:TextBox class="form-control" ID="txtPoleTower" onkeydown="return preventEnterSubmit(event)" MaxLength="3" placeholder="" onkeypress="return isNumberKey(event);" autocomplete="off" TabIndex="2" runat="server" Style="margin-left: 18px"></asp:TextBox>
                                </div>
                                <div class="col-4" id="Div2" runat="server">
                                    <label for="Name">
                                        Size of Conductor( IN SQ.MM)
<samp style="color: red">* </samp>
                                    </label>
                                    <asp:TextBox class="form-control" ID="txtConductorSize" onkeydown="return preventEnterSubmit(event)" MaxLength="3" onkeypress="return isNumberKey(event);" placeholder="" autocomplete="off" TabIndex="2" runat="server" Style="margin-left: 18px"></asp:TextBox>
                                </div>
                                <div class="col-4" id="Div3" runat="server">
                                    <label for="Name">
                                        Size of Ground Wire( IN SQ.MM)	

                            <samp style="color: red">* </samp>
                                    </label>
                                    <asp:TextBox class="form-control" ID="txtGroundWireSize" onkeydown="return preventEnterSubmit(event)" MaxLength="2" onkeypress="return isNumberKey(event);" placeholder="" autocomplete="off" TabIndex="2" runat="server" Style="margin-left: 18px"></asp:TextBox>
                                </div>
                                <div class="col-4" id="Div4" runat="server">
                                    <label for="Name">
                                        Number of Railway Crossing
                            <samp style="color: red">* </samp>
                                    </label>
                                    <asp:TextBox class="form-control" ID="txtRailwayCrossingNo" onkeydown="return preventEnterSubmit(event)" MaxLength="2" onkeypress="return isNumberKey(event);" placeholder="" autocomplete="off" TabIndex="2" runat="server" Style="margin-left: 18px"></asp:TextBox>
                                </div>
                                <div class="col-4" id="Div5" runat="server">
                                    <label for="Name">
                                        Number of Road Crossing
                            <samp style="color: red">* </samp>
                                    </label>
                                    <asp:TextBox class="form-control" ID="txtRoadCrossingNo" onkeydown="return preventEnterSubmit(event)" MaxLength="2" onkeypress="return isNumberKey(event);" placeholder="" autocomplete="off" TabIndex="2" runat="server" Style="margin-left: 18px"></asp:TextBox>
                                </div>
                                <div class="col-4" id="Div6" runat="server">
                                    <label for="Name">
                                        Number of River/Canal Crossing
                            <samp style="color: red">* </samp>
                                    </label>
                                    <asp:TextBox class="form-control" ID="txtRiverCanalCrossing" onkeydown="return preventEnterSubmit(event)" MaxLength="2" onkeypress="return isNumberKey(event);" placeholder="" autocomplete="off" TabIndex="2" runat="server" Style="margin-left: 18px"></asp:TextBox>
                                </div>
                                <div class="col-4" id="Div7" runat="server">
                                    <label for="Name">
                                        Number of Power Line Crossing:	
                            <samp style="color: red">* </samp>
                                    </label>
                                    <asp:TextBox class="form-control" ID="txtPowerLineCrossing" onkeydown="return preventEnterSubmit(event)" MaxLength="2" onkeypress="return isNumberKey(event);" placeholder="" autocomplete="off" TabIndex="2" runat="server" Style="margin-left: 18px"></asp:TextBox>
                                </div>

                            </div>
                        </div>
                        <div id="OverheadCable" runat="server" visible="true">
                            <div class="row">
                                <div class="col-4">
                                    <label>
                                        Number of Pole/Tower<samp style="color: red"> * </samp>
                                    </label>
                                    <asp:TextBox class="form-control" ID="txtPoleTowerNo" onkeydown="return preventEnterSubmit(event)" onkeypress="return isNumberKey(event);" placeholder="" autocomplete="off" TabIndex="2" runat="server" Style="margin-left: 18px"></asp:TextBox>
                                </div>
                                <div class="col-4" id="Div10" runat="server">
                                    <label for="Name">
                                        Size of Conductor( IN SQ.MM)	
<samp style="color: red">* </samp>
                                    </label>
                                    <asp:TextBox class="form-control" ID="txtConductorSize1" onkeydown="return preventEnterSubmit(event)" onkeypress="return isNumberKey(event);" placeholder="" autocomplete="off" TabIndex="2" runat="server" Style="margin-left: 18px"></asp:TextBox>
                                </div>
                                <div class="col-4" id="Div11" runat="server">
                                    <label for="Name">
                                        Size of cable: (in MM sq.)
                            <samp style="color: red">* </samp>
                                    </label>
                                    <asp:TextBox class="form-control" ID="txtCableSize1" onkeydown="return preventEnterSubmit(event)" onkeypress="return isNumberKey(event);" placeholder="" autocomplete="off" TabIndex="2" runat="server" Style="margin-left: 18px"></asp:TextBox>
                                </div>
                                <div class="col-4" id="Div19" runat="server">
                                    <label for="Name">
                                        Number of Railway Crossing
                            <samp style="color: red">* </samp>
                                    </label>
                                    <asp:TextBox class="form-control" ID="txtRailwayCrossingNmbr" onkeydown="return preventEnterSubmit(event)" onkeypress="return isNumberKey(event);" placeholder="" autocomplete="off" TabIndex="2" runat="server" Style="margin-left: 18px"></asp:TextBox>
                                </div>
                                <div class="col-4" id="Div20" runat="server">
                                    <label for="Name">
                                        Number of Road Crossing
                            <samp style="color: red">* </samp>
                                    </label>
                                    <asp:TextBox class="form-control" ID="txtRoadCrossingNmbr" onkeydown="return preventEnterSubmit(event)" onkeypress="return isNumberKey(event);" placeholder="" autocomplete="off" TabIndex="2" runat="server" Style="margin-left: 18px"></asp:TextBox>
                                </div>
                                <div class="col-4" id="Div21" runat="server">
                                    <label for="Name">
                                        Number of River/Canal Crossing
                            <samp style="color: red">* </samp>
                                    </label>
                                    <asp:TextBox class="form-control" ID="txtRiverCanalCrossingNmber" onkeydown="return preventEnterSubmit(event)" onkeypress="return isNumberKey(event);" placeholder="" autocomplete="off" TabIndex="2" runat="server" Style="margin-left: 18px"></asp:TextBox>
                                </div>
                                <div class="col-4" id="Div22" runat="server">
                                    <label for="Name">
                                        Number of Power Line Crossing:	
                            <samp style="color: red">* </samp>
                                    </label>
                                    <asp:TextBox class="form-control" ID="txtPowerLineCrossingNmbr" onkeydown="return preventEnterSubmit(event)" onkeypress="return isNumberKey(event);" placeholder="" autocomplete="off" TabIndex="2" runat="server" Style="margin-left: 18px"></asp:TextBox>
                                </div>

                            </div>
                        </div>
                        <div id="Earthing" runat="server" visible="true">
                            <div class="row">
                                <div class="col-4">
                                    <label>
                                        Number of Earthing:
                            <samp style="color: red">* </samp>
                                    </label>
                                    <asp:DropDownList class="form-control  select-form select2" TabIndex="6" runat="server" AutoPostBack="true" ID="ddlNoOfEarthing" selectionmode="Multiple" Style="width: 100% !important">
                                    </asp:DropDownList>
                                </div>
                                <div id="Earthingtype1" runat="server">
                                    <div class="col-2">
                                        <label>
                                            Earthing Type
                            <samp style="color: red">* </samp>
                                        </label>
                                        <asp:DropDownList class="form-control  select-form select2" TabIndex="6" runat="server" AutoPostBack="true" ID="ddlEarthingtype1" selectionmode="Multiple" Style="width: 100% !important">
                                            <asp:ListItem Value="0" Text="Select"></asp:ListItem>
                                            <asp:ListItem Value="1" Text="Rode"></asp:ListItem>
                                            <asp:ListItem Value="1" Text="Pipe"></asp:ListItem>
                                            <asp:ListItem Value="1" Text="Plate"></asp:ListItem>
                                        </asp:DropDownList>
                                    </div>

                                    <div class="col-2">
                                        <label>
                                            Value in(ohms)
                            <samp style="color: red">* </samp>
                                        </label>
                                        <asp:TextBox class="form-control" ID="txtearthingValue1" onkeydown="return preventEnterSubmit(event)" placeholder="" autocomplete="off" TabIndex="2" runat="server" Style="margin-left: 18px"></asp:TextBox>
                                    </div>
                                </div>
                                <div id="Earthingtype2" runat="server">
                                    <div class="col-2">
                                        <label>
                                            Earthing Type
<samp style="color: red">* </samp>
                                        </label>
                                        <asp:DropDownList class="form-control  select-form select2" TabIndex="6" runat="server" AutoPostBack="true" ID="ddlEarthingtype2" selectionmode="Multiple" Style="width: 100% !important">
                                            <asp:ListItem Value="0" Text="Select"></asp:ListItem>
                                            <asp:ListItem Value="1" Text="Rode"></asp:ListItem>
                                            <asp:ListItem Value="2" Text="Pipe"></asp:ListItem>
                                            <asp:ListItem Value="3" Text="Plate"></asp:ListItem>
                                        </asp:DropDownList>
                                    </div>
                                    <div class="col-2">
                                        <label for="Name">
                                            Value in(ohms)
<samp style="color: red">* </samp>
                                        </label>
                                        <asp:TextBox class="form-control" ID="txtEarthingValue2" onkeydown="return preventEnterSubmit(event)" placeholder="" autocomplete="off" TabIndex="2" runat="server" Style="margin-left: 18px"></asp:TextBox>
                                    </div>
                                </div>

                                <div id="Earthingtype3" runat="server">
                                    <div class="col-2">
                                        <label for="Name">
                                            Earthing Type
<samp style="color: red">* </samp>
                                        </label>
                                        <asp:DropDownList class="form-control  select-form select2" TabIndex="6" runat="server" AutoPostBack="true" ID="ddlEarthingtype3" selectionmode="Multiple" Style="width: 100% !important">
                                            <asp:ListItem Value="0" Text="Select"></asp:ListItem>
                                            <asp:ListItem Value="1" Text="Rode"></asp:ListItem>
                                            <asp:ListItem Value="2" Text="Pipe"></asp:ListItem>
                                            <asp:ListItem Value="3" Text="Plate"></asp:ListItem>
                                        </asp:DropDownList>
                                    </div>
                                    <div class="col-2">
                                        <label for="Name">
                                            Value in(ohms)
<samp style="color: red">* </samp>
                                        </label>
                                        <asp:TextBox class="form-control" ID="txtEarthingValue3" onkeydown="return preventEnterSubmit(event)" placeholder="" autocomplete="off" TabIndex="2" runat="server" Style="margin-left: 18px"></asp:TextBox>
                                    </div>
                                </div>

                                <div id="Earthingtype4" runat="server">
                                    <div class="col-2">
                                        <label for="Name">
                                            Earthing Type
<samp style="color: red">* </samp>
                                        </label>
                                        <asp:DropDownList class="form-control  select-form select2" TabIndex="6" runat="server" AutoPostBack="true" ID="ddlEarthingtype4" selectionmode="Multiple" Style="width: 100% !important">
                                            <asp:ListItem Value="0" Text="Select"></asp:ListItem>
                                            <asp:ListItem Value="1" Text="Rode"></asp:ListItem>
                                            <asp:ListItem Value="2" Text="Pipe"></asp:ListItem>
                                            <asp:ListItem Value="3" Text="Plate"></asp:ListItem>
                                        </asp:DropDownList>
                                    </div>
                                    <div class="col-2">
                                        <label for="Name">
                                            Value in(ohms)
<samp style="color: red">* </samp>
                                        </label>
                                        <asp:TextBox class="form-control" ID="txtEarthingValue4" onkeydown="return preventEnterSubmit(event)" onkeypress="return isNumberKey(event);" placeholder="" autocomplete="off" TabIndex="2" runat="server" Style="margin-left: 18px"></asp:TextBox>
                                    </div>
                                </div>

                                <div id="Earthingtype5" runat="server">
                                    <div class="col-2">
                                        <label for="Name">
                                            Earthing Type
<samp style="color: red">* </samp>
                                        </label>
                                        <asp:DropDownList class="form-control  select-form select2" TabIndex="6" runat="server" AutoPostBack="true" ID="ddlEarthingtype5" selectionmode="Multiple" Style="width: 100% !important">
                                            <asp:ListItem Value="0" Text="Select"></asp:ListItem>
                                            <asp:ListItem Value="1" Text="Rode"></asp:ListItem>
                                            <asp:ListItem Value="2" Text="Pipe"></asp:ListItem>
                                            <asp:ListItem Value="3" Text="Plate"></asp:ListItem>
                                        </asp:DropDownList>
                                    </div>
                                    <div class="col-2">
                                        <label for="Name">
                                            Value in(ohms)
<samp style="color: red">* </samp>
                                        </label>
                                        <asp:TextBox class="form-control" ID="txtEarthingValue5" onkeydown="return preventEnterSubmit(event)" placeholder="" autocomplete="off" TabIndex="2" runat="server" Style="margin-left: 18px"></asp:TextBox>
                                    </div>
                                </div>

                                <div id="Earthingtype6" runat="server">
                                    <div class="col-2">
                                        <label for="Name">
                                            Earthing Type
<samp style="color: red">* </samp>
                                        </label>
                                        <asp:DropDownList class="form-control  select-form select2" TabIndex="6" runat="server" AutoPostBack="true" ID="ddlEarthingtype6" selectionmode="Multiple" Style="width: 100% !important">
                                            <asp:ListItem Value="0" Text="Select"></asp:ListItem>
                                            <asp:ListItem Value="1" Text="Rode"></asp:ListItem>
                                            <asp:ListItem Value="2" Text="Pipe"></asp:ListItem>
                                            <asp:ListItem Value="3" Text="Plate"></asp:ListItem>
                                        </asp:DropDownList>
                                    </div>
                                    <div class="col-2">
                                        <label>
                                            Value in(ohms)
<samp style="color: red">* </samp>
                                        </label>
                                        <asp:TextBox class="form-control" ID="txtEarthingValue6" onkeydown="return preventEnterSubmit(event)" onkeypress="return isNumberKey(event);" placeholder="" autocomplete="off" TabIndex="2" runat="server" Style="margin-left: 18px"></asp:TextBox>
                                    </div>
                                </div>
                                <div id="Earthingtype7" runat="server">
                                    <div class="col-2">
                                        <label>
                                            Earthing Type
<samp style="color: red">* </samp>
                                        </label>
                                        <asp:DropDownList class="form-control  select-form select2" TabIndex="6" runat="server" AutoPostBack="true" ID="ddlEarthingtype7" selectionmode="Multiple" Style="width: 100% !important">
                                            <asp:ListItem Value="0" Text="Select"></asp:ListItem>
                                            <asp:ListItem Value="1" Text="Rode"></asp:ListItem>
                                            <asp:ListItem Value="2" Text="Pipe"></asp:ListItem>
                                            <asp:ListItem Value="3" Text="Plate"></asp:ListItem>
                                        </asp:DropDownList>
                                    </div>
                                    <div class="col-2">
                                        <label for="Name">
                                            Value in(ohms)
<samp style="color: red">* </samp>
                                        </label>
                                        <asp:TextBox class="form-control" ID="txtEarthingValue7" onkeydown="return preventEnterSubmit(event)" placeholder="" autocomplete="off" TabIndex="2" runat="server" Style="margin-left: 18px"></asp:TextBox>
                                    </div>
                                </div>
                                <div id="Earthingtype8" runat="server">
                                    <div class="col-2">
                                        <label>
                                            Earthing Type
<samp style="color: red">* </samp>
                                        </label>
                                        <asp:DropDownList class="form-control  select-form select2" TabIndex="6" runat="server" AutoPostBack="true" ID="ddlEarthingtype8" selectionmode="Multiple" Style="width: 100% !important">
                                            <asp:ListItem Value="0" Text="Select"></asp:ListItem>
                                            <asp:ListItem Value="1" Text="Rode"></asp:ListItem>
                                            <asp:ListItem Value="2" Text="Pipe"></asp:ListItem>
                                            <asp:ListItem Value="3" Text="Plate"></asp:ListItem>
                                        </asp:DropDownList>
                                    </div>
                                    <div class="col-2">
                                        <label>
                                            Value in(ohms)
<samp style="color: red">* </samp>
                                        </label>
                                        <asp:TextBox class="form-control" ID="txtEarthingValue8" onkeydown="return preventEnterSubmit(event)" onkeypress="return isNumberKey(event);" placeholder="" autocomplete="off" TabIndex="2" runat="server" Style="margin-left: 18px"></asp:TextBox>
                                    </div>
                                </div>

                                <div id="Earthingtype9" runat="server">
                                    <div class="col-2">
                                        <label for="Name">
                                            Earthing Type
<samp style="color: red">* </samp>
                                        </label>
                                        <asp:DropDownList class="form-control  select-form select2" TabIndex="6" runat="server" AutoPostBack="true" ID="ddlEarthingtype9" selectionmode="Multiple" Style="width: 100% !important">
                                            <asp:ListItem Value="0" Text="Select"></asp:ListItem>
                                            <asp:ListItem Value="1" Text="Rode"></asp:ListItem>
                                            <asp:ListItem Value="2" Text="Pipe"></asp:ListItem>
                                            <asp:ListItem Value="3" Text="Plate"></asp:ListItem>
                                        </asp:DropDownList>
                                    </div>
                                    <div class="col-2">
                                        <label for="Name">
                                            Value in(ohms)
<samp style="color: red">* </samp>
                                        </label>
                                        <asp:TextBox class="form-control" ID="txtEarthingValue9" onkeydown="return preventEnterSubmit(event)" placeholder="" autocomplete="off" TabIndex="2" runat="server" Style="margin-left: 18px"></asp:TextBox>
                                    </div>
                                </div>
                                <div id="Earthingtype10" runat="server">
                                    <div class="col-2">
                                        <label>
                                            Earthing Type
<samp style="color: red">* </samp>
                                        </label>
                                        <asp:DropDownList class="form-control  select-form select2" TabIndex="6" runat="server" AutoPostBack="true" ID="ddlEarthingtype10" selectionmode="Multiple" Style="width: 100% !important">
                                            <asp:ListItem Value="0" Text="Select"></asp:ListItem>
                                            <asp:ListItem Value="1" Text="Rode"></asp:ListItem>
                                            <asp:ListItem Value="2" Text="Pipe"></asp:ListItem>
                                            <asp:ListItem Value="3" Text="Plate"></asp:ListItem>
                                        </asp:DropDownList>
                                    </div>
                                    <div class="col-2">
                                        <label>
                                            Value in(ohms)
<samp style="color: red">* </samp>
                                        </label>
                                        <asp:TextBox class="form-control" ID="txtEarthingValue10" onkeydown="return preventEnterSubmit(event)" onkeypress="return isNumberKey(event);" placeholder="" autocomplete="off" TabIndex="2" runat="server" Style="margin-left: 18px"></asp:TextBox>
                                    </div>
                                </div>
                                <div id="Earthingtype11" runat="server">
                                    <div class="col-2">
                                        <label>
                                            Earthing Type
<samp style="color: red">* </samp>
                                        </label>
                                        <asp:DropDownList class="form-control  select-form select2" TabIndex="6" runat="server" AutoPostBack="true" ID="ddlEarthingtype11" selectionmode="Multiple" Style="width: 100% !important">
                                            <asp:ListItem Value="0" Text="Select"></asp:ListItem>
                                            <asp:ListItem Value="1" Text="Rode"></asp:ListItem>
                                            <asp:ListItem Value="2" Text="Pipe"></asp:ListItem>
                                            <asp:ListItem Value="3" Text="Plate"></asp:ListItem>
                                        </asp:DropDownList>
                                    </div>
                                    <div class="col-2">
                                        <label>
                                            Value in(ohms)
<samp style="color: red">* </samp>
                                        </label>
                                        <asp:TextBox class="form-control" ID="txtEarthingValue11" onkeydown="return preventEnterSubmit(event)" placeholder="" autocomplete="off" TabIndex="2" runat="server" Style="margin-left: 18px"></asp:TextBox>
                                    </div>
                                </div>

                                <div id="Earthingtype12" runat="server">
                                    <div class="col-2">
                                        <label>
                                            Earthing Type
<samp style="color: red">* </samp>
                                        </label>
                                        <asp:DropDownList class="form-control  select-form select2" TabIndex="6" runat="server" AutoPostBack="true" ID="ddlEarthingtype12" selectionmode="Multiple" Style="width: 100% !important">
                                            <asp:ListItem Value="0" Text="Select"></asp:ListItem>
                                            <asp:ListItem Value="1" Text="Rode"></asp:ListItem>
                                            <asp:ListItem Value="2" Text="Pipe"></asp:ListItem>
                                            <asp:ListItem Value="3" Text="Plate"></asp:ListItem>
                                        </asp:DropDownList>
                                    </div>
                                    <div class="col-2">
                                        <label>
                                            Value in(ohms)
<samp style="color: red">* </samp>
                                        </label>
                                        <asp:TextBox class="form-control" ID="txtEarthingValue12" onkeydown="return preventEnterSubmit(event)" onkeypress="return isNumberKey(event);" placeholder="" autocomplete="off" TabIndex="2" runat="server" Style="margin-left: 18px"></asp:TextBox>
                                    </div>
                                </div>
                                <div id="Earthingtype13" runat="server">
                                    <div class="col-2">
                                        <label>
                                            Earthing Type
<samp style="color: red">* </samp>
                                        </label>
                                        <asp:DropDownList class="form-control  select-form select2" TabIndex="6" runat="server" AutoPostBack="true" ID="ddlEarthingtype13" selectionmode="Multiple" Style="width: 100% !important">
                                            <asp:ListItem Value="0" Text="Select"></asp:ListItem>
                                            <asp:ListItem Value="1" Text="Rode"></asp:ListItem>
                                            <asp:ListItem Value="2" Text="Pipe"></asp:ListItem>
                                            <asp:ListItem Value="3" Text="Plate"></asp:ListItem>
                                        </asp:DropDownList>
                                    </div>
                                    <div class="col-2">
                                        <label>
                                            Value in(ohms)
<samp style="color: red">* </samp>
                                        </label>
                                        <asp:TextBox class="form-control" ID="txtEarthingValue13" onkeydown="return preventEnterSubmit(event)" placeholder="" autocomplete="off" TabIndex="2" runat="server" Style="margin-left: 18px"></asp:TextBox>
                                    </div>
                                </div>
                                <div id="Earthingtype14" runat="server">
                                    <div class="col-2">
                                        <label>
                                            Earthing Type
<samp style="color: red">* </samp>
                                        </label>
                                        <asp:DropDownList class="form-control  select-form select2" TabIndex="6" runat="server" AutoPostBack="true" ID="ddlEarthingtype14" selectionmode="Multiple" Style="width: 100% !important">
                                            <asp:ListItem Value="0" Text="Select"></asp:ListItem>
                                            <asp:ListItem Value="1" Text="Rode"></asp:ListItem>
                                            <asp:ListItem Value="2" Text="Pipe"></asp:ListItem>
                                            <asp:ListItem Value="3" Text="Plate"></asp:ListItem>
                                        </asp:DropDownList>
                                    </div>
                                    <div class="col-2">
                                        <label>
                                            Value in(ohms)
<samp style="color: red">* </samp>
                                        </label>
                                        <asp:TextBox class="form-control" ID="txtEarthingValue14" onkeydown="return preventEnterSubmit(event)" onkeypress="return isNumberKey(event);" placeholder="" autocomplete="off" TabIndex="2" runat="server" Style="margin-left: 18px"></asp:TextBox>
                                    </div>
                                </div>
                                <div id="Earthingtype15" runat="server">
                                    <div class="col-2">
                                        <label>
                                            Earthing Type
<samp style="color: red">* </samp>
                                        </label>
                                        <asp:DropDownList class="form-control  select-form select2" TabIndex="6" runat="server" AutoPostBack="true" ID="ddlEarthingtype15" selectionmode="Multiple" Style="width: 100% !important">
                                            <asp:ListItem Value="0" Text="Select"></asp:ListItem>
                                            <asp:ListItem Value="1" Text="Rode"></asp:ListItem>
                                            <asp:ListItem Value="2" Text="Pipe"></asp:ListItem>
                                            <asp:ListItem Value="3" Text="Plate"></asp:ListItem>
                                        </asp:DropDownList>
                                    </div>
                                    <div class="col-2">
                                        <label>
                                            Value in(ohms)
<samp style="color: red">* </samp>
                                        </label>
                                        <asp:TextBox class="form-control" ID="txtEarthingValue15" onkeydown="return preventEnterSubmit(event)" onkeypress="return isNumberKey(event);" placeholder="" autocomplete="off" TabIndex="2" runat="server" Style="margin-left: 18px"></asp:TextBox>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div id="Insulation440vAbove" runat="server" visible="true">
                            <div class="row">
                                <div class="col-4">
                                    <label>
                                        Red Phase – Earth Wire (in Mohm)<samp style="color: red"> * </samp>
                                    </label>
                                    <asp:TextBox class="form-control" ID="txtRedEarthWire" onkeydown="return preventEnterSubmit(event)" onkeypress="return isNumberKey(event);" placeholder="" autocomplete="off" TabIndex="2" runat="server" Style="margin-left: 18px"></asp:TextBox>
                                </div>
                                <div class="col-4" id="Div32" runat="server">
                                    <label for="Name">
                                        Yellow Phase – Earth Wire (in Mohm)	

                            <samp style="color: red">* </samp>
                                    </label>
                                    <asp:TextBox class="form-control" ID="txtYellowEarthWire" onkeydown="return preventEnterSubmit(event)" onkeypress="return isNumberKey(event);" placeholder="" autocomplete="off" TabIndex="2" runat="server" Style="margin-left: 18px"></asp:TextBox>
                                </div>
                                <div class="col-4" id="Div33" runat="server">
                                    <label for="Name">
                                        Blue Phase – Earth Wire (in Mohm)	

                    <samp style="color: red">* </samp>
                                    </label>
                                    <asp:TextBox class="form-control" ID="txtBlueEarthWire" onkeydown="return preventEnterSubmit(event)" onkeypress="return isNumberKey(event);" placeholder="" autocomplete="off" TabIndex="2" runat="server" Style="margin-left: 18px"></asp:TextBox>
                                </div>
                                <div class="col-4" id="Div34" runat="server">
                                    <label for="Name">
                                        Red Phase – Yellow Phase(in Mohm)
                    <samp style="color: red">* </samp>
                                    </label>
                                    <asp:TextBox class="form-control" ID="txtRedYellowPhase" onkeydown="return preventEnterSubmit(event)" onkeypress="return isNumberKey(event);" placeholder="" autocomplete="off" TabIndex="2" runat="server" Style="margin-left: 18px"></asp:TextBox>
                                </div>
                                <div class="col-4" id="Div35" runat="server">
                                    <label for="Name">
                                        Blue Phase – Yellow Phase(in Mohm)
                    <samp style="color: red">* </samp>
                                    </label>
                                    <asp:TextBox class="form-control" ID="txtBlueYellowPhase" onkeydown="return preventEnterSubmit(event)" onkeypress="return isNumberKey(event);" placeholder="" autocomplete="off" TabIndex="2" runat="server" Style="margin-left: 18px"></asp:TextBox>
                                </div>
                                <div class="col-4" id="Div36" runat="server">
                                    <label for="Name">
                                        Red Phase – Blue Phase(in Mohm)
                    <samp style="color: red">* </samp>
                                    </label>
                                    <asp:TextBox class="form-control" ID="txtRedBluePhase" onkeydown="return preventEnterSubmit(event)" onkeypress="return isNumberKey(event);" placeholder="" autocomplete="off" TabIndex="2" runat="server" Style="margin-left: 18px"></asp:TextBox>
                                </div>
                            </div>
                        </div>
                        <div id="Insulation220vAbove" runat="server" visible="true">
                            <div class="row">
                                <div class="col-4">
                                    <label>
                                        Phase wire - Neutral wire (in Mohm)<samp style="color: red"> * </samp>
                                    </label>
                                    <asp:TextBox class="form-control" ID="txtNeutralWire" onkeydown="return preventEnterSubmit(event)" onkeypress="return isNumberKey(event);" placeholder="" autocomplete="off" TabIndex="2" runat="server" Style="margin-left: 18px"></asp:TextBox>
                                </div>
                                <div class="col-4" id="Div37" runat="server">
                                    <label for="Name">
                                        Phase wire - Earth (in Mohm)
                            <samp style="color: red">* </samp>
                                    </label>
                                    <asp:TextBox class="form-control" ID="txtEarthWire" onkeydown="return preventEnterSubmit(event)" onkeypress="return isNumberKey(event);" placeholder="" autocomplete="off" TabIndex="2" runat="server" Style="margin-left: 18px"></asp:TextBox>
                                </div>
                                <div class="col-4" id="Div39" runat="server">
                                    <label for="Name">
                                        Neutral wire - Earth (in Mohm)
                    <samp style="color: red">* </samp>
                                    </label>
                                    <asp:TextBox class="form-control" ID="txtNeutralWireEarth" onkeydown="return preventEnterSubmit(event)" onkeypress="return isNumberKey(event);" placeholder="" autocomplete="off" TabIndex="2" runat="server" Style="margin-left: 18px"></asp:TextBox>
                                </div>
                            </div>
                        </div>
                        <div id="LineTypeUnderground" runat="server" visible="true">
                            <div class="row">
                                <div class="col-4">
                                    <label>
                                        Type of Cable
                            <samp style="color: red">* </samp>
                                    </label>
                                    <asp:DropDownList class="form-control  select-form select2" TabIndex="6" runat="server" AutoPostBack="true" ID="ddlCableType" selectionmode="Multiple" Style="width: 100% !important">
                                        <asp:ListItem Value="" Text="Select"></asp:ListItem>
                                        <asp:ListItem Value="1" Text="XPLE"></asp:ListItem>
                                        <asp:ListItem Value="2" Text="Other"></asp:ListItem>
                                    </asp:DropDownList>
                                </div>
                                <div class="col-4">
                                    <label>
                                        Size of Cable: In(MM Sq.)<samp style="color: red"> * </samp>
                                    </label>
                                    <asp:TextBox class="form-control" ID="txtCableSize" onkeydown="return preventEnterSubmit(event)" onkeypress="return isNumberKey(event);" placeholder="" autocomplete="off" TabIndex="2" runat="server" Style="margin-left: 18px"></asp:TextBox>
                                </div>
                                <div class="col-4">
                                    <label>
                                        Cable Laid in
                            <samp style="color: red">* </samp>
                                    </label>
                                    <asp:DropDownList class="form-control  select-form select2" TabIndex="6" runat="server" AutoPostBack="true" ID="ddlCableLaid" selectionmode="Multiple" Style="width: 100% !important">
                                        <asp:ListItem Value="" Text="Select"></asp:ListItem>
                                        <asp:ListItem Value="1" Text="Trench"></asp:ListItem>
                                        <asp:ListItem Value="2" Text="circuit"></asp:ListItem>
                                        <asp:ListItem Value="3" Text="cable tray"></asp:ListItem>
                                    </asp:DropDownList>
                                </div>
                            </div>
                        </div>
                        <div id="UndergroundInsulation440vAbove" runat="server" visible="true">
                            <div class="row">
                                <div class="col-4">
                                    <label>
                                        Red Phase – Earth Wire (in Mohm)<samp style="color: red"> * </samp>
                                    </label>
                                    <asp:TextBox class="form-control" ID="txtRedWire" onkeydown="return preventEnterSubmit(event)" onkeypress="return isNumberKey(event);" placeholder="" autocomplete="off" TabIndex="2" runat="server" Style="margin-left: 18px"></asp:TextBox>
                                </div>
                                <div class="col-4" id="Div38" runat="server">
                                    <label for="Name">
                                        Yellow Phase – Earth Wire (in Mohm)	
        <samp style="color: red">* </samp>
                                    </label>
                                    <asp:TextBox class="form-control" ID="txtYellowWire" onkeydown="return preventEnterSubmit(event)" onkeypress="return isNumberKey(event);" placeholder="" autocomplete="off" TabIndex="2" runat="server" Style="margin-left: 18px"></asp:TextBox>
                                </div>
                                <div class="col-4" id="Div40" runat="server">
                                    <label for="Name">
                                        Blue Phase – Earth Wire (in Mohm)	
<samp style="color: red">* </samp>
                                    </label>
                                    <asp:TextBox class="form-control" ID="txtBlueWire" onkeydown="return preventEnterSubmit(event)" onkeypress="return isNumberKey(event);" placeholder="" autocomplete="off" TabIndex="2" runat="server" Style="margin-left: 18px"></asp:TextBox>
                                </div>
                                <div class="col-4" id="Div41" runat="server">
                                    <label for="Name">
                                        Red Phase – Yellow Phase(in Mohm)
<samp style="color: red">* </samp>
                                    </label>
                                    <asp:TextBox class="form-control" ID="txtRedYellowWire" onkeydown="return preventEnterSubmit(event)" onkeypress="return isNumberKey(event);" placeholder="" autocomplete="off" TabIndex="2" runat="server" Style="margin-left: 18px"></asp:TextBox>
                                </div>
                                <div class="col-4" id="Div42" runat="server">
                                    <label for="Name">
                                        Blue Phase – Yellow Phase(in Mohm)
<samp style="color: red">* </samp>
                                    </label>
                                    <asp:TextBox class="form-control" ID="txtBlueYellowWire" onkeydown="return preventEnterSubmit(event)" onkeypress="return isNumberKey(event);" placeholder="" autocomplete="off" TabIndex="2" runat="server" Style="margin-left: 18px"></asp:TextBox>
                                </div>
                                <div class="col-4" id="Div43" runat="server">
                                    <label for="Name">
                                        Red Phase – Blue Phase(in Mohm)
<samp style="color: red">* </samp>
                                    </label>
                                    <asp:TextBox class="form-control" ID="txtRedBlueWire" onkeydown="return preventEnterSubmit(event)" onkeypress="return isNumberKey(event);" placeholder="" autocomplete="off" TabIndex="2" runat="server" Style="margin-left: 18px"></asp:TextBox>
                                </div>
                            </div>
                        </div>
                        <div id="UndergroundInsulation220vAbove" runat="server" visible="true">
                            <div class="row">
                                <div class="col-4">
                                    <label>
                                        Phase wire - Neutral wire (in Mohm)<samp style="color: red"> * </samp>
                                    </label>
                                    <asp:TextBox class="form-control" ID="txtNeutralPhaseWire" onkeydown="return preventEnterSubmit(event)" onkeypress="return isNumberKey(event);" placeholder="" autocomplete="off" TabIndex="2" runat="server" Style="margin-left: 18px"></asp:TextBox>
                                </div>
                                <div class="col-4" id="Div44" runat="server">
                                    <label for="Name">
                                        Phase wire - Earth (in Mohm)
                            <samp style="color: red">* </samp>
                                    </label>
                                    <asp:TextBox class="form-control" ID="txtPhaseWireEarth" onkeydown="return preventEnterSubmit(event)" onkeypress="return isNumberKey(event);" placeholder="" autocomplete="off" TabIndex="2" runat="server" Style="margin-left: 18px"></asp:TextBox>
                                </div>
                                <div class="col-4" id="Div45" runat="server">
                                    <label for="Name">
                                        Neutral wire - Earth (in Mohm)
<samp style="color: red">* </samp>
                                    </label>
                                    <asp:TextBox class="form-control" ID="txtNeutralWireEarthUnderground" onkeydown="return preventEnterSubmit(event)" onkeypress="return isNumberKey(event);" placeholder="" autocomplete="off" TabIndex="2" runat="server" Style="margin-left: 18px"></asp:TextBox>
                                </div>
                                <div class="col-4" id="Div46" runat="server">
                                    <label for="Name">
                                        Number of Earthing:
                    <samp style="color: red">* </samp>
                                    </label>
                                    <asp:DropDownList class="form-control  select-form select2" TabIndex="6" runat="server" AutoPostBack="true" ID="DropDownList22" selectionmode="Multiple" Style="width: 100% !important">
                                        <asp:ListItem Value="1" Text="1"></asp:ListItem>
                                    </asp:DropDownList>
                                </div>
                                <div class="col-2" id="Div47" runat="server">
                                    <label for="Name">
                                        Earthing Type
                    <samp style="color: red">* </samp>
                                    </label>
                                    <asp:DropDownList class="form-control  select-form select2" TabIndex="6" runat="server" AutoPostBack="true" ID="DropDownList16" selectionmode="Multiple" Style="width: 100% !important">
                                    </asp:DropDownList>
                                </div>
                                <div class="col-2" id="Div48" runat="server">
                                    <label for="Name">
                                        Value in(ohms)
                    <samp style="color: red">* </samp>
                                    </label>
                                    <asp:TextBox class="form-control" ID="TextBox49" onkeydown="return preventEnterSubmit(event)" placeholder="" autocomplete="off" TabIndex="2" runat="server" Style="margin-left: 18px"></asp:TextBox>
                                </div>
                                <div class="col-2" id="Div49" runat="server">
                                    <label for="Name">
                                        Earthing Type
                            <samp style="color: red">* </samp>
                                    </label>
                                    <asp:DropDownList class="form-control  select-form select2" TabIndex="6" runat="server" AutoPostBack="true" ID="DropDownList17" selectionmode="Multiple" Style="width: 100% !important">
                                    </asp:DropDownList>
                                </div>
                                <div class="col-2" id="Div50" runat="server">
                                    <label for="Name">
                                        Value in(ohms)
                            <samp style="color: red">* </samp>
                                    </label>
                                    <asp:TextBox class="form-control" ID="TextBox50" onkeydown="return preventEnterSubmit(event)" placeholder="" autocomplete="off" TabIndex="2" runat="server" Style="margin-left: 18px"></asp:TextBox>
                                </div>
                                <div class="col-2" id="Div51" runat="server">
                                    <label for="Name">
                                        Earthing Type
                            <samp style="color: red">* </samp>
                                    </label>
                                    <asp:DropDownList class="form-control  select-form select2" TabIndex="6" runat="server" AutoPostBack="true" ID="DropDownList18" selectionmode="Multiple" Style="width: 100% !important">
                                    </asp:DropDownList>
                                </div>
                                <div class="col-2" id="Div52" runat="server">
                                    <label for="Name">
                                        Value in(ohms)
                            <samp style="color: red">* </samp>
                                    </label>
                                    <asp:TextBox class="form-control" ID="TextBox51" onkeydown="return preventEnterSubmit(event)" placeholder="" autocomplete="off" TabIndex="2" runat="server" Style="margin-left: 18px"></asp:TextBox>
                                </div>
                                <div class="col-2" id="Div53" runat="server">
                                    <label for="Name">
                                        Earthing Type
                            <samp style="color: red">* </samp>
                                    </label>
                                    <asp:DropDownList class="form-control  select-form select2" TabIndex="6" runat="server" AutoPostBack="true" ID="DropDownList19" selectionmode="Multiple" Style="width: 100% !important">
                                    </asp:DropDownList>
                                </div>
                                <div class="col-2" id="Div54" runat="server">
                                    <label for="Name">
                                        Value in(ohms)
                            <samp style="color: red">* </samp>
                                    </label>
                                    <asp:TextBox class="form-control" ID="TextBox52" onkeydown="return preventEnterSubmit(event)" placeholder="" autocomplete="off" TabIndex="2" runat="server" Style="margin-left: 18px"></asp:TextBox>
                                </div>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-4"></div>
                            <div class="col-4" style="text-align: center;">
                                <asp:Button ID="btnSubmit" Text="Generate Test Report" runat="server" ValidationGroup="Submit" class="btn btn-primary mr-2"
                                    Style="background: linear-gradient(135deg, hsla(318, 44%, 51%, 1) 0%, hsla(347, 94%, 48%, 1) 100%); border-color: #d42766;"  />
                            </div>
                            <div class="col-4">
                                <asp:HiddenField ID="HiddenField1" runat="server" />
                            </div>
                        </div>
                        <div class="row">
                        </div>
                    </div>

                </div>
                    </div>
                    <div id="Paris" class="w3-container city" visible="false" runat="server">
                        <h2>Paris</h2>
                        <p>Paris is the capital of France.</p>
                    </div>
                    <div id="Tokyo" class="w3-container city" style="display: none" visible="false" runat="server">
                        <h2>Tokyo</h2>
                        <p>Tokyo is the capital of Japan.</p>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <script type="text/javascript">
        function openCity(cityName) {
            var i;
            var x = document.getElementsByClassName("city");
            for (i = 0; i < x.length; i++) {
                x[i].style.display = "none";
            }
            document.getElementById(cityName).style.display = "block";
        }
    </script>
</asp:Content>