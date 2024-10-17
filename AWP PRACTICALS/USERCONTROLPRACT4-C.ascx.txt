<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="MyUserControl.ascx.cs" Inherits="WebApplication13.MyUserControl" %>
<div style="border: 1px solid #ccc; padding: 10px;">
    <h3>User Control Header</h3>
    <asp:Label ID="lblMessage" runat="server" Text="Hello from User Control!"></asp:Label>
    <asp:Button ID="btnClickMe" runat="server" Text="Click Me!" OnClick="btnClickMe_Click" />
</div>
