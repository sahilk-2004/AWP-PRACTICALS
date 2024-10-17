<%@ Page Title="AdRotator Demo" Language="C#" AutoEventWireup="true" CodeBehind="AdRotatorDemo.aspx.cs" Inherits="YourNamespace.AdRotatorDemo" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>AdRotator Demo</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Advertisement Rotator</h2>
            <asp:AdRotator ID="AdRotator1" runat="server" AdFile="~/Ads.xml" />
        </div>
    </form>
</body>
</html>
