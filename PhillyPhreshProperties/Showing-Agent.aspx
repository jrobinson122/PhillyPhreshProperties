<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Showing-Agent.aspx.cs" Inherits="PhillyPhreshProperties.Showing_Agent" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.2.1/dist/css/bootstrap.min.css" rel="stylesheet" />
    <title>Showing</title>
</head>
<body>
    <form id="formShowingAgent" runat="server">
        <div id="showingAgent" class="d-block w-50 mx-auto p-2 bg-dark text-white rounded-3">
            <nav class="navbar navbar-expand-md navbar-brand justify-content-center">
                <div class="container-flex">
                    <asp:Button ID="btnHome" runat="server" CssClass="btn btn-outline-info" Text="Home" />
                    <asp:Button ID="btnSearch" runat="server" CssClass="btn btn-outline-info" Text="Search" />
                    <asp:Button ID="btnShowing" runat="server" CssClass="btn btn-outline-info" Text="Home Showing" />
                    <asp:Button ID="btnLogout" runat="server" CssClass="btn btn-outline-info" Text="Logout" />
                </div>
            </nav>
            <h2 class="text-center display-3">Philly Phresh Properties</h2>

            <h4 class="text-center display-4">View your scheduled showings below.</h4>

            <div id="showings" class="flex-column d-flex justify-content-center align-items-center w-75 mx-auto">
                <table class="table">
                    <tr>
                        <th>Buyer</th>
                        <th>Property</th>
                        <th>Date</th>
                        <th>Time</th>
                    </tr>
                    <asp:Repeater ID="rptShowings" runat="server">
                        <ItemTemplate>
                            <tr>
                                <td>
                                    <asp:Label ID="lblBuyer" runat="server" CssClass="form-label" Text='<%# DataBinder.Eval(Container.DataItem, "Buyer")%>' />
                                </td>
                                <td>
                                    <asp:Label ID="lblProperty" runat="server" CssClass="form-label" Text='<%# DataBinder.Eval(Container.DataItem, "Address")%>' />
                                </td>
                                <td>
                                    <asp:Label ID="lblDate" runat="server" CssClass="form-label" Text='<%# DataBinder.Eval(Container.DataItem, "Date")%>' />
                                </td>
                                <td>
                                    <asp:Label ID="lblTime" runat="server" CssClass="form-label" Text='<%# DataBinder.Eval(Container.DataItem, "Time")%>' />
                                </td>
                            </tr>
                        </ItemTemplate>
                    </asp:Repeater>
                </table>
            </div><%--end showings div--%>

            <div class="row my-1 ">
                <asp:Button ID="btnExit" runat="server" CssClass="btn btn-outline-info" Text="Exit"/>
            </div>            

        </div>
    </form>
</body>
</html>
