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
            empFamilyNameTextBox.Text = string.Empty;
            empNationalCodeTextBox.Text = string.Empty;
            empPhoneNumberTextBox.Text = string.Empty;
            empMobileNumberTextBox.Text = string.Empty;
            empAddressTextBox.Text = string.Empty;

            empNameTextBox.Focus();
        }

        public void CodeGenerator()
        {
            Models.DatabaseContext databaseContext = null;

            try
            {
                databaseContext = new Models.DatabaseContext();

                var lastCode = databaseContext.Employees
                               .OrderBy(current => current.Code)
                               .Select(current => current.Code)
                               .FirstOrDefault();

                //if (lastCode > 0)
                //{
                //int lastCodeInt = System.Convert.ToInt32(lastCode);
                // lastCodeInt = lastCodeInt + 1;
                empCodeTextBox.Text = System.Convert.ToString(lastCode = lastCode++);
                return;
                //}

                
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
                        current.NationalCode, empNationalCodeTextBox.Text) == 0)
                        .FirstOrDefault();
                if (employee != null)
                {
                    System.Windows.Forms.MessageBox.Show("کارمندی با این کد ملی موجود می باشد !");
                    return;
                }

                employee = new Models.Employee
                {
                    Code = System.Convert.ToInt32(empCodeTextBox.Text),
                    Name = empNameTextBox.Text,
                    FamilyName = empFamilyNameTextBox.Text,
                    FatherName = empFamilyNameTextBox.Text,
                    NationalCode = empNationalCodeTextBox.Text,
                    MobileNumber = System.Convert.ToInt32(empMobileNumberTextBox.Text),
                    PhoneNumber = System.Convert.ToInt32(empPhoneNumberTextBox.Text),
                };

                databaseContext.Employees.Add(employee);
                databaseContext.SaveChanges();

                ResetForm();

                System.Windows.Forms.MessageBox.Show("مشخصات کارمند با موفقیت ثبت گردید ! ");
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
    }
}
