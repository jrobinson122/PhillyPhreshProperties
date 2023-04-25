<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Verification.aspx.cs" Inherits="PhillyPhreshProperties.Verification" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="formVerification" runat="server" onsubmit="return false;">
        <h1>Verification</h1>
        <p>Please check your email for a verification link.</p>
        <div>
            <asp:TextBox ID="txtVerificationCode" runat="server" Placeholder="Verification Code"></asp:TextBox>
            <asp:Button ID="btnVerify" runat="server" Text="Verify" OnClick="btnVerify_Click" />
        </div>
    </form>
</body>
</html>
