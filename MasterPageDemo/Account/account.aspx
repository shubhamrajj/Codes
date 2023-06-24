<%@ Page  Trace="true" Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="account.aspx.cs" Inherits="MasterPageDemo.Account.account" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="C1" runat="server">
    <br />
<strong>This is Account Page</strong><br />
<asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="1px" CellPadding="3" DataKeyNames="ecode" DataSourceID="SqlDataSource1" GridLines="Horizontal" Height="219px" Width="363px">
    <AlternatingRowStyle BackColor="#F7F7F7" />
    <Columns>
        <asp:BoundField DataField="ecode" HeaderText="ecode" ReadOnly="True" SortExpression="ecode" />
        <asp:BoundField DataField="ename" HeaderText="ename" SortExpression="ename" />
        <asp:BoundField DataField="salary" HeaderText="salary" SortExpression="salary" />
        <asp:BoundField DataField="deptid" HeaderText="deptid" SortExpression="deptid" />
    </Columns>
    <FooterStyle BackColor="#B5C7DE" ForeColor="#4A3C8C" />
    <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#F7F7F7" />
    <PagerStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" HorizontalAlign="Right" />
    <RowStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" />
    <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="#F7F7F7" />
    <SortedAscendingCellStyle BackColor="#F4F4FD" />
    <SortedAscendingHeaderStyle BackColor="#5A4C9D" />
    <SortedDescendingCellStyle BackColor="#D8D8F0" />
    <SortedDescendingHeaderStyle BackColor="#3E3277" />
</asp:GridView>
<asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:CapgDBConnectionString %>" SelectCommand="SELECT * FROM [tbl_Employee]"></asp:SqlDataSource>
<br />
<br />
<br />
<br />
</asp:Content>
