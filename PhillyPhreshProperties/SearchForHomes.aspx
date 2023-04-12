<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SearchForHomes.aspx.cs" Inherits="PhillyPhreshProperties.SearchForHomes" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="gvHomes" runat="server" AutoGenerateColumns="false">
                <Columns>
                    <asp:BoundField DataField="Address" HeaderText="House Address" />
                    <asp:BoundField DataField="PropertyType" HeaderText="Property Type" />
                     <asp:BoundField DataField="HomeSize" HeaderText="House Size (in Sq Ft)" />
                    <asp:BoundField DataField="NumBeds" HeaderText="Number of Beds" />
                     <asp:BoundField DataField="NumBath" HeaderText="Number of Baths" />
                    <asp:BoundField DataField="Amenities" HeaderText="Amenities" />
                     <asp:BoundField DataField="Heating/CoolingInfo" HeaderText="Heating and Cooling Info" />
                    <asp:BoundField DataField="YearBuilt" HeaderText="Year of Construction" />
                    <asp:BoundField DataField="Garage" HeaderText="Garage Type" />
                     <asp:BoundField DataField="Description" HeaderText="Description of Property" />
                    <asp:BoundField DataField="AskingPrice" HeaderText="Asking Price" />

                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>
