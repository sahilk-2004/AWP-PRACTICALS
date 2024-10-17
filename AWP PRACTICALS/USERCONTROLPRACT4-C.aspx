<%@ Page Title="User Control Demo" Language="C#" AutoEventWireup="true" CodeBehind="UserControlDemo.aspx.cs" Inherits="WebApplication13.UserControlDemo" %>
<%@ Register TagPrefix="uc" TagName="MyUserControl" Src="~/MyUserControl.ascx" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>User Control Demo</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Demonstration of User Control</h2>
            <uc:MyUserControl ID="MyUserControl1" runat="server" />
        </div>
    </form>
</body>
</html>
