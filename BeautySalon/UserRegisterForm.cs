using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeautySalon.Admin
{
    public partial class UserRegisterForm : Infrastructure.BaseForm
    {
        public UserRegisterForm()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            Hide();
            Infrastructure.Utility.UserLoginForm.Show();
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        public void ResetForm ()
        {
            usernameTextBox.Text = string.Empty;
            passwordTextBox.Text = string.Empty;
            userFamilyNameTextBox.Text = string.Empty;
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            Models.DatabaseContext databaseContext = null;
            try
            {
                databaseContext = new Models.DatabaseContext();
                Models.User user = databaseContext.Users
                    .Where(current => string.Compare(current.UserName, usernameTextBox.Text, true) == 0)
                    .FirstOrDefault();

                if (databaseContext != null)
                {
                    System.Windows.Forms.MessageBox.Show("! کاربری با این نام موجود می باشد ");
                    usernameTextBox.Focus();

                    return;
                }

                user = new Models.User
                {
                    UserName = usernameTextBox.Text,
                    Password = passwordTextBox.Text,
                    FamilyName = userFamilyNameTextBox.Text,
                };
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
