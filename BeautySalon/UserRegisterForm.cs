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
    public partial class UserRegisterForm :Infrastructure.BaseForm
    {
        public UserRegisterForm()
        {
            InitializeComponent();
        }

        //باز شدن پنجره ورود به سیستم در هنگام کلیک بر روی دکمه ی ورود
        private void LoginButton_Click(object sender, EventArgs e)
        {
            Hide();
            Infrastructure.Utility.UserLoginForm.Show();
        }

        // انجام دستور ریست شدن فرم ثبت نام در هنگام کلیک بر روی دکمه انصراف
        private void ResetButton_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        // دستور ریست شدن فرم ثبت نام 
        private void ResetForm ()
        {
            usernameTextBox.Text = string.Empty;
            passwordTextBox.Text = string.Empty;
            userFamilyNameTextBox.Text = string.Empty;
        }
        
        // انجام عملیات ثبت نام در هنگام کلیک بر دکمه ی ثبت 
        private void RegisterButton_Click(object sender, EventArgs e)
        {
            //چک کردن خالی نبودن نام کاربری و رمز عبور در هنگام ثبت نام 
            if (string.IsNullOrWhiteSpace(usernameTextBox.Text) ||
                string.IsNullOrWhiteSpace(passwordTextBox.Text))
            {
                usernameTextBox.Text =
                    usernameTextBox.Text.Replace(" ", string.Empty);

                passwordTextBox.Text =
                    passwordTextBox.Text.Replace(" ", string.Empty);

                System.Windows.Forms.MessageBox.Show(" ! نام کاربری و پسوورد الزامی است ");

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

            // انجام عملیات ذخیره ی کاربر جدید 
            Models.DatabaseContext databaseContext = null;
            try
            {
                databaseContext = new Models.DatabaseContext();
                Models.User user = databaseContext.Users
                    .Where(current => string.Compare(current.UserName, usernameTextBox.Text, true) == 0)
                    .FirstOrDefault();

                if (user != null)
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
                    IsActive = true,
                };

                databaseContext.Users.Add(user);
                databaseContext.SaveChanges();

                System.Windows.Forms.MessageBox.Show("! ثبت نام با موفقیت انجام شد ");

                ResetForm();
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show($"Error{ ex.Message }");
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

        //خروج از برنامه در صورت کلیک بر روی کلید خروج
        private void ExitButton_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void UserRegisterForm_Load(object sender, EventArgs e)
        {

        }
    }
}
