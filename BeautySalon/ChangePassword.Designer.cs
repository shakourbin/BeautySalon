namespace BeautySalon
{
    partial class ChangePassword
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.userFamilyNameTextBox = new Hsh.Windows.Forms.TextBox();
            this.userFamilyNameLabel = new Hsh.Windows.Forms.Label();
            this.passwordTextBox = new Hsh.Windows.Forms.TextBox();
            this.passwordLabel = new Hsh.Windows.Forms.Label();
            this.usernameLabel = new Hsh.Windows.Forms.Label();
            this.usernameTextBox = new Hsh.Windows.Forms.TextBox();
            this.saveButton = new Hsh.Windows.Forms.Button();
            this.canceleButton = new Hsh.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userFamilyNameTextBox
            // 
            this.userFamilyNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userFamilyNameTextBox.Location = new System.Drawing.Point(11, 70);
            this.userFamilyNameTextBox.Name = "userFamilyNameTextBox";
            this.userFamilyNameTextBox.Size = new System.Drawing.Size(306, 20);
            this.userFamilyNameTextBox.TabIndex = 11;
            // 
            // userFamilyNameLabel
            // 
            this.userFamilyNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.userFamilyNameLabel.AutoSize = true;
            this.userFamilyNameLabel.Location = new System.Drawing.Point(323, 73);
            this.userFamilyNameLabel.Name = "userFamilyNameLabel";
            this.userFamilyNameLabel.Size = new System.Drawing.Size(104, 13);
            this.userFamilyNameLabel.TabIndex = 10;
            this.userFamilyNameLabel.Text = "تکرار رمز عبور جدید :";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.passwordTextBox.Location = new System.Drawing.Point(11, 44);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(306, 20);
            this.passwordTextBox.TabIndex = 9;
            // 
            // passwordLabel
            // 
            this.passwordLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(323, 47);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(80, 13);
            this.passwordLabel.TabIndex = 8;
            this.passwordLabel.Text = "رمز عبور جدید : ";
            // 
            // usernameLabel
            // 
            this.usernameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(323, 21);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(79, 13);
            this.usernameLabel.TabIndex = 7;
            this.usernameLabel.Text = "رمز عبور قبلی :";
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.usernameTextBox.Location = new System.Drawing.Point(12, 18);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(305, 20);
            this.usernameTextBox.TabIndex = 6;
            // 
            // saveButton
            // 
            this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.saveButton.Location = new System.Drawing.Point(242, 112);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 12;
            this.saveButton.Text = "ثبت";
            this.saveButton.UseVisualStyleBackColor = true;
            // 
            // canceleButton
            // 
            this.canceleButton.Location = new System.Drawing.Point(12, 112);
            this.canceleButton.Name = "canceleButton";
            this.canceleButton.Size = new System.Drawing.Size(75, 23);
            this.canceleButton.TabIndex = 13;
            this.canceleButton.Text = "انصراف";
            this.canceleButton.UseVisualStyleBackColor = true;
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 147);
            this.Controls.Add(this.canceleButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.userFamilyNameTextBox);
            this.Controls.Add(this.userFamilyNameLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.usernameTextBox);
            this.MaximumSize = new System.Drawing.Size(650, 186);
            this.MinimumSize = new System.Drawing.Size(443, 186);
            this.Name = "ChangePassword";
            this.Text = "فرم تغییر رمز عبور";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Hsh.Windows.Forms.TextBox userFamilyNameTextBox;
        private Hsh.Windows.Forms.Label userFamilyNameLabel;
        public Hsh.Windows.Forms.TextBox passwordTextBox;
        private Hsh.Windows.Forms.Label passwordLabel;
        private Hsh.Windows.Forms.Label usernameLabel;
        public Hsh.Windows.Forms.TextBox usernameTextBox;
        private Hsh.Windows.Forms.Button saveButton;
        private Hsh.Windows.Forms.Button canceleButton;
    }
}