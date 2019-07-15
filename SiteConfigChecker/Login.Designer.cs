namespace SiteConfigChecker
{
    partial class Login
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
            this.sysAdminLocationTextBox = new System.Windows.Forms.TextBox();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.sysAdminLocationLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.loginBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sysAdminLocationTextBox
            // 
            this.sysAdminLocationTextBox.Location = new System.Drawing.Point(255, 134);
            this.sysAdminLocationTextBox.Name = "sysAdminLocationTextBox";
            this.sysAdminLocationTextBox.Size = new System.Drawing.Size(300, 20);
            this.sysAdminLocationTextBox.TabIndex = 0;
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(255, 204);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(300, 20);
            this.usernameTextBox.TabIndex = 1;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(255, 271);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(300, 20);
            this.passwordTextBox.TabIndex = 2;
            this.passwordTextBox.UseSystemPasswordChar = true;
            // 
            // sysAdminLocationLabel
            // 
            this.sysAdminLocationLabel.AutoSize = true;
            this.sysAdminLocationLabel.Location = new System.Drawing.Point(252, 118);
            this.sysAdminLocationLabel.Name = "sysAdminLocationLabel";
            this.sysAdminLocationLabel.Size = new System.Drawing.Size(187, 13);
            this.sysAdminLocationLabel.TabIndex = 3;
            this.sysAdminLocationLabel.Text = "System Administrator Server hostname";
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(252, 188);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(55, 13);
            this.usernameLabel.TabIndex = 4;
            this.usernameLabel.Text = "Username";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(252, 255);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(53, 13);
            this.passwordLabel.TabIndex = 5;
            this.passwordLabel.Text = "Password";
            // 
            // loginBtn
            // 
            this.loginBtn.Location = new System.Drawing.Point(255, 319);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(130, 30);
            this.loginBtn.TabIndex = 6;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(425, 319);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(130, 30);
            this.cancelBtn.TabIndex = 7;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.sysAdminLocationLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.sysAdminLocationTextBox);
            this.Name = "Login";
            this.Text = "SiteConfigChecker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox sysAdminLocationTextBox;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label sysAdminLocationLabel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Button cancelBtn;
    }
}

