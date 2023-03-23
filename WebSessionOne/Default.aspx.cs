using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows;
using WebSessionOne.Context;
using WebSessionOne.Model;

namespace WebSessionOne
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txbFirst.Text == "" && txbLast.Text == "" &&
                    txbPat.Text == "" && txbMail.Text == "" 
                    && txbLog.Text == "" && txbPas.Text == "")
                {
                    throw new Exception("Заполните все поля!");
                }
                else
                {
                    UserAsp user = new UserAsp();
                    if (user.ID == 0)
                    {
                        user.FirstName = txbFirst.Text;
                        user.LastName = txbLast.Text;
                        user.Patronymic = txbPat.Text;
                        user.Email = txbMail.Text;
                        user.Login = txbLog.Text;
                        user.Password = txbPas.Text;
                        DataApp.db.UserAsp.Add(user);
                    }
                    DataApp.db.SaveChanges();
                    MessageBox.Show("Вы успешно зарегестрировались", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
                    Response.Redirect("~/about.aspx");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }
        }
    }
}