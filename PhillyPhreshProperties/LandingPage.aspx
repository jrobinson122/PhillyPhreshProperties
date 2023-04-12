<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LandingPage.aspx.cs" Inherits="PhillyPhreshProperties.LandingPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.2.1/dist/css/bootstrap.min.css" rel="stylesheet" />
    <title>Home</title>
</head>
<body>
    <form id="form1" runat="server">
        <div id="landing" class="d-block w-50 mx-auto p-2 bg-dark text-white rounded-3">
            <h2 class="text-center display-3">Philly Phresh Properties</h2>
            <h5>Find the home of your dreams below. Please be sure to select and enter a location and price range.</h5>
            <br />

            <nav class="navbar navbar-expand-md navbar-brand justify-content-center">
                <div class="container-flex">
                    <asp:Button ID="btnSearch" runat="server" CssClass="btn btn-outline-danger" Text="Search" />
                    <asp:Button ID="btnProfile" runat="server" CssClass="btn btn-outline-danger mx-1" Text="My Profile" />
                    <asp:Button ID="btnEdit" runat="server" CssClass="btn btn-outline-danger" Text="Edit Profile" />
                    <asp:Button ID="btnMatches" runat="server" CssClass="btn btn-outline-danger mx-1" Text="Matches" />
                    <asp:Button ID="btnLogout" runat="server" CssClass="btn btn-outline-info" Text="Logout" OnClick="btnLogout_Click" />
                </div>
            </nav>

            <div id="searchBar" class="flex-column d-flex justify-content-center align-items-center mx-auto">
                <div class="row gx-4 my-1">
                    <div class="col-4">
                        <asp:Label ID="lblLocation" runat="server" class=" col-form-label-lg">Location:</asp:Label>
                        <asp:TextBox ID="txtKey" runat="server" CssClass=" form-control mb-2"></asp:TextBox>
                        <asp:DropDownList ID="ddlLoction" runat="server" class="form-select">
                            <asp:ListItem Text=""></asp:ListItem>
                            <asp:ListItem Text="City" Value="1"></asp:ListItem>
                            <asp:ListItem Text="State" Value="2"></asp:ListItem>
                            <asp:ListItem Text="Zipcode" Value="3"></asp:ListItem>
                        </asp:DropDownList>
                    </div>

                    <div class="col-md-4">
                        <asp:Label ID="lblPriceRange" runat="server" class="col-form-label-lg">Price Range:</asp:Label>
                        <asp:DropDownList ID="ddlPriceRange" runat="server" class="form-select">
                            <asp:ListItem Text="All" Value="0"></asp:ListItem>
                            <asp:ListItem Text="$100k and under" Value="1"></asp:ListItem>
                            <asp:ListItem Text="$200k and under" Value="2"></asp:ListItem>
                            <asp:ListItem Text="$300k and under" Value="3"></asp:ListItem>
                            <asp:ListItem Text="$400k and under" Value="4"></asp:ListItem>
                            <asp:ListItem Text="$500k and under" Value="5"></asp:ListItem>
                            <asp:ListItem Text="$1M and under" Value="6"></asp:ListItem>
                        </asp:DropDownList>
                    </div>

                    <div class="col-md-4">
                        <asp:Button ID="btnFind" runat="server" CssClass="btn btn-outline-info mt-5" Text="Find" />
                    </div>

                </div>
                <div class="row gx-4 my-1 ">
                    <h4>Additional Find Filters</h4>

                    <div class="col-md-4">
                        <asp:Label ID="lblPropertyType" runat="server" class="col-form-label-lg">Property Type:</asp:Label>
                        <asp:DropDownList ID="ddlPropertyType" runat="server" class="form-select">
                            <asp:ListItem Text="All" Value="0"></asp:ListItem>
                            <asp:ListItem Text="Single-Family" Value="1"></asp:ListItem>
                            <asp:ListItem Text="Multi-Family" Value="2"></asp:ListItem>
                            <asp:ListItem Text="Condo" Value="3"></asp:ListItem>
                            <asp:ListItem Text="Townhouse" Value="4"></asp:ListItem>
                        </asp:DropDownList>
                    </div>

                    <div class="col-md-4">
                        <asp:Label ID="Label1" runat="server" class="col-form-label-lg">Number of Bedrooms:</asp:Label>
                        <asp:DropDownList ID="DropDownList2" runat="server" class="form-select">
                            <asp:ListItem Text="All" Value="0"></asp:ListItem>
                            <asp:ListItem Text="Single-Family" Value="1"></asp:ListItem>
                            <asp:ListItem Text="Multi-Family" Value="2"></asp:ListItem>
                            <asp:ListItem Text="Condo" Value="3"></asp:ListItem>
                            <asp:ListItem Text="Townhouse" Value="4"></asp:ListItem>
                        </asp:DropDownList>
                    </div>

                </div>

            </div><%--end searchBar div--%>


        </div>
    </form>
</body>
</html>
