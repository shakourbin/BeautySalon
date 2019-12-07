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

                if ((string.Compare(
                    currentUser.Password, oldPasswordTextBox.Text, ignoreCase: false) != 0) 
                    && string.IsNullOrWhiteSpace(oldPasswordTextBox.Text))
                {
                    System.Windows.Forms.MessageBox.Show(" ! پسوورد قدیمی اشتباه می باشد  ");
                    oldPasswordTextBox.Focus();
                    return;
                }

                if (string.Compare(
                    currentUser.Password, oldPasswordTextBox.Text, ignoreCase: false) == 0)
                {
                    if (string.Compare(
                        newPasswordTextBox.Text, passwordConfirmTextBox.Text, ignoreCase: false) != 0
                        && string.IsNullOrWhiteSpace(newPasswordTextBox.Text))
                    {
                        System.Windows.Forms.MessageBox.Show(" تکرار رمز جدید صحیح نمی باشد ! ");
                    }

                    currentUser.Password = newPasswordTextBox.Text;
                    databaseContext.SaveChanges();

                    System.Windows.Forms.MessageBox.Show(" رمز شما با موفقیت تغییر یافت ! ");
                    return;
                }
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
