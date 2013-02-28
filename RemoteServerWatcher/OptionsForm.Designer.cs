namespace RemoteServerWatcher {
    partial class OptionsForm {
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
            this.tabControlOptions = new System.Windows.Forms.TabControl();
            this.tabPageMain = new System.Windows.Forms.TabPage();
            this.groupBoxTimer = new System.Windows.Forms.GroupBox();
            this.labelTimerInterval = new System.Windows.Forms.Label();
            this.comboBoxTimerInterval = new System.Windows.Forms.ComboBox();
            this.checkBoxMonitorAutostart = new System.Windows.Forms.CheckBox();
            this.tabControlOptions.SuspendLayout();
            this.tabPageMain.SuspendLayout();
            this.groupBoxTimer.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(447, 277);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 0;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(366, 277);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 1;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // tabControlOptions
            // 
            this.tabControlOptions.Controls.Add(this.tabPageMain);
            this.tabControlOptions.Location = new System.Drawing.Point(12, 12);
            this.tabControlOptions.Name = "tabControlOptions";
            this.tabControlOptions.SelectedIndex = 0;
            this.tabControlOptions.Size = new System.Drawing.Size(510, 259);
            this.tabControlOptions.TabIndex = 2;
            // 
            // tabPageMain
            // 
            this.tabPageMain.Controls.Add(this.groupBoxTimer);
            this.tabPageMain.Location = new System.Drawing.Point(4, 22);
            this.tabPageMain.Name = "tabPageMain";
            this.tabPageMain.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMain.Size = new System.Drawing.Size(502, 233);
            this.tabPageMain.TabIndex = 0;
            this.tabPageMain.Text = "Main";
            this.tabPageMain.UseVisualStyleBackColor = true;
            // 
            // groupBoxTimer
            // 
            this.groupBoxTimer.Controls.Add(this.labelTimerInterval);
            this.groupBoxTimer.Controls.Add(this.comboBoxTimerInterval);
            this.groupBoxTimer.Controls.Add(this.checkBoxMonitorAutostart);
            this.groupBoxTimer.Location = new System.Drawing.Point(7, 7);
            this.groupBoxTimer.Name = "groupBoxTimer";
            this.groupBoxTimer.Size = new System.Drawing.Size(238, 74);
            this.groupBoxTimer.TabIndex = 2;
            this.groupBoxTimer.TabStop = false;
            this.groupBoxTimer.Text = "Timer settings";
            // 
            // labelTimerInterval
            // 
            this.labelTimerInterval.AutoSize = true;
            this.labelTimerInterval.Location = new System.Drawing.Point(72, 45);
            this.labelTimerInterval.Name = "labelTimerInterval";
            this.labelTimerInterval.Size = new System.Drawing.Size(84, 13);
            this.labelTimerInterval.TabIndex = 4;
            this.labelTimerInterval.Text = "Timer intervel (s)";
            // 
            // comboBoxTimerInterval
            // 
            this.comboBoxTimerInterval.FormattingEnabled = true;
            this.comboBoxTimerInterval.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "10",
            "15",
            "30",
            "60"});
            this.comboBoxTimerInterval.Location = new System.Drawing.Point(6, 42);
            this.comboBoxTimerInterval.Name = "comboBoxTimerInterval";
            this.comboBoxTimerInterval.Size = new System.Drawing.Size(60, 21);
            this.comboBoxTimerInterval.TabIndex = 3;
            this.comboBoxTimerInterval.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxTimerInterval_KeyPress);
            // 
            // checkBoxMonitorAutostart
            // 
            this.checkBoxMonitorAutostart.AutoSize = true;
            this.checkBoxMonitorAutostart.Location = new System.Drawing.Point(6, 19);
            this.checkBoxMonitorAutostart.Name = "checkBoxMonitorAutostart";
            this.checkBoxMonitorAutostart.Size = new System.Drawing.Size(123, 17);
            this.checkBoxMonitorAutostart.TabIndex = 2;
            this.checkBoxMonitorAutostart.Text = "Start monitor on start";
            this.checkBoxMonitorAutostart.UseVisualStyleBackColor = true;
            // 
            // OptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 312);
            this.Controls.Add(this.tabControlOptions);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.buttonCancel);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(550, 350);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(550, 350);
            this.Name = "OptionsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Preferences";
            this.tabControlOptions.ResumeLayout(false);
            this.tabPageMain.ResumeLayout(false);
            this.groupBoxTimer.ResumeLayout(false);
            this.groupBoxTimer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.TabControl tabControlOptions;
        private System.Windows.Forms.TabPage tabPageMain;
        private System.Windows.Forms.GroupBox groupBoxTimer;
        private System.Windows.Forms.Label labelTimerInterval;
        private System.Windows.Forms.ComboBox comboBoxTimerInterval;
        private System.Windows.Forms.CheckBox checkBoxMonitorAutostart;
    }
}