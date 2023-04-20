<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddAHomeProfile.aspx.cs" Inherits="PhillyPhreshProperties.AddAHomeProfile" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.2.1/dist/css/bootstrap.min.css" rel="stylesheet" />
    <title>Add Home Profile</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Add Home Profile</h2>
            <label>Address:</label>
            <asp:TextBox ID="txtAddress" runat="server"></asp:TextBox>
            <br />
            <label>City:</label>
            <asp:TextBox ID="txtCity" runat="server"></asp:TextBox>
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
            <br />
             <label>Home Description:</label>
            <asp:TextBox ID="descriptionTxtBox" runat="server"></asp:TextBox>
            <br />
             <br />
             <label>Asking Price:</label>
            <asp:TextBox ID="askingPriceTxtBox" runat="server"></asp:TextBox>
            <br />
              <asp:Button ID="btnSubmit" runat="server" Text="Submit" ForeColor="Black" OnClick="btnSubmit_Click"/>
            <br />
            <asp:Label ID="lblMessage" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
