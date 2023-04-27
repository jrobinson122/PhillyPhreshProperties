<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Showings-Buyer.aspx.cs" Inherits="PhillyPhreshProperties.Showings_Buyer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.2.1/dist/css/bootstrap.min.css" rel="stylesheet" />
    <title>Showings-Buyer</title>

    <script type="text/javascript">
        var xmlhRequest = new XMLHttpRequest();

        //Show data using an update panel not javascript
        function loadShowings()
        {
            xmlhRequest.open("POST", "Showings-Buyer.aspx", true);
            xmlhRequest.onreadystatechange = function () {
                if (xmlhRequest.readyState == 4 && xmlhRequest.status == 200) {
                    var data = xmlhRequest.responseText;
                    var html = "<table>" +
                        "<tr style='font-weight:bold'>" +
                        "<td> Agent </td>" +
                        "<td> Property </td>" +
                        "<td> City </td>" +
                        "<td> Date </td>" +
                        "<td> Time </td>" +
                        "</tr>";

                    for (var i = 0; i < data.length; i++) {
                        html += "<tr>" + "<td>" + data[i].Agent + "</td>" +
                            "<td>" + data[i].Address + "</td>" +
                            "<td>" + data[i].City + "</td>" +
                            "<td>" + data[i].Date + "</td>" +
                            "<td>" + data[i].Time + "</td>" +
                            "</tr>";
                    }
                    html += "</table>"

                    document.getElementById("showings").innerHTML = html;
                }
            }
            xmlhRequest.setRequestHeader
            xmlhRequest.send();
        }
        
    </script>
</head>
<body>
    <form id="formShowingsBuyer" runat="server">
        <div class="d-block w-50 mx-auto p-2 bg-dark text-white rounded-3">
            <nav class="navbar navbar-expand-md navbar-brand justify-content-center">
                <div class="container-flex">
                    <asp:Button ID="btnHome" runat="server" CssClass="btn btn-outline-info" Text="Home" />
                    <asp:Button ID="btnSearch" runat="server" CssClass="btn btn-outline-info" Text="Search" />
                    <asp:Button ID="btnShowing" runat="server" CssClass="btn btn-outline-info" Text="Showings" />
                    <asp:Button ID="btnLogout" runat="server" CssClass="btn btn-outline-info" Text="Logout" />
                </div>
            </nav>

            <h2 class="text-center display-3">Philly Phresh Properties</h2>
            <h4 class="text-center display-4">Schedule a home showing below.</h4>

            <div id="scheduling" class="flex-column d-flex justify-content-center align-items-center w-75 mx-auto">
                <div class="row gx-3 my-1 ">
                    <div class="col-md-6">
                        <asp:Label ID="lblAddress" runat="server" CssClass="col-form-label" Text="Address: "/>
                        <asp:Textbox ID="txtAddress" runat="server" CssClass="col-form-label" />
                    </div>
                    <div class="col-md-6">
                        <asp:Label ID="lblCity" runat="server" CssClass="col-form-label" Text="City: "/>
                        <asp:Textbox ID="txtCity" runat="server" CssClass="col-form-label" />
                    </div>
                </div>
                <div class="row my-1 ">
                    <div class="col-auto">
                        <asp:Label ID="lblSchedule" runat="server" CssClass="form-label">Select a preferred date and time:</asp:Label>
       
                        <asp:DropDownList ID="ddlDate" runat="server" CssClass="form-select">
                            <asp:ListItem Text="" Value="0"/>
                            <asp:ListItem Text="Tomorrow" Value="1" />
                            <asp:ListItem Text="Two days from today" Value="2" />
                            <asp:ListItem Text="Three days from today" Value="3" />
                            <asp:ListItem Text="Four days from today" Value="4" />
                            <asp:ListItem Text="Five days from today" Value="5" />
                            <asp:ListItem Text="Week from today" Value="6" />
                        </asp:DropDownList>
       
                        <asp:DropDownList ID="ddlTime" runat="server" CssClass="form-select my-2">
                            <asp:ListItem Text="" Value="0"/>
                            <asp:ListItem Text="1 PM" Value="1"/>
                            <asp:ListItem Text="2 PM" Value="2"/>
                            <asp:ListItem Text="3 PM" Value="3"/>
                            <asp:ListItem Text="4 PM" Value="4"/>
                            <asp:ListItem Text="5 PM" Value="5"/>
                            <asp:ListItem Text="6 PM" Value="6"/>
                        </asp:DropDownList>
                    </div>
                </div>
                
                <asp:Button ID="btnSchedule" runat="server" Text="Schedule" CssClass="btn btn-info align-content-center" OnClick="btnSchedule_Click" />
                <asp:Label ID="lblError" runat="server" Visible="false" CssClass="my-2 text-warning align-content-center"/>

            </div><%--end scheduling div--%>

            <div id="showings" class="flex-column d-flex justify-content-center w-75 mx-auto"> </div><%--end showings div--%>

            <div class="row my-1 align-content-center">
                <asp:Button ID="btnExit" runat="server" CssClass="btn btn-outline-info w-50" Text="Exit" OnClick="btnExit_Click"/>
            </div>                

        </div>
    </form>
</body>
</html>
