<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Dashboard-Agent.aspx.cs" Inherits="PhillyPhreshProperties.Dashboard_Agent" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.2.1/dist/css/bootstrap.min.css" rel="stylesheet" />
    <title>Dashboard</title>
</head>
<body>
    <form id="formDashboardAgent" runat="server">
        <div id="dashboardAgent" class="d-block w-50 mx-auto p-2 bg-dark text-white rounded-3">
            <nav class="navbar navbar-expand-md navbar-brand justify-content-center">
                <div class="container-flex">
                    <asp:Button ID="btnHome" runat="server" CssClass="btn btn-outline-info" Text="Home" />
                    <asp:Button ID="btnSearch" runat="server" CssClass="btn btn-outline-info" Text="Search" />
                    <asp:Button ID="btnShowing" runat="server" CssClass="btn btn-outline-info" Text="Showings" OnClick="btnShowing_Click" />
                    <asp:Button ID="btnLogout" runat="server" CssClass="btn btn-outline-info" Text="Logout" />
                </div>
            </nav>

            <div id="dashContent" class="flex-column d-flex justify-content-center align-items-center w-75 mx-auto">
                <asp:GridView ID="gvHomes" runat="server" AutoGenerateColumns="false" OnSelectedIndexChanged="gvHomes_SelectedIndexChanged">
                    <Columns>
                        <asp:BoundField DataField="Address" HeaderText="Address"/>
                        <asp:BoundField DataField="City" HeaderText="City"/>
                        <asp:BoundField DataField="PropertyType" HeaderText="Property"/>
                        <asp:BoundField DataField="AskingPrice" HeaderText="Price"/>
                        <asp:BoundField DataField="Status" HeaderText="Status"/>
                        <asp:TemplateField>
                            <ItemTemplate>
                                <asp:Button ID="btnModify" runat="server" CssClass="btn btn-outline-info" Text="Modify"/>
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
                <br />

                <asp:GridView ID="gvReviews" runat="server" AutoGenerateColumns="false">
                    <Columns>
                        <asp:BoundField DataField="ReviewerFirstName" HeaderText="Buyer First Name"/>
                        <asp:BoundField DataField="ReviewerLastName" HeaderText="Buyer Last Name"/>
                        <asp:BoundField DataField="PriceComment" HeaderText="Pricing"/>
                        <asp:BoundField DataField="LocationComment" HeaderText="Location"/>
                        <asp:BoundField DataField="HomeComment" HeaderText="House"/>
                        <asp:BoundField DataField="Rating" HeaderText="Rating"/>
                    </Columns>
                </asp:GridView>

            </div><%--end dashContent div--%>

        </div>
    </form>
</body>
</html>
