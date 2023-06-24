<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ValidationControlsPage.aspx.cs" Inherits="EmployeeDetails.ValidationControlsPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 251px;
        }
    </style>
    <script src="MyScript.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table border="1" style="width: 80%;">
                <tr>
                    <td colspan="2" style="text-align: center; background-color: #FFCC99">
                        <asp:Label ID="lblHeading" runat="server" Font-Bold="True" Font-Size="Larger" ForeColor="#CC3300" style="text-align: center" Text="Validation Controls"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        <asp:Label ID="Label1" runat="server" Text="Enter Username"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtUName" runat="server" Width="180px" ValidationGroup="g2"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtUName" ErrorMessage="Username must not be empty" Font-Bold="True" Font-Size="Small" ForeColor="#FF3300" SetFocusOnError="True" ValidationGroup="g2"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        <asp:Label ID="Label2" runat="server" Text="Enter Password"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtPass" runat="server" TextMode="Password" Width="180px" ValidationGroup="g1"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtPass" ErrorMessage="Password is empty" Font-Bold="True" Font-Size="Small" ForeColor="#FF3300" SetFocusOnError="True" ValidationGroup="g1"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        <asp:Label ID="Label3" runat="server" Text="Re-Type Password"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtRePass" runat="server" TextMode="Password" Width="180px" ValidationGroup="g1"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtRePass" Display="Dynamic" ErrorMessage="Field must not be empty" Font-Bold="True" Font-Size="Small" ForeColor="#FF3300" SetFocusOnError="True" ValidationGroup="g1"></asp:RequiredFieldValidator>
&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="txtPass" ControlToValidate="txtRePass" Display="Dynamic" ErrorMessage="Pasword Mismatched" Font-Bold="True" Font-Size="Small" ForeColor="#FF3300" SetFocusOnError="True" ValidationGroup="g1"></asp:CompareValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        <asp:Label ID="Label4" runat="server" Text="Enter Age"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtAge" runat="server" Width="180px" ValidationGroup="g1"></asp:TextBox>
                        <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="txtAge" Display="Dynamic" ErrorMessage="Age must be Between 18 - 100" Font-Bold="True" Font-Size="Small" ForeColor="#FF3300" MaximumValue="100" MinimumValue="18" SetFocusOnError="True" Type="Integer" ValidationGroup="g1"></asp:RangeValidator>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtAge" Display="Dynamic" ErrorMessage="Field must not be Empty" Font-Bold="True" Font-Size="Small" ForeColor="#FF3300" SetFocusOnError="True" ValidationGroup="g1"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        <asp:Label ID="Label5" runat="server" Text="Enter Email-ID"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtEmailID" runat="server" Width="180px" ValidationGroup="g2"></asp:TextBox>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtEmailID" Display="Dynamic" ErrorMessage="Invalid Email ID Pattern" Font-Bold="True" Font-Size="Small" ForeColor="#FF3300" SetFocusOnError="True" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtEmailID" Display="Dynamic" ErrorMessage="Cannot be Empty" Font-Bold="True" Font-Size="Small" ForeColor="#FF3300" ValidationGroup="g2"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        <asp:Label ID="Label6" runat="server" Text="Enter Data"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtData" runat="server"></asp:TextBox>
                        <asp:CustomValidator ID="CustomValidator1" runat="server" ClientValidationFunction="CheckLength" ControlToValidate="txtData" ErrorMessage="Invalid Data" Display="Dynamic" Font-Bold="True" Font-Size="Small" ForeColor="#FF3300" OnServerValidate="CustomValidator1_ServerValidate" ValidationGroup="g2"></asp:CustomValidator>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="txtData" Display="Dynamic" ErrorMessage="Field Cannot be Empty" Font-Bold="True" Font-Size="Small" ForeColor="#FF3300" ValidationGroup="g2"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">&nbsp;</td>
                    <td>
                        <asp:ValidationSummary ID="ValidationSummary1" runat="server" BackColor="Black" ForeColor="Yellow" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1" style="text-align: right">
                        <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" Text="Submit" ValidationGroup="g2" />
                    </td>
                    <td>
                        <asp:Button ID="Button1" runat="server" Text="Button" ValidationGroup="g1" />
                        <asp:Label ID="lblMsg" runat="server" Font-Bold="True" ForeColor="#CC3300"></asp:Label>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
