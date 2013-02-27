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
            this.labelHostName = new System.Windows.Forms.Label();
            this.textBoxHostName = new System.Windows.Forms.TextBox();
            this.checkBoxServerEnabled = new System.Windows.Forms.CheckBox();
            this.buttonTestConnection = new System.Windows.Forms.Button();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.labelLOgin = new System.Windows.Forms.Label();
            this.labelServerName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.buttonSaveServer = new System.Windows.Forms.Button();
            this.listBoxServers = new System.Windows.Forms.ListBox();
            this.buttonAddNewServer = new System.Windows.Forms.Button();
            this.buttonServerRemove = new System.Windows.Forms.Button();
            this.groupBoxMainGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(391, 226);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 9;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(310, 226);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 8;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // groupBoxMainGroup
            // 
            this.groupBoxMainGroup.Controls.Add(this.buttonServerRemove);
            this.groupBoxMainGroup.Controls.Add(this.buttonAddNewServer);
            this.groupBoxMainGroup.Controls.Add(this.labelHostName);
            this.groupBoxMainGroup.Controls.Add(this.textBoxHostName);
            this.groupBoxMainGroup.Controls.Add(this.checkBoxServerEnabled);
            this.groupBoxMainGroup.Controls.Add(this.buttonTestConnection);
            this.groupBoxMainGroup.Controls.Add(this.textBoxPassword);
            this.groupBoxMainGroup.Controls.Add(this.labelPassword);
            this.groupBoxMainGroup.Controls.Add(this.textBoxLogin);
            this.groupBoxMainGroup.Controls.Add(this.labelLOgin);
            this.groupBoxMainGroup.Controls.Add(this.labelServerName);
            this.groupBoxMainGroup.Controls.Add(this.textBoxName);
            this.groupBoxMainGroup.Controls.Add(this.buttonSaveServer);
            this.groupBoxMainGroup.Controls.Add(this.listBoxServers);
            this.groupBoxMainGroup.Location = new System.Drawing.Point(13, 13);
            this.groupBoxMainGroup.Name = "groupBoxMainGroup";
            this.groupBoxMainGroup.Size = new System.Drawing.Size(459, 207);
            this.groupBoxMainGroup.TabIndex = 2;
            this.groupBoxMainGroup.TabStop = false;
            this.groupBoxMainGroup.Text = "Servers";
            // 
            // labelHostName
            // 
            this.labelHostName.AutoSize = true;
            this.labelHostName.Location = new System.Drawing.Point(237, 49);
            this.labelHostName.Name = "labelHostName";
            this.labelHostName.Size = new System.Drawing.Size(32, 13);
            this.labelHostName.TabIndex = 11;
            this.labelHostName.Text = "Host:";
            // 
            // textBoxHostName
            // 
            this.textBoxHostName.Location = new System.Drawing.Point(275, 46);
            this.textBoxHostName.Name = "textBoxHostName";
            this.textBoxHostName.Size = new System.Drawing.Size(178, 20);
            this.textBoxHostName.TabIndex = 2;
            this.textBoxHostName.Enter += new System.EventHandler(this.textBoxName_Enter);
            // 
            // checkBoxServerEnabled
            // 
            this.checkBoxServerEnabled.AutoSize = true;
            this.checkBoxServerEnabled.Checked = true;
            this.checkBoxServerEnabled.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxServerEnabled.Location = new System.Drawing.Point(255, 128);
            this.checkBoxServerEnabled.Name = "checkBoxServerEnabled";
            this.checkBoxServerEnabled.Size = new System.Drawing.Size(76, 17);
            this.checkBoxServerEnabled.TabIndex = 5;
            this.checkBoxServerEnabled.Text = "Is Enabled";
            this.checkBoxServerEnabled.UseVisualStyleBackColor = true;
            // 
            // buttonTestConnection
            // 
            this.buttonTestConnection.Location = new System.Drawing.Point(337, 124);
            this.buttonTestConnection.Name = "buttonTestConnection";
            this.buttonTestConnection.Size = new System.Drawing.Size(116, 23);
            this.buttonTestConnection.TabIndex = 6;
            this.buttonTestConnection.Text = "Test Connection";
            this.buttonTestConnection.UseVisualStyleBackColor = true;
            this.buttonTestConnection.Click += new System.EventHandler(this.buttonTestConnection_Click);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(275, 98);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(178, 20);
            this.textBoxPassword.TabIndex = 4;
            this.textBoxPassword.Enter += new System.EventHandler(this.textBoxName_Enter);
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(213, 101);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(56, 13);
            this.labelPassword.TabIndex = 6;
            this.labelPassword.Text = "Password:";
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Location = new System.Drawing.Point(275, 72);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(178, 20);
            this.textBoxLogin.TabIndex = 3;
            this.textBoxLogin.Enter += new System.EventHandler(this.textBoxName_Enter);
            // 
            // labelLOgin
            // 
            this.labelLOgin.AutoSize = true;
            this.labelLOgin.Location = new System.Drawing.Point(233, 75);
            this.labelLOgin.Name = "labelLOgin";
            this.labelLOgin.Size = new System.Drawing.Size(36, 13);
            this.labelLOgin.TabIndex = 4;
            this.labelLOgin.Text = "Login:";
            // 
            // labelServerName
            // 
            this.labelServerName.AutoSize = true;
            this.labelServerName.Location = new System.Drawing.Point(231, 22);
            this.labelServerName.Name = "labelServerName";
            this.labelServerName.Size = new System.Drawing.Size(38, 13);
            this.labelServerName.TabIndex = 3;
            this.labelServerName.Text = "Name:";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(275, 19);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(178, 20);
            this.textBoxName.TabIndex = 1;
            this.textBoxName.Enter += new System.EventHandler(this.textBoxName_Enter);
            // 
            // buttonSaveServer
            // 
            this.buttonSaveServer.Location = new System.Drawing.Point(215, 178);
            this.buttonSaveServer.Name = "buttonSaveServer";
            this.buttonSaveServer.Size = new System.Drawing.Size(75, 23);
            this.buttonSaveServer.TabIndex = 7;
            this.buttonSaveServer.Text = "Save";
            this.buttonSaveServer.UseVisualStyleBackColor = true;
            this.buttonSaveServer.Click += new System.EventHandler(this.buttonSaveServer_Click);
            // 
            // listBoxServers
            // 
            this.listBoxServers.FormattingEnabled = true;
            this.listBoxServers.Location = new System.Drawing.Point(6, 23);
            this.listBoxServers.Name = "listBoxServers";
            this.listBoxServers.Size = new System.Drawing.Size(203, 173);
            this.listBoxServers.TabIndex = 0;
            this.listBoxServers.SelectedIndexChanged += new System.EventHandler(this.listBoxServers_SelectedIndexChanged);
            // 
            // buttonAddNewServer
            // 
            this.buttonAddNewServer.Location = new System.Drawing.Point(297, 178);
            this.buttonAddNewServer.Name = "buttonAddNewServer";
            this.buttonAddNewServer.Size = new System.Drawing.Size(75, 23);
            this.buttonAddNewServer.TabIndex = 12;
            this.buttonAddNewServer.Text = "Add new";
            this.buttonAddNewServer.UseVisualStyleBackColor = true;
            this.buttonAddNewServer.Click += new System.EventHandler(this.buttonAddNewServer_Click);
            // 
            // buttonServerRemove
            // 
            this.buttonServerRemove.Location = new System.Drawing.Point(378, 178);
            this.buttonServerRemove.Name = "buttonServerRemove";
            this.buttonServerRemove.Size = new System.Drawing.Size(75, 23);
            this.buttonServerRemove.TabIndex = 13;
            this.buttonServerRemove.Text = "Remove";
            this.buttonServerRemove.UseVisualStyleBackColor = true;
            this.buttonServerRemove.Click += new System.EventHandler(this.buttonServerRemove_Click);
            // 
            // RemoteServers
            // 
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
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
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
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Button buttonSaveServer;
        private System.Windows.Forms.ListBox listBoxServers;
        private System.Windows.Forms.CheckBox checkBoxServerEnabled;
        private System.Windows.Forms.Button buttonTestConnection;
        private System.Windows.Forms.TextBox textBoxHostName;
        private System.Windows.Forms.Label labelHostName;
        private System.Windows.Forms.Button buttonAddNewServer;
        private System.Windows.Forms.Button buttonServerRemove;
    }
}