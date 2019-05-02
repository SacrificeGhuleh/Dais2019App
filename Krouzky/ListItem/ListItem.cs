#region UsingRegion

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

#endregion

namespace Krouzky {
    public partial class ListItem : TableLayoutPanel {
        private static readonly Color SelectedBtnColor = SystemColors.ControlLight;
        private static readonly Color UnSelectedBtnColor = SystemColors.Control;

        public bool selected {
            get { return this.checkBox.Checked; }
        }

        public virtual void delete() {
        }

        public ListItem() {
            this.InitializeComponent();

            this.ColumnCount = 2;
            this.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20));
            this.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            this.Controls.Add(this.nameLabel, 1, 0);
            this.Controls.Add(this.checkBox, 0, 0);
            this.Dock = DockStyle.Top;
            this.Location = new Point(0, 0);
            this.Name = "ListItem";
            this.RowCount = 1;
            this.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            this.Size = new Size(466, 20);
            this.TabIndex = 1;
        }

        public ListItem(IContainer container) : this() {
            container.Add(this);
        }

        public string getLabelStr() {
            return this.nameLabel.Text;
        }

        protected void setLabelStr(string str) {
            this.nameLabel.Text = str;
        }

        protected void checkBox_CheckedChanged(object sender, EventArgs e) {
            this.nameLabel.BackColor = this.checkBox.Checked
                ? SelectedBtnColor
                : UnSelectedBtnColor;
        }

        protected virtual void nameLabel_DoubleClick(object sender, EventArgs e) {
        }
    }
}