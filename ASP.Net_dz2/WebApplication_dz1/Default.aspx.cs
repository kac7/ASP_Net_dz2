using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication_dz1
{
    public partial class Default : System.Web.UI.Page
    {
        Singleton instance = Singleton.Instance;
        
        protected void Page_Load(object sender, EventArgs e)
        {
            HyperLink1.NavigateUrl = $"TebleUsers.aspx";
        }
        protected void ButtonAdd_Click(object sender, EventArgs e)
        {
            instance.Users.Add( new User {
                Id = instance.id,
                City = City.Text,
                Email = Email.Text,
                FirstName = FirstName.Text,
                LastName = LastName.Text,
                Login = Login.Text,
                Password = Password.Text,
                RoleUser = new Role(ListBoxRole.SelectedItem.Text)
            });
            Password.Text = ""; 
            Login.Text = "";
            FirstName.Text = "";
            LastName.Text = "";
            City.Text = "";
            Email.Text = "";
            instance.id++;
        }
    }
}