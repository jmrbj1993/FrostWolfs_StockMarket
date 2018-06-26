<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SignUp.aspx.cs" Inherits="STMSM.SignUp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="css/bootstrap.min.css" rel="stylesheet" />
    <link href="css/bootstrap-theme.min.css" rel="stylesheet" />
    <link href="css/Customes%20css/navbar.css" rel="stylesheet" />
</head>
<body style="background-image:url(Images/giphy.gif);">
    <form id="form1" runat="server" class="form-signin" >
        <div class="container">
           
            <div class="row">
                <div class="col-md-3"></div>
                <div class="col-md-5">
                    <div class="panel panel-primary">
                        <div class="panel-heading">Sign Up</div>
                        <div class="panel-body">


                            <div class="form-group">
                                <label for="lblNumberOFbyes">UserName</label><br />
                                <asp:TextBox ID="txtUserName"  AutoPostBack="true" runat="server"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtUserName" ErrorMessage="Enter User Name" Font-Bold="True" ForeColor="Red"></asp:RequiredFieldValidator>
                            </div>
                            <div class="form-group">
                                <label for="lblPriceperShare">Password</label><br />
                                <asp:TextBox ID="txtPassword" TextMode="Password" runat="server"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtPassword" ErrorMessage="Enter Password" Font-Bold="True" ForeColor="Red"></asp:RequiredFieldValidator>
                            </div>

                            <div class="form-group">
                                <label for="lblPriceperShare">Confirm Password</label><br />
                                <asp:TextBox ID="txtConfirmPassword" TextMode="Password" runat="server"></asp:TextBox>
                                <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="Confirm Password Not Matched" ControlToCompare="txtPassword" ControlToValidate="txtConfirmPassword" Font-Bold="True" ForeColor="Red"></asp:CompareValidator>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtConfirmPassword" ErrorMessage="Enter Confirm Password" Font-Bold="True" ForeColor="Red"></asp:RequiredFieldValidator>
                                
                            </div>
                            
                            <asp:Button ID="btnConfirm" class="btn btn-info" runat="server" Text="SignUP" OnClick="btnConfirm_Click" />
                            
                            <label for="lblMes" runat="server" id="lblMessage" style="color: green;"></label>
                            <%--          </ContentTemplate>
                            </asp:UpdatePanel>--%>
                        </div>

                    </div>


                </div>
            </div>
            <div class="col-md-3"></div>
        </div>
       
    </form>
</body>
</html>
