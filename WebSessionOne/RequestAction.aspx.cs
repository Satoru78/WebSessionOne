using Microsoft.Win32;
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
    public partial class RequestAction : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                Visitor visitor = new Visitor();
                if (visitor.ID == 0)
                {
                    visitor.FirstName = txbFirstName.Text;
                    visitor.LastName = txbName.Text;
                    visitor.Patronymic = txbPatr.Text;
                    visitor.Phone = txbPhone.Text;
                    visitor.Mail = txbEmail.Text;
                    visitor.Organization = txbOrg.Text;
                    visitor.Note = txbNote.Text;
                    visitor.DateOfBirth = DateTime.Parse(txbDateOfBirth.Text);
                    visitor.Serial = int.Parse(txbSerial.Text);
                    visitor.Number = int.Parse(txbNumber.Text);

                    DataApp.db.Visitor.Add(visitor);
                }
                DataApp.db.SaveChanges();
                MessageBox.Show("Данные сохранены", "Успешно", MessageBoxButton.OK, MessageBoxImage.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Произошла ошибка");
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/contact.aspx");
        }
        OpenFileDialog open = new OpenFileDialog();
        protected void Button1_Click(object sender, EventArgs e)
        {
            open.ShowDialog();
        }
    }
}