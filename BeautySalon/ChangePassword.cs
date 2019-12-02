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

                if (string.Compare(currentUser.Password , oldPasswordTextBox.Text , ignoreCase: false) !=0 )
                {

                }
                    

            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
