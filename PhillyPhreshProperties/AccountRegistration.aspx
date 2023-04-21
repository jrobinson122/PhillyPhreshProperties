<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AccountRegistration.aspx.cs" Inherits="PhillyPhreshProperties.AccountRegistration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.2.1/dist/css/bootstrap.min.css" rel="stylesheet" />
    <title>Account Registration</title>
</head>
<body>
    <form id="formAccountRegistration" runat="server">
        <div class="d-block w-50 mx-auto p-2 bg-dark text-white rounded-3">
            <h2 class="text-center display-3">Philly Phresh Properties</h2>
            <h3 class="text-center">Account Sign-Up</h3>

            <div class="flex-column d-flex justify-content-center align-items-center w-75 mx-auto">
                <asp:Table ID="tblRegister" runat="server" CssClass="table">
                    <asp:TableRow>
                        <asp:TableCell CssClass="form-label text-white">
                                Email:
                                </asp:TableCell>
                        <asp:TableCell>
                            <asp:TextBox ID="txtRegisterEmail" runat="server" CssClass="form-control"></asp:TextBox>
                        </asp:TableCell>
                    </asp:TableRow>
                    <asp:TableRow>
                        <asp:TableCell CssClass="form-label text-white">
                                Password:
                                </asp:TableCell>
                        <asp:TableCell>
                            <asp:TextBox ID="txtRegisterPassword" runat="server" CssClass="form-control"></asp:TextBox>
                        </asp:TableCell>
                    </asp:TableRow>
                    <asp:TableRow>
                        <asp:TableCell CssClass="form-label text-white">
                                First Name:
                                </asp:TableCell>
                        <asp:TableCell>
                            <asp:TextBox ID="txtRegisterFirstName" runat="server" CssClass="form-control"></asp:TextBox>
                        </asp:TableCell>
                    </asp:TableRow>
                    <asp:TableRow>
                        <asp:TableCell CssClass="form-label text-white">
                                Last Name:
                                </asp:TableCell>
                        <asp:TableCell>
                            <asp:TextBox ID="txtRegisterLastName" runat="server" CssClass="form-control"></asp:TextBox>
                        </asp:TableCell>
                    </asp:TableRow>
                    <asp:TableRow>
                        <asp:TableCell CssClass="form-label text-white">
                                Address:
                                </asp:TableCell>
                        <asp:TableCell>
                            <asp:TextBox ID="txtRegisterAddress" runat="server" CssClass="form-control"></asp:TextBox>
                        </asp:TableCell>
                    </asp:TableRow>
                    <asp:TableRow>
                        <asp:TableCell CssClass="form-label text-white">
                                City:
                                </asp:TableCell>
                        <asp:TableCell>
                            <asp:TextBox ID="txtRegisterCity" runat="server" CssClass="form-control"></asp:TextBox>
                        </asp:TableCell>
                    </asp:TableRow>
                    <asp:TableRow>
                        <asp:TableCell CssClass="form-label text-white">
                                State:
                                </asp:TableCell>
                        <asp:TableCell>
                            <asp:TextBox ID="txtRegisterState" runat="server" CssClass="form-control"></asp:TextBox>
                        </asp:TableCell>
                    </asp:TableRow>
                    <asp:TableRow>
                        <asp:TableCell CssClass="form-label text-white">
                                Zipcode:
                                </asp:TableCell>
                        <asp:TableCell>
                            <asp:TextBox ID="txtRegisterZipCode" runat="server" CssClass="form-control"></asp:TextBox>
                        </asp:TableCell>
                    </asp:TableRow>
                    <asp:TableRow>
                        <asp:TableCell CssClass="form-label text-white">
                                Phone Number:
                                </asp:TableCell>
                        <asp:TableCell>
                            <asp:TextBox ID="txtRegisterPhoneNumber" runat="server" CssClass="form-control"></asp:TextBox>
                        </asp:TableCell>
                    </asp:TableRow>
                    <asp:TableRow>
                        <asp:TableCell CssClass="form-label text-white">
                                Account Type:
                                </asp:TableCell>
                        <asp:TableCell>
                            <asp:DropDownList ID="ddlAccountType" runat="server" CssClass="form-select">
                                <asp:ListItem Text="Home Buyer" Value="Buyer" />
                                <asp:ListItem Text="Home Seller" Value="Seller" />
                                <asp:ListItem Text="Real Estate Agent" Value="Agent" />
                            </asp:DropDownList>
                        </asp:TableCell>
                    </asp:TableRow>
                    <asp:TableRow>
                        <asp:TableCell CssClass="form-label text-white">
                                Security Question #1:
                                </asp:TableCell>
                        <asp:TableCell>
                            <asp:DropDownList ID="ddlSecurityQuestion1" runat="server" CssClass="form-select">
                                <asp:ListItem>What is your middle name?</asp:ListItem>
                                <asp:ListItem>What city were you born in?</asp:ListItem>
                                <asp:ListItem>What is the name of your favorite pet?</asp:ListItem>
                                <asp:ListItem>What was the make of your first car?</asp:ListItem>
                                <asp:ListItem>What high school did you attend?</asp:ListItem>
                            </asp:DropDownList>
                        </asp:TableCell>
                    </asp:TableRow>
                    <asp:TableRow>
                        <asp:TableCell CssClass="form-label text-white">
                                Answer:
                                </asp:TableCell>
                        <asp:TableCell>
                            <asp:TextBox ID="txtSecurityAnswer1" runat="server" CssClass="form-control"></asp:TextBox>
                        </asp:TableCell>
                    </asp:TableRow>
                    <asp:TableRow>
                        <asp:TableCell CssClass="form-label text-white">
                                Security Question #2:
                                </asp:TableCell>
                        <asp:TableCell>
                            <asp:DropDownList ID="ddlSecurityQuestion2" runat="server" CssClass="form-select">
                                <asp:ListItem>What was the name of your elementary school?</asp:ListItem>
                                <asp:ListItem>What was your first job?</asp:ListItem>
                                <asp:ListItem>What was the name of your favorite teacher?</asp:ListItem>
                                <asp:ListItem>What was your mother's maiden name?</asp:ListItem>
                                <asp:ListItem>What is your favorite sports team?</asp:ListItem>
                            </asp:DropDownList>
                        </asp:TableCell>
                    </asp:TableRow>
                    <asp:TableRow>
                        <asp:TableCell CssClass="form-label text-white">
                                Answer:
                                </asp:TableCell>
                        <asp:TableCell>
                            <asp:TextBox ID="txtSecurityAnswer2" runat="server" CssClass="txtbtn"></asp:TextBox>
                        </asp:TableCell>
                    </asp:TableRow>
                    <asp:TableRow>
                        <asp:TableCell CssClass="form-label text-white">
                                Security Question #3:
                                </asp:TableCell>
                        <asp:TableCell>
                            <asp:DropDownList ID="ddlSecurityQuestion3" runat="server" CssClass="form-select">
                                <asp:ListItem>What is the name of your first boyfriend/girlfriend?</asp:ListItem>
                                <asp:ListItem>In what city does your nearest sibling live?</asp:ListItem>
                                <asp:ListItem>What is your favorite food?</asp:ListItem>
                                <asp:ListItem>What is the name of your favorite childhood friend?</asp:ListItem>
                                <asp:ListItem>What is the name of a college you applied to but didn't attend?</asp:ListItem>
                            </asp:DropDownList>
                        </asp:TableCell>
                    </asp:TableRow>
                    <asp:TableRow>
                        <asp:TableCell CssClass="form-label text-white">
                                Answer:
                                </asp:TableCell>
                        <asp:TableCell>
                            <asp:TextBox ID="txtSecurityAnswer3" runat="server" CssClass="form-control"></asp:TextBox>
                        </asp:TableCell>
                    </asp:TableRow>
                </asp:Table>
                
                <asp:Button ID="btnSubmit" runat="server" Text="Submit" CssClass="btn btn-info align-content-center" OnClick="btnSubmit_Click" />
                <br />
                <asp:Label ID="lblMessage" runat="server"></asp:Label>
            </div>
            
        </div>
    </form>
</body>
</html>
