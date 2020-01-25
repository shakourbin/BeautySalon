using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hsh.Windows.Forms;

namespace BeautySalon.Infrastructure
{
    public static class Utility
    {
        static Utility()
        {
        }

        public static Models.User AuthenticatedUser { get; set; }

        private static BeautySalon.UserLoginForm userLoginForm;
        public static BeautySalon.UserLoginForm UserLoginForm
        {
            get
            {
                if(userLoginForm== null)
                {
                    userLoginForm = new BeautySalon.UserLoginForm();
                }
                return userLoginForm;
            }
        }

        private static BeautySalon.UserRegisterForm userRegisterForm;
        public static BeautySalon.UserRegisterForm UserRegisterForm
        {
            get
            {
                if (userRegisterForm == null)
                {
                    userRegisterForm = new BeautySalon.UserRegisterForm();
                }
                return userRegisterForm;
            }
        }

        private static BeautySalon.MainForm mainForm;
        public static BeautySalon.MainForm MainForm
        {
            get
            {
                if (mainForm == null)
                {
                    mainForm = new BeautySalon.MainForm();
                }
                return mainForm;
            }
        }

        private static BeautySalon.ChangePassword changePassword;
        public static BeautySalon.ChangePassword ChangePassword
        {
            get
            {
                if (changePassword == null)
                {
                    changePassword = new ChangePassword();
                }
                return changePassword;
            }
        }

        private static BeautySalon.Admin.EmployeeRegisterForm employeeRegisterForm;
        public static BeautySalon.Admin.EmployeeRegisterForm EmployeeRegisterForm
        {
            get
            {
                if (employeeRegisterForm == null)
                {
                    employeeRegisterForm = new Admin.EmployeeRegisterForm();
                }
                return employeeRegisterForm;
            }
        }

    }
}
