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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.sysAdminLocationTextBox = new System.Windows.Forms.TextBox();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.sysAdminLocationLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.loginBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.domainTextBox = new System.Windows.Forms.TextBox();
            this.adAuthCheckBox = new System.Windows.Forms.CheckBox();
            this.domainLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // sysAdminLocationTextBox
            // 
            this.sysAdminLocationTextBox.Location = new System.Drawing.Point(256, 174);
            this.sysAdminLocationTextBox.Name = "sysAdminLocationTextBox";
            this.sysAdminLocationTextBox.Size = new System.Drawing.Size(300, 20);
            this.sysAdminLocationTextBox.TabIndex = 0;
            this.sysAdminLocationTextBox.Text = "App-123";
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(256, 244);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(300, 20);
            this.usernameTextBox.TabIndex = 1;
            this.usernameTextBox.Text = "nice";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(256, 311);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(300, 20);
            this.passwordTextBox.TabIndex = 2;
            this.passwordTextBox.Text = "nicecti1!";
            this.passwordTextBox.UseSystemPasswordChar = true;
            // 
            // sysAdminLocationLabel
            // 
            this.sysAdminLocationLabel.AutoSize = true;
            this.sysAdminLocationLabel.Location = new System.Drawing.Point(253, 158);
            this.sysAdminLocationLabel.Name = "sysAdminLocationLabel";
            this.sysAdminLocationLabel.Size = new System.Drawing.Size(187, 13);
            this.sysAdminLocationLabel.TabIndex = 3;
            this.sysAdminLocationLabel.Text = "System Administrator Server hostname";
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(253, 228);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(55, 13);
            this.usernameLabel.TabIndex = 4;
            this.usernameLabel.Text = "Username";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(253, 295);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(53, 13);
            this.passwordLabel.TabIndex = 5;
            this.passwordLabel.Text = "Password";
            // 
            // loginBtn
            // 
            this.loginBtn.Location = new System.Drawing.Point(256, 359);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(130, 30);
            this.loginBtn.TabIndex = 6;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(426, 359);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(130, 30);
            this.cancelBtn.TabIndex = 7;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // domainTextBox
            // 
            this.domainTextBox.Enabled = false;
            this.domainTextBox.Location = new System.Drawing.Point(256, 99);
            this.domainTextBox.Name = "domainTextBox";
            this.domainTextBox.Size = new System.Drawing.Size(300, 20);
            this.domainTextBox.TabIndex = 8;
            this.domainTextBox.Text = "madc.local";
            // 
            // adAuthCheckBox
            // 
            this.adAuthCheckBox.AutoSize = true;
            this.adAuthCheckBox.Location = new System.Drawing.Point(255, 54);
            this.adAuthCheckBox.Name = "adAuthCheckBox";
            this.adAuthCheckBox.Size = new System.Drawing.Size(194, 17);
            this.adAuthCheckBox.TabIndex = 9;
            this.adAuthCheckBox.Text = "Use Active Directory Authentication";
            this.adAuthCheckBox.UseVisualStyleBackColor = true;
            this.adAuthCheckBox.CheckedChanged += new System.EventHandler(this.adAuthCheckBox_CheckedChanged);
            // 
            // domainLabel
            // 
            this.domainLabel.AutoSize = true;
            this.domainLabel.Location = new System.Drawing.Point(252, 80);
            this.domainLabel.Name = "domainLabel";
            this.domainLabel.Size = new System.Drawing.Size(43, 13);
            this.domainLabel.TabIndex = 10;
            this.domainLabel.Text = "Domain";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.domainLabel);
            this.Controls.Add(this.adAuthCheckBox);
            this.Controls.Add(this.domainTextBox);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.sysAdminLocationLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.sysAdminLocationTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.Text = "Site Configuration Checker - Log in";
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
        private System.Windows.Forms.TextBox domainTextBox;
        private System.Windows.Forms.CheckBox adAuthCheckBox;
        private System.Windows.Forms.Label domainLabel;
    }
}

