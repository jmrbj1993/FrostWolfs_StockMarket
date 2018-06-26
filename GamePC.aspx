<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GamePC.aspx.cs" Inherits="STMSM.GamePC" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
    <link href="css/bootstrap.min.css" rel="stylesheet" />
    <link href="css/bootstrap-theme.min.css" rel="stylesheet" />
    <link href="css/Customes%20css/navbar.css" rel="stylesheet" />


</head>
<body style="background-image:url(Images/13.jpg);">


    <form id="form1" runat="server">

        <div class="container">
            <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
            <asp:Timer ID="Timer1" runat="server" Interval="1000" OnTick="Timer1_Tick"></asp:Timer>
            <asp:UpdatePanel ID="UpdatePanel1" runat="server" UpdateMode="Conditional">
                <Triggers>
                    <asp:AsyncPostBackTrigger ControlID="Timer1" EventName="Tick" />
                </Triggers>
                <ContentTemplate>


                    <div class="row">
                        <div class="col-md-12">
                            <nav class="navbar navbar-inverse">
                                <div class="container-fluid">
                                    <div class="navbar-header">
                                        <button type="button" class="navbar-toggle" data-toggle="collapse" data-target=".navbar-collapse" aria-expanded="false" aria-controls="navbar">
                                            <span class="sr-only">Toggle navigation</span>
                                            <span class="icon-bar"></span>
                                            <span class="icon-bar"></span>
                                            <span class="icon-bar"></span>
                                        </button>
                                        <a class="navbar-brand" href="#">Stock Market</a>
                                    </div>
                                    <div id="navbar" class="navbar-collapse collapse">
                                        <ul class="nav navbar-nav">
                                            <li class="active"><a href="Game.aspx">Game</a></li>
                                            <li class="active"><a href="HistoryOfUsers.aspx">History</a></li>

                                            <li class="active"><a href="CurrentPlayersGame.aspx">Current Players</a></li>
                                        </ul>
                                        <p runat="server" id="NavUSer" class="navbar-text" style="color: yellow;"></p>
                                        <p runat="server" id="NavUserChance" class="navbar-text" style="color: yellow;"></p>
                                        <p runat="server" id="NavBalance" class="navbar-text" style="color: yellow;"></p>
                                        <p runat="server" id="NavCountDown" class="navbar-text" style="color: yellow;"></p>
                                        <div class="navbar-form navbar-left">
                                            <div class="form-group">

                                                <asp:Button ID="Button1" runat="server" CssClass="btn btn-primary" Text="Sign Out" OnClick="btnSignOut_Click" />
                                            </div>
                                        </div>
                                    </div>







                                </div>
                            </nav>
                        </div>
                    </div>
                </ContentTemplate>
            </asp:UpdatePanel>





            <asp:Timer ID="Timer2" runat="server" Interval="10000" OnTick="Timer2_Tick"></asp:Timer>
            <asp:UpdatePanel ID="UpdatePanel2" runat="server" UpdateMode="Conditional">
                <ContentTemplate>

                    <div class="row">
                        <div class="col-md-9">
                            <div class="panel panel-primary">
                                <div class="panel-heading">Shares</div>
                                <div class="panel-body">

                                    <div class="form-control">
                                        <label for="lblSectionFilteration">Sector Filteration</label>
                                        <asp:DropDownList ID="ddlSector" runat="server" DataSourceID="SqlDataSource2" DataTextField="SectorName" DataValueField="SectorID" AutoPostBack="True" OnSelectedIndexChanged="ddlSector_SelectedIndexChanged"></asp:DropDownList>

                                        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:StCon %>" SelectCommand="SELECT [SectorID], [SectorName] FROM [Sector]"></asp:SqlDataSource>
                                    </div>
                                    <table class="table table-bordered table-hover">
                                        <thead>
                                            <tr>
                                                <th>Sector</th>
                                                <th>Company</th>
                                                <th>Price</th>
                                                <th>+/-</th>
                                                <th>+/-EC</th>
                                                <th>+/-ES</th>
                                                <th>Share</th>
                                                <th>Value</th>
                                            </tr>
                                        </thead>
                                        <tbody>
                                            <asp:Repeater ID="RptMarket" runat="server">
                                                <ItemTemplate>
                                                    <tr>

                                                        <td><%#Eval("SectorName") %></td>
                                                        <td><%#Eval("CompanyName") %></td>
                                                        <td><%#Eval("Price") %></td>
                                                        <td><%#Eval("IncDes") %></td>
                                                        <td><%#Eval("EventCompany") %></td>
                                                        <td><%#Eval("EventSector") %></td>
                                                        <td><%#Eval("Share") %></td>
                                                        <td><%#Eval("Value") %></td>
                                                    </tr>
                                                </ItemTemplate>
                                            </asp:Repeater>
                                        </tbody>
                                    </table>


                                </div>

                            </div>


                        </div>
                        <div class="col-md-3">
                            <div class="panel panel-primary">
                                <div class="panel-heading">Buy/Sell</div>
                                <div class="panel-body">


                                    <div class="form-group">
                                        <label for="lblSector">Sector</label>
                                        <asp:DropDownList ID="ddlSector1" OnSelectedIndexChanged="ddlSector1_SelectedIndexChanged" class="form-control" AutoPostBack="True" runat="server" DataSourceID="SqlDataSource3" DataTextField="SectorName" DataValueField="SectorID"></asp:DropDownList>
                                        <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:StCon %>" SelectCommand="SELECT [SectorID], [SectorName] FROM [Sector] ORDER BY [SectorID] asc"></asp:SqlDataSource>

                                        <label for="lblCompany">Company</label>
                                        <asp:DropDownList ID="ddlCompany1" OnSelectedIndexChanged="ddlCompany1_SelectedIndexChanged" class="form-control" AutoPostBack="True" runat="server" DataSourceID="SqlDataSource4" DataTextField="CompanyName" DataValueField="ComapnyID"></asp:DropDownList>
                                        <asp:SqlDataSource ID="SqlDataSource4" runat="server" ConnectionString="<%$ ConnectionStrings:StCon %>" SelectCommand="SELECT Market.ComapnyID, Market.CompanyName FROM Market INNER JOIN Sector ON Market.SectorID = Sector.SectorID AND Market.SectorID = @var ORDER BY Market.ComapnyID asc">
                                            <SelectParameters>
                                                <asp:ControlParameter ControlID="ddlSector1" Name="var" PropertyName="SelectedValue" />
                                            </SelectParameters>
                                        </asp:SqlDataSource>
                                        <label for="lblNumberOFbyes">Number Of Shares</label>
                                        <asp:TextBox ID="txtNumberOFbyes" OnTextChanged="txtNumberOFbyes_TextChanged" AutoPostBack="true" runat="server"></asp:TextBox>
                                        <label for="lblPriceperShare">Price Per Share</label>
                                        <asp:TextBox ID="txtPriceperShare" ReadOnly="true" runat="server"></asp:TextBox>
                                        <label for="lblPriceperShare">Total Price</label>
                                        <asp:TextBox ID="txtTotalPrice" ReadOnly="true" runat="server"></asp:TextBox>
                                    </div>
                                    
                                    <asp:Button ID="btnBye" class="btn btn-primary" runat="server" Text="Buy" OnClick="btnBye_Click" />
                                    <asp:Button ID="btnSell" class="btn btn-default" runat="server" Text="Sell" OnClick="btnSell_Click" />
                                    <label for="lblMes" runat="server" id="lblErorMessage" style="color: red;"></label>

                                </div>

                            </div>


                        </div>
                    </div>

                    <div class="row">
                        <div class="col-md-12">
                            <asp:Chart ID="Chart2" runat="server" Width="350">
                                <Titles>
                                    <asp:Title Text="Next Rounds Will Be">
                                    </asp:Title>
                                </Titles>
                                <Series>
                                    <asp:Series Name="Series2" ChartArea="ChartArea1" ChartType="Line">
                                        <Points>
                                        
                                        </Points>
                                    </asp:Series>
                                </Series>
                                <ChartAreas>
                                    <asp:ChartArea Name="ChartArea1">
                                        <AxisX Title="Company Name">
                                        </AxisX>
                                        <AxisY Title="Probabillity">
                                        </AxisY>
                                    </asp:ChartArea>
                                </ChartAreas>
                            </asp:Chart>
                        </div>
                    </div>
                </ContentTemplate>
                <Triggers>
                    <asp:AsyncPostBackTrigger ControlID="Timer2" EventName="Tick" />
                </Triggers>
            </asp:UpdatePanel>
        </div>


    </form>
</body>
</html>
