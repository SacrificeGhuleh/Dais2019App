using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Krouzky {
    public partial class FormLoading : Form {
        System.Timers.Timer timer;

        private int dots_ = 0;

        public void setErrorText(Exception e) {
            this.timer.Stop();
            this.stateLabel.Text = "Error";
            this.errorPanel.Visible = true;
            this.errorField.Text = e.ToString();
        }

        public FormLoading() {
            InitializeComponent();
            timer = new System.Timers.Timer(1000);
            /*this.timer.Elapsed += (sender, args) => {
                                      this.dots_++;
                                      this.dots_ %= 4;
                                      this.stateLabel.Text = "FormLoading";
                                      for (int i = 0; i < this.dots_; i++) {
                                          this.stateLabel.Text += ".";
                                      }
                                  };
            this.timer.Start();*/
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
