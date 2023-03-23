using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows;
using WebSessionOne.Context;

namespace WebSessionOne
{
    public partial class About : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txbLog.Text == "" && txbPas.Text == "")
                {
                    throw new Exception("Заполните все поля");
                }
                else
                {
                    var userLogin = DataApp.db.UserAsp.FirstOrDefault(item => item.Login == txbLog.Text || item.Password == txbPas.Text);
                    if (userLogin != null)
                    {
                        Response.Redirect("~/contact.aspx");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show( ex.Message , "Ошибка");
            }
        }
    }
}