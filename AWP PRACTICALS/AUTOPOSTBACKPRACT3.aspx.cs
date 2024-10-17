using System;
using System.Web.UI;

namespace YourNamespace
{
    public partial class ServerControlsDemo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void TextBoxName_TextChanged(object sender, EventArgs e)
        {
            LabelOutput.Text = $"Hello, {TextBoxName.Text}!";
        }

        protected void DropDownListColors_SelectedIndexChanged(object sender, EventArgs e)
        {
            LabelOutput.Text = $"You selected the color: {DropDownListColors.SelectedItem.Text}";
        }

        protected void CheckBoxAgree_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBoxAgree.Checked)
            {
                LabelOutput.Text = "Thank you for agreeing to the terms.";
            }
            else
            {
                LabelOutput.Text = "Please agree to the terms and conditions.";
            }
        }

        protected void RadioButtonListGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            LabelOutput.Text = $"Gender selected: {RadioButtonListGender.SelectedItem.Text}";
        }
    }
}
