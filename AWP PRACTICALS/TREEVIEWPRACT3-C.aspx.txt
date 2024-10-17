<%@ Page Title="TreeView and Menu Demo" Language="C#" AutoEventWireup="true" CodeBehind="TreeViewMenuDemo.aspx.cs" Inherits="YourNamespace.TreeViewMenuDemo" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>TreeView and Menu Demo</title>
    <style>
        .menuStyle { 
            margin-bottom: 20px; 
        }
        .treeStyle {
            margin-top: 20px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>TreeView and Menu Demo</h2>

            <!-- Menu Control -->
            <asp:Menu ID="Menu1" runat="server" Orientation="Horizontal" CssClass="menuStyle">
                <Items>
                    <asp:MenuItem Text="Home" NavigateUrl="~/Home.aspx"></asp:MenuItem>
                    <asp:MenuItem Text="Products">
                        <asp:MenuItem Text="Electronics" NavigateUrl="~/Products/Electronics.aspx"></asp:MenuItem>
                        <asp:MenuItem Text="Clothing" NavigateUrl="~/Products/Clothing.aspx"></asp:MenuItem>
                        <asp:MenuItem Text="Books" NavigateUrl="~/Products/Books.aspx"></asp:MenuItem>
                    </asp:MenuItem>
                    <asp:MenuItem Text="About Us" NavigateUrl="~/About.aspx"></asp:MenuItem>
                    <asp:MenuItem Text="Contact Us" NavigateUrl="~/Contact.aspx"></asp:MenuItem>
                </Items>
            </asp:Menu>

            <!-- TreeView Control -->
            <asp:TreeView ID="TreeView1" runat="server" CssClass="treeStyle" OnSelectedNodeChanged="TreeView1_SelectedNodeChanged">
                <Nodes>
                    <asp:TreeNode Text="Departments" Value="Departments">
                        <asp:TreeNode Text="Sales" Value="Sales"></asp:TreeNode>
                        <asp:TreeNode Text="IT" Value="IT">
                            <asp:TreeNode Text="Development" Value="Development"></asp:TreeNode>
                            <asp:TreeNode Text="Support" Value="Support"></asp:TreeNode>
                        </asp:TreeNode>
                        <asp:TreeNode Text="HR" Value="HR"></asp:TreeNode>
                    </asp:TreeNode>
                </Nodes>
            </asp:TreeView>

            <!-- Label for Output -->
            <p>
                <asp:Label ID="LabelOutput" runat="server" Text="Select an item from the tree to display details." ForeColor="Blue"></asp:Label>
            </p>
        </div>
    </form>
</body>
</html>
