<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AccountRegistration.aspx.cs" Inherits="PhillyPhreshProperties.AccountRegistration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Account Registration</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Table ID="tblRegister" runat="server" HorizontalAlign="Center">
                <asp:TableHeaderRow>
                    <asp:TableHeaderCell>Sign Up</asp:TableHeaderCell>
                </asp:TableHeaderRow>
                <asp:TableRow>
                    <asp:TableCell>
                            Email:
                            </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox ID="txtRegisterEmail" runat="server" CssClass="txtbtn"></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>
                            Password:
                            </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox ID="txtRegisterPassword" runat="server" CssClass="txtbtn"></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>
                            First Name:
                            </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox ID="txtRegisterFirstName" runat="server" CssClass="txtbtn"></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>
                            Last Name:
                            </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox ID="txtRegisterLastName" runat="server" CssClass="txtbtn"></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>
                            Address:
                            </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox ID="txtRegisterAddress" runat="server" CssClass="txtbtn"></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>
                            City:
                            </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox ID="txtRegisterCity" runat="server" CssClass="txtbtn"></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>
                            State:
                            </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox ID="txtRegisterState" runat="server" CssClass="txtbtn"></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>
                            Zipcode:
                            </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox ID="txtRegisterZipCode" runat="server" CssClass="txtbtn"></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>
                            Phone Number:
                            </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox ID="txtRegisterPhoneNumber" runat="server" CssClass="txtbtn"></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>
                            Account Type:
                            </asp:TableCell>
                    <asp:TableCell>
                        <asp:DropDownList ID="ddlAccountType" runat="server">
                            <asp:ListItem Text="Home Buyer" Value="Buyer" />
                            <asp:ListItem Text="Home Seller" Value="Seller" />
                            <asp:ListItem Text="Real Estate Agent" Value="Agent" />
                        </asp:DropDownList>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>
                            Security Question #1:
                            </asp:TableCell>
                    <asp:TableCell>
                        <asp:DropDownList ID="ddlSecurityQuestion1" runat="server" CssClass="ddl">
                            <asp:ListItem>What is your middle name?</asp:ListItem>
                            <asp:ListItem>What city were you born in?</asp:ListItem>
                            <asp:ListItem>What is the name of your favorite pet?</asp:ListItem>
                            <asp:ListItem>What was the make of your first car?</asp:ListItem>
                            <asp:ListItem>What high school did you attend?</asp:ListItem>
                        </asp:DropDownList>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>
                            Answer:
                            </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox ID="txtSecurityAnswer1" runat="server" CssClass="txtbtn"></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>
                            Security Question #2:
                            </asp:TableCell>
                    <asp:TableCell>
                        <asp:DropDownList ID="ddlSecurityQuestion2" runat="server" CssClass="ddl">
                            <asp:ListItem>What was the name of your elementary school?</asp:ListItem>
                            <asp:ListItem>What was your first job?</asp:ListItem>
                            <asp:ListItem>What was the name of your favorite teacher?</asp:ListItem>
                            <asp:ListItem>What was your mother's maiden name?</asp:ListItem>
                            <asp:ListItem>What is your favorite sports team?</asp:ListItem>
                        </asp:DropDownList>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>
                            Answer:
                            </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox ID="txtSecurityAnswer2" runat="server" CssClass="txtbtn"></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>
                            Security Question #3:
                            </asp:TableCell>
                    <asp:TableCell>
                        <asp:DropDownList ID="ddlSecurityQuestion3" runat="server" CssClass="ddl">
                            <asp:ListItem>What is the name of your first boyfriend/girlfriend?</asp:ListItem>
                            <asp:ListItem>In what city does your nearest sibling live?</asp:ListItem>
                            <asp:ListItem>What is your favorite food?</asp:ListItem>
                            <asp:ListItem>What is the name of your favorite childhood friend?</asp:ListItem>
                            <asp:ListItem>What is the name of a college you applied to but didn't attend?</asp:ListItem>
                        </asp:DropDownList>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>
                            Answer:
                            </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox ID="txtSecurityAnswer3" runat="server" CssClass="txtbtn"></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>
            </asp:Table>
            <asp:Button ID="btnSubmit" runat="server" Text="Submit" ForeColor="Black" OnClick="btnSubmit_Click" />
            <br />
            <asp:Label ID="lblMessage" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
