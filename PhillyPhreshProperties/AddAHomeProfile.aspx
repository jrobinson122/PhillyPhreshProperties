<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddAHomeProfile.aspx.cs" Inherits="PhillyPhreshProperties.AddAHomeProfile" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Add Home Profile</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Add Home Profile</h2>
            <label>Address:</label>
            <asp:TextBox ID="txtAddress" runat="server"></asp:TextBox>
            <br />
            <label>Property Type:</label>
            <asp:DropDownList ID="ddlPropertyType" runat="server">
                <asp:ListItem Text="Single Family" Value="SingleFamily"></asp:ListItem>
                <asp:ListItem Text="Multi Family" Value="MultiFamily"></asp:ListItem>
                <asp:ListItem Text="Townhouse" Value="Townhouse"></asp:ListItem>
                <asp:ListItem Text="Condo" Value="Condo"></asp:ListItem>
            </asp:DropDownList>
            <br />
            <label>Home Size (in sqft):</label>
            <asp:TextBox ID="txtHomeSize" runat="server"></asp:TextBox>
            <br />
            <label>Number of Bedrooms:</label>
            <asp:TextBox ID="txtNumBedrooms" runat="server"></asp:TextBox>
            <br />
            <label>Number of Bathrooms:</label>
            <asp:TextBox ID="txtNumBathrooms" runat="server"></asp:TextBox>
            <br />
            ll
           
            <label>Amenities:</label>
            <asp:CheckBoxList ID="chkAmenities" runat="server">
                <asp:ListItem Text="Fireplace"></asp:ListItem>
                <asp:ListItem Text="Basement"></asp:ListItem>
                <asp:ListItem Text="Pool"></asp:ListItem>
                <asp:ListItem Text="Hot Tub"></asp:ListItem>
                <asp:ListItem Text="Garden"></asp:ListItem>
                <asp:ListItem Text="Bar"></asp:ListItem>
            </asp:CheckBoxList>
            <br />
            <label>Heating and Cooling System:</label>
            <asp:DropDownList ID="ddlHeatingCooling" runat="server">
                <asp:ListItem Text="Central Air" Value="CentralAir"></asp:ListItem>
                <asp:ListItem Text="Forced Air Heat" Value="ForcedAirHeat"></asp:ListItem>
                <asp:ListItem Text="Oil Heat" Value="OilHeat"></asp:ListItem>
                <asp:ListItem Text="Propane Heat" Value="PropaneHeat"></asp:ListItem>
                <asp:ListItem Text="Hot Water Radiators" Value="HotWaterRadiators"></asp:ListItem>
                <asp:ListItem Text="Electric Heating" Value="ElectricHeating"></asp:ListItem>
            </asp:DropDownList>
            <br />
            <label>Year Built:</label>
            <asp:TextBox ID="txtYearBuilt" runat="server"></asp:TextBox>
            <br />
            <label>Garage:</label>
            <asp:DropDownList ID="ddlGarage" runat="server">
                <asp:ListItem Text="None" Value="None"></asp:ListItem>
                <asp:ListItem Text="2 Car" Value="2Car"></asp:ListItem>
            </asp:DropDownList>
        </div>
    </form>
</body>
</html>
