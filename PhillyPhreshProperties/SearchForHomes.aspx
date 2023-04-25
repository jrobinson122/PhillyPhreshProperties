<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SearchForHomes.aspx.cs" Inherits="PhillyPhreshProperties.SearchForHomes" EnableEventValidation="false" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Search For Homes</title>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css" />
</head>

<body>
    <script type="text/javascript">
        //function showModal() {
        //    $('#homeModal').modal('show');)
        //}
        //function hideModal() {
        //    $('#homeModal').modal('hide');
        //}

    </script>

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
            <asp:GridView ID="gvHomes" runat="server" AutoGenerateColumns="false" OnRowCommand="gvHomes_RowCommand">
                <Columns>
                    <asp:BoundField DataField="Address" HeaderText="Address" />
                    <asp:BoundField DataField="City" HeaderText="City" />
                    <asp:BoundField DataField="PropertyType" HeaderText="Property Type" />
                    <asp:BoundField DataField="HomeSize" HeaderText="Home Size" />
                    <%-- <asp:BoundField DataField="NumBeds" HeaderText="Number of Beds" />
                    <asp:BoundField DataField="NumBath" HeaderText="Number of Baths" />--%>
                    <asp:BoundField DataField="Amenities" HeaderText="Amenities" />
                    <asp:BoundField DataField="HeatingCooling" HeaderText="Heating and Cooling Info" />
                    <asp:BoundField DataField="YearBuilt" HeaderText="Year Built" />
                    <asp:BoundField DataField="Garage" HeaderText="Garage Type" />
                    <%-- <asp:BoundField DataField="Description" HeaderText="Description" />--%>
                    <asp:BoundField DataField="AskingPrice" HeaderText="Asking Price" />                      
                 <%--   <asp:ButtonField ButtonType="Button" Text="View Details" CommandName="ViewHomeDetails" />--%>
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:LinkButton ID="viewHomeInfoBtn" runat="server" Text="View Home Info" CommandName="ViewHomeInfo" CommandArgument="<%# Container.DataItemIndex %>"></asp:LinkButton>
                           <%-- <asp:Button ID="btnShowModalPopup" runat="server" Text="View Details" CommandName="ViewHomeInfo" OnClick="btnShowModalPopup_Click" />--%>
                        </ItemTemplate>
                    </asp:TemplateField>
                   
                </Columns>
            </asp:GridView>
            <asp:Panel ID="pnlHomeDetails" runat="server" CssClass="modalPopup" Visible="false">        
                <h2>Home Details</h2>
                <label>Address: </label>
                <asp:Label ID="addressModalLbl" runat="server" Text=""></asp:Label>
                <br />
                <label>City: </label>
                <asp:Label ID="cityModalLbl" runat="server" Text=""></asp:Label>
                <br />
                <label>Property Type: </label>
                <asp:Label ID="propertyTypeModalLbl" runat="server" Text=""></asp:Label>
                <br />
                <label>Home Size: </label>
                <asp:Label ID="homeSizeModalLbl" runat="server" Text=""></asp:Label>
                <br />
                 <label>Number Of Beds: </label>
            <asp:Label ID="numBedsModalLbl" runat="server" Text=""></asp:Label>
            <br />
            <label>Number Of Baths: </label>
            <asp:Label ID="numBathsModalLbl" runat="server" Text=""></asp:Label>
            <br />
               <label>Amenities: </label>
                <asp:Label ID="amenitiesModalLbl" runat="server" Text=""></asp:Label>
                <br />
                <label>Heating Cooling Description: </label>
                <asp:Label ID="heatingCoolingModalLbl" runat="server" Text=""></asp:Label>
                <br />
                <label>Year Built: </label>
                <asp:Label ID="yearBuiltModalLbl" runat="server" Text=""></asp:Label>
                <br />
                <label>Garage: </label>
                <asp:Label ID="garageModalLbl" runat="server" Text=""></asp:Label>
                <br />
                <label>Description: </label>
            <asp:Label ID="descriptionModalLbl" runat="server" Text=""></asp:Label>
            <br />
               <label>Asking Price: </label>
                <asp:Label ID="askingPriceModalLbl" runat="server" Text=""></asp:Label>
                <h3>Real Estate Agent</h3>
                <label>Name: </label>
                <asp:Label ID="lblAgentNameModalLbl" runat="server" Text=""></asp:Label><br />
               
               <br />
                <asp:Button ID="btnClose" runat="server" Text="Close" OnClick="btnClose_Click" />
            </asp:Panel>
            <%-- <asp:TemplateField HeaderText="View Home Detials">
                        <ItemTemplate>
                            <asp:Button ID="btnViewHomeDetails" runat="server" Text="View Home Details" CssClass="btn btn-info"
                                CommandName="ViewHomeDetails" CommandArgument='<%# Eval("HomeID") %>' OnClick="btnViewHomeDetails_Click" />
                        </ItemTemplate>
                    </asp:TemplateField>--%>
    </form>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
</body>
</html>
