<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DataGridDemo.aspx.cs" Inherits="EmployeeDetails.DataGridDemo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 189px;
        }
        .auto-style2 {
            width: 189px;
            text-align: right;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="X-Large" ForeColor="#CC3300" Text="GridView Binding Demo"></asp:Label>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" DataSourceID="SqlDataSource1" ForeColor="#333333" GridLines="None" Height="281px" Width="456px" AllowPaging="True" AllowSorting="True" DataKeyNames="ecode">
                <AlternatingRowStyle BackColor="White" />
                <Columns>
                    <asp:BoundField DataField="ecode" HeaderText="ecode" ReadOnly="True" SortExpression="ecode" />
                    <asp:BoundField DataField="ename" HeaderText="ename" SortExpression="ename" />
                    <asp:BoundField DataField="salary" HeaderText="salary" SortExpression="salary" />
                    <asp:BoundField DataField="deptid" HeaderText="deptid" SortExpression="deptid" />
                </Columns>
                <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
                <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
                <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
                <SortedAscendingCellStyle BackColor="#FDF5AC" />
                <SortedAscendingHeaderStyle BackColor="#4D0000" />
                <SortedDescendingCellStyle BackColor="#FCF6C0" />
                <SortedDescendingHeaderStyle BackColor="#820000" />
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:CapgDBConnectionString %>" OnSelecting="SqlDataSource1_Selecting" SelectCommand="SELECT * FROM [tbl_Employee]" DeleteCommand="DELETE FROM [tbl_Employee] WHERE [ecode] = @ecode" InsertCommand="INSERT INTO [tbl_Employee] ([ecode], [ename], [salary], [deptid]) VALUES (@ecode, @ename, @salary, @deptid)" UpdateCommand="UPDATE [tbl_Employee] SET [ename] = @ename, [salary] = @salary, [deptid] = @deptid WHERE [ecode] = @ecode">
                <DeleteParameters>
                    <asp:Parameter Name="ecode" Type="Int32" />
                </DeleteParameters>
                <InsertParameters>
                    <asp:ControlParameter ControlID="txtEcode" Name="ecode" PropertyName="Text" Type="Int32" />
                    <asp:ControlParameter ControlID="txtEname" Name="ename" PropertyName="Text" Type="String" />
                    <asp:ControlParameter ControlID="txtSal" Name="salary" PropertyName="Text" Type="Int32" />
                    <asp:ControlParameter ControlID="txtDeptid" Name="deptid" PropertyName="Text" Type="Int32" />
                </InsertParameters>
                <UpdateParameters>
                    <asp:Parameter Name="ename" Type="String" />
                    <asp:Parameter Name="salary" Type="Int32" />
                    <asp:Parameter Name="deptid" Type="Int32" />
                    <asp:Parameter Name="ecode" Type="Int32" />
                </UpdateParameters>
            </asp:SqlDataSource>
            <table style="width: 50%;" border="1">
                <tr>
                    <td class="auto-style1">Enter Ecode :</td>
                    <td>
                        <asp:TextBox ID="txtEcode" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">Enter Ename :</td>
                    <td>
                        <asp:TextBox ID="txtEname" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">Enter Salary :</td>
                    <td>
                        <asp:TextBox ID="txtSal" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">Enter DeptID :</td>
                    <td>
                        <asp:TextBox ID="txtDeptid" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Button ID="BtnAdd" runat="server" OnClick="BtnAdd_Click" Text="Add" />
                    </td>
                    <td>
                        <asp:Label ID="lblMsg" runat="server" ForeColor="Red"></asp:Label>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
