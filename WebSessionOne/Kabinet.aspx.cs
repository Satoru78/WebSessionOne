using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebSessionOne.Model;

namespace WebSessionOne
{
    public partial class Kabinet : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            UserAsp userAsp = new UserAsp();
            Label2.Text = $"{userAsp.Patronymic}";
            if (!IsPostBack)
            {             

                BindGridView();
                
            }
        }
        protected void BindGridView()
        {
            using (var db = new WsrTestEntities())
            {
                var data = db.Request.ToList();
                GridView1.DataSource = data;
                GridView1.DataBind();
            }
        }
        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/contact.aspx");
        }
    }
}