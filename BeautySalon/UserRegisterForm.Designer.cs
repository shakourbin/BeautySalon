namespace BeautySalon.Admin
{
    partial class UserRegisterForm
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
            this.usernameTextBox = new Hsh.Windows.Forms.TextBox();
            this.usernameLabel = new Hsh.Windows.Forms.Label();
            this.passwordLabel = new Hsh.Windows.Forms.Label();
            this.passwordTextBox = new Hsh.Windows.Forms.TextBox();
            this.userFamilyNameLabel = new Hsh.Windows.Forms.Label();
            this.userFamilyNameTextBox = new Hsh.Windows.Forms.TextBox();
            this.registerButton = new Hsh.Windows.Forms.Button();
            this.resetButton = new Hsh.Windows.Forms.Button();
            this.loginButton = new Hsh.Windows.Forms.Button();
            this.exitButton = new Hsh.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.usernameTextBox.Location = new System.Drawing.Point(13, 21);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(318, 20);
            this.usernameTextBox.TabIndex = 0;
            // 
            // usernameLabel
            // 
            this.usernameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(352, 27);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(67, 13);
            this.usernameLabel.TabIndex = 1;
            this.usernameLabel.Text = "نام کاربری : ";
            // 
            // passwordLabel
            // 
            this.passwordLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(366, 50);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(53, 13);
            this.passwordLabel.TabIndex = 2;
            this.passwordLabel.Text = "رمز عبور :";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.passwordTextBox.Location = new System.Drawing.Point(12, 47);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(319, 20);
            this.passwordTextBox.TabIndex = 3;
            // 
            // userFamilyNameLabel
            // 
            this.userFamilyNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.userFamilyNameLabel.AutoSize = true;
            this.userFamilyNameLabel.Location = new System.Drawing.Point(344, 79);
            this.userFamilyNameLabel.Name = "userFamilyNameLabel";
            this.userFamilyNameLabel.Size = new System.Drawing.Size(75, 13);
            this.userFamilyNameLabel.TabIndex = 4;
            this.userFamilyNameLabel.Text = "نام خانوادگی :";
            // 
            // userFamilyNameTextBox
            // 
            this.userFamilyNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userFamilyNameTextBox.Location = new System.Drawing.Point(12, 73);
            this.userFamilyNameTextBox.Name = "userFamilyNameTextBox";
            this.userFamilyNameTextBox.Size = new System.Drawing.Size(319, 20);
            this.userFamilyNameTextBox.TabIndex = 5;
            // 
            // registerButton
            // 
            this.registerButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.registerButton.Location = new System.Drawing.Point(256, 108);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(75, 23);
            this.registerButton.TabIndex = 6;
            this.registerButton.Text = "&ثبت";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.resetButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.resetButton.Location = new System.Drawing.Point(175, 108);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 23);
            this.resetButton.TabIndex = 7;
            this.resetButton.Text = "&انصراف";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // loginButton
            // 
            this.loginButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.loginButton.Location = new System.Drawing.Point(94, 108);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(75, 23);
            this.loginButton.TabIndex = 8;
            this.loginButton.Text = "&ورود";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exitButton.Location = new System.Drawing.Point(13, 108);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 9;
            this.exitButton.Text = "&خروج";
            this.exitButton.UseVisualStyleBackColor = true;
            // 
            // UserRegisterForm
            // 
            this.AcceptButton = this.registerButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.resetButton;
            this.ClientSize = new System.Drawing.Size(427, 147);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.userFamilyNameTextBox);
            this.Controls.Add(this.userFamilyNameLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.usernameTextBox);
            this.MaximumSize = new System.Drawing.Size(650, 186);
            this.MinimumSize = new System.Drawing.Size(443, 186);
            this.Name = "UserRegisterForm";
            this.Text = "فرم ثبت نام کاربر";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Hsh.Windows.Forms.Label usernameLabel;
        private Hsh.Windows.Forms.Label passwordLabel;
        private Hsh.Windows.Forms.Label userFamilyNameLabel;
        private Hsh.Windows.Forms.Button registerButton;
        private Hsh.Windows.Forms.Button resetButton;
        private Hsh.Windows.Forms.Button loginButton;
        private Hsh.Windows.Forms.Button exitButton;
        public Hsh.Windows.Forms.TextBox usernameTextBox;
        public Hsh.Windows.Forms.TextBox passwordTextBox;
        public Hsh.Windows.Forms.TextBox userFamilyNameTextBox;
    }
}