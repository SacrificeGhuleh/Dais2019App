#region UsingRegion

using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

#endregion

namespace Krouzky {
    public partial class TwoCols : Panel {
        public TwoCols() {
            this.InitializeComponent();        
            this.Controls.Add(this.rightLabel);
            this.Controls.Add(this.leftLabel);
            this.Dock = DockStyle.Top;
            this.Location = new Point(115, 4);
            this.Name = "TwoCols";
            this.Size = new Size(50, 25);
            this.TabIndex = 0;
        }

        public TwoCols(IContainer container) : this() {
            container.Add(this);
        }
    }
}