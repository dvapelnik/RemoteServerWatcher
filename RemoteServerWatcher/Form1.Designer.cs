namespace RemoteServerWatcher {
    partial class MainForm {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            this.menuStripMainMenu = new System.Windows.Forms.MenuStrip();
            this.fIleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.remoteServersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.richTextBoxLog = new System.Windows.Forms.RichTextBox();
            this.contextMenuStripRichTextBox = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonStop = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.labelTime = new System.Windows.Forms.Label();
            this.chartServers = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonManualUpdate = new System.Windows.Forms.Button();
            this.textBoxCommand = new System.Windows.Forms.TextBox();
            this.buttonSendCommand = new System.Windows.Forms.Button();
            this.comboBoxServers = new System.Windows.Forms.ComboBox();
            this.backgroundWorkerForServers = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorkerForCommand = new System.ComponentModel.BackgroundWorker();
            this.statusStripMain = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.notifyIconTray = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStripTray = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripMainMenu.SuspendLayout();
            this.contextMenuStripRichTextBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartServers)).BeginInit();
            this.statusStripMain.SuspendLayout();
            this.contextMenuStripTray.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripMainMenu
            // 
            this.menuStripMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fIleToolStripMenuItem});
            this.menuStripMainMenu.Location = new System.Drawing.Point(0, 0);
            this.menuStripMainMenu.Name = "menuStripMainMenu";
            this.menuStripMainMenu.Size = new System.Drawing.Size(782, 24);
            this.menuStripMainMenu.TabIndex = 6;
            this.menuStripMainMenu.Text = "menuStrip1";
            // 
            // fIleToolStripMenuItem
            // 
            this.fIleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.remoteServersToolStripMenuItem,
            this.preToolStripMenuItem,
            this.toolStripMenuItem2,
            this.exitToolStripMenuItem});
            this.fIleToolStripMenuItem.Name = "fIleToolStripMenuItem";
            this.fIleToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fIleToolStripMenuItem.Text = "FIle";
            // 
            // remoteServersToolStripMenuItem
            // 
            this.remoteServersToolStripMenuItem.Name = "remoteServersToolStripMenuItem";
            this.remoteServersToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.remoteServersToolStripMenuItem.Text = "Remote servers";
            this.remoteServersToolStripMenuItem.Click += new System.EventHandler(this.remoteServersToolStripMenuItem_Click);
            // 
            // preToolStripMenuItem
            // 
            this.preToolStripMenuItem.Name = "preToolStripMenuItem";
            this.preToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.preToolStripMenuItem.Text = "Preferences";
            this.preToolStripMenuItem.Click += new System.EventHandler(this.preToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(151, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // richTextBoxLog
            // 
            this.richTextBoxLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxLog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBoxLog.ContextMenuStrip = this.contextMenuStripRichTextBox;
            this.richTextBoxLog.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBoxLog.Location = new System.Drawing.Point(12, 271);
            this.richTextBoxLog.Name = "richTextBoxLog";
            this.richTextBoxLog.ReadOnly = true;
            this.richTextBoxLog.Size = new System.Drawing.Size(760, 238);
            this.richTextBoxLog.TabIndex = 7;
            this.richTextBoxLog.Text = "";
            this.richTextBoxLog.TextChanged += new System.EventHandler(this.richTextBoxLog_TextChanged);
            // 
            // contextMenuStripRichTextBox
            // 
            this.contextMenuStripRichTextBox.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearToolStripMenuItem});
            this.contextMenuStripRichTextBox.Name = "contextMenuStripRichTextBox";
            this.contextMenuStripRichTextBox.Size = new System.Drawing.Size(102, 26);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonStop.Location = new System.Drawing.Point(732, 27);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(40, 23);
            this.buttonStop.TabIndex = 5;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // buttonStart
            // 
            this.buttonStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonStart.Location = new System.Drawing.Point(688, 27);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(38, 23);
            this.buttonStart.TabIndex = 4;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Location = new System.Drawing.Point(188, 32);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(30, 13);
            this.labelTime.TabIndex = 4;
            this.labelTime.Text = "Time";
            // 
            // chartServers
            // 
            this.chartServers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chartServers.BorderlineColor = System.Drawing.Color.DimGray;
            this.chartServers.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea1.AxisX.LabelStyle.Enabled = false;
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.AxisX2.MajorGrid.Enabled = false;
            chartArea1.AxisY.MajorGrid.Enabled = false;
            chartArea1.AxisY2.MajorGrid.Enabled = false;
            chartArea1.Name = "ChartAreaServersLA";
            this.chartServers.ChartAreas.Add(chartArea1);
            this.chartServers.Location = new System.Drawing.Point(12, 56);
            this.chartServers.Name = "chartServers";
            this.chartServers.Size = new System.Drawing.Size(760, 200);
            this.chartServers.TabIndex = 7;
            this.chartServers.Text = "chartServers";
            // 
            // buttonManualUpdate
            // 
            this.buttonManualUpdate.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonManualUpdate.Location = new System.Drawing.Point(12, 27);
            this.buttonManualUpdate.Name = "buttonManualUpdate";
            this.buttonManualUpdate.Size = new System.Drawing.Size(170, 23);
            this.buttonManualUpdate.TabIndex = 3;
            this.buttonManualUpdate.Text = "Update servers`s status manually";
            this.buttonManualUpdate.UseVisualStyleBackColor = true;
            this.buttonManualUpdate.Click += new System.EventHandler(this.buttonManualUpdate_Click);
            // 
            // textBoxCommand
            // 
            this.textBoxCommand.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCommand.Location = new System.Drawing.Point(12, 517);
            this.textBoxCommand.Name = "textBoxCommand";
            this.textBoxCommand.Size = new System.Drawing.Size(552, 20);
            this.textBoxCommand.TabIndex = 0;
            this.textBoxCommand.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCommand_KeyPress);
            // 
            // buttonSendCommand
            // 
            this.buttonSendCommand.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSendCommand.Location = new System.Drawing.Point(697, 515);
            this.buttonSendCommand.Name = "buttonSendCommand";
            this.buttonSendCommand.Size = new System.Drawing.Size(75, 23);
            this.buttonSendCommand.TabIndex = 2;
            this.buttonSendCommand.Text = "Send";
            this.buttonSendCommand.UseVisualStyleBackColor = true;
            this.buttonSendCommand.Click += new System.EventHandler(this.buttonSendCommand_Click);
            // 
            // comboBoxServers
            // 
            this.comboBoxServers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxServers.FormattingEnabled = true;
            this.comboBoxServers.Location = new System.Drawing.Point(570, 517);
            this.comboBoxServers.Name = "comboBoxServers";
            this.comboBoxServers.Size = new System.Drawing.Size(121, 21);
            this.comboBoxServers.TabIndex = 1;
            // 
            // backgroundWorkerForServers
            // 
            this.backgroundWorkerForServers.WorkerSupportsCancellation = true;
            // 
            // statusStripMain
            // 
            this.statusStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelTime});
            this.statusStripMain.Location = new System.Drawing.Point(0, 540);
            this.statusStripMain.Name = "statusStripMain";
            this.statusStripMain.Size = new System.Drawing.Size(782, 22);
            this.statusStripMain.TabIndex = 8;
            this.statusStripMain.Text = "statusStrip1";
            // 
            // toolStripStatusLabelTime
            // 
            this.toolStripStatusLabelTime.Name = "toolStripStatusLabelTime";
            this.toolStripStatusLabelTime.Size = new System.Drawing.Size(19, 17);
            this.toolStripStatusLabelTime.Text = "    ";
            // 
            // notifyIconTray
            // 
            this.notifyIconTray.ContextMenuStrip = this.contextMenuStripTray;
            this.notifyIconTray.Click += new System.EventHandler(this.showToolStripMenuItem_Click);
            // 
            // contextMenuStripTray
            // 
            this.contextMenuStripTray.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem1});
            this.contextMenuStripTray.Name = "contextMenuStripTray";
            this.contextMenuStripTray.Size = new System.Drawing.Size(104, 54);
            // 
            // showToolStripMenuItem
            // 
            this.showToolStripMenuItem.Name = "showToolStripMenuItem";
            this.showToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.showToolStripMenuItem.Text = "Show";
            this.showToolStripMenuItem.Click += new System.EventHandler(this.showToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(100, 6);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(103, 22);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 562);
            this.Controls.Add(this.statusStripMain);
            this.Controls.Add(this.comboBoxServers);
            this.Controls.Add(this.buttonSendCommand);
            this.Controls.Add(this.textBoxCommand);
            this.Controls.Add(this.buttonManualUpdate);
            this.Controls.Add(this.chartServers);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.richTextBoxLog);
            this.Controls.Add(this.menuStripMainMenu);
            this.MainMenuStrip = this.menuStripMainMenu;
            this.MinimumSize = new System.Drawing.Size(16, 600);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Remote server watcher";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.menuStripMainMenu.ResumeLayout(false);
            this.menuStripMainMenu.PerformLayout();
            this.contextMenuStripRichTextBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartServers)).EndInit();
            this.statusStripMain.ResumeLayout(false);
            this.statusStripMain.PerformLayout();
            this.contextMenuStripTray.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripMainMenu;
        private System.Windows.Forms.ToolStripMenuItem fIleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem remoteServersToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.RichTextBox richTextBoxLog;
        private System.Windows.Forms.ToolStripMenuItem preToolStripMenuItem;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Label labelTime;
        internal System.Windows.Forms.DataVisualization.Charting.Chart chartServers;
        private System.Windows.Forms.Button buttonManualUpdate;
        private System.Windows.Forms.TextBox textBoxCommand;
        private System.Windows.Forms.Button buttonSendCommand;
        private System.Windows.Forms.ComboBox comboBoxServers;
        private System.ComponentModel.BackgroundWorker backgroundWorkerForServers;
        private System.ComponentModel.BackgroundWorker backgroundWorkerForCommand;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripRichTextBox;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStripMain;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelTime;
        private System.Windows.Forms.NotifyIcon notifyIconTray;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripTray;
        private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;

    }
}

