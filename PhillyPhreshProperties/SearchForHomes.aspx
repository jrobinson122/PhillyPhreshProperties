<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SearchForHomes.aspx.cs" Inherits="PhillyPhreshProperties.SearchForHomes" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="filterBtn" runat="server" Text="All Filters" />
            <div id="searchDiv">
                <asp:Button ID="searchByCityAndPriceBtn" runat="server" Text="Search By Price and City" OnClick="searchByCityAndPriceBtn_Click" />
                <asp:Button ID="searchByLocationPropertyTypeAndPrice" runat="server" Text="Search By Location, Property Type, and Price" />
                <asp:Button ID="searchBy" runat="server" Text="Button" />
                <br />
                <asp:Table ID="priceAndCitySearchTable" runat="server" Visible="false">
                    <asp:TableRow>
                        <asp:TableCell>
                            <asp:Label ID="cityLbl" runat="server" Text="Enter City: "></asp:Label>
                            <asp:TextBox ID="cityTxtBox" runat="server"></asp:TextBox>
                        </asp:TableCell>
                         </asp:TableRow>
                    <asp:TableRow>
                         <asp:TableCell>
                            <asp:Label ID="Label2" runat="server" Text="Enter Price Range: "></asp:Label>
                            <asp:TextBox ID="TextBox2" runat="server" Text="Minimum"></asp:TextBox>
                            <asp:TextBox ID="TextBox3" runat="server" Text="Maximum"></asp:TextBox>
                            <asp:Button ID="searchForHomesByCityAndPrice" runat="server" Text="Search For Homes" OnClick="searchForHomesByCityAndPrice_Click"/>
                        </asp:TableCell>
                    </asp:TableRow>                          
                </asp:Table>
                <br />
             </div>
            <asp:Button ID="scheduleShowingBtn" runat="server" Text="Schedule House Showing" />
            <asp:Button ID="displayHomesBtn" runat="server" Text="Display Homes" />
            <asp:GridView ID="gvHomes" runat="server">
            </asp:GridView>
        </div>
    </form>
</body>
</html>
