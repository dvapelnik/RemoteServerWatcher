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
            this.groupBoxOverload = new System.Windows.Forms.GroupBox();
            this.checkBoxOverloadAlert = new System.Windows.Forms.CheckBox();
            this.comboBoxOverloadValue = new System.Windows.Forms.ComboBox();
            this.labelOverloadValue = new System.Windows.Forms.Label();
            this.comboBoxOverloadAlertPeriod = new System.Windows.Forms.ComboBox();
            this.labelOverloadNotificationPeriod = new System.Windows.Forms.Label();
            this.comboBoxOverloadAlertBallonIntervalToShow = new System.Windows.Forms.ComboBox();
            this.labelOverloadAlertBallonIntervalToShow = new System.Windows.Forms.Label();
            this.tabControlOptions.SuspendLayout();
            this.tabPageMain.SuspendLayout();
            this.groupBoxTimer.SuspendLayout();
            this.groupBoxOverload.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
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
            this.tabPageMain.Controls.Add(this.groupBoxOverload);
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
            // groupBoxOverload
            // 
            this.groupBoxOverload.Controls.Add(this.labelOverloadAlertBallonIntervalToShow);
            this.groupBoxOverload.Controls.Add(this.comboBoxOverloadAlertBallonIntervalToShow);
            this.groupBoxOverload.Controls.Add(this.labelOverloadNotificationPeriod);
            this.groupBoxOverload.Controls.Add(this.comboBoxOverloadAlertPeriod);
            this.groupBoxOverload.Controls.Add(this.labelOverloadValue);
            this.groupBoxOverload.Controls.Add(this.comboBoxOverloadValue);
            this.groupBoxOverload.Controls.Add(this.checkBoxOverloadAlert);
            this.groupBoxOverload.Location = new System.Drawing.Point(7, 87);
            this.groupBoxOverload.Name = "groupBoxOverload";
            this.groupBoxOverload.Size = new System.Drawing.Size(238, 140);
            this.groupBoxOverload.TabIndex = 3;
            this.groupBoxOverload.TabStop = false;
            this.groupBoxOverload.Text = "Overload";
            // 
            // checkBoxOverloadAlert
            // 
            this.checkBoxOverloadAlert.AutoSize = true;
            this.checkBoxOverloadAlert.Location = new System.Drawing.Point(6, 19);
            this.checkBoxOverloadAlert.Name = "checkBoxOverloadAlert";
            this.checkBoxOverloadAlert.Size = new System.Drawing.Size(147, 17);
            this.checkBoxOverloadAlert.TabIndex = 0;
            this.checkBoxOverloadAlert.Text = "Show baloon on overload";
            this.checkBoxOverloadAlert.UseVisualStyleBackColor = true;
            // 
            // comboBoxOverloadValue
            // 
            this.comboBoxOverloadValue.FormattingEnabled = true;
            this.comboBoxOverloadValue.Items.AddRange(new object[] {
            "10",
            "25",
            "50",
            "100"});
            this.comboBoxOverloadValue.Location = new System.Drawing.Point(6, 42);
            this.comboBoxOverloadValue.Name = "comboBoxOverloadValue";
            this.comboBoxOverloadValue.Size = new System.Drawing.Size(60, 21);
            this.comboBoxOverloadValue.TabIndex = 3;
            // 
            // labelOverloadValue
            // 
            this.labelOverloadValue.AutoSize = true;
            this.labelOverloadValue.Location = new System.Drawing.Point(72, 45);
            this.labelOverloadValue.Name = "labelOverloadValue";
            this.labelOverloadValue.Size = new System.Drawing.Size(79, 13);
            this.labelOverloadValue.TabIndex = 4;
            this.labelOverloadValue.Text = "Overload value";
            // 
            // comboBoxOverloadAlertPeriod
            // 
            this.comboBoxOverloadAlertPeriod.FormattingEnabled = true;
            this.comboBoxOverloadAlertPeriod.Items.AddRange(new object[] {
            "1",
            "5",
            "15",
            "30",
            "60"});
            this.comboBoxOverloadAlertPeriod.Location = new System.Drawing.Point(6, 69);
            this.comboBoxOverloadAlertPeriod.Name = "comboBoxOverloadAlertPeriod";
            this.comboBoxOverloadAlertPeriod.Size = new System.Drawing.Size(60, 21);
            this.comboBoxOverloadAlertPeriod.TabIndex = 5;
            // 
            // labelOverloadNotificationPeriod
            // 
            this.labelOverloadNotificationPeriod.AutoSize = true;
            this.labelOverloadNotificationPeriod.Location = new System.Drawing.Point(72, 72);
            this.labelOverloadNotificationPeriod.Name = "labelOverloadNotificationPeriod";
            this.labelOverloadNotificationPeriod.Size = new System.Drawing.Size(161, 13);
            this.labelOverloadNotificationPeriod.TabIndex = 6;
            this.labelOverloadNotificationPeriod.Text = "Overload notification period (min)";
            // 
            // comboBoxOverloadAlertBallonIntervalToShow
            // 
            this.comboBoxOverloadAlertBallonIntervalToShow.FormattingEnabled = true;
            this.comboBoxOverloadAlertBallonIntervalToShow.Items.AddRange(new object[] {
            "1",
            "5",
            "10",
            "30",
            "60"});
            this.comboBoxOverloadAlertBallonIntervalToShow.Location = new System.Drawing.Point(6, 96);
            this.comboBoxOverloadAlertBallonIntervalToShow.Name = "comboBoxOverloadAlertBallonIntervalToShow";
            this.comboBoxOverloadAlertBallonIntervalToShow.Size = new System.Drawing.Size(60, 21);
            this.comboBoxOverloadAlertBallonIntervalToShow.TabIndex = 3;
            // 
            // labelOverloadAlertBallonIntervalToShow
            // 
            this.labelOverloadAlertBallonIntervalToShow.AutoSize = true;
            this.labelOverloadAlertBallonIntervalToShow.Location = new System.Drawing.Point(72, 99);
            this.labelOverloadAlertBallonIntervalToShow.Name = "labelOverloadAlertBallonIntervalToShow";
            this.labelOverloadAlertBallonIntervalToShow.Size = new System.Drawing.Size(131, 13);
            this.labelOverloadAlertBallonIntervalToShow.TabIndex = 7;
            this.labelOverloadAlertBallonIntervalToShow.Text = "Alert ballon lifetime interval";
            // 
            // OptionsForm
            // 
            this.AcceptButton = this.buttonOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
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
            this.groupBoxOverload.ResumeLayout(false);
            this.groupBoxOverload.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBoxOverload;
        private System.Windows.Forms.CheckBox checkBoxOverloadAlert;
        private System.Windows.Forms.Label labelOverloadValue;
        private System.Windows.Forms.ComboBox comboBoxOverloadValue;
        private System.Windows.Forms.Label labelOverloadNotificationPeriod;
        private System.Windows.Forms.ComboBox comboBoxOverloadAlertPeriod;
        private System.Windows.Forms.Label labelOverloadAlertBallonIntervalToShow;
        private System.Windows.Forms.ComboBox comboBoxOverloadAlertBallonIntervalToShow;
    }
}