using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using UserLoginApp.BLL;

namespace UserLoginApp
{
    public partial class Index : System.Web.UI.Page
    {
        UserManager aManager=new UserManager();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void saveButton_Click(object sender, EventArgs e)
        {
            
            string name = nameTextBox.Text;
            String password = passwordTextbox.Text;
             int id=aManager.GetUser(name, password);
            Session["id"] = id;
            if (id > 0)
            {
                Response.Redirect("Home.aspx");
            }
            else
            {
                msgLevel.Text = "User name or Password is Invalid";
            }
        }
    }
}