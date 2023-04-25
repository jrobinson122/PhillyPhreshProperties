<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UserReviews.ascx.cs" Inherits="PhillyPhreshProperties.UserReviews" %>
<div class="review-rating-container">
    <h2>Leave a Review</h2>
    <div class="form-group">
        <label for="txtReviewerName">Your Name:</label>
        <input type="text" id="txtReviewerName" runat="server" />
    </div>
   
    <div class="form-group">
        <label for="ddlRating">Rating:</label>
        <asp:DropDownList ID="ddlRating" runat="server">
            <asp:ListItem Value="5">5 - Excellent</asp:ListItem>
            <asp:ListItem Value="4">4 - Very Good</asp:ListItem>
            <asp:ListItem Value="3">3 - Good</asp:ListItem>
            <asp:ListItem Value="2">2 - Fair</asp:ListItem>
            <asp:ListItem Value="1">1 - Poor</asp:ListItem>
        </asp:DropDownList>
    </div>
    <div class="form-group">
        <label for="txtPrice">Comments on the price:</label>
        <textarea id="txtPrice" runat="server"></textarea>
    </div>
    <div class="form-group">
        <label for="txtLocation">Comments on the location:</label>
        <textarea id="txtLocation" runat="server"></textarea>
    </div>
    <div class="form-group">
        <label for="txtHome">Comments on the home:</label>
        <textarea id="txtHome" runat="server"></textarea>
    </div>
    <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
</div>
