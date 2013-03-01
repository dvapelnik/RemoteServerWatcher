using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RemoteServerWatcher {
    public partial class OptionsForm : Form {
        MainForm mainForm;

        public OptionsForm() {
            InitializeComponent();
            mainForm = (MainForm)Application.OpenForms["MainForm"];

            checkBoxMonitorAutostart.Checked = mainForm.storage.GetOption(MainForm.StartTimerOnLoad) == "1";
            comboBoxTimerInterval.Text = (Int32.Parse(mainForm.storage.GetOption(MainForm.TimerInterval)) / 1000).ToString();
        }

        private void buttonCancel_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void buttonOk_Click(object sender, EventArgs e) {
            mainForm.storage.UpdateOption(MainForm.StartTimerOnLoad, checkBoxMonitorAutostart.Checked ? "1" : "0");
            if (mainForm.storage.UpdateOption(MainForm.TimerInterval, (Int32.Parse(comboBoxTimerInterval.Text) * 1000).ToString())) {
                mainForm.timer.Interval = Int32.Parse(comboBoxTimerInterval.Text) * 1000;
            }
            this.Close();
        }

        private void comboBoxTimerInterval_KeyPress(object sender, KeyPressEventArgs e) {
            e.Handled = !Char.IsDigit(e.KeyChar);
        }
    }
}
