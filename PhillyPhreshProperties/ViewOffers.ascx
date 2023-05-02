<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ViewOffers.ascx.cs" Inherits="PhillyPhreshProperties.ViewOffers" %>

<head runat="server">
    <meta charset="utf-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.2.1/dist/css/bootstrap.min.css" rel="stylesheet" />
</head>

<div id="divOffers" class="flex-column d-flex justify-content-center align-items-center w-75 mx-auto">
    <div class="row gx-3 my-1">
        <div class="col-md-6">
            <asp:Label ID="lblBuyer" runat="server" CssClass="form-label" />
        </div>
        <div class="col-md-6">
            <asp:Label ID="lblAgent" runat="server" CssClass="form-label" />
        </div>
    </div>

    <div class="row gx-3 my-1">
        <div class="col-md-6">
            <asp:Label ID="lblAddress" runat="server" CssClass="form-label" />
        </div>
        <div class="col-md-6">
            <asp:Label ID="lblCity" runat="server" CssClass="form-label" />
        </div>
    </div>

    <div class="row gx-3 my-1">
        <div class="col-md-6">
            <asp:Label ID="lblAskingPrice" runat="server" CssClass="form-label" />
        </div>
        <div class="col-md-6">
            <asp:Label ID="lblOffer" runat="server" CssClass="form-label" />
        </div>
    </div>

    <div class="row gx-3 my-1">
        <div class="col-md-6">
            <asp:Button ID="btnAccept" runat="server" CssClass="btn btn-outline-info" Text="Accept Offer" OnClick="btnAccept_Click"/>
        </div>
        <div class="col-md-6">
            <asp:Button ID="btnDecline" runat="server" CssClass="btn btn-outline-warning" Text="Decline Offer" OnClick="btnDecline_Click"/>
        </div>
    </div>
    
</div><%--end divOffers--%>
