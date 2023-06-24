<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RepeaterDataDemo2.aspx.cs" Inherits="EmployeeDetails.RepeaterDataDemo2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
            <asp:Repeater ID="Repeater1" runat="server" DataSourceID="SqlDataSource1">
                <HeaderTemplate>
                    <table border="1" width="50%">
                        <tr>
                            <th>Ecode</th><th>Ename</th><th>Salary</th><th>DeptiID</th>
                        </tr>
                </HeaderTemplate>
                <ItemTemplate>
                    <tr>
                        <td><asp:Label ID="Label1" runat="server" Text='<%#Eval("ecode")%>'></asp:Label></td>
                        <td><asp:Label ID="Label2" runat="server" Text='<%#Eval("ename")%>'></asp:Label></td>
                        <td><asp:Label ID="Label3" runat="server" Text='<%#Eval("salary")%>'></asp:Label></td>
                        <td><asp:Label ID="Label4" runat="server" Text='<%#Eval("deptid")%>'></asp:Label></td>
                    </tr>
                </ItemTemplate>
                <FooterTemplate> 
                    </table>
                 </FooterTemplate>    
               
              
            </asp:Repeater>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:CapgDBConnectionString %>" SelectCommand="SELECT * FROM [tbl_Employee]"></asp:SqlDataSource>
    </form>
</body>
</html>
