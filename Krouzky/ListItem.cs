using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Krouzky {
    using System.Drawing;
    using System.Windows.Forms;
    using Krouzky.ORM.Database.DTO;

    public partial class ListItem : TableLayoutPanel {
        private Lektor lektor_;
        public ListItem(Lektor lektor) : this() {
            this.lektor_ = lektor;
            this.nameLabel.Text = $"{lektor.osoba.jmeno} {lektor.osoba.prijmeni}";
        }

        public ListItem() {
            InitializeComponent();

            this.ColumnCount = 2;
            this.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Controls.Add(this.nameLabel, 1, 0);
            this.Controls.Add(this.checkBox, 0, 0);
            this.Dock = System.Windows.Forms.DockStyle.Top;
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "ListItem";
            this.RowCount = 1;
            this.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.Size = new System.Drawing.Size(466, 48);
            this.TabIndex = 1;
        }

        public ListItem(IContainer container) : this() {
            container.Add(this);
        }

        private void checkBox_CheckedChanged(object sender, EventArgs e) {
            if (this.checkBox.Checked) {
                this.nameLabel.BackColor = Color.FromArgb(0x51,0x55,0x5c);
            }
            else
            {
                this.nameLabel.BackColor = Color.FromArgb(0x29, 0x2c, 0x33);
            }
        }

        private void nameLabel_DoubleClick(object sender, EventArgs e)
        {
            new FormLektor(this.lektor_).ShowDialog();
        }
    }
}
