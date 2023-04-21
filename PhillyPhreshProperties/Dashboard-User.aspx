    <%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Dashboard-User.aspx.cs" Inherits="PhillyPhreshProperties.LandingPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.2.1/dist/css/bootstrap.min.css" rel="stylesheet" />
    <title>Home</title>
</head>
<body>
    <form id="formDashboardUser" runat="server">
        <div id="dashboardUser" class="d-block w-50 mx-auto p-2 bg-dark text-white rounded-3">
           <nav class="navbar navbar-expand-md navbar-brand justify-content-center">
                <div class="container-flex">
                    <asp:Button ID="btnHome" runat="server" CssClass="btn btn-outline-info" Text="Home" />
                    <asp:Button ID="btnSearch" runat="server" CssClass="btn btn-outline-info" Text="Search" />
                    <asp:Button ID="btnShowing" runat="server" CssClass="btn btn-outline-info" Text="Home Showing" />
                    <asp:Button ID="btnLogout" runat="server" CssClass="btn btn-outline-info" Text="Logout" OnClick="btnLogout_Click" />
                </div>
            </nav>

            <h2 class="text-center display-3">Philly Phresh Properties</h2>

            <%--make 2 dashboard pages for user and agent--%>

            


        </div><%--end dashboardUser div--%>
    </form>
</body>
</html>
