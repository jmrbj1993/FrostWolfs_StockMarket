<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WaitingForPlayers.aspx.cs" Inherits="STMSM.WaitingForPlayers" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="css/bootstrap.min.css" rel="stylesheet" />
    <link href="css/bootstrap-theme.min.css" rel="stylesheet" />
    <link href="css/Customes%20css/navbar.css" rel="stylesheet" />
</head>
<body style="background-image:url(Images/11.jpg);">
    <form id="form1" runat="server">
        
        <div class="container">
            <div class="row">
                <div class="col-lg-12">
                    <nav class="navbar navbar-default">
                        <div class="container-fluid">
                            <div class="navbar-header">
                                <button type="button" class="navbar-toggle" data-toggle="collapse" data-target=".navbar-collapse" aria-expanded="false" aria-controls="navbar">
                                    <span class="sr-only">Toggle navigation</span>
                                    <span class="icon-bar"></span>
                                    <span class="icon-bar"></span>
                                    <span class="icon-bar"></span>
                                </button>
                                <a class="navbar-brand"  href="#">Stock Market Game</a>
                            </div>








                        </div>
                    </nav>
                </div>
            </div>
            <div class="row">
                <div class="col-md-4"></div>
                <div class="col-md-4">
                    <h1 style="text-align: center;color:white;">Stock Market Game</h1>
                    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
                     <asp:Timer ID="Timer1" runat="server" OnTick="Timer1_Tick" Interval="3000" ></asp:Timer>
                    <asp:UpdatePanel ID="UpdatePanel1" runat="server" UpdateMode="Conditional">
                        <ContentTemplate>
                            <div class="panel panel-primary">
                                <div class="panel-heading">Player List</div>
                                <div class="panel-body">
                                    <table class="table table-bordered table-hover">
                                        <thead>
                                            <tr>
                                                <th>Player Name</th>

                                            </tr>
                                        </thead>
                                        <tbody>
                                            <asp:Repeater ID="Repeater1" runat="server">
                                                <ItemTemplate>
                                                    <tr>
                                                        <td><%#Eval("PlayerName") %></td>
                                                    </tr>
                                                </ItemTemplate>
                                            </asp:Repeater>
                                        </tbody>
                                    </table>
                                </div>
                            </div>
                            
                        </ContentTemplate>
                        <Triggers>
                            <asp:AsyncPostBackTrigger ControlID="Timer1" EventName="Tick" />
                        </Triggers>
                    </asp:UpdatePanel>

                    <div class="progress">
                        <div class="progress-bar progress-bar-success progress-bar-striped active" runat="server" id="ProgGame" role="progressbar" aria-valuenow="98" aria-valuemin="0" aria-valuemax="100" style="width: 40%">
                        </div>
                    </div>
                    <label for="lblMes" runat="server" id="lblMessage" style="color: red;"></label>
                    <asp:Button ID="btnStart" class="btn btn-primary" runat="server" Text="Start Game" OnClick="btnStart_Click" Visible="true" />
                </div>
                <div class="col-md-4">
                </div>
            </div>



        </div>


    </form>
</body>
</html>
