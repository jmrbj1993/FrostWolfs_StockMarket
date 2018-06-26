<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HistoryOfUsers.aspx.cs" Inherits="STMSM.HistoryOfUsers" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="css/bootstrap.min.css" rel="stylesheet" />
    <link href="css/bootstrap-theme.min.css" rel="stylesheet" />
    <link href="css/Customes%20css/navbar.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <div class="container">
            <div class="row">
                <div class="col-md-12">
                    <nav class="navbar navbar-inverse">
                        <div class="container-fluid">
                            <div class="navbar-header">
                                <button type="button" class="navbar-toggle collapsed" data-toggle="collapse" data-target="#navbar" aria-expanded="false" aria-controls="navbar">
                                    <span class="sr-only">Toggle navigation</span>
                                    <span class="icon-bar"></span>
                                    <span class="icon-bar"></span>
                                    <span class="icon-bar"></span>
                                </button>
                                <a class="navbar-brand" href="#">Stock Market Simulation</a>
                            </div>
                            <div id="navbar" class="navbar-collapse collapse">
                                <ul class="nav navbar-nav">
                                    <li class="active"><a href="Game.aspx">Game</a></li>
                                    <li class="active"><a href="HistoryOfUsers.aspx">History</a></li>
                                     <li class="active"><a href="CurrentPlayersGame.aspx">Current Players</a></li>
                                </ul>

                            </div>
                        </div>
                    </nav>
                </div>
      </div>
        <div class="row">
            <div class="col-md-2"></div>
            <div class="col-md-8">
               <div class="panel panel-primary">
                        <div class="panel-heading">History Details</div>
                        <div class="panel-body">
                            <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
                            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                                <ContentTemplate>
                                   
                                    <table class="table table-bordered table-hover">
                                        <thead>
                                            <tr>
                                                <th>Remark</th>
                                                <th>Sector</th>
                                                <th>Company</th>
                                                <th>Price</th>
                                               <%-- <th>Volume</th>--%>
                                                <th>Share</th>
                                                <th>Value</th>
                                                <%--<th>Profit</th>--%>
                                                
                                            </tr>
                                        </thead>
                                        <tbody>
                                            <asp:Repeater ID="RptHistory" runat="server">
                                                <ItemTemplate>
                                                    <tr>
                                                        <td><%#Eval("Remark") %></td>
                                                        <td><%#Eval("SectorName") %></td>
                                                        <td><%#Eval("CompanyName") %></td>
                                                        <td><%#Eval("Price") %></td>
                                                        <%--<td><%#Eval("Volume") %></td>--%>
                                                        <td><%#Eval("Share") %></td>
                                                        <td><%#Eval("Value") %></td>
                                                        <%--<td><%#Eval("Profit") %></td>--%>
                                                    </tr>
                                                </ItemTemplate>
                                            </asp:Repeater>
                                        </tbody>
                                    </table>
                                </ContentTemplate>
                            </asp:UpdatePanel>

                        </div>

                    </div>


            </div>
            <div class="col-md-2"></div>
        </div>
    </div>
    </form>
</body>
</html>
