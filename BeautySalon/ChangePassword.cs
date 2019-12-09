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
    public partial class ChangePassword : Infrastructure.BaseForm
    {
        public ChangePassword()
        {
            InitializeComponent();
        }

        //دستور انصراف
        public void ResetForm()
        {
            oldPasswordTextBox.Text = string.Empty;
            newPasswordTextBox.Text = string.Empty;
            passwordConfirmTextBox.Text = string.Empty;

            oldPasswordTextBox.Focus();
        }

        // کلیک بر روی دکمه ی انصراف و پاک کردن فرم 
        private void ResetButton_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        // ذخیره ی پسوورد جدید 
        private void SaveButton_Click(object sender, EventArgs e)
        {
            string errorMessage = string.Empty;

            if (string.IsNullOrWhiteSpace(oldPasswordTextBox.Text))
            {
                errorMessage = " ! وارد کردن رمز عبور قدیمی الزامی می باشد ";
            }

            if (string.IsNullOrWhiteSpace(newPasswordTextBox.Text))
            {
                if (errorMessage != string.Empty)
                {
                    errorMessage += System.Environment.NewLine;
                }

                errorMessage += " ! وارد کردن رمز عبور جدید الزامی می باشد ";
            }
            else
            {
                if (newPasswordTextBox.Text.Length < 8)
                {
                    if (errorMessage != string.Empty)
                    {
                        errorMessage += System.Environment.NewLine;
                    }

                    errorMessage += " رمز عبور باید حداقل شامل 8 کاراکتر باشد ! ";
                }
            }

            if (string.IsNullOrWhiteSpace(passwordConfirmTextBox.Text))
            {
                if (errorMessage != string.Empty)
                {
                    errorMessage += System.Environment.NewLine;
                }

                errorMessage += "   تکرار رمز عبور جدید الزامی است !";
            }
            else
            {
                if (string.Compare(
                    passwordConfirmTextBox.Text, newPasswordTextBox.Text, ignoreCase: false) != 0)
                {
                    if (errorMessage != string.Empty)
                    {
                        errorMessage += System.Environment.NewLine;
                    }

                    errorMessage += "  تکرار رمز عبور اشتباه می باشد !  ";
                }
            }

            if (errorMessage != string.Empty)
            {
                System.Windows.Forms.MessageBox.Show(errorMessage);

                oldPasswordTextBox.Focus();

                return;
            }

            Models.DatabaseContext databaseContext = null;

            try
            {
                databaseContext = new Models.DatabaseContext();
                Models.User currentUser = databaseContext.Users
                    .Where(current => current.Id == Infrastructure.Utility.AuthenticatedUser.Id)
                    .FirstOrDefault();

                if (currentUser == null)
                {
                    System.Windows.Forms.Application.Exit();
                }

                if (string.Compare(
                    currentUser.Password, oldPasswordTextBox.Text, ignoreCase: false) != 0)
                {
                    System.Windows.Forms.MessageBox.Show("  پسوورد قدیمی اشتباه می باشد ! ");
                    oldPasswordTextBox.Focus();
                    return;
                }

                currentUser.Password = newPasswordTextBox.Text;

                databaseContext.SaveChanges();

                System.Windows.Forms.MessageBox.Show(" رمز شما با موفقیت تغییر یافت ! ");

                ResetForm();

                return;
            }

            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show($" Error : {ex.Message}");
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
