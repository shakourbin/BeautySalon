using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeautySalon
{
    public partial class UserLoginForm : Infrastructure.BaseForm
    {
        public UserLoginForm()
        {
            InitializeComponent();
        }

        // دستور ریست شدن فرم ورود به سیستم  
        public void ResetForm()
        {
            usernameTextBox.Text = string.Empty;
            passwordTextBox.Text = string.Empty;

            usernameTextBox.Focus();
        }

        // انجام دستور ریست شدن فرم ورود به سیستم در هنگام کلیک بر روی دکمه انصراف
        private void ResetButton_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        //خروج از برنامه در صورت کلیک بر روی کلید خروج 
        private void ExitButton_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        //باز شدن پنجره ثبت نام در هنگام کلیک بر روی دکمه ی ثبت نام
        private void RegisterButton_Click(object sender, EventArgs e)
        {
            Hide();
            Infrastructure.Utility.UserRegisterForm.Show();
        }

        // ورود به سیستم در هنگام کلیک بر روی دکمه ی ورود 
        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(usernameTextBox.Text) ||
                string.IsNullOrWhiteSpace(passwordTextBox.Text))
            {
                usernameTextBox.Text =
                    usernameTextBox.Text.Replace(" ", string.Empty);
                passwordTextBox.Text =
                    passwordTextBox.Text.Replace(" ", string.Empty);

                System.Windows.MessageBox
                    .Show("!نام کاربری و رمز عبور الزامی می باشد ");

                if (usernameTextBox.Text == string.Empty)
                {
                    usernameTextBox.Focus();
                }
                else
                {
                    passwordTextBox.Focus();
                }
                return;
            }
            Models.DatabaseContext databaseContext = null;

            try
            {
                databaseContext = new Models.DatabaseContext();

                Models.User foundedeUser = databaseContext.Users
                    .Where(current => string.Compare(current.UserName, usernameTextBox.Text, true) == 0)
                    .FirstOrDefault();

                if (foundedeUser == null)
                {
                    System.Windows.Forms.MessageBox
                        .Show("  !نام کاربری یا رمز عبور اشتباه می باشد ");
                    usernameTextBox.Focus();

                    return;
                }
                if (string.Compare(foundedeUser.Password, passwordTextBox.Text, ignoreCase: false) != 0)
                {
                    System.Windows.Forms.MessageBox
                        .Show("! نام کاربری یا رمز عبور اشتباه می باشد ");
                    usernameTextBox.Focus();

                    return;
                }
                if (foundedeUser.IsActive == false)
                {
                    System.Windows.Forms.MessageBox
                        .Show("! کاربر غیر فعال می باشد ، با سرپرست سیستم تماس بگیرید  ");

                    usernameTextBox.Focus();

                    return;
                }

                Infrastructure.Utility.AuthenticatedUser = foundedeUser;

                Hide();

                Infrastructure.Utility.MainForm.Show();

            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox
                    .Show($"Error {ex.Message}");
            }
            finally
            {
                if (databaseContext != null)
                {
                    databaseContext.Dispose();
                    databaseContext = null;
                }
            }
        }
    }
}
