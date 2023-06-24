<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ValidationControlAssignment.aspx.cs" Inherits="SampleWebApplication.ValidationControlAssignment" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 31px;
        }
        .auto-style2 {
            text-align: center;
            background-color: #6699FF;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table style="width:100%;">
                <tr>
                    <td class="auto-style2" colspan="2"><strong>Validation Control</strong></td>
                </tr>
                <tr>
                    <td>Name</td>
                    <td>
                        <asp:TextBox ID="txtName" runat="server" BorderColor="#0099FF"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtName" ErrorMessage="Required Field" Font-Bold="True" Font-Size="Small" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">Phone Number</td>
                    <td class="auto-style1">
                        <asp:TextBox ID="txtPno" runat="server" BorderColor="#0099FF"></asp:TextBox>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtPno" Display="Dynamic" ErrorMessage="Incorrect Phone Number.Use the following format 999-999-9999" Font-Bold="True" Font-Size="Small" ForeColor="#FF3300" SetFocusOnError="True" ValidationExpression="((\(\d{3}\) ?)|(\d{3}-))?\d{3}-\d{4}"></asp:RegularExpressionValidator>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtPno" Display="Dynamic" ErrorMessage="Cannot be Empty" Font-Bold="True" Font-Size="Small" ForeColor="#FF3300" SetFocusOnError="True"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>E-Mail</td>
                    <td>
                        <asp:TextBox ID="txtEmail" runat="server" BorderColor="#0099FF"></asp:TextBox>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="txtEmail" Display="Dynamic" ErrorMessage="Incorrect E-Mail Address Format" Font-Bold="True" Font-Size="Small" ForeColor="#FF3300" SetFocusOnError="True" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtEmail" Display="Dynamic" ErrorMessage="Cannot be Empty" Font-Bold="True" Font-Size="Small" ForeColor="#FF3300" SetFocusOnError="True"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>Minimum Price</td>
                    <td>
                        <asp:TextBox ID="txtMin" runat="server" BorderColor="#0099FF"></asp:TextBox>
                        <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="txtMin" Display="Dynamic" ErrorMessage="Has to be an Integer and Greater than 0" Font-Bold="True" Font-Size="Small" ForeColor="#FF3300" MaximumValue="10000" MinimumValue="1" SetFocusOnError="True" Type="Integer"></asp:RangeValidator>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtMin" Display="Dynamic" ErrorMessage="Has to be an Integer and Greater than 0" Font-Bold="True" Font-Size="Small" ForeColor="#FF3300" SetFocusOnError="True"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>Maximum Price</td>
                    <td>
                        <asp:TextBox ID="txtMax" runat="server" BorderColor="#0099FF"></asp:TextBox>
                        <asp:RangeValidator ID="RangeValidator2" runat="server" ControlToValidate="txtMax" Display="Dynamic" ErrorMessage="Has to be an Integer and Greater than 0" Font-Bold="True" Font-Size="Small" ForeColor="#FF3300" MaximumValue="99999999" MinimumValue="1" SetFocusOnError="True" Type="Integer"></asp:RangeValidator>
                        <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="txtMin" ControlToValidate="txtMax" Display="Dynamic" ErrorMessage="Maximum Price should be Greater than Minimum Price" Font-Bold="True" Font-Size="Small" ForeColor="#FF3300" SetFocusOnError="True" Type="Integer"></asp:CompareValidator>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtMax" Display="Dynamic" ErrorMessage="Has to be an Integer and Greater than 0" Font-Bold="True" Font-Size="Small" ForeColor="#FF3300" SetFocusOnError="True"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Button ID="btnSubmit" runat="server" BorderColor="#0099FF" OnClick="btnSubmit_Click" Text="Submit" />
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:ValidationSummary ID="ValidationSummary1" runat="server" Font-Bold="True" Font-Size="Small" ForeColor="#FF3300" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
