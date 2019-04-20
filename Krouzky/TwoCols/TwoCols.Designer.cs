namespace Krouzky
{
    partial class TwoCols
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rightLabel = new System.Windows.Forms.Label();
            this.leftLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rightLabel
            // 
            this.rightLabel.AutoSize = true;
            this.rightLabel.BackColor = System.Drawing.SystemColors.Control;
            this.rightLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.rightLabel.Location = new System.Drawing.Point(52, 0);
            this.rightLabel.Name = "rightLabel";
            this.rightLabel.Size = new System.Drawing.Size(40, 25);
            this.rightLabel.TabIndex = 1;
            this.rightLabel.Text = "1.1.";
            this.rightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // leftLabel
            // 
            this.leftLabel.AutoSize = true;
            this.leftLabel.BackColor = System.Drawing.SystemColors.Control;
            this.leftLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.leftLabel.Location = new System.Drawing.Point(0, 0);
            this.leftLabel.Name = "leftLabel";
            this.leftLabel.Size = new System.Drawing.Size(25, 25);
            this.leftLabel.TabIndex = 0;
            this.leftLabel.Text = "Po";
            this.leftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TwoCols
            // 
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label rightLabel;
        public System.Windows.Forms.Label leftLabel;
    }
}
