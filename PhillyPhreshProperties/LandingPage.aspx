<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LandingPage.aspx.cs" Inherits="PhillyPhreshProperties.LandingPage" %>

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
    <form id="formLandingPage" runat="server">
        <div id="landing" class="d-block w-50 mx-auto p-2 bg-dark text-white rounded-3">
            <h2 class="text-center display-3">Philly Phresh Properties</h2>
            <h5>Find the home of your dreams below. Please be sure to select and enter a location and price range.</h5>
            <br />

            <nav class="navbar navbar-expand-md navbar-brand justify-content-center">
                <div class="container-flex">
                    <asp:Button ID="btnHome" runat="server" CssClass="btn btn-outline-info" Text="Home" />
                    <asp:Button ID="btnSearch" runat="server" CssClass="btn btn-outline-danger" Text="Search" />
                    <asp:Button ID="btnProfile" runat="server" CssClass="btn btn-outline-danger mx-1" Text="" />
                    <asp:Button ID="btnShowing" runat="server" CssClass="btn btn-outline-info" Text="Home Showing" />
                    <asp:Button ID="btnMatches" runat="server" CssClass="btn btn-outline-danger mx-1" Text="Matches" />
                    <asp:Button ID="btnLogout" runat="server" CssClass="btn btn-outline-info" Text="Logout" OnClick="btnLogout_Click" />
                </div>
            </nav>

            <%--create needed stored procedures to Jon db then transfer funtions to SP class--%>
            <%--should we make this the dasboard page--%>
            <%--start doing bootstrap for all pages--%>
            <%--need a db table of houses and class for a house--%>


        </div><%--end landing div--%>
    </form>
</body>
</html>
