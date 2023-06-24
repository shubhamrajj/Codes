<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DetailsViewDemo.aspx.cs" Inherits="EmployeeDetails.DetailsViewDemo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:DetailsView ID="DetailsView1" runat="server" AllowPaging="True" AutoGenerateRows="False" BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" CellPadding="4" DataKeyNames="ecode" DataSourceID="SqlDataSource1" Height="332px" Width="538px">
                <EditRowStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
                <Fields>
                    <asp:BoundField DataField="ecode" HeaderText="ecode" ReadOnly="True" SortExpression="ecode" />
                    <asp:BoundField DataField="ename" HeaderText="ename" SortExpression="ename" />
                    <asp:BoundField DataField="salary" HeaderText="salary" SortExpression="salary" />
                    <asp:BoundField DataField="deptid" HeaderText="deptid" SortExpression="deptid" />
                    <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" ShowInsertButton="True" />
                </Fields>
                <FooterStyle BackColor="#99CCCC" ForeColor="#003399" />
                <HeaderStyle BackColor="#003399" Font-Bold="True" ForeColor="#CCCCFF" />
                <PagerStyle BackColor="#99CCCC" ForeColor="#003399" HorizontalAlign="Left" />
                <RowStyle BackColor="White" ForeColor="#003399" />
            </asp:DetailsView>
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
