﻿using System;
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
    public partial class MainForm : BeautySalon.Infrastructure.BaseForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        // خروج از برنامه
        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = System.Windows.Forms.MessageBox.Show(
                icon: MessageBoxIcon.Question,
                caption: "سوال ؟ ",
                buttons: MessageBoxButtons.YesNo,
                defaultButton: MessageBoxDefaultButton.Button2,
                text: " آیا به خروج از برنامه اطمینان دارید ؟ "
                );

            if (dialogResult == DialogResult.Yes)
            {
                System.Windows.Forms.Application.Exit();
            }
        }

        //خروج از اکانت کاربری
        private void LogoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = System.Windows.Forms.MessageBox.Show(
                icon: MessageBoxIcon.Question,
                caption: "سوال ؟ ",
                buttons: MessageBoxButtons.YesNo,
                defaultButton: MessageBoxDefaultButton.Button2,
                text: " آیا به خروج از پنل کاربری اطمینان دارید ؟ "
                );

            if (dialogResult == DialogResult.Yes)
            {
                Infrastructure.Utility.MainForm.Hide();
                Infrastructure.Utility.UserLoginForm.ResetForm();
                Infrastructure.Utility.UserLoginForm.Show();
            }
        }

        private ChangePassword changePassword;

        private void ChangePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ((changePassword.IsDisposed)||(changePassword == null))
            {
                changePassword = new ChangePassword()
                {
                    MdiParent = this,
                };
                changePassword.Show();
            }
        }
    }
}
