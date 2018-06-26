<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ScoreBoard.aspx.cs" Inherits="STMSM.ScoreBoard" %>

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
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        <asp:Timer ID="timerRefresh" runat="server" Interval="2000" OnTick="timerRefresh_Tick"></asp:Timer>
        <div class="container">
            <div class="row">
                <div class="col-md-12">
                    <nav class="navbar navbar-default">
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
                                    <li class="active"><a href="#">Home</a></li>


                                </ul>

                            </div>
                        </div>
                    </nav>
                </div>
            </div>

            <div class="row">
                <div class="col-md-4"></div>
                <div class="col-md-4">
                    <div class="panel panel-primary">
                        <div class="panel-heading">Ranking</div>
                        <div class="panel-body">
                            <table class="table table-bordered table-hover">
                                <thead>
                                    <tr>
                                        <th>Player Name</th>
                                        <th>Balance</th>
                                        <th>Rank</th>

                                    </tr>
                                </thead>
                                <tbody>
                                    <asp:Repeater ID="RptRanking" runat="server">
                                        <ItemTemplate>
                                            <tr>

                                                <td><%#Eval("UserName") %></td>
                                                <td><%#Eval("Profit") %></td>
                                                <td><%#Eval("RankID") %></td>

                                                <td></td>

                                            </tr>
                                        </ItemTemplate>
                                    </asp:Repeater>
                                </tbody>
                            </table>
                        </div>
                    </div>
                </div>
                <div class="col-md-4"></div>

            </div>
        </div>
    </form>
</body>
</html>
