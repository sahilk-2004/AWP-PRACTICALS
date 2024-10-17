using System;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace YourNamespace
{
    public partial class TreeViewMenuDemo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Initial setup or actions can be added here if needed
            }
        }

        protected void TreeView1_SelectedNodeChanged(object sender, EventArgs e)
        {
            // Display the selected node's text and value when a node is clicked
            LabelOutput.Text = $"You selected: {TreeView1.SelectedNode.Text} (Value: {TreeView1.SelectedNode.Value})";
        }
    }
}
