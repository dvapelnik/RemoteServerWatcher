namespace RemoteServerWatcher {
    partial class RemoteServers {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOk = new System.Windows.Forms.Button();
            this.groupBoxMainGroup = new System.Windows.Forms.GroupBox();
            this.listBoxServers = new System.Windows.Forms.ListBox();
            this.buttonSaveServer = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelServerName = new System.Windows.Forms.Label();
            this.labelLOgin = new System.Windows.Forms.Label();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.groupBoxMainGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(397, 226);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 0;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(316, 226);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 1;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // groupBoxMainGroup
            // 
            this.groupBoxMainGroup.Controls.Add(this.textBoxPassword);
            this.groupBoxMainGroup.Controls.Add(this.labelPassword);
            this.groupBoxMainGroup.Controls.Add(this.textBoxLogin);
            this.groupBoxMainGroup.Controls.Add(this.labelLOgin);
            this.groupBoxMainGroup.Controls.Add(this.labelServerName);
            this.groupBoxMainGroup.Controls.Add(this.textBox1);
            this.groupBoxMainGroup.Controls.Add(this.buttonSaveServer);
            this.groupBoxMainGroup.Controls.Add(this.listBoxServers);
            this.groupBoxMainGroup.Location = new System.Drawing.Point(13, 13);
            this.groupBoxMainGroup.Name = "groupBoxMainGroup";
            this.groupBoxMainGroup.Size = new System.Drawing.Size(459, 207);
            this.groupBoxMainGroup.TabIndex = 2;
            this.groupBoxMainGroup.TabStop = false;
            this.groupBoxMainGroup.Text = "Servers";
            // 
            // listBoxServers
            // 
            this.listBoxServers.FormattingEnabled = true;
            this.listBoxServers.Location = new System.Drawing.Point(6, 23);
            this.listBoxServers.Name = "listBoxServers";
            this.listBoxServers.Size = new System.Drawing.Size(203, 173);
            this.listBoxServers.TabIndex = 0;
            // 
            // buttonSaveServer
            // 
            this.buttonSaveServer.Location = new System.Drawing.Point(378, 173);
            this.buttonSaveServer.Name = "buttonSaveServer";
            this.buttonSaveServer.Size = new System.Drawing.Size(75, 23);
            this.buttonSaveServer.TabIndex = 1;
            this.buttonSaveServer.Text = "Save";
            this.buttonSaveServer.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(275, 23);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(178, 20);
            this.textBox1.TabIndex = 2;
            // 
            // labelServerName
            // 
            this.labelServerName.AutoSize = true;
            this.labelServerName.Location = new System.Drawing.Point(231, 26);
            this.labelServerName.Name = "labelServerName";
            this.labelServerName.Size = new System.Drawing.Size(38, 13);
            this.labelServerName.TabIndex = 3;
            this.labelServerName.Text = "Name:";
            // 
            // labelLOgin
            // 
            this.labelLOgin.AutoSize = true;
            this.labelLOgin.Location = new System.Drawing.Point(233, 52);
            this.labelLOgin.Name = "labelLOgin";
            this.labelLOgin.Size = new System.Drawing.Size(36, 13);
            this.labelLOgin.TabIndex = 4;
            this.labelLOgin.Text = "Login:";
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Location = new System.Drawing.Point(275, 49);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(178, 20);
            this.textBoxLogin.TabIndex = 5;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(213, 78);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(56, 13);
            this.labelPassword.TabIndex = 6;
            this.labelPassword.Text = "Password:";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(275, 75);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(178, 20);
            this.textBoxPassword.TabIndex = 7;
            // 
            // RemoteServers
            // 
            this.AcceptButton = this.buttonOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.Controls.Add(this.groupBoxMainGroup);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.buttonCancel);
            this.MaximumSize = new System.Drawing.Size(500, 300);
            this.MinimumSize = new System.Drawing.Size(500, 300);
            this.Name = "RemoteServers";
            this.Text = "Remote servers";
            this.groupBoxMainGroup.ResumeLayout(false);
            this.groupBoxMainGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.GroupBox groupBoxMainGroup;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.Label labelLOgin;
        private System.Windows.Forms.Label labelServerName;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonSaveServer;
        private System.Windows.Forms.ListBox listBoxServers;
    }
}