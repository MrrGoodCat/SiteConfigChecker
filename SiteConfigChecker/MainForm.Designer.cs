namespace SiteConfigChecker
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ComponentsPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BSFcb = new System.Windows.Forms.CheckBox();
            this.ComponentsSelectorLabel = new System.Windows.Forms.Label();
            this.IIScb = new System.Windows.Forms.CheckBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ComponentsPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ComponentsPanel
            // 
            this.ComponentsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ComponentsPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ComponentsPanel.Controls.Add(this.panel1);
            this.ComponentsPanel.Controls.Add(this.ComponentsSelectorLabel);
            this.ComponentsPanel.Location = new System.Drawing.Point(13, 13);
            this.ComponentsPanel.Name = "ComponentsPanel";
            this.ComponentsPanel.Size = new System.Drawing.Size(700, 232);
            this.ComponentsPanel.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.IIScb);
            this.panel1.Controls.Add(this.BSFcb);
            this.panel1.Location = new System.Drawing.Point(4, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(689, 201);
            this.panel1.TabIndex = 2;
            // 
            // BSFcb
            // 
            this.BSFcb.AutoSize = true;
            this.BSFcb.Location = new System.Drawing.Point(8, 8);
            this.BSFcb.Name = "BSFcb";
            this.BSFcb.Size = new System.Drawing.Size(49, 17);
            this.BSFcb.TabIndex = 0;
            this.BSFcb.Text = "BSF ";
            this.BSFcb.UseVisualStyleBackColor = true;
            // 
            // ComponentsSelectorLabel
            // 
            this.ComponentsSelectorLabel.AutoSize = true;
            this.ComponentsSelectorLabel.Location = new System.Drawing.Point(7, 7);
            this.ComponentsSelectorLabel.Name = "ComponentsSelectorLabel";
            this.ComponentsSelectorLabel.Size = new System.Drawing.Size(223, 13);
            this.ComponentsSelectorLabel.TabIndex = 1;
            this.ComponentsSelectorLabel.Text = "Select components that you want to validate: ";
            // 
            // IIScb
            // 
            this.IIScb.AutoSize = true;
            this.IIScb.Location = new System.Drawing.Point(8, 31);
            this.IIScb.Name = "IIScb";
            this.IIScb.Size = new System.Drawing.Size(68, 17);
            this.IIScb.TabIndex = 1;
            this.IIScb.Text = "IIS Basic";
            this.IIScb.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(13, 262);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(700, 513);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(692, 487);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "BSF";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(694, 368);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "IIS Basic";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 787);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.ComponentsPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Site Configuration Checker";
            this.ComponentsPanel.ResumeLayout(false);
            this.ComponentsPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ComponentsPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox BSFcb;
        private System.Windows.Forms.Label ComponentsSelectorLabel;
        private System.Windows.Forms.CheckBox IIScb;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
    }
}