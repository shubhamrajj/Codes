<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FormViewDemo.aspx.cs" Inherits="EmployeeDetails.FormViewDemo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:FormView ID="FormView1" runat="server" AllowPaging="True" DataKeyNames="ecode" DataSourceID="SqlDataSource1" Width="255px">
                <EditItemTemplate>
                    ecode:
                    <asp:Label ID="ecodeLabel1" runat="server" Text='<%# Eval("ecode") %>' />
                    <br />
                    ename:
                    <asp:TextBox ID="enameTextBox" runat="server" Text='<%# Bind("ename") %>' />
                    <br />
                    salary:
                    <asp:TextBox ID="salaryTextBox" runat="server" Text='<%# Bind("salary") %>' />
                    <br />
                    deptid:
                    <asp:TextBox ID="deptidTextBox" runat="server" Text='<%# Bind("deptid") %>' />
                    <br />
                    <asp:LinkButton ID="UpdateButton" runat="server" CausesValidation="True" CommandName="Update" Text="Update" />
                    &nbsp;<asp:LinkButton ID="UpdateCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
                </EditItemTemplate>
                <InsertItemTemplate>
                    ecode:
                    <asp:TextBox ID="ecodeTextBox" runat="server" Text='<%# Bind("ecode") %>' />
                    <br />
                    ename:
                    <asp:TextBox ID="enameTextBox" runat="server" Text='<%# Bind("ename") %>' />
                    <br />
                    salary:
                    <asp:TextBox ID="salaryTextBox" runat="server" Text='<%# Bind("salary") %>' />
                    <br />
                    deptid:
                    <asp:TextBox ID="deptidTextBox" runat="server" Text='<%# Bind("deptid") %>' />
                    <br />
                    <asp:LinkButton ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert" Text="Insert" />
                    &nbsp;<asp:LinkButton ID="InsertCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
                </InsertItemTemplate>
                <ItemTemplate>
                    ecode:
                    <asp:Label ID="ecodeLabel" runat="server" Text='<%# Eval("ecode") %>' />
                    <br />
                    ename:
                    <asp:Label ID="enameLabel" runat="server" Text='<%# Bind("ename") %>' />
                    <br />
                    salary:
                    <asp:Label ID="salaryLabel" runat="server" Text='<%# Bind("salary") %>' />
                    <br />
                    deptid:
                    <asp:Label ID="deptidLabel" runat="server" Text='<%# Bind("deptid") %>' />
                    <br />

                    <asp:LinkButton ID="EditButton" runat="server" CausesValidation="False" CommandName="Edit" Text="Edit" />
                    &nbsp;<asp:LinkButton ID="DeleteButton" runat="server" CausesValidation="False" CommandName="Delete" Text="Delete" />
                    &nbsp;<asp:LinkButton ID="NewButton" runat="server" CausesValidation="False" CommandName="New" Text="New" />
                </ItemTemplate>
            </asp:FormView>
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
