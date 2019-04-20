#region UsingRegion

using System;
using System.Windows.Forms;

#endregion

namespace Krouzky {
    public partial class FormLoading : Form {
        public FormLoading() {
            this.InitializeComponent();
            this.stateLabel.Text = "Loading...";
        }

        public void setErrorText(Exception e) {
            this.Invoke(new Action(() => {
                this.stateLabel.Text = "Error";
                this.errorPanel.Visible = true;
                this.errorField.Text = e.ToString();
            }));
        }

        private void closeBtn_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}