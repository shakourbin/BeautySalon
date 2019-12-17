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
    public partial class EmployeeRegisterForm : Infrastructure.BaseForm
    {
        public EmployeeRegisterForm()
        {
            InitializeComponent();
        }

        public void ResetForm()
        {
            empNameTextBox.Text = string.Empty;
            empFamilyNameTextBox.Text = string.Empty;
            empIdentityCodeTextBox.Text = string.Empty;
            empTelephoenumberTextBox.Text = string.Empty;
            empMobileNumberTextBox.Text = string.Empty;
            empAddressTextBox.Text = string.Empty;
        }

        public void CodeGenerator()
        {
            Models.DatabaseContext databaseContext = null;

            try
            {
                databaseContext = new Models.DatabaseContext();
                var lastCode = databaseContext.Employees
                               .OrderBy(current => current.EmployeeCode)
                               .Select(current => current.EmployeeCode)
                               .FirstOrDefault();

                if (lastCode != null)
                {
                    int lastCodeInt = System.Convert.ToInt32(lastCode);
                    lastCodeInt = lastCodeInt + 1;
                    empCodeTextBox.Text = System.Convert.ToString(lastCodeInt);
                    return;
                }

                empCodeTextBox.Text = "1";
                return;
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show($"Error: {ex.Message}");
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

        private void EmployeeRegisterForm_Load(object sender, EventArgs e)
        {
            CodeGenerator();
        }

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
                Models.Employee employee = databaseContext.Employees
                    .Where(current => string.Compare(
                        current.IdentityCode, empIdentityCodeTextBox.Text , ignoreCase:true) == 0)
                        .FirstOrDefault();
                    
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
