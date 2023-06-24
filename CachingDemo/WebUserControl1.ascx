<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="WebUserControl1.ascx.cs" Inherits="CachingDemo.WebUserControl1" %>
<%@ OutputCache Duration="15" VaryByParam="None"%>
<asp:Label ID="lblMsg" runat="server" ForeColor="#FF3300"></asp:Label>
<p>
    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
</p>

