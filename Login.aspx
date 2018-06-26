<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="STMSM.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login</title>
    <link href="css/bootstrap.min.css" rel="stylesheet" />
    <link href="css/Customes%20css/signin.css" rel="stylesheet" />
</head>
<body style="background-image:url(Images/giphy.gif);">
    <form id="form1" runat="server" class="form-signin">
                    <h3 style="color:red;">Frostwolfs Stock Game</h3>
       
                    <div class="panel panel-primary">
                        <div class="panel-heading">Login</div>
                        <div class="panel-body">
                            <div class="form-group">
                                <label for="lblSector">User Name</label>
                                <input type="text" id="inputText" runat="server" class="form-control" placeholder="UserName" >
                            </div>

                            <div class="form-group">
                                <label for="lblSector">Password </label>
                                <input type="password" id="inputPassword" runat="server" class="form-control" placeholder="Password">
                            </div>
                            <div class="form-group">
                                <asp:Button ID="BtnLogin" runat="server" CssClass="btn btn-success" Text="Submit" OnClick="BtnLogin_ServerClick" />
                                <asp:Button ID="BtnSignUp" runat="server" CssClass="btn btn-info" Text="SignUp" OnClick="BtnSignUp_Click"/>
                            </div>
                           
                            <asp:RadioButton ID="rdM" runat="server" AutoPostBack="true" GroupName="vali" Text="Multiplayer" Checked="true" OnCheckedChanged="rdM_CheckedChanged"/>
                            <asp:RadioButton ID="rdS" runat="server" AutoPostBack="true" GroupName="vali" Text="Singleplayer" Checked="true" OnCheckedChanged="rdM_CheckedChanged"/>
                        </div>
                        <div class="panel-footer">

                            <label for="lblMes" runat="server" id="lblErorMessage" style="color: red;"></label>
                        </div>
                    </div>
             




    </form>
</body>
</html>
