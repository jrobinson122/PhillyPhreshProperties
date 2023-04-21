<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ManageHomeProfile-Agent.aspx.cs" Inherits="PhillyPhreshProperties.ManageHomeProfile_Agent" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.2.1/dist/css/bootstrap.min.css" rel="stylesheet" />
    <title>Manage Home Profile</title>
</head>
<body>
    <form id="formManageHome" runat="server">
        <div class="d-block w-50 mx-auto p-2 bg-dark text-white rounded-3">
            <nav class="navbar navbar-expand-md navbar-brand justify-content-center">
                <div class="container-flex">
                    <asp:Button ID="btnSearch" runat="server" CssClass="btn btn-outline-danger" Text="Search" />
                    <asp:Button ID="btnProfile" runat="server" CssClass="btn btn-outline-danger mx-1" Text="My Profile" />
                    <asp:Button ID="btnEdit" runat="server" CssClass="btn btn-outline-danger" Text="Edit Profile" />
                    <asp:Button ID="btnMatches" runat="server" CssClass="btn btn-outline-danger mx-1" Text="Matches" />
                    <asp:Button ID="btnLogout" runat="server" CssClass="btn btn-outline-info" Text="Logout" OnClick="btnLogout_Click" />
                </div>
            </nav>

        </div>
    </form>
</body>
</html>
