using System;

public partial class MasterPage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // Optional: Set year in a Literal control if added in footer
        // litYear.Text = DateTime.Now.Year.ToString();
    }
}
