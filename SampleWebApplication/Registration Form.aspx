<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registration Form.aspx.cs" Inherits="SampleWebApplication.Registration_Form" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
            background-color: #FFFFFF;
            color: #0000FF;
        }
        .auto-style2 {
            width: 193px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
            <table style="width:100%;">
                <tr>
                    <td class="auto-style1"  colspan="2"><strong>Registration Form for a Course</strong></td>
                </tr>
                <tr>
                    <td class="auto-style2">Name:</td>
                    <td>
                        <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtName" Display="Dynamic" ErrorMessage="Required Field" Font-Bold="True" Font-Size="Small" ForeColor="#FF3300" SetFocusOnError="True"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Choose City:</td>
                    <td>
                        <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True">
                            <asp:ListItem>Chennai</asp:ListItem>
                            <asp:ListItem>Kolkata</asp:ListItem>
                            <asp:ListItem>Mumbai</asp:ListItem>
                            <asp:ListItem>Bangalore</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Select Course:</td>
                    <td>
                        <asp:ListBox ID="ListBox1" runat="server" SelectionMode="Multiple">
                            <asp:ListItem>OCA</asp:ListItem>
                            <asp:ListItem>PMP</asp:ListItem>
                            <asp:ListItem>SCJP</asp:ListItem>
                            <asp:ListItem>MCTS</asp:ListItem>
                            <asp:ListItem>JAVA</asp:ListItem>
                            <asp:ListItem>MVC</asp:ListItem>
                            <asp:ListItem>CIS</asp:ListItem>
                            <asp:ListItem>ADO</asp:ListItem>
                            <asp:ListItem>DEV</asp:ListItem>
                        </asp:ListBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Date:</td>
                    <td>
                        <asp:Calendar ID="Calendar1" runat="server" BackColor="White" BorderColor="Black" BorderStyle="Solid" CellSpacing="1" Font-Names="Verdana" Font-Size="9pt" ForeColor="Black" Height="250px" NextPrevFormat="ShortMonth" Width="330px">
                            <DayHeaderStyle Font-Bold="True" Font-Size="8pt" ForeColor="#333333" Height="8pt" />
                            <DayStyle BackColor="#CCCCCC" />
                            <NextPrevStyle Font-Bold="True" Font-Size="8pt" ForeColor="White" />
                            <OtherMonthDayStyle ForeColor="#999999" />
                            <SelectedDayStyle BackColor="#333399" ForeColor="White" />
                            <TitleStyle BackColor="#333399" BorderStyle="Solid" Font-Bold="True" Font-Size="12pt" ForeColor="White" Height="12pt" />
                            <TodayDayStyle BackColor="#999999" ForeColor="White" />
                        </asp:Calendar>
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Button ID="btnSubmit" runat="server" BackColor="#66CCFF" BorderColor="#0099FF" OnClick="btnSubmit_Click" Text="Submit" />
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Label ID="lblMsg1" runat="server" ForeColor="#DF872F"></asp:Label>
                        <br />
                        <asp:Label ID="lblMsg2" runat="server" ForeColor="#DF872F" ></asp:Label>
                        <br />
                        <asp:Label ID="lblMsg3" runat="server" ForeColor="#DF872F"></asp:Label>
                        <br />
                        <asp:Label ID="lblMsg4" runat="server" ForeColor="#DF872F"></asp:Label>
                        <br />
                    </td>
                    
                </tr>
            </table>
    </form>
</body>
</html>
