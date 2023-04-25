<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ManageHomeProfile.aspx.cs" Inherits="PhillyPhreshProperties.ManageHomeProfile" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Home List</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Homes List</h1>
            <hr />
            <asp:GridView ID="gvHomes" runat="server" AutoGenerateColumns="False" OnRowEditing="gvHomes_RowEditing" OnRowUpdating="gvHomes_RowUpdating" OnRowDeleting="gvHomes_RowDeleting">
                <Columns>
                    <asp:BoundField DataField="Address" HeaderText="Address" />
                    <asp:TemplateField HeaderText="Price">
                        <ItemTemplate>
                            <asp:TextBox ID="txtAskingPrice" runat="server" Text='<%# Bind("AskingPrice") %>'></asp:TextBox>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Status">
                        <ItemTemplate>
                            <asp:DropDownList ID="ddlStatus" runat="server" SelectedValue='<%# Bind("Status") %>'>
                                <asp:ListItem Text="For Sale" Value="For Sale"></asp:ListItem>
                                <asp:ListItem Text="Sold" Value="Sold"></asp:ListItem>
                                <asp:ListItem Text="Contingent Offer/Pending Sale" Value="Contingent Offer/Pending Sale"></asp:ListItem>
                            </asp:DropDownList>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Actions">
                        <ItemTemplate>
                            <asp:LinkButton ID="lnkEdit" runat="server" Text="Edit" CommandName="Edit" CommandArgument='<%# Container.DataItemIndex %>'></asp:LinkButton>
                            <asp:LinkButton ID="lnkDelete" runat="server" Text="Delete" CommandName="Delete" CommandArgument='<%# Container.DataItemIndex %>'></asp:LinkButton>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:LinkButton ID="lnkUpdate" runat="server" Text="Update" CommandName="Update" CommandArgument='<%# Container.DataItemIndex %>'></asp:LinkButton>
                            <asp:LinkButton ID="lnkCancel" runat="server" Text="Cancel" CommandName="Cancel"></asp:LinkButton>
                        </EditItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
</div>
    </form>
</body>
</html>
