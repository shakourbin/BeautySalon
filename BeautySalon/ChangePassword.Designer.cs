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
            this.passwordConfirmTextBox = new Hsh.Windows.Forms.TextBox();
            this.userFamilyNameLabel = new Hsh.Windows.Forms.Label();
            this.newPasswordTextBox = new Hsh.Windows.Forms.TextBox();
            this.passwordLabel = new Hsh.Windows.Forms.Label();
            this.usernameLabel = new Hsh.Windows.Forms.Label();
            this.oldPasswordTextBox = new Hsh.Windows.Forms.TextBox();
            this.saveButton = new Hsh.Windows.Forms.Button();
            this.resetButton = new Hsh.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // passwordConfirmTextBox
            // 
            this.passwordConfirmTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.passwordConfirmTextBox.Location = new System.Drawing.Point(118, 70);
            this.passwordConfirmTextBox.Name = "passwordConfirmTextBox";
            this.passwordConfirmTextBox.Size = new System.Drawing.Size(297, 20);
            this.passwordConfirmTextBox.TabIndex = 11;
            this.passwordConfirmTextBox.UseSystemPasswordChar = true;
            // 
            // userFamilyNameLabel
            // 
            this.userFamilyNameLabel.AutoSize = true;
            this.userFamilyNameLabel.Location = new System.Drawing.Point(9, 73);
            this.userFamilyNameLabel.Name = "userFamilyNameLabel";
            this.userFamilyNameLabel.Size = new System.Drawing.Size(104, 13);
            this.userFamilyNameLabel.TabIndex = 10;
            this.userFamilyNameLabel.Text = "تکرار رمز عبور جدید :";
            // 
            // newPasswordTextBox
            // 
            this.newPasswordTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.newPasswordTextBox.Location = new System.Drawing.Point(118, 44);
            this.newPasswordTextBox.Name = "newPasswordTextBox";
            this.newPasswordTextBox.Size = new System.Drawing.Size(297, 20);
            this.newPasswordTextBox.TabIndex = 9;
            this.newPasswordTextBox.UseSystemPasswordChar = true;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(9, 47);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(80, 13);
            this.passwordLabel.TabIndex = 8;
            this.passwordLabel.Text = "رمز عبور جدید : ";
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(9, 21);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(79, 13);
            this.usernameLabel.TabIndex = 7;
            this.usernameLabel.Text = "رمز عبور قبلی :";
            // 
            // oldPasswordTextBox
            // 
            this.oldPasswordTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.oldPasswordTextBox.Location = new System.Drawing.Point(119, 18);
            this.oldPasswordTextBox.Name = "oldPasswordTextBox";
            this.oldPasswordTextBox.Size = new System.Drawing.Size(296, 20);
            this.oldPasswordTextBox.TabIndex = 6;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(12, 112);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 12;
            this.saveButton.Text = "ثبت";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(93, 112);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 23);
            this.resetButton.TabIndex = 13;
            this.resetButton.Text = "انصراف";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // ChangePassword
            // 
            this.AcceptButton = this.saveButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 147);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.passwordConfirmTextBox);
            this.Controls.Add(this.userFamilyNameLabel);
            this.Controls.Add(this.newPasswordTextBox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.oldPasswordTextBox);
            this.MaximumSize = new System.Drawing.Size(650, 186);
            this.MinimumSize = new System.Drawing.Size(443, 186);
            this.Name = "ChangePassword";
            this.Text = "فرم تغییر رمز عبور";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Hsh.Windows.Forms.TextBox passwordConfirmTextBox;
        private Hsh.Windows.Forms.Label userFamilyNameLabel;
        public Hsh.Windows.Forms.TextBox newPasswordTextBox;
        private Hsh.Windows.Forms.Label passwordLabel;
        private Hsh.Windows.Forms.Label usernameLabel;
        public Hsh.Windows.Forms.TextBox oldPasswordTextBox;
        private Hsh.Windows.Forms.Button saveButton;
        private Hsh.Windows.Forms.Button resetButton;
    }
}