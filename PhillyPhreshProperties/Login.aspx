<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="PhillyPhreshProperties.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.2.1/dist/css/bootstrap.min.css" rel="stylesheet" />
    <title>Login</title>
</head>
<body class="bg-info">
    <form id="form1" runat="server">
        <div id="login" class="d-block w-50 mx-auto p-2 bg-dark text-white rounded-3">
            <h2 class="text-center display-3">Welcome to Philly Phresh Properties!</h2>
            <br />

            <p class="text-center h5">Buy or sell an amazing home here in the city of brotherly love with us. Enter your info below to login.</p>
            <p class="text-center h5">If you are new to Philly Phresh please click register instead.</p>

            
            
            <div id="logComponents" class="flex-column d-flex justify-content-center align-items-center w-75 mx-auto">
                <div class="row my-1 ">
                    <div class="col-auto">
                        <asp:Label ID="lblEmail" runat="server" class=" col-form-label-lg">Email:</asp:Label>
                        <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                </div><%--end email div--%>

                <div class="row my-1">
                    <div class="col-auto">
                        <asp:Label ID="lblPassword" runat="server" CssClass="col-form-label-lg">Password:</asp:Label>
                        <asp:TextBox ID="txtPassword" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                </div><%--end password div--%>

                <div class="row gx-5 my-1">
                    <div class="col-md-6">
                        <asp:Button ID="btnRegister" runat="server" Text="Register"  CssClass="btn btn-outline-success align-content-center" OnClick="btnRegister_Click"/>
                    </div>
                    <div class="col-md-6">
                        <asp:Button ID="btnLogin" runat="server" Text="Login"  CssClass="btn btn-outline-info" OnClick="btnLogin_Click"/>
                    </div>
                </div><%--end buttons div--%>
                
                <asp:Label ID="lblError" runat="server" Visible="false" CssClass="ms-3 text-warning"></asp:Label>

            </div><%--end logComponents div--%>
        </div><%--end login div--%>
    </form>
</body>
</html>
