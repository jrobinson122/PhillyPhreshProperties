﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Dashboard-Agent.aspx.cs" Inherits="PhillyPhreshProperties.Dashboard_Agent" %>

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
    <form id="formDashboardAgent" runat="server">
        <div id="dashboardAgent">
            <nav class="navbar navbar-expand-md navbar-brand justify-content-center">
                <div class="container-flex">
                    <asp:Button ID="btnHome" runat="server" CssClass="btn btn-outline-info" Text="Home" />
                    <asp:Button ID="btnSearch" runat="server" CssClass="btn btn-outline-danger" Text="Search" />
                    <asp:Button ID="btnShowing" runat="server" CssClass="btn btn-outline-info" Text="Home Showing" />
                    <asp:Button ID="btnLogout" runat="server" CssClass="btn btn-outline-info" Text="Logout" OnClick="btnLogout_Click" />
                </div>
            </nav>

            <%--create a button for each home that would allow an agent to modify the info of a home--%>
            <%--would need to query db to access and update house table--%>
            <%--match the city of the house to the city of the agent--%>
            <%--one agent per city--%>

        </div>
    </form>
</body>
</html>
