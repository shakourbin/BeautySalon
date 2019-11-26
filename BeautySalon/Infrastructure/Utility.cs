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
    }
}
