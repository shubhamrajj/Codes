<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DetailForm.aspx.cs" Inherits="EmployeeDetails.DetailForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 136px;
        }
        .auto-style2 {
            width: 354px;
        }
        .auto-style3 {
            text-align: center;
        }
        .auto-style4 {
            background-color: #CC0000;
        }
        .auto-style5 {
            width: 205px;
            text-align: center;
            height: 33px;
        }
        .auto-style6 {
            text-align: center;
            height: 33px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table style="width80%: ;" border="1">
                <tr>
                    <td class="auto-style4" colspan="3" style="text-align: center">
                        <asp:Label ID="lblLogin" runat="server" Font-Bold="True" ForeColor="White" Text="Employee Details Form"></asp:Label>
                        <br />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        <asp:Label ID="lblEname" runat="server" Font-Size="Small" Text="Employee Name"></asp:Label>
                    </td>
                    <td class="auto-style2">
                        <asp:TextBox ID="txtEname" runat="server" OnTextChanged="TextBox1_TextChanged" Width="478px"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        <asp:Label ID="lblEid" runat="server" Font-Size="Small" Text="Employee ID"></asp:Label>
                    </td>
                    <td class="auto-style2">
                        <asp:TextBox ID="txtEID" runat="server" Width="477px"></asp:TextBox>
                    </td>
                    <td>&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="btnFindbyID" runat="server" Text="Find By ID" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        <asp:Label ID="lblEsal" runat="server" Font-Size="Small" Text="Salary"></asp:Label>
                    </td>
                    <td class="auto-style2">
                        <asp:TextBox ID="txtEsal" runat="server" Width="475px"></asp:TextBox>
                    </td>
                    <td rowspan="2">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        <asp:Label ID="lblDeptid" runat="server" Font-Size="Small" Text="Department ID"></asp:Label>
                    </td>
                    <td class="auto-style2">
                        <asp:TextBox ID="txtDeptid" runat="server" Width="474px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3" colspan="3">
                        <asp:Button ID="btnDisplay" runat="server" OnClick="btnDisplay_Click" Text="Display Emp" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="btnAddEmp" runat="server" Text="Add Emp" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="btnDeleteEmp" runat="server" OnClick="btnDeleteEmp_Click" Text="Delete Emp" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="btnUpdateEmp" runat="server" Text="Update Emp" />
                    </td>
                </tr>
            </table>
        </div>
        <table style="width: 80%;" border="1">
            <tr>
                <td class="auto-style5">
                    <asp:Label ID="lblEmpName" runat="server"></asp:Label>
                </td>
                <td class="auto-style6">
                    <asp:Label ID="lblEmpId" runat="server"></asp:Label>
                </td>
                <td class="auto-style6">
                    <asp:Label ID="lblEmpSal" runat="server"></asp:Label>
                </td>
                <td class="auto-style6">
                    <asp:Label ID="lblEmpDptID" runat="server"></asp:Label>
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
