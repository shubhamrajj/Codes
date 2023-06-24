<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RepeatersDataDemo.aspx.cs" Inherits="EmployeeDetails.RepeatersDataDemo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Repeater ID="Repeater1" runat="server" DataSourceID="SqlDataSource1">
                <HeaderTemplate>
                    <asp:Label ID="Label1" runat="server" Text="Employee Details 2022" Font-Size="Large" ForeColor="#FF3300" Font-Bold="True"></asp:Label>
                    <hr color="red" size="10%" />
                </HeaderTemplate>
                <ItemTemplate>
                    Ecode:<asp:Label ID="Label3" runat="server" Text='<%#Eval("ecode")%>'></asp:Label>
                    <br />
                    Ename:<asp:Label ID="Label4" runat="server" Text='<%#Eval("ename")%>'></asp:Label>
                    <br />
                    Salary:<asp:Label ID="Label5" runat="server" Text='<%#Eval("salary")%>'></asp:Label>
                    <br />
                    DeptID:<asp:Label ID="Label6" runat="server" Text='<%#Eval("deptid")%>'></asp:Label>
                    <br />
                    Bonus:<asp:Label ID="Label7" runat="server" Text='<%#GetBonus(Eval("salary"))%>'></asp:Label>
                    <hr />
                </ItemTemplate>
                <FooterTemplate>
                    <hr color="blue" size="5%"/>
                    <asp:Label ID="Label2" runat="server" Text="-----End of Record-----"></asp:Label>
                </FooterTemplate>
            </asp:Repeater>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:CapgDBConnectionString %>" DeleteCommand="DELETE FROM [tbl_Employee] WHERE [ecode] = @ecode" InsertCommand="INSERT INTO [tbl_Employee] ([ecode], [ename], [salary], [deptid]) VALUES (@ecode, @ename, @salary, @deptid)" SelectCommand="SELECT * FROM [tbl_Employee]" UpdateCommand="UPDATE [tbl_Employee] SET [ename] = @ename, [salary] = @salary, [deptid] = @deptid WHERE [ecode] = @ecode">
                <DeleteParameters>
                    <asp:Parameter Name="ecode" Type="Int32" />
                </DeleteParameters>
                <InsertParameters>
                    <asp:Parameter Name="ecode" Type="Int32" />
                    <asp:Parameter Name="ename" Type="String" />
                    <asp:Parameter Name="salary" Type="Int32" />
                    <asp:Parameter Name="deptid" Type="Int32" />
                </InsertParameters>
                <UpdateParameters>
                    <asp:Parameter Name="ename" Type="String" />
                    <asp:Parameter Name="salary" Type="Int32" />
                    <asp:Parameter Name="deptid" Type="Int32" />
                    <asp:Parameter Name="ecode" Type="Int32" />
                </UpdateParameters>
            </asp:SqlDataSource>
        </div>
    </form>
</body>
</html>
