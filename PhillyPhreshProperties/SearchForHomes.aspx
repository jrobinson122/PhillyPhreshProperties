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
                <asp:Button ID="searchByLocationAndPriceBtn" runat="server" Text="Search By Price and City" OnClick="searchByCityAndPriceBtn_Click" />
                <asp:Button ID="searchByLocationPropertyTypeAndPriceBtn" runat="server" Text="Search By Location, Property Type, and Price" OnClick="searchByLocationPropertyTypeAndPrice_Click" />
                <asp:Button ID="searchByLocationPricePropertySizeBedBathBtn" runat="server" Text="Search by Location, Price, Property Type, Home Size, Mimumum Bed and Bath" OnClick="searchByLocationPricePropertySizeBedBathBtn_Click" />
                <br />
                <asp:Table ID="CriteriaSearchTable" runat="server" Visible="false">
                    <asp:TableRow>
                        <asp:TableCell ID="cityCell">
                            <asp:Label ID="cityLbl" runat="server" Text="Enter City: "></asp:Label>
                            <asp:TextBox ID="cityTxtBox" runat="server"></asp:TextBox>
                        </asp:TableCell>
                    </asp:TableRow>
                    <asp:TableRow>
                        <asp:TableCell ID="priceCell">
                            <asp:Label ID="priceLbl" runat="server" Text="Enter Price Range: "></asp:Label>
                            <asp:TextBox ID="minmumPricetxt" runat="server" Text="Minimum"></asp:TextBox>
                            <asp:TextBox ID="maximumPricetxt" runat="server" Text="Maximum"></asp:TextBox>
                            <asp:Button ID="searchForHomesByCityAndPrice" runat="server" Text="Search For Homes" OnClick="searchForHomesByCityAndPrice_Click" />
                        </asp:TableCell>
                    </asp:TableRow>
                    <asp:TableRow>
                        <asp:TableCell ID="propertyCell">
                            <asp:DropDownList ID="propertyTypeDDL" runat="server">
                                    <asp:ListItem Text="Single Family" Value="SingleFamily"></asp:ListItem>
                                    <asp:ListItem Text="Multi Family" Value="MultiFamily"></asp:ListItem>
                                    <asp:ListItem Text="Townhouse" Value="Townhouse"></asp:ListItem>
                                    <asp:ListItem Text="Condo" Value="Condo"></asp:ListItem>
                            </asp:DropDownList>
                            <asp:Button ID="searchForHomesByLocationPropertyAndPriceBtn" runat="server" Text="Search For Homes" OnClick="searchForHomesByLocationPropertyAndPriceBtn_Click" />
                        </asp:TableCell>
                    </asp:TableRow>
                     <asp:TableRow>
                        <asp:TableCell ID="homeSizeCell">
                            <asp:Label ID="homeSizeLbl" runat="server" Text="Enter Desired Home Size in Sq Ft: "></asp:Label>
                            <asp:TextBox ID="homeSizeTxt" runat="server" Text=""></asp:TextBox>
                            <asp:Button ID="searchForHomesByLocationPropertyPriceAndCriteria" runat="server" Text="Search For Homes" OnClick="searchForHomesByLocationPropertyPriceAndCriteria_Click" />
                        </asp:TableCell>
                    </asp:TableRow>
                </asp:Table>

                <br />
            </div>
            <asp:Button ID="scheduleShowingBtn" runat="server" Text="Schedule House Showing" />
            <asp:Button ID="displayHomesBtn" runat="server" Text="Display Homes" />
            <asp:GridView ID="gvHomes" runat="server">
               <%-- <Columns>
                    <asp:BoundField DataField="Address" HeaderText="Address" />
                    <asp:BoundField DataField="City" HeaderText="City" />
                    <asp:BoundField DataField="PropertyType" HeaderText="Property Type" />
                    <asp:BoundField DataField="HomeSize" HeaderText="Home Size" />
                    <asp:BoundField DataField="NumBeds" HeaderText="Number of Beds" />
                    <asp:BoundField DataField="NumBath" HeaderText="Number of Baths" />
                    <asp:BoundField DataField="Amenities" HeaderText="Amenities" />
                    <asp:BoundField DataField="HeatingCooling" HeaderText="Heating and Cooling Info" />
                    <asp:BoundField DataField="YearBuilt" HeaderText="Year Built" />
                    <asp:BoundField DataField="Garage" HeaderText="Garage Type" />
                    <asp:BoundField DataField="Description" HeaderText="Description" />
                    <asp:BoundField DataField="AskingPrice" HeaderText="Asking Price" />
                </Columns>--%>
            </asp:GridView>
            <asp:Label ID="lblMessage" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
