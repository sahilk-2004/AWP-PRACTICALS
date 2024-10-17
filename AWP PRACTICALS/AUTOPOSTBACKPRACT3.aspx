<%@ Page Title="Server Controls Demo" Language="C#" AutoEventWireup="true" CodeBehind="ServerControlsDemo.aspx.cs" Inherits="YourNamespace.ServerControlsDemo" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Server Controls Demo</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Server Controls Demo</h2>

            <!-- TextBox with AutoPostBack -->
            <p>
                Enter your name:
                <asp:TextBox ID="TextBoxName" runat="server" AutoPostBack="True" OnTextChanged="TextBoxName_TextChanged"></asp:TextBox>
            </p>

            <!-- DropDownList with AutoPostBack -->
            <p>
                Select your favorite color:
                <asp:DropDownList ID="DropDownListColors" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownListColors_SelectedIndexChanged">
                    <asp:ListItem Value="Red">Red</asp:ListItem>
                    <asp:ListItem Value="Blue">Blue</asp:ListItem>
                    <asp:ListItem Value="Green">Green</asp:ListItem>
                </asp:DropDownList>
            </p>

            <!-- CheckBox with AutoPostBack -->
            <p>
                <asp:CheckBox ID="CheckBoxAgree" runat="server" Text="I agree to the terms and conditions" AutoPostBack="True" OnCheckedChanged="CheckBoxAgree_CheckedChanged" />
            </p>

            <!-- RadioButtonList with AutoPostBack -->
            <p>
                Choose your gender:
                <asp:RadioButtonList ID="RadioButtonListGender" runat="server" AutoPostBack="True" OnSelectedIndexChanged="RadioButtonListGender_SelectedIndexChanged">
                    <asp:ListItem Text="Male" Value="Male"></asp:ListItem>
                    <asp:ListItem Text="Female" Value="Female"></asp:ListItem>
                </asp:RadioButtonList>
            </p>

            <!-- Label to display output -->
            <p>
                <asp:Label ID="LabelOutput" runat="server" Text="Your information will appear here." ForeColor="Blue"></asp:Label>
            </p>
        </div>
    </form>
</body>
</html>
