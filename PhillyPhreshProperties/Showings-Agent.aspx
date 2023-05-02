<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Showings-Agent.aspx.cs" Inherits="PhillyPhreshProperties.Showings_Agent" %>

<%@ Register Src="~/ViewOffers.ascx" TagName="ViewOffer" TagPrefix="uc1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.2.1/dist/css/bootstrap.min.css" rel="stylesheet" />
    <title>Showings-Agent</title>
</head>
<body>
    <form id="formShowingAgent" runat="server">
        <div id="showingAgent" class="d-block w-50 mx-auto p-2 bg-dark text-white rounded-3">
            <nav class="navbar navbar-expand-md navbar-brand justify-content-center">
                <div class="container-flex">
                    <asp:Button ID="btnHome" runat="server" CssClass="btn btn-outline-info" Text="Home" />
                    <asp:Button ID="btnSearch" runat="server" CssClass="btn btn-outline-info" Text="Search" />
                    <asp:Button ID="btnShowing" runat="server" CssClass="btn btn-outline-info" Text="Showings" />
                    <asp:Button ID="btnLogout" runat="server" CssClass="btn btn-outline-info" Text="Logout" />
                </div>
            </nav>
            <h2 class="text-center display-3">Philly Phresh Properties</h2>

            <h4 class="text-center display-4">View your scheduled showings below.</h4>

            <div id="showings" class="flex-column d-flex justify-content-center align-items-center w-75 mx-auto text-bg-light">
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
                                <td>
                                    <asp:Button ID="btnOffer" runat="server" Text="View Offer" CssClass="btn btn-outline-info" CommandName="Offer" />
                                </td>
                            </tr>
                        </ItemTemplate>
                    </asp:Repeater>
                </table>
            </div><%--end showings div--%>

            <div id="divOffer" class="flex-column d-flex justify-content-center w-75 mx-auto" runat="server" style="display:none;">
                <uc1:ViewOffer ID="vOffer" runat="server"/>
            </div><%--end divOffers--%>

            <div class="row my-1 justify-content-center">
                <asp:Button ID="btnExit" runat="server" CssClass="btn btn-outline-info w-25" Text="Exit"/>
            </div>            

        </div>
    </form>
</body>
</html>
