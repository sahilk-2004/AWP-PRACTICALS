using System;

namespace WebApplication13
{
    public partial class MyUserControl : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnClickMe_Click(object sender, EventArgs e)
        {
            lblMessage.Text = "Button clicked at " + DateTime.Now.ToString();
        }
    }
}
