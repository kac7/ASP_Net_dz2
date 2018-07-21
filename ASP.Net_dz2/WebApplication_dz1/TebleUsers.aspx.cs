using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication_dz1
{
    public partial class TebleUsers : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CheckBoxList1.SelectedIndexChanged += CheckBoxList1_SelectedIndexChanged;
            if (!IsPostBack)
            {
                foreach (User v in Singleton.Instance.Users)
                {
                    string str = $"{v.Login}  -  {v.RoleUser.Name} <a class=\"link\" href=\"{"Edit.aspx?id=" + v.Id}\">Изменить</a>";
                    ListItem list = new ListItem { Text = str, Value = v.Id.ToString() };

                    CheckBoxList1.Items.Add(list);
                }
            }
            
            Return.NavigateUrl = $"Default.aspx";
        }

        private void CheckBoxList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListItem items in CheckBoxList1.Items)
            {
                if (items.Selected)
                {
                    del.Visible = true;
                    break;
                }
                else {
                    del.Visible = false;
                }
            }
        }
        protected void ButtonDelete_Click(object sender, EventArgs e)
        {
            List<ListItem> toBeRemoved = new List<ListItem>();
            for (int i = 0; i < CheckBoxList1.Items.Count; i++)
            {
                if (CheckBoxList1.Items[i].Selected == true)
                {
                    CheckBoxList1.Items[i].Value.ToString();
                    for (int j = 0; j < Singleton.Instance.Users.Count; j++)
                    {
                        if (Singleton.Instance.Users[j].Id.ToString() == CheckBoxList1.Items[i].Value.ToString())
                        {
                            Singleton.Instance.Users.RemoveAt(j);
                        }
                    }
                    toBeRemoved.Add(CheckBoxList1.Items[i]);
                }
            }
            for (int i = 0; i < toBeRemoved.Count; i++)
            {
                CheckBoxList1.Items.Remove(toBeRemoved[i]);
            }
            del.Visible = false;
        }
    }
}